## 10

Výrokový počet (logické spojky, jejich úplný systém, odvozovací pravidla, splnitelnost, aplikace v logických obvodech), predikátový počet (abeceda a konstrukce jazyka), naivní teorie množin (potenční množina, systém množin, operace na množinách, relace mezi množinami), binární relace (vlastnosti a speciální typy [ekvivalence, uspořádání, zobrazení])

### Užitečné odkazy
- <https://szz.ondrejsvorc.cz/1%20-%20SZZTP%20-%20Teoretick%C3%A9%20z%C3%A1klady%20informatiky/10/>

### Výrokový počet
- synonymum: výroková logika
- formální logický systém, který z výroků pomocí logických spojek vytváří složené výroky a určuje jejich pravdivost

### Sémantika

### Tabulka pravdivostních hodnot

### Tautologie, kontradikce a splnitelnost

### Kontradikce

### Splnitelnost formule

### Sémantický důsledek

### Odvozovací pravidla

### Výrok
- sdělení deklarativního typu, u kterého má význam uvažovat o pravdivostní hodnotě
- každý výrok je buď **atomární**, nebo **složený**

#### Atomární výrok
- výrok bez logických spojek
- př. „Prší.“ ($u$)

#### Složený výrok
- složený výrok je výrok, který není atomární, tj. obsahuje alespoň jednu logickou spojku
- př. „Neprší.“ (¬$u$)

### Výroková formule

#### Sdělení deklarativního typu
- oznamovací věta, které lze přiřadit pravdivostní hodnotu

#### Pravdivostní hodnota
- pravda (logická 1)
- nepravda (logická 0)

### Logické spojky
- pravdivostní funkce, které určují pravdivost složeného výroku podle pravdivostních hodnot vstupů

#### Arita spojky
- značí se $k$
- počet vstupních výroků do logické spojky

### Unární spojka
- $k = 1$

#### Negace
- $¬u$
- způsob čtení: **negace** $u$

### Binární spojka
- $k = 2$
- celkem 16 binárních spojek

#### Konjunkce
- $u ∧ v$
- způsob čtení č. 1: $u$ **konjuktivně s** $v$
- způsob čtení č. 2: $u$ **a zároveň** $v$

#### Disjunkce
- $u ∨ v$
- způsob čtení: $u$ **nebo** $v$

#### Ekvivalence
- $u ⇔ v$
- způsob čtení č. 1: $u$ **je ekvivalentní s** $v$
- způsob čtení č. 2: $u$ **právě tehdy, když** $v$

#### Implikace
- $u ⇒ v$
- způsob čtení č. 1: $u$ **implikuje** $v$
- způsob čtení č. 2: **jestliže** $u$, **pak** $v$

### Ternární spojka
- $k = 3$
- příklad z programování: $A ? B : C$ (ternární operátor)
  - interpretace: pokud A, pak B, jinak C
  - je odvoditelná z binárních a unární (∧, ∨, ¬)
- příklad vyjádření ternární spojky pomocí úplného systému logických spojek:
  - $f(A,B,C)=(A∧B)∨(¬A∧C)$

**Spojky vyšší arity (k > 2) lze nahradit binárními a unárními spojkami.**

### Počet spojek
- =  počet všech pravdivostních funkcí dané arity $k$
- **unární spojka** má 1 vstup → $u$ a každý vstup může nabývat 2 pravdivostních hodnot (0/1)
  - konkrétně: $\{(0), (1)\}$
  - $2^{2^k}$ = $2^{2^1}$ = $2^{2}$ = 4 unární spojky
- **binární spojka** má 2 vstupy → $u$ a $v$ a každý vstup může nabývat 2 pravdivostních hodnot (0/1)
  - konkrétně: $\{(0,0), (0,1), (1,0), (1,1)\}$
  - $2^{2^k}$ = $2^{2^2}$ = $2^{4}$ = 16 binárních spojek
- **ternární spojka** má 3 vstupy → $u, v, w$ a každý vstup může nabývat 2 pravdivostních hodnot (0/1)
  - konkrétně: $\{(0,0,0), (0,0,1), (0,1,0), (0,1,1), (1,0,0), (1,0,1), (1,1,0), (1,1,1)\}$
  - $2^{2^k}$ = $2^{2^3}$ = $2^{8}$ = 256 ternárních spojek

**Počet všech $k$-árních pravdivostních funkcí je $2^{2^k}$**

### Úplný systém spojek
- množina logických spojek, pomocí které lze vyjádřit každý složený výrok
- příklady:
  - ${¬,∧}$
  - ${¬,∨}$
  - ${NAND}$

### Aplikace v logických obvodech
- výroky ↔ signály (0/1)
- spojky ↔ logická hradla
  - ∧ → AND
  - ∨ → OR
  - ¬ → NOT
- návrh a minimalizace obvodů

### Predikátový počet

#### Abeceda

#### Konstrukce jazyka

### Naivní teorie množin

#### Potenční množina

#### Systém množin

#### Operace na množinách

#### Relace mezi množinami

### Binární relace

#### Vlastnosti binární relace

#### Ekvivalence

#### Uspořádání

#### Zobrazení
