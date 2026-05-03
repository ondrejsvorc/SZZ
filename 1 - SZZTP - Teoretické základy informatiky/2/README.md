## 2

Komplexní algoritmy nad seznamy (filtrování, vyhledávání, třídění/řazení výběrem nebo vkládáním), efektivnější implementace vyhledávání a třídění (binární vyhledávání, merge sort), časová složitost algoritmů

### Filtrování
- proces extrakce prvků ze vstupní množiny na základě specifikovaného predikátu, přičemž výsledkem je podmnožina, jejíž kardinalita je menší nebo rovna kardinalitě množiny původní

$$S' = \{x \in S \mid P(x)\}$$

$$|S'| \leq |S|$$

- S' = výsledná podmnožina
- S = vstupní množina
- x = libovolný prvek náležející do množiny $S$
- P(x) = predikát

#### Pojmy
- Kardinalita = počet prvků dané mnžoiny
- Predikát = podmínka/funkce nabývající hodnot pravda nebo nepravda (P(x) - pro daný prvek $x$)

#### Příklad

Mějme množinu čísel $S = \{1, 5, 8, 12, 15\}$ a predikát $P(x)$, který říká, že „$x$ je sudé číslo“.

$$P(x) \equiv x \pmod 2 = 0$$

- $1$ → $P(1)$ je nepravda
- $8$ → $P(8)$ je pravda
- ...

$$S' = \{x \in S \mid P(x)\} = \{8, 12\}$$
$$S' = \{x \in S \mid x \pmod 2 = 0\} = \{8, 12\}$$

Výsledkem bude $S' = \{8, 12\}$, přičemž platí, že počet prvků (kardinalita) výsledku je menší než počet prvků vstupu ($2 \leq 5$).

### Vyhledávání
- definice obecně

### Třídění/řazení
- definice obecně

### Třídění výběrem (Selection Sort)
-

### Třídění vkládáním (Insertion Sort)
-

### Časová složitost algoritmů