## Základy zpracování dat
- základní datové typy (numeric, logical, character, factor) a datové struktury (vektory, matice, datové tabulky, seznam)
- základní logické a matematické operace
- operace nad řetězci včetně využití jednoduchých regulárních výrazů
- načítání a ukládání dat (CSV, XLSX)
- cykly a podmíněné příkazy
- tvorba vlastních funkcí a skriptů
- manipulace s datovými tabulkami (různé úpravy a transformace, výběr, řazení, filtrování, slučování, seskupování a sumarizace, převod mezi krátkým a dlouhým formátem, kontingenční tabulky)
- tvorba základních i pokročilých typů grafů (včetně histogramů a boxplotů) a jejich interpretace
- tvorba reprodukovatelných reportů (Rmd, qmd)

### Základní datové typy

#### numeric
- číselná hodnota (celé i desetinné číslo)

```r
x <- 10
y <- 3.14
```

#### logical
- logická hodnota (TRUE/FALSE)

```r
x <- 5 > 3
```

#### character
- textový řetězec

```r
name <- "Ondra"
city <- "Ústí nad Labem"
```

#### factor
- kategorická proměnná

```r
gender <- factor(c("Male", "Female"))
```

### Základní datové struktury

#### Vektor
- jednorozměrná kolekce hodnot stejného typu

```r
numbers <- c(1, 2, 3, 4)
```

Přístup k prvku:

```r
numbers[1]
```

---

#### Matice
- dvourozměrná struktura hodnot stejného typu

```r
matrix_data <- matrix(c(1, 2, 3, 4), nrow = 2, ncol = 2)
```

Přístup k prvku:

```r
matrix_data[1, 2] # [řádek, sloupec]
```

---

#### Datová tabulka
- tabulková data
- sloupce mohou mít různé datové typy

```r
students <- data.frame(name = c("Anna", "Petr"), age = c(20, 21))
```

Přístup ke sloupci:

```r
students$name
```

---

#### Seznam
- kolekce objektů různých typů

```r
anna_list <- list(name = "Anna", age = 20, grades = c(1, 2, 1))
```

Přístup k položce:

```r
anna_list$name
```

### Základní matematické operace

#### Sčítání

```r
5 + 3
```

#### Odčítání

```r
5 - 3
```

#### Násobení

```r
5 * 3
```

#### Dělení

```r
5 / 3
```

#### Mocnina

```r
5 ^ 2
```

#### Zbytek po dělení

```r
5 %% 2
```

#### Celočíselné dělení

```r
5 %/% 2
```

### Základní logické operace

#### Rovnost

```r
x == y
```

#### Nerovnost

```r
x != y
```

#### Větší než

```r
x > y
```

#### Menší než

```r
x < y
```

#### Větší nebo rovno

```r
x >= y
```

#### Menší nebo rovno

```r
x <= y
```

#### Logické AND

```r
x & y
```

#### Logické OR

```r
x | y
```

#### Logická negace

```r
!x
```

### Operace nad řetězci

#### Vytvoření řetězce

```r
name <- "Ondra"
```

#### Spojení řetězců

```r
paste("Hello", "World")
```

Výsledek:

```text
"Hello World"
```

Bez mezery:

```r
paste0("Hello", "World")
```

Výsledek:

```text
"HelloWorld"
```

#### Délka řetězce

```r
nchar("Ondra")
```

#### Převod na malá písmena

```r
tolower("ONDRA")
```

#### Převod na velká písmena

```r
toupper("ondra")
```

#### Nahrazení textu

```r
gsub(
  "World",
  "R",
  "Hello World"
)
```

#### Rozdělení řetězce

```r
strsplit(
  "a,b,c",
  ","
)
```

### Regulární výrazy

#### Obsahuje text

```r
grepl(
  "high school",
  education
)
```

#### Začíná textem

```r
grepl(
  "^high",
  education
)
```

#### Končí textem

```r
grepl(
  "school$",
  education
)
```

#### Libovolný znak

```r
grepl(
  "a.c",
  text
)
```

Příklady:

```text
abc
axc
a7c
```

#### Opakování znaku

```r
grepl(
  "a+",
  text
)
```

Příklady:

```text
a
aa
aaa
```

#### Číslice

```r
grepl(
  "[0-9]",
  text
)
```

#### Písmeno

```r
grepl(
  "[A-Za-z]",
  text
)
```

#### Více možností

```r
grepl(
  "cat|dog",
  text
)
```

Příklady:

```text
cat
dog
```

### Načítání a ukládání dat

#### Načtení CSV souboru

```r
data <- read.csv(
  "data.csv"
)
```

#### Načtení CSV souboru s oddělovačem ;

```r
data <- read.csv2(
  "data.csv"
)
```

#### Uložení CSV souboru

```r
write.csv(
  data,
  "output.csv",
  row.names = FALSE
)
```

#### Načtení XLSX souboru

```r
library(readxl)

data <- read_excel(
  "data.xlsx"
)
```

#### Načtení konkrétního listu

```r
data <- read_excel(
  "data.xlsx",
  sheet = "Sheet1"
)
```

#### Uložení XLSX souboru

```r
library(writexl)

write_xlsx(
  data,
  "output.xlsx"
)
```

### Podmíněné příkazy

#### if

```r
if (x > 0) {
  print("kladné číslo")
}
```

#### if else

```r
if (x > 0) {
  print("kladné číslo")
} else {
  print("záporné číslo nebo nula")
}
```

#### if else if

```r
if (x > 0) {
  print("kladné číslo")
} else if (x < 0) {
  print("záporné číslo")
} else {
  print("nula")
}
```

### Cykly

#### for

```r
for (i in 1:5) {
  print(i)
}
```

#### for přes vektor

```r
numbers <- c(10, 20, 30)

for (number in numbers) {
  print(number)
}
```

#### while

```r
x <- 1

while (x <= 5) {
  print(x)
  x <- x + 1
}
```

#### break

- ukončí cyklus

```r
for (i in 1:10) {
  if (i == 5) {
    break
  }

  print(i)
}
```

#### next

- přeskočí aktuální iteraci

```r
for (i in 1:5) {
  if (i == 3) {
    next
  }

  print(i)
}
```

### Manipulace s datovými tabulkami

#### Výběr sloupců

```r
data %>%
  select(
    name,
    age
  )
```

#### Přejmenování sloupců

```r
data %>%
  rename(
    full_name = name
  )
```

#### Přidání nového sloupce

```r
data %>%
  mutate(
    age_plus_one = age + 1
  )
```

#### Filtrování řádků

```r
data %>%
  filter(
    age >= 18
  )
```

#### Filtrování pomocí regulárního výrazu

```r
data %>%
  filter(
    grepl(
      "high school",
      education
    )
  )
```

#### Řazení vzestupně

```r
data %>%
  arrange(age)
```

#### Řazení sestupně

```r
data %>%
  arrange(desc(age))
```

### Seskupování a sumarizace

#### Seskupení podle jedné proměnné

```r
data %>%
  group_by(gender) %>%
  summarise(
    avg_age = mean(age)
  )
```

#### Seskupení podle více proměnných

```r
data %>%
  group_by(
    gender,
    race
  ) %>%
  summarise(
    avg_age = mean(age),
    .groups = "drop"
  )
```

### Slučování tabulek

#### Inner Join

```r
inner_join(
  table1,
  table2,
  by = "id"
)
```

#### Left Join

```r
left_join(
  table1,
  table2,
  by = "id"
)
```

#### Right Join

```r
right_join(
  table1,
  table2,
  by = "id"
)
```

#### Full Join

```r
full_join(
  table1,
  table2,
  by = "id"
)
```

### Převod mezi formáty

#### Dlouhý → Široký formát

```r
pivot_wider(
  data,
  names_from = gender,
  values_from = avg.score
)
```

#### Široký → Dlouhý formát

```r
pivot_longer(
  data,
  cols = c(
    female,
    male
  ),
  names_to = "gender",
  values_to = "avg.score"
)
```

### Kontingenční tabulky

#### Absolutní četnosti

```r
table(
  data$gender
)
```

#### Dvourozměrná kontingenční tabulka

```r
table(
  data$gender,
  data$race
)
```

#### Relativní četnosti

```r
prop.table(
  table(data$gender)
)
```

#### Relativní četnosti po řádcích

```r
prop.table(
  table(
    data$gender,
    data$race
  ),
  margin = 1
)
```

### Tvorba grafů

#### Bodový graf (Scatter Plot)

- zobrazuje vztah mezi dvěma číselnými proměnnými

```r
plot(
  x = data$height,
  y = data$weight
)
```

Interpretace:
- rostoucí trend → kladná závislost
- klesající trend → záporná závislost
- bez vzoru → slabá nebo žádná závislost

---

#### Spojnicový graf (Line Plot)

- zobrazuje vývoj hodnot v čase

```r
plot(
  data$year,
  data$value,
  type = "l"
)
```

Interpretace:
- trend
- sezónnost
- náhlé změny

---

#### Sloupcový graf (Bar Plot)

- porovnání kategorií

```r
barplot(
  table(data$gender)
)
```

Interpretace:
- porovnání četností kategorií

---

#### Koláčový graf (Pie Chart)

- podíly kategorií na celku

```r
pie(
  table(data$gender)
)
```

Interpretace:
- procentuální zastoupení kategorií

### Histogram

- zobrazuje rozdělení číselné proměnné

```r
hist(
  data$age
)
```

Interpretace:
- tvar rozdělení
- šikmost
- počet vrcholů
- odlehlé hodnoty

Možné tvary:

- symetrické rozdělení
- pravostranně šikmé rozdělení
- levostranně šikmé rozdělení
- vícemodální rozdělení

### Boxplot

- grafické zobrazení polohy a variability dat

```r
boxplot(
  data$age
)
```

Pro skupiny:

```r
boxplot(
  age ~ gender,
  data = data
)
```

Interpretace:
- medián
- dolní kvartil (Q1)
- horní kvartil (Q3)
- mezikvartilové rozpětí (IQR)
- odlehlé hodnoty

### Pokročilé grafy

#### Více histogramů pomocí ggplot2

```r
library(ggplot2)

ggplot(
  data,
  aes(x = age)
) +
  geom_histogram()
```

#### Boxplot podle kategorií

```r
ggplot(
  data,
  aes(
    x = gender,
    y = age
  )
) +
  geom_boxplot()
```

#### Bodový graf s regresní přímkou

```r
ggplot(
  data,
  aes(
    x = height,
    y = weight
  )
) +
  geom_point() +
  geom_smooth(
    method = "lm",
    se = FALSE
  )
```

Interpretace:
- směr vztahu
- síla vztahu
- odlehlé body
- přibližná linearita