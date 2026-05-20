## Matematický software
- základní matematické operace v Pythonu a matematické výpočty v NumPy a SciPy
- vizualizace dat pomocí Matplotlib PyPlot
- interpolace a aproximace funkce jedné proměnné
- derivace a integrace funkce jedné proměnné
- řešení obyčejných diferenciálních rovnic

### Užitečné odkazy
- <https://youtu.be/zpYMiJd3pqg?si=zG0NRiX7Hurm2U-l> (SIR model - v angličtině)
- <https://www.youtube.com/watch?v=NKMHhm2Zbkw> (SIR model - v angličtině)

### Základní matematické operace

Standardní matematické funkce poskytuje modul `math`.

```python
import math

# Základní operace
addition: float = 5 + 3
subtraction: float = 5 - 3
multiplication: float = 5 * 3
division: float = 5 / 3
power: float = 5 ** 3
modulo: int = 5 % 3

# Odmocnina
square_root: float = math.sqrt(25)

# Goniometrické funkce
sinus: float = math.sin(math.pi / 2)
cosinus: float = math.cos(0)
tangens: float = math.tan(math.pi / 4)

# Logaritmy
natural_logarithm: float = math.log(10)
decimal_logarithm: float = math.log10(100)

# Konstanty
pi_value: float = math.pi
euler_number: float = math.e

# Nápovědy
help(math)
help(math.sqrt)

available_functions: list[str] = dir(math)
print(available_functions)
```

### SIR model
- matematický epidemiologický model, který popisuje šíření infekčních nemocí v populaci

Populace je rozdělena do 3 skupin:

| Označení | Název (EN) | Název (CS) | Význam |
|---|---|---|---|
| S | Susceptible | zdraví | zdraví lidé, kteří se mohou nakazit |
| I | Infectious | nakažení | aktuálně nakažení lidé |
| R | Recovered | uzdravení | uzdravení lidé s imunitou |

SIR model popisuje, kolik lidí se nachází v jednotlivých skupinách na začátku simulace a jak se tyto počty mění v čase.

#### Příklad

Na začátku:
- 99 % populace je zdravých
- 1 % populace je nakažených
- nikdo ještě není uzdravený

```python
susceptible = 0.99
infected = 0.01
recovered = 0.0
```

Protože modelujeme celou populaci, musí platit že:

$$
S+I+R=1
$$

Po určité době:
- nakažení začnou infikovat další lidi
- část nakažených se uzdraví
- počet uzdravených roste

#### Diferenciální rovnice

SIR model popisuje, jak rychle se jednotlivé skupiny mění v čase.

$$
\frac{dS}{dt} = -\beta SI
$$

- zdravých ubývá
- zdraví se nakazí kontaktem s nakaženými

$$
\frac{dI}{dt} = \beta SI - \gamma I
$$

- nakažení přibývají novými infekcemi
- nakažených ubývá uzdravením

$$
\frac{dR}{dt} = \gamma I
$$

- uzdravení přibývají

#### Význam parametrů

| Parametr | Význam |
|---|---|
| β | rychlost šíření infekce |
| γ | rychlost uzdravení |

#### Celý model

$$
\begin{cases}
\frac{dS}{dt} = -\beta SI \\
\frac{dI}{dt} = \beta SI - \gamma I \\
\frac{dR}{dt} = \gamma I
\end{cases}
$$

$$\frac{dS}{dt} = -\beta \frac{S \cdot I}{N}$$

#### Reprodukční číslo
- určuje, kolik dalších lidí průměrně nakazí jeden nakažený člověk

Značí se:

$$
R_0
$$

V SIR modelu platí:

$$
R_0 = \frac{\beta}{\gamma}
$$

| Parametr | Význam |
|---|---|
| β | rychlost šíření infekce |
| γ | rychlost uzdravení |

Interpretace:

| Hodnota R₀ | Význam |
|---|---|
| R₀ < 1 | epidemie postupně zaniká |
| R₀ = 1 | epidemie je stabilní |
| R₀ > 1 | epidemie se šíří |

### SIS model
- model, ve kterém po uzdravení nevzniká imunita
- uzdravený člověk se může znovu nakazit

Populace je rozdělena do 2 skupin:

| Označení | Název (EN) | Název (CS) | Význam |
|---|---|---|---|
| S | Susceptible | zdraví | zdraví lidé, kteří se mohou nakazit |
| I | Infectious | nakažení | aktuálně nakažení lidé |

Protože uzdravení ztrácí imunitu, neexistuje skupina:

$$
R
$$

Diferenciální rovnice:

$$
\frac{dS}{dt} = -\beta SI + \gamma I
$$

- zdravých ubývá novými infekcemi
- zdravých přibývá uzdravením nakažených

$$
\frac{dI}{dt} = \beta SI - \gamma I
$$

- nakažení přibývají infekcí
- nakažených ubývá uzdravením

Celý model:

$$
\begin{cases}
\frac{dS}{dt} = -\beta SI + \gamma I \\
\frac{dI}{dt} = \beta SI - \gamma I
\end{cases}
$$

### SIRD model
- rozšíření SIR modelu o úmrtí
- model popisuje šíření nemoci, uzdravení i úmrtí

Populace je rozdělena do 4 skupin:

| Označení | Název (EN) | Název (CS) | Význam |
|---|---|---|---|
| S | Susceptible | zdraví | zdraví lidé, kteří se mohou nakazit |
| I | Infectious | nakažení | aktuálně nakažení lidé |
| R | Recovered | uzdravení | uzdravení lidé s imunitou |
| D | Deceased | mrtví | lidé, kteří zemřeli |

Průběh:

$$
S \rightarrow I \rightarrow R
$$

nebo:

$$
S \rightarrow I \rightarrow D
$$

Diferenciální rovnice:

$$
\frac{dS}{dt} = -\beta SI
$$

- zdravých ubývá novými infekcemi

$$
\frac{dI}{dt} = \beta SI - \gamma I - \mu I
$$

- nakažení přibývají infekcí
- nakažených ubývá uzdravením
- nakažených ubývá úmrtím

$$
\frac{dR}{dt} = \gamma I
$$

- uzdravení přibývají

$$
\frac{dD}{dt} = \mu I
$$

- mrtvých přibývá

Význam parametrů:

| Parametr | Význam |
|---|---|
| β | rychlost šíření infekce |
| γ | rychlost uzdravení |
| μ | mortalita |

Celý model:

$$
\begin{cases}
\frac{dS}{dt} = -\beta SI \\
\frac{dI}{dt} = \beta SI - \gamma I - \mu I \\
\frac{dR}{dt} = \gamma I \\
\frac{dD}{dt} = \mu I
\end{cases}
$$

### SIRVD model
- rozšíření SIRD modelu o vakcinaci
- model popisuje šíření nemoci, uzdravení, úmrtí i očkování

Populace je rozdělena do 5 skupin:

| Označení | Název (EN) | Název (CS) | Význam |
|---|---|---|---|
| S | Susceptible | zdraví | zdraví lidé, kteří se mohou nakazit |
| I | Infectious | nakažení | aktuálně nakažení lidé |
| R | Recovered | uzdravení | uzdravení lidé s imunitou |
| V | Vaccinated | očkovaní | očkovaní lidé |
| D | Deceased | mrtví | lidé, kteří zemřeli |

Průběh:

$$
S \rightarrow I \rightarrow R
$$

nebo:

$$
S \rightarrow I \rightarrow D
$$

nebo:

$$
S \rightarrow V
$$

Diferenciální rovnice:

$$
\frac{dS}{dt} = -\beta SI - \nu S
$$

- zdravých ubývá infekcí
- zdravých ubývá vakcinací

$$
\frac{dV}{dt} = \nu S
$$

- očkovaných přibývá

$$
\frac{dI}{dt} = \beta SI - \gamma I - \mu I
$$

- nakažení přibývají infekcí
- nakažených ubývá uzdravením
- nakažených ubývá úmrtím

$$
\frac{dR}{dt} = \gamma I
$$

- uzdravení přibývají

$$
\frac{dD}{dt} = \mu I
$$

- mrtvých přibývá

Význam parametrů:

| Parametr | Význam |
|---|---|
| β | rychlost šíření infekce |
| γ | rychlost uzdravení |
| μ | mortalita |
| ν | rychlost vakcinace |

Celý model:

$$
\begin{cases}
\frac{dS}{dt} = -\beta SI - \nu S \\
\frac{dV}{dt} = \nu S \\
\frac{dI}{dt} = \beta SI - \gamma I - \mu I \\
\frac{dR}{dt} = \gamma I \\
\frac{dD}{dt} = \mu I
\end{cases}
$$

### Lotka–Volterra model predátor–kořist

- matematický model popisující vztah mezi predátorem a kořistí
- model popisuje vývoj populací v čase

Populace je rozdělena do 2 skupin:

| Označení | Název | Význam |
|---|---|---|
| x | kořist | populace kořisti |
| y | predátor | populace predátorů |

Průběh:

- kořist se přirozeně rozmnožuje
- predátoři loví kořist
- bez kořisti predátoři postupně vymírají

Diferenciální rovnice:

$$
\frac{dx}{dt} = \alpha x - \beta xy
$$

- kořist přirozeně roste
- kořisti ubývá lovem

$$
\frac{dy}{dt} = \delta xy - \gamma y
$$

- predátorů přibývá díky potravě
- predátoři přirozeně umírají

Význam parametrů:

| Parametr | Význam |
|---|---|
| α | rychlost růstu kořisti |
| β | intenzita lovu |
| γ | úmrtnost predátorů |
| δ | růst predátorů díky potravě |

Celý model:

$$
\begin{cases}
\frac{dx}{dt} = \alpha x - \beta xy \\
\frac{dy}{dt} = \delta xy - \gamma y
\end{cases}
$$