## 5

Diferenciální a integrální počet funkcí jedné proměnné (definice derivace funkce a její geometrický význam, primitivní funkce, určitý integrál a jeho geometrický význam), numerické derivování a integrace (obdélníkové, lichoběžníkové a Simpsonovo pravidlo), aplikace (určení lokálního extrému, navazování křivek, objem rotačního tělesa)

### Užitečné odkazy
- <https://szz.ondrejsvorc.cz/01%20-%20SZZTP%20-%20Teoretick%C3%A9%20z%C3%A1klady%20informatiky/05/>

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

### Limita
- číslo, ke kterému se funkce v nějakém bodě blíží
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

$$
\lim_{x \to a^-} f(x)
$$

- hodnota, ke které se funkce blíží při přibližování k bodu $a$ zleva

### Limita zprava

$$
\lim_{x \to a^+} f(x)
$$

- hodnota, ke které se funkce blíží při přibližování k bodu $a$ zprava

### Existence limity
- limita existuje právě tehdy, když existuje limita zleva i limita zprava a vychází stejně

$$
\lim_{x \to a^-} f(x)=\lim_{x \to a^+} f(x)=L
\Rightarrow
\lim_{x \to a} f(x)=L
$$

Například funkce:

$$
f(x)=\frac{1}{x}
$$

nemá v bodě $x=0$ limitu, protože:

$$
\lim_{x \to 0^-} \frac{1}{x}=-\infty
$$

$$
\lim_{x \to 0^+} \frac{1}{x}=+\infty
$$

limita zleva a limita zprava nejsou stejné.

### Derivace

### Integrál

### Určitý integrál