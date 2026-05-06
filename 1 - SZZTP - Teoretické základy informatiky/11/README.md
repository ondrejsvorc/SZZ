## 11

Rekurence (vymezení, základní metody řešení [iterační a substituční metoda], řešení převodem na algebraické rovnice), speciální funkce (dolní a horní celá část, logaritmy), asymptotická notace (O‑, Theta‑, Omega‑ notace [vztahy a manipulace]), algoritmy (vymezení, Euklidův algoritmus [prvočísla, největší společný dělitel, nejmenší společný násobek])

### Užitečné odkazy
- <https://szz.ondrejsvorc.cz/1%20-%20SZZTP%20-%20Teoretick%C3%A9%20z%C3%A1klady%20informatiky/11/>
- <https://kam.fit.cvut.cz/deploy/bi-pkm/mirror/textbook/sec-dolni-a-horni-cela-cast.html>

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

### O-notace

### Theta-notace

### Omega-notace

### Euklidův algoritmus
- algoritmus pro výpočet největšího společného dělitele ($gcd$)

### Prvočísla
- čísla dělitelná pouze 1 a sama sebou

### Největší společný dělitel
- největší číslo, které dělí obě čísla
- GCD = Greatest Common Divisor

$$
\gcd(a,b)
$$

### Nejmenší společný násobek
- nejmenší číslo, které je násobkem obou