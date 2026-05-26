## NoSQL databáze

### Užitečné odkazy
- <https://github.com/ondrejsvorc/UJEP/tree/main/2.%20year/RDBS/zapocet>
- <https://github.com/ondrejsvorc/UJEP/tree/main/2.%20year/ODM/seminar-project>

### Ukázková úloha

#### Propojení a vizualizace dat ze dvou datových zdrojů
- Cizinci podle státního občanství, věku a pohlaví – rok 2019
- HDP na hlavu pro jednotlivé státy (lze samozřejmě použít i jiný relevantní zdroj)

#### Klíčové fáze řešení
- návrh struktury záznamů pro dokumentově orientovanou databázi (MongoDB)
- vytvoření skriptu pro zpracování externích zdrojů a jejich vložení do databáze (včetně řešení
nekonzistencí identifikátorů, chybějících dat apod.)
- denormalizace
- návrh a implementace dotazů (preferovány jsou agregační operace)

#### Doporučený výstup
- seskupení dat podle roků, státního občanství
- seskupení dat cizinců podle HDP na hlavu v zemích, kde mají státní občanství
- jednoduchá vizualizace výsledků

#### Seznam dostupných materiálů a technologií
K dispozici bude Docker kontejner s oficiálním obrazem databázového systému MongoDB +
Python s běžnými nástroji pro zpracování dat (NumPy, Pandas).

### Mé řešení ukázkové úlohy
V MongoDB bych postupoval podobně procesně jako v 01 - Relační databázové systémy a OLAP databáze, ale místo relačních tabulek bych navrhl dokumenty tak, aby se většina analýz dala dělat přímo nad jednou kolekcí. Nejdřív bych načetl oba zdroje v Pythonu, sjednotil názvy států přes ISO kódy, vyřešil chybějící nebo nejednoznačné hodnoty a vytvořil denormalizované dokumenty, kde jeden záznam reprezentuje kombinaci `rok + stát + věk + pohlaví`. Dokument by obsahoval například `year`, `country`, `iso3_code`, `age`, `sex`, `foreigners_count`, `gdp_per_capita`, `gdp_group` a případně metadata zdrojů. Data bych vložil do kolekce například `foreigners_gdp`, nad kterou bych vytvořil indexy na `year`, `iso3_code`, `country.name` a `gdp_group`. Analýzy bych pak řešil agregačními pipeline: `$group` pro seskupení podle roku a občanství, další `$group` podle pásem HDP, `$sort` a `$limit` pro top země, případně `$match` pro výběr roku 2019. Výsledky agregací bych načetl zpět do Pythonu přes `pymongo`, převedl na `pandas.DataFrame` a vizualizoval pomocí `matplotlib` nebo `seaborn`, například jako top 10 občanství, scatter plot HDP na hlavu vs. počet cizinců a graf rozdělení podle HDP skupin.

#### Návrh struktury dokumentu

```json
{
  "year": 2019,
  "country": {
    "iso3_code": "UKR",
    "name_cz": "Ukrajina",
    "name_en": "Ukraine"
  },
  "age": 35,
  "sex": "muž",
  "foreigners_count": 1250,
  "gdp": {
    "gdp_per_capita": 3660.0,
    "currency": "USD",
    "source": "World Bank"
  },
  "gdp_group": "nízké HDP"
}
```

Kolekce by se mohla jmenovat například `foreigners_gdp`.

#### Vytvoření indexů

```javascript
db.foreigners_gdp.createIndex({ year: 1 })
db.foreigners_gdp.createIndex({ "country.iso3_code": 1 })
db.foreigners_gdp.createIndex({ "country.name_cz": 1 })
db.foreigners_gdp.createIndex({ gdp_group: 1 })
```

```python
import pandas as pd
from pymongo import MongoClient

# pip install pandas pymongo openpyxl

client = MongoClient("mongodb://localhost:27017/")
db = client["foreigners_analysis"]
collection = db["foreigners_gdp"]

foreigners = pd.read_csv("foreigners_2019.csv")
gdp = pd.read_csv("gdp_per_capita.csv")

country_map = {
    "Ukrajina": "UKR",
    "Slovensko": "SVK",
    "Vietnam": "VNM",
    "Rusko": "RUS",
    "Německo": "DEU"
}

foreigners["iso3_code"] = foreigners["country"].map(country_map)
gdp["iso3_code"] = gdp["country"].map(country_map)

data = foreigners.merge(
    gdp[["iso3_code", "gdp_per_capita", "currency"]],
    on="iso3_code",
    how="left"
)

def get_gdp_group(value):
    if pd.isna(value):
        return "neznámé HDP"
    if value < 10000:
        return "nízké HDP"
    if value < 30000:
        return "střední HDP"
    return "vysoké HDP"

documents = []

for _, row in data.iterrows():
    documents.append({
        "year": int(row["year"]),
        "country": {
            "iso3_code": row["iso3_code"],
            "name_cz": row["country"]
        },
        "age": int(row["age"]),
        "sex": row["sex"],
        "foreigners_count": int(row["count"]),
        "gdp": {
            "gdp_per_capita": None if pd.isna(row["gdp_per_capita"]) else float(row["gdp_per_capita"]),
            "currency": row.get("currency", "USD")
        },
        "gdp_group": get_gdp_group(row["gdp_per_capita"])
    })

collection.delete_many({})
collection.insert_many(documents)
```

#### Agregační dotazy v MongoDB

```javascript
// Počet cizinců podle roku a státního občanství
db.foreigners_gdp.aggregate([
  {
    $group: {
      _id: {
        year: "$year",
        country: "$country.name_cz"
      },
      foreigners_count: { $sum: "$foreigners_count" }
    }
  },
  {
    $sort: {
      foreigners_count: -1
    }
  }
])
```

```javascript
// Top 10 státních občanství za rok 2019
db.foreigners_gdp.aggregate([
  {
    $match: {
      year: 2019
    }
  },
  {
    $group: {
      _id: "$country.name_cz",
      foreigners_count: { $sum: "$foreigners_count" }
    }
  },
  {
    $sort: {
      foreigners_count: -1
    }
  },
  {
    $limit: 10
  }
])
```

```javascript
// Cizinci podle pásem HDP
db.foreigners_gdp.aggregate([
  {
    $match: {
      year: 2019
    }
  },
  {
    $group: {
      _id: "$gdp_group",
      foreigners_count: { $sum: "$foreigners_count" }
    }
  },
  {
    $sort: {
      foreigners_count: -1
    }
  }
])
```

```javascript
// HDP na hlavu vs. počet cizinců podle země
db.foreigners_gdp.aggregate([
  {
    $match: {
      year: 2019,
      "gdp.gdp_per_capita": { $ne: null }
    }
  },
  {
    $group: {
      _id: {
        country: "$country.name_cz",
        gdp_per_capita: "$gdp.gdp_per_capita"
      },
      foreigners_count: { $sum: "$foreigners_count" }
    }
  },
  {
    $sort: {
      foreigners_count: -1
    }
  }
])
```

#### Vizualizace v Pythonu

```python
import pandas as pd
import matplotlib.pyplot as plt
import seaborn as sns
from pymongo import MongoClient

client = MongoClient("mongodb://localhost:27017/")
db = client["foreigners_analysis"]
collection = db["foreigners_gdp"]

sns.set_theme(style="whitegrid")

pipeline_top10 = [
    {"$match": {"year": 2019}},
    {
        "$group": {
            "_id": "$country.name_cz",
            "foreigners_count": {"$sum": "$foreigners_count"}
        }
    },
    {"$sort": {"foreigners_count": -1}},
    {"$limit": 10}
]

top10 = pd.DataFrame(list(collection.aggregate(pipeline_top10)))
top10 = top10.rename(columns={"_id": "country"})

plt.figure(figsize=(10, 5))
sns.barplot(data=top10, x="foreigners_count", y="country")
plt.title("Top 10 občanství podle počtu cizinců")
plt.xlabel("Počet cizinců")
plt.ylabel("Státní občanství")
plt.tight_layout()
plt.savefig("top10_obcanstvi_mongodb.png")
plt.show()
```

```python
pipeline_scatter = [
    {
        "$match": {
            "year": 2019,
            "gdp.gdp_per_capita": {"$ne": None}
        }
    },
    {
        "$group": {
            "_id": {
                "country": "$country.name_cz",
                "gdp_per_capita": "$gdp.gdp_per_capita"
            },
            "foreigners_count": {"$sum": "$foreigners_count"}
        }
    }
]

scatter_raw = list(collection.aggregate(pipeline_scatter))

scatter = pd.DataFrame([
    {
        "country": row["_id"]["country"],
        "gdp_per_capita": row["_id"]["gdp_per_capita"],
        "foreigners_count": row["foreigners_count"]
    }
    for row in scatter_raw
])

plt.figure(figsize=(8, 5))
sns.scatterplot(
    data=scatter,
    x="gdp_per_capita",
    y="foreigners_count",
    size="foreigners_count",
    legend=False
)
plt.title("HDP na hlavu vs. počet cizinců")
plt.xlabel("HDP na hlavu")
plt.ylabel("Počet cizinců")
plt.tight_layout()
plt.savefig("hdp_vs_cizinci_mongodb.png")
plt.show()
```

```python
pipeline_gdp_groups = [
    {"$match": {"year": 2019}},
    {
        "$group": {
            "_id": "$gdp_group",
            "foreigners_count": {"$sum": "$foreigners_count"}
        }
    },
    {"$sort": {"foreigners_count": -1}}
]

gdp_groups = pd.DataFrame(list(collection.aggregate(pipeline_gdp_groups)))
gdp_groups = gdp_groups.rename(columns={"_id": "gdp_group"})

plt.figure(figsize=(8, 5))
sns.barplot(data=gdp_groups, x="gdp_group", y="foreigners_count")
plt.title("Počet cizinců podle skupin HDP")
plt.xlabel("Skupina HDP")
plt.ylabel("Počet cizinců")
plt.tight_layout()
plt.savefig("gdp_skupiny_mongodb.png")
plt.show()
```