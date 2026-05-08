## 4

Reálná funkce jedné reálné proměnné (definice, definiční obor a obor hodnot, graf funkce, limita a spojitost funkce), polynomy (definice, vlastnosti, Hornerovo schéma), numerické řešení nelineárních rovnic (metoda půlení intervalu, Newtonova metoda)

### Užitečné odkazy
- <https://szz.ondrejsvorc.cz/1%20-%20SZZTP%20-%20Teoretick%C3%A9%20z%C3%A1klady%20informatiky/4/>

### Funkce
- zobrazení mezi dvěma množinami

$$f : A \to B$$

Každému prvku z množiny $A$ přiřazuje právě jeden prvek z množiny $B$.

$$
A,B \subseteq U
$$

$A$ i $B$ jsou podmnožiny univerza $U$. V kontextu funkce můžeme tvrdit, že:
- $A$ = definiční obor
- $B$ = obor hodnot

Univerzum je množina všech prvků uvažovaných v daném kontextu. V kontextu funkce mohou být z univerza vybírány prvky tvořící:
- definiční obor
- obor hodnot
- kartézský součin
- ...

Předpis funkce pak popisuje závislost mezi prvky definičního oboru a odpovídajícími prvky oboru hodnot. Jinými slovy určuje, jakým způsobem se z hodnoty vstupu vypočítá odpovídající hodnota výstupu.

### Reálná funkce
- funkce, jejíž definiční obor i obor hodnot jsou tvořeny reálnými čísly

$$
f : A \to B
$$

$$
A,B \subseteq \mathbb{R}
$$

$$
f : \mathbb{R} \to \mathbb{R}
$$

Každému reálnému číslu z definičního oboru přiřazuje právě jedno reálné číslo z oboru hodnot.

### Reálná funkce jedné proměnné
- reálná funkce, jejíž vstup je tvořen právě jednou proměnnou

$$
x \in \mathbb{R}
$$

$$
f(x) \in \mathbb{R}
$$

### Definiční obor
- množina všech hodnot vstupní proměnné, pro které je funkce definována a dokáže přiřadit odpovídající hodnotu z oboru hodnot
- intuitivně představuje všechny hodnoty na ose $x$, pro které má funkce smysl a lze vypočítat její hodnotu

Značí se:
$$
D(f)
$$

Pro každou hodnotu:
$$
x \in D(f)
$$

musí být možné určit odpovídající funkční hodnotu:
$$
f(x)
$$

#### Příklad
$$
f(x)=\frac{1}{x}
$$

$$
D(f)=\mathbb{R}\setminus\{0\}
$$

protože pro danou hodnotu:

$$
x=0
$$

nelze určit funkční hodnotu.

### Obor hodnot
- množina všech hodnot, kterých může funkce nabývat
- intuitivně představuje všechny hodnoty na ose $y$, které může funkce vytvořit

Značí se:
$$
H(f)
$$

Každá funkční hodnota:

$$
f(x)
$$

patří do oboru hodnot.

#### Příklad
$$
f(x)=x^2
$$
$$
H(f)=[0,\infty)
$$

protože druhá mocnina reálného čísla nikdy není záporná.

### Graf funkce
- množina všech bodů, které reprezentují funkční hodnoty dané funkce v konkrétní soustavě souřadnic (např. kartézské)

Každý bod grafu odpovídá dvojici:
$$
[x,f(x)]
$$

Graf funkce tvoří všechny body:
$$
\{[x,f(x)] \mid x \in D(f)\}
$$

### Příklad
$$
f(x)=x^2
$$
Grafem této funkce je parabola otevřená směrem nahoru.

### Limita
- číslo, ke kterému se blíží hodnoty funkce $f(x)$, pokud se argument funkce $x$ blíží k určitému bodu $a$
- popisuje chování funkce v okolí daného bodu, nikoliv nutně přímo v tomto bodě

$$
\lim_{x \to a} f(x)=L
$$

To znamená, že pokud se:
$$
x \to a
$$

pak se odpovídající funkční hodnoty:
$$
f(x) \to L
$$

přičemž „$\to$“ v tomto kontextu čteme jako „se blíží k“.

### Limita zleva
### Limita zprava
### Kdy existuje limita

### Spojitost funkce
- funkce je spojitá v bodě $a \in D(f)$, pokud limita funkce v bodě $a$ existuje a je rovna funkční hodnotě v tomto bodě

$$
\lim_{x \to a} f(x)=f(a)
$$

### Polynomy

### Vlastnosti polynomů

### Hornerovo schéma

### Numerické řešení nelineárních rovnic

### Metoda půlení intervalu

### Newtonova metoda