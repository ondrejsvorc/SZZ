## 10

Výrokový počet (logické spojky, jejich úplný systém, odvozovací pravidla, splnitelnost, aplikace v logických obvodech), predikátový počet (abeceda a konstrukce jazyka), naivní teorie množin (potenční množina, systém množin, operace na množinách, relace mezi množinami), binární relace (vlastnosti a speciální typy [ekvivalence, uspořádání, zobrazení])

### Užitečné odkazy
- <https://szz.ondrejsvorc.cz/1%20-%20SZZTP%20-%20Teoretick%C3%A9%20z%C3%A1klady%20informatiky/10/>

### Výrokový počet
- synonymum: výroková logika
- formální logický systém, který z výroků pomocí logických spojek vytváří složené výroky a určuje jejich pravdivost

### Tabulka pravdivostních hodnot
- tabulka, která pro všechny možné kombinace pravdivostních hodnot atomárních výroků uvádí pravdivostní hodnotu dané formule

### Tautologie
- vždy pravdivý výrok nezávisle na vstupu
- např.: $u∨¬u$

### Kontradikce
- vždy nepravdivý nezávisle na vstupu
- např.: $u∧¬u$

### Splnitelná formule
- formule, která není kontradikcí
- např.: $u∧v$
  - je pravdivá např. pro u=1,v=1 ⇒ splnitelná

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
- rozšíření výrokového počtu o proměnné a kvantifikátory, které umožňuje vyjadřovat vlastnosti objektů a vztahy mezi nimi

#### Doména
- množina objektů, které v predikátovém počtu uvažujeme
- např. všichni studenti

#### Predikát
- výraz s proměnnými, který se po dosazení stává výrokem
- např.:
  - $P(x)$: „$x$ je sudé“
  - $x=y$
  - $x∈A$

#### Proměnná
- symbol označující libovolný objekt z domény
- např.: $x$

#### Kvantifikátor
- symbol určující, pro kolik objektů z domény výrok platí
- např.: $∀x(x>0)$

#### Abeceda
- množina symbolů, ze kterých se tvoří výrazy
  - proměnné: $x$, $y$, $z$, ...
  - konstanty: $a$, $b$, $c$, ...
  - predikátové symboly: $∈$, $=$, ...
  - funkční symboly (funktory): sjednocení, průnik, ...
  - logické spojky: $¬$, $∧$, $∨$, $⇒$, $⇔$
  - kvantifikátory: $∀$, $∃$

### Naivní teorie množin
- neformální přístup k množinám, kde množinu lze chápat jako libovolný soubor prvků daný nějakou vlastností

### Množina
- soubor navzájem odlišitelných prvků
- prvek buď do množiny patří, nebo nepatří (∈ / ∉)
- prvek se v množině vyskytuje nejvýše jednou
- na pořadí prvků nezáleží

#### Systém množin
- množina množin

#### Potenční množina
- systém množin obsahující všechny podmnožiny dané množiny
- značí se $Pot(𝐴)$
  - $A=\{1,2\}$
  - $P(A)=\{∅,\{1\},\{2\},\{1,2\}\}$
- počet podmnožin potenční množiny: $|Pot(𝐴)|$ = $2^n$, kde $n$ je počet prvků dané množiny 

#### Univerzum
- značí se $U$
- množina všech prvků, o kterých v daném kontextu uvažujeme
- vždy zadané nebo implicitní
- všechny množiny jsou podmnožiny $U$

#### Operace na množinách
- **sjednocení**  
  - $A ∪ B = \{ x \mid x ∈ A ∨ x ∈ B \}$

- **průnik**  
  - $A ∩ B = \{ x \mid x ∈ A ∧ x ∈ B \}$

- **rozdíl**  
  - $A \setminus B = \{ x \mid x ∈ A ∧ x ∉ B \}$

- **doplněk/komplement**  
  - $A^c = \{ x \mid x ∈ U ∧ x ∉ A \}$

#### Relace mezi množinami
- **rovnost**
  - $A = B$
  - $\forall x \,(x ∈ A ⇔ x ∈ B)$

- **podmnožina**
  - $A ⊆ B$
  - $\forall x \,(x ∈ A ⇒ x ∈ B)$

- **vlastní podmnožina**
  - $A ⊂ B$
  - $A ⊆ B ∧ A ≠ B$

- **nadmnožina**
  - $A ⊇ B$

- **disjunktnost**
  - $A ∩ B = ∅$

### Binární relace
- podmnožina kartézského součinu $A \times B$
- $R ⊆ A \times B$
- prvek relace je uspořádaná dvojice $(a,b)$

#### Obory relace
- **definiční obor (první obor)**  
  - $Dom(R) = \{ a \mid ∃b: (a,b) ∈ R \}$
- **obor hodnot (druhý obor)**  
  - $Im(R) = \{ b \mid ∃a: (a,b) ∈ R \}$

#### Kartézský součin
- množina všech uspořádaných dvojic prvků z množin $A$ a $B$
- $A \times B = \{ (a,b) \mid a ∈ A ∧ b ∈ B \}$
- velikost: $|A \times B| = |A| \cdot |B|$

#### Obory relace
- definiční obor (první obor)
- obor hodnot (druhý obor)

#### Znázornění relace
- **kartézský graf**  
  - body v rovině odpovídající dvojicím $(a,b)$
- **orientovaný graf**  
  - vrcholy = prvky množiny  
  - hrana $a → b$ pokud $(a,b) ∈ R$

#### Vlastnosti relace na množině
- **reflexivita**  
  - $\forall x ∈ A: (x,x) ∈ R$
- **antireflexivita**  
  - $\forall x ∈ A: (x,x) ∉ R$
- **symetrie**  
  - $(x,y) ∈ R ⇒ (y,x) ∈ R$
- **antisymetrie**  
  - $(x,y) ∈ R ∧ (y,x) ∈ R ⇒ x = y$
- **tranzitivita**  
  - $(x,y) ∈ R ∧ (y,z) ∈ R ⇒ (x,z) ∈ R$

#### Ekvivalence
- relace, která je:
  - reflexivní
  - symetrická
  - tranzitivní
- rozděluje množinu na **třídy ekvivalence**
- **třída ekvivalence prvku $x$**:
  - $[x] = \{ y ∈ A \mid (x,y) ∈ R \}$

#### Uspořádání
- relace, která je:
  - reflexivní (neostré uspořádání) nebo antireflexivní (ostré)
  - antisymetrická
  - tranzitivní
- typy:
  - **částečné uspořádání**
  - **lineární (totální) uspořádání** – každý pár prvků je porovnatelný

#### Hasseův diagram
- grafické znázornění uspořádání
- pravidla:
  - neznázorňují se reflexivní hrany
  - neznázorňují se tranzitivní hrany
  - kreslí se zdola nahoru

#### Zobrazení
- speciální binární relace $f ⊆ A \times B$
- každému prvku $a ∈ A$ přiřazuje právě jeden prvek $b ∈ B$
- značení:
  - $f: A → B$
- vlastnosti:
  - **injektivní**  
    - $f(x)=f(y) ⇒ x=y$
  - **surjektivní**  
    - $\forall b ∈ B ∃a ∈ A: f(a)=b$
  - **bijektivní**  
    - injektivní i surjektivní