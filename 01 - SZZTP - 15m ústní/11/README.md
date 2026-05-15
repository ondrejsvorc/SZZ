## 11

Rekurence (vymezení, základní metody řešení [iterační a substituční metoda], řešení převodem na algebraické rovnice), speciální funkce (dolní a horní celá část, logaritmy), asymptotická notace (O‑, Theta‑, Omega‑ notace [vztahy a manipulace]), algoritmy (vymezení, Euklidův algoritmus [prvočísla, největší společný dělitel, nejmenší společný násobek])

### Užitečné odkazy
- <https://szz.ondrejsvorc.cz/01%20-%20SZZTP%20-%20Teoretick%C3%A9%20z%C3%A1klady%20informatiky/11/>
- <https://kam.fit.cvut.cz/deploy/bi-pkm/mirror/textbook/sec-dolni-a-horni-cela-cast.html>
- <https://www.cs.vsb.cz/kot/download/uti2006/uti-pr-09.pdf>

### Rekurence
- vztah, který definuje hodnotu funkce (typicky posloupnosti) pomocí jejích předchozích hodnot

Formálně:
$$
a_n = f(a_{n-1}, a_{n-2}, \ldots, a_{n-k})
$$

Rekurence se skládá ze dvou částí:
- rekurentní vztah (jak spočítat další hodnotu)
- počáteční podmínky (např. $a_0, a_1$)

#### Rekurentní zápis
$$
a_n = a_{n-1} + 2,\quad a_0 = 1
$$

#### Postupné rozvinutí

$$
\begin{aligned}
a_0 &= 1 \\
a_1 &= a_0 + 2 = 3 \\
a_2 &= a_1 + 2 = 5 \\
a_3 &= a_2 + 2 = 7 \\
&\vdots
\end{aligned}
$$

#### Posloupnost

$$
(1, 3, 5, 7, 9, \ldots)
$$

#### Vzorec pro n-tý člen

$$
a_n = 1 + 2n
$$

### Praktický příklad

Součet čísel od 1 do n.

Rekurentní uvažování: součet do $n$ získáme tak, že vezmeme součet do $n-1$ a přičteme $n$.

```csharp
int Sum(int n)
{
    if (n == 0) return 0;
    return Sum(n - 1) + n;
}
```

#### Rekurentní vztah:
$$
S(n) = S(n-1) + n,\quad S(0) = 0
$$

#### Rekurentní vztah pro součet do 4:
$$
\begin{aligned}
S(4) &= S(3) + 4 \\
     &= S(2) + 3 + 4 \\
     &= S(1) + 2 + 3 + 4 \\
     &= S(0) + 1 + 2 + 3 + 4 \\
     &= 0 + 1 + 2 + 3 + 4
\end{aligned}
$$

#### Jiný zápis rekurentního vztahu:
$$
S(n) = 1 + 2 + 3 + \cdots + n
$$

Iterativní uvažování: součet získáme postupným sčítáním všech čísel od 1 do $n$ v cyklu.
```csharp
int Sum(int n)
{
    int result = 0;

    for (int i = 1; i <= n; i++)
    {
        result += i;
    }

    return result;
}
```

$$
\sum_{i=1}^{n} i
$$

Součet získáme přímo pomocí vzorce bez postupného sčítání, tedy jako funkci závislou pouze na $n$.
```csharp
int Sum(int n)
{
    return n * (n + 1) / 2;
}
```

$$
S(n) = \frac{n(n+1)}{2}
$$

*Rekurence ukazuje, jak se hodnota postupně skládá z předchozích hodnot, iterace jak ji spočítat krok za krokem a uzavřený vzorec jak ji získat přímo bez mezikroků.*

| Typ řešení tohoto problému        | Časová složitost | Prostorová složitost |
|------------------|------------------|----------------------|
| Rekurentní       | O(n)             | O(n)                 |
| Iterativní       | O(n)             | O(1)                 |
| Vzorec pro n-tý člen  | O(1)             | O(1)                 |

### Iterační metoda

### Substituční metoda
- 

### Řešení převodem na algebraické rovnice

### Dolní celá část
- zaokrouhlení dolů

#### Značení
$$
\lfloor x \rfloor
$$

#### Příklad
$$
\lfloor 3.7 \rfloor = 3
$$

#### Definice
$$
\lfloor x \rfloor = \max \{ m \in \mathbb{Z} \mid m \le x \}
$$

![](https://kam.fit.cvut.cz/deploy/bi-pkm/mirror/textbook/figures/fig-dolni.svg)

### Horní celá část
- zaokrouhlení nahoru

#### Značení
$$
\lceil x \rceil
$$

#### Příklad
$$
\lceil 3.2 \rceil = 4
$$

#### Definice
$$
\lceil x \rceil = \min \{ m \in \mathbb{Z} \mid m \ge x \}
$$

![](https://kam.fit.cvut.cz/deploy/bi-pkm/mirror/textbook/figures/fig-horni.svg)

### Logaritmus
- inverzní funkce k exponenciále

$$
\log_b a = c \Leftrightarrow b^c = a
$$

#### Základní pravidla
- $\log(ab) = \log a + \log b$
- $\log\!\left(\frac{a}{b}\right) = \log a - \log b$
- $\log(a^k) = k \log a$
- $\log(\sqrt[k]{a}) = \frac{1}{k}\log a$
- $\log_b a = \frac{\log a}{\log b}$
- $\log_b a = \frac{\ln a}{\ln b}$
- $\log_b 1 = 0$
- $\log_b b = 1$
- $\log_b (b^k) = k$
- $b^{\log_b a} = a$

#### Monotonicita
- pro $b \in (1, \infty)$ je $\log_b x$ rostoucí  
- pro $b \in (0, 1)$ je $\log_b x$ klesající

### Asymptotická notace
- formální matematický nástroj pro porovnávání rychlosti růstu funkcí v limitě pro $n \to \infty$
- v informatice se používá se k vyjadřování asymptotické složitosti algoritmů

### Asymptotická složitost
- charakteristika algoritmu popisující, jak roste jeho časová nebo paměťová náročnost v závislosti na velikosti vstupu při $n \to \infty$.
- vyjadřuje se asymptotickou notací
- druhy:
    - časová
    - paměťová

### Asymptotický růst
- způsob, jakým se mění hodnota funkce při $n \to \infty$
- popisuje rychlost růstu funkce pro dostatečně velké hodnoty vstupu

### Časová asymptotická složitost
- asymptotický růst počtu operací algoritmu

### Paměťová asymptotická složitost
- asymptotický růst spotřeby paměti algoritmu

### Big-O notace ($O$)
- též Landauova notace
- asymptotická notace vyjadřující horní mez růstu funkce
- používá se pro odhad složitosti algoritmu v nejhorších případech (worst case scenarios)

Formálně:

$$
f(n) \in O(g(n))
$$

pokud existují konstanty:

$$
c > 0,\ n_0
$$

takové, že:

$$
f(n) \le c \cdot g(n)
\quad \text{pro všechna } n \ge n_0
$$

kde:

- $f(n)$ = skutečná funkce, kterou analyzujeme
- $g(n)$ = referenční růstová funkce, se kterou $f(n)$ porovnáváme
- $c$ = konstantní násobek určující tolerovanou horní mez
- $n_0$ = hranice, od které porovnání začíná platit

Od $n_0$ je $f(n)$ vždy **pod nebo na** křivce $c \cdot g(n)$.

#### Příklad

$$
f(n) \in O(n^2)
$$

znamená:
- funkce má asymptoticky nejvýše kvadratický růst.
- funkce je asymptoticky omezena shora funkcí $n^2$
- pro dostatečně velká $n$ je růst funkce nejvýše kvadratický.

### Omega notace ($\Omega$)
- asymptotická notace vyjadřující dolní asymptotickou mez
- používá se pro odhad složitosti algoritmu v nejlepších případech (best case scenarios)

Formálně:

$$
f(n) \in \Omega(g(n))
$$

pokud existují konstanty:

$$
c > 0,\ n_0
$$

takové, že:

$$
f(n) \ge c \cdot g(n)
\quad \text{pro všechna } n \ge n_0
$$

kde:

- $f(n)$ = skutečná funkce, kterou analyzujeme
- $g(n)$ = referenční růstová funkce, se kterou $f(n)$ porovnáváme
- $c$ = konstantní násobek určující tolerovanou dolní mez
- $n_0$ = hranice, od které porovnání začíná platit

Od $n_0$ je $f(n)$ vždy **nad nebo na** křivce $c \cdot g(n)$.

### Theta notace ($\Theta$)
- asymptotická notace vyjadřující těsnou asymptotickou mez
- těsná asymptotická mez = současně horní i dolní mez
- používá se tehdy, kdy je Big-O i Omega notace stejná

$$
f(n) \in \Theta(g(n))
\;\Rightarrow\;
f(n) \in O(g(n))
\land
f(n) \in \Omega(g(n))
$$

Formálně:

$$
f(n) \in \Theta(g(n))
$$

pokud existují konstanty:

$$
c_1 > 0,\ c_2 > 0,\ n_0
$$

takové, že:

$$
c_1 \cdot g(n)
\le
f(n)
\le
c_2 \cdot g(n)
\quad \text{pro všechna } n \ge n_0
$$

kde:

- $f(n)$ = skutečná funkce, kterou analyzujeme
- $g(n)$ = referenční růstová funkce, se kterou $f(n)$ porovnáváme
- $c_1$ = konstantní násobek určující dolní asymptotickou mez
- $c_2$ = konstantní násobek určující horní asymptotickou mez
- $n_0$ = hranice, od které porovnání začíná platit

Od $n_0$ je $f(n)$ vždy **mezi** křivkami $c_1 \cdot g(n) \quad$ a $\quad c_2 \cdot g(n)$

### Dominantní člen
- člen funkce s nejrychlejším růstem
- určuje asymptotickou složitost

Příklad:

$$
3n^2 + 5n + 1
$$

dominantní člen:

$$
n^2
$$

proto:

$$
3n^2 + 5n + 1 \in \Theta(n^2)
$$

### Příklad, kde jsou asymptotické notace stejné

```python
def print_pairs(n: int) -> None:
    for i in range(n): # n iterací
        for j in range(n): # n iterací
            print(i, j)
```
Vnější cyklus běží $n$-krát a každou iteraci. vnějšího cyklu běží vnitřní cyklus také $n$-krát.

Počet iterací:
$$n ⋅ n = n^2$$

Notace:
- $f(n) \in O(n^2)$ = algoritmus neroste rychleji než kvadraticky
- $f(n) \in \Theta(n^2)$ = algoritmus roste přesně kvadraticky
- $f(n) \in \Omega(n^2)$ = algoritmus roste alespoň kvadraticky

### Příklad, kde jsou asymptotické notace odlišné

```python
def contains_zero(numbers: list[int]) -> bool:
    for number in numbers:
        if number == 0:
            return True

    return False
```

#### Worst case scenario
- žádný z prvků není nula (např. [1, 2, 3, 4])
- algoritmus musí projít celé pole
- počet operací roste lineárně

Ve worst case scenario proběhne cyklus $n$-krát a podmínka se také vyhodnotí $n$-krát. `return True` v tomto scénáři neproběhne ani jednou, protože žádný prvek není nula. `return False` proběhne jednou po dokončení cyklu. Funkci počtu operací tedy můžeme zapsat jako:

$$
f(n) = n + n + 1
$$

Po algebraickém zjednodušení:

$$
f(n) = 2n + 1
$$

V asymptotické analýze ignorujeme konstantní násobky i konstantní členy, protože pro velká $n$ nemají významný vliv na růst funkce. Dominantní růst tedy určuje:

$$
f(n) = n
$$

proto:

$$
\Theta(n)
$$

Protože v nejhorším případě algoritmus roste asymptoticky nejvýše lineárně a zároveň alespoň lineárně. Horní i dolní asymptotické meze jsou tedy stejné (proto je nejpřesnější použít Theta notaci).

#### Best case scenario
- první prvek je nula (např. [0, 1, 2, 3])
- algoritmus skončí hned
- počet operací je konstantní

V best case scenario proběhne cyklus právě jednou a podmínka se také vyhodnotí právě jednou. `return True` proběhne okamžitě při první iteraci a `return False` se již nikdy neprovede. Funkci počtu operací tedy můžeme zapsat jako:

$$
f(n) = 1 + 1 + 1
$$

Po algebraickém zjednodušení:

$$
f(n) = 3
$$

V asymptotické analýze ignorujeme konstantní násobky i konstantní členy, protože pro velká $n$ nemají významný vliv na růst funkce. Dominantní růst tedy určuje:

$$
f(n) = 1
$$

proto:

$$
\Theta(1)
$$

Protože v nejlepším případě algoritmus roste asymptoticky nejvýše konstantně a zároveň alespoň konstantně. Horní i dolní asymptotické meze jsou tedy stejné (proto je nejpřesnější použít Theta notaci).

### Euklidův algoritmus
- algoritmus pro výpočet největšího společného dělitele ($gcd$)
- největší číslo, které beze zbytku dělí obě daná čísla

$$
m, n \in \mathbb{Z}, \quad 0 \leq m < n
$$

$$
\gcd(0, n) = n
$$

$$
\gcd(m, n) = \gcd(n \bmod m,\; m), \quad \text{pro } m > 0
$$

#### Postup

$$
\gcd(m, n) = \gcd(n \bmod m,\; m)
$$

opakujeme, dokud nedostaneme:

$$
\gcd(0, k) = k
$$

*$mod$ = dělení se zbytkem (např. 10 mod 3 = 1, protože 10 děleno 3 je 9 a zbytek je 1 a mod vrací právě ten zbytek po dělení)*

#### Příklad

$$
\begin{aligned}
\gcd(12,18)
&= \gcd(18 \bmod 12,\;12) \\
&= \gcd(6,\;12) \\
&= \gcd(12 \bmod 6,\;6) \\
&= \gcd(0,\;6) \\
&= 6
\end{aligned}
$$

$$
\begin{aligned}
18 \bmod 12 &= 6 \\
12 \bmod 6 &= 0
\end{aligned}
$$

### Prvočísla
- čísla dělitelná pouze 1 a sama sebou

### Největší společný dělitel
- největší číslo, které beze zbytku dělí všechna zadaná čísla
- GCD = Greatest Common Divisor

#### Příklad

Dělitelé čísla $12$:

$$
\{1, 2, 3, 4, 6, 12\}
$$

Dělitelé čísla $18$:

$$
\{1, 2, 3, 6, 9, 18\}
$$

Společní dělitelé:

$$
\{1, 2, 3, 6\}
$$

Největší z nich:

$$
6
$$

tedy:

$$
\gcd(12,18)=6
$$

### Nejmenší společný násobek
- nejmenší číslo, které je násobkem obou čísel
- LCM = Least Common Multiple

#### Příklad

Násobky čísla $4$:

$$
\{4, 8, 12, 16, 20, 24, \dots\}
$$

Násobky čísla $6$:

$$
\{6, 12, 18, 24, 30, \dots\}
$$

Společné násobky:

$$
\{12, 24, \dots\}
$$

Nejmenší z nich:

$$
12
$$

tedy:

$$
\operatorname{lcm}(4,6)=12
$$