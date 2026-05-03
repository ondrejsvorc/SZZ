## 2

Komplexní algoritmy nad seznamy (filtrování, vyhledávání, třídění/řazení výběrem nebo vkládáním), efektivnější implementace vyhledávání a třídění (binární vyhledávání, merge sort), časová složitost algoritmů

### Užitečné odkazy
- <https://szz.ondrejsvorc.cz/1%20-%20SZZTP%20-%20Teoretick%C3%A9%20z%C3%A1klady%20informatiky/2/>
- <https://visualgo.net/en/sorting> (vizualizace)
- <https://youtu.be/RfXt_qHDEPw> (řadící algoritmy)
- <https://youtu.be/LOcfJorH7xs> (Insertion Sort - česky)
- <https://youtu.be/g-PGLbMth_g> (Selection Sort - anglicky)

### Filtrování
- proces extrakce prvků ze vstupní množiny na základě specifikovaného predikátu, přičemž výsledkem je podmnožina, jejíž kardinalita je menší nebo rovna kardinalitě množiny původní

$$S' = \{x \in S \mid P(x)\}$$

$$|S'| \leq |S|$$

- $S'$ = výsledná podmnožina
- $S$ = vstupní množina
- $x$ = libovolný prvek náležející do množiny $S$
- $P(x)$ = predikát

#### Příklad

Mějme množinu čísel $S = \{1, 5, 8, 12, 15\}$ a predikát $P(x)$, který říká, že „$x$ je sudé číslo“.

$$P(x) \equiv x \pmod 2 = 0$$

- $1$ → $P(1)$ je nepravda
- $8$ → $P(8)$ je pravda
- ...

$$S' = \{x \in S \mid P(x)\} = \{8, 12\}$$
$$S' = \{x \in S \mid x \pmod 2 = 0\} = \{8, 12\}$$

Výsledkem bude $S' = \{8, 12\}$, přičemž platí, že počet prvků (kardinalita) výsledku je menší než počet prvků vstupu ($2 \leq 5$).

#### Pojmy
- Kardinalita = počet prvků dané mnžoiny.
- Predikát = podmínka/funkce nabývající hodnot pravda nebo nepravda (P(x) - pro daný prvek $x$).

### Vyhledávání
- proces identifikace a lokalizace konkrétního prvku ve vstupní množině na základě zadaného identifikátoru nebo predikátu

#### Příklad

Mějme uspořádanou množinu $S = \{1, 5, 8, 12, 15\}$ a hledejme prvek $x_{target} = 12$.

Definujeme predikát shody: $P(x) \colon x = 12$.

Algoritmus projde množinu $S$ a testuje $P(x)$ pro každý prvek.

Pro $x = 12$ je $P(12)$ pravda.

Výsledek: Prvek nalezen na pozici (indexu) $i = 3$ (při indexování od 0).$$S[i] = x_{target}$$

### Pojmy
- Identifikátor = unikátní hodnota, která slouží k jednoznačnému odlišení konkrétního prvku od ostatních v rámci dané množiny (např. ID).
- Identifikace = proces vyhodnocení predikátu.
- Lokalizace = proces určení přesného umístění identifikovaného prvku.

### Rozdíl mezi filtrováním a vyhledáváním
Zatímco filtrování vytváří novou podmnožinu prvků na základě platnosti predikátu, vyhledávání provádí identifikaci a následnou lokalizaci konkrétního prvku za účelem získání jeho indexu nebo potvrzení existence.

### Třídění / Řazení
- proces transformace prvků vstupní množiny do takové permutace, která odpovídá zvolené relaci uspořádání, přičemž kardinalita množiny zůstává invariantní

Mějme vstupní množinu $S$. Třídění je proces hledání takové permutace $S_{sorted}$, pro kterou platí:

$$x_1 \leq x_2 \leq \dots \leq x_n$$
$$|S_{sorted}| = |S|$$

- $S$ = vstupní množina
- $S_{sorted}$ = výsledná seřazená množina
- $\leq$ = relace uspořádání
- $|S|$ = kardinalita

#### Příklad

Mějme množinu $S = \{15, 5, 12, 1, 8\}$ a relaci uspořádání $\leq$ (vzestupně).

1. **Vstup:** Permutace $\{15, 5, 12, 1, 8\}$.
2. **Proces:** Transformace prvků na základě porovnávání dvojic.
3. **Výstup:** Permutace $S_{sorted} = \{1, 5, 8, 12, 15\}$.

**Výsledkem je seřazená posloupnost:**
$$1 \leq 5 \leq 8 \leq 12 \leq 15$$
$$|S_{sorted}| = 5$$


### Pojmy
- Transformace = proces změny stavu nebo struktury dat (v tomto případě změna pořadí prvků z původního na seřazené).
- Permutace = jedno z možných uspořádání prvků dané množiny (přerovnání prvků tak, že žádný nechybí ani nepřebývá)
- Relace uspořádání = pravidlo, které určuje vzájemnou pozici dvou prvků (např. zda je prvek menší, větší, nebo roven jinému).
- Invariantní = vlastnost, která se v průběhu procesu nemění (u třídění je invariantem počet prvků – kardinalita)

### Třídění výběrem (Selection Sort)

Mějme množinu $S = \{3, 5, 1\}$ a relaci uspořádání $\leq$ (vzestupně).

**1. průchod:**
   - Prohledáváme celou množinu $\{3, 5, 1\}$ a hledáme minimum.
   - Minimum je **1**.
   - Vyměníme ho s prvkem na první pozici (číslo **3**).
   - Stav: $[1 \mid 5, 3]$ *(levá část od čáry je seřazená)*

**2. průchod:**
   - Hledáme minimum ve zbývající neseřazené části $\{5, 3\}$.
   - Minimum je **3**.
   - Vyměníme ho s prvkem na první volné pozici (číslo **5**).
   - Stav: $[1, 3 \mid 5]$

Poslední prvek ($5$) již není s čím porovnávat, zůstává na místě.

$$S_{sorted} = \{1, 3, 5\}$$

### Třídění vkládáním (Insertion Sort)
-

### Rozdíl mezi tříděním výběrem a vkládáním
-

### Binární vyhledávání (Binary Search)
-

### Merge Sort
- 

### Časová složitost algoritmů
-