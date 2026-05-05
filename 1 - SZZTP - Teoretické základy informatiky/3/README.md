## 3

Spojové datové struktury (jednosměrný spojový seznam, binární strom) a základní operace nad nimi (vkládání, výmaz, vyhledávání) včetně časové složitosti

### Užitečné odkazy
- <https://szz.ondrejsvorc.cz/1%20-%20SZZTP%20-%20Teoretick%C3%A9%20z%C3%A1klady%20informatiky/3/>

### Spojový seznam
- lineární datová struktura tvořená uzly, kde každý uzel obsahuje hodnotu a odkaz na další uzel, přičemž pořadí prvků je určeno těmito odkazy, nikoli fyzickým uložením v paměti

### Jednosměrný spojový seznam
- spojový seznam, ve kterém každý uzel obsahuje právě jeden odkaz, a to na následující uzel, čímž vzniká jednosměrný řetězec prvků od počátečního uzlu (head) k poslednímu uzlu, který neodkazuje na žádný další uzel (tj. má odkaz na null)

#### Základní operace
- vkládání
    - vložení prvku na začátek seznamu $O(1)$
    - vložení prvku na konec seznamu $O(n)$
- výmaz
    - nalezení prvku a přepojení odkazů $O(n)$
- vyhledávání
    - sekvenční průchod od počátečního uzlu až do nalezení $O(n)$

### Strom
- hierarchická datová struktura tvořená uzly propojenými odkazy, kde existuje právě jeden kořenový uzel (root) a každý uzel (kromě kořenového) má právě jednoho předchůdce

### Binární strom
- strom, ve kterém každý uzel obsahuje hodnotu a nejvýše dva odkazy, a to na levého a pravého potomka

#### Základní operace
- vkládání
  - vložení uzlu na vhodnou pozici dle struktury stromu $O(n)$
- odstranění
  - nalezení uzlu a úprava odkazů $O(n)$
- vyhledávání
  - průchod stromem od kořene $O(n)$

#### Terminologie
- kořen (root) = počáteční uzel stromu, ke kterému nevede žádný odkaz od jiného uzlu
- potomek (child) = uzel, na který vede odkaz z jiného uzlu
- rodič (parent) = uzel, který má odkaz na daný uzel
- list (leaf) = uzel, který nemá žádné potomky
- hloubka (depth) = počet hran od kořene k danému uzlu
- výška (height) = délka nejdelší cesty od daného uzlu k listu
- podstrom (subtree) = strom tvořený uzlem a všemi jeho potomky