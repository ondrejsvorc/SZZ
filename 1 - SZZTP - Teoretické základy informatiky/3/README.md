## 3

Spojové datové struktury (jednosměrný spojový seznam, binární strom) a základní operace nad nimi (vkládání, výmaz, vyhledávání) včetně časové složitosti

### Užitečné odkazy
- <https://szz.ondrejsvorc.cz/1%20-%20SZZTP%20-%20Teoretick%C3%A9%20z%C3%A1klady%20informatiky/3/>
- <https://ki.ujep.cz/opory/Aplikovana_Informatika/NMgr/Pokrocile_datove_struktury_a_algoritmy.html#Spojov%C3%BD-seznam>
- <https://cw.fel.cvut.cz/b182/_media/courses/b6b36dsa/dsa-3-slozitostalgoritmu.pdf>

### Spojový seznam
- lineární datová struktura tvořená uzly
- jednosměrný / obousměrný

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

#### Uzel
- základní prvek spojového seznamu, který obsahuje data a referenci na další uzel
- vztah `Node -> Node` představuje rekurzivní asociaci
- v rámci spojového seznamu lze uzly zároveň chápat jako kompozici seznamu

```csharp
public sealed class Node(int data, Node? next = null)
{
    public int Data { get; set; } = data;

    public Node? Next { get; set; } = next;
}
```

### Strom
- hierarchická datová struktura tvořená uzly propojenými odkazy, kde existuje právě jeden kořenový uzel (root) a každý uzel (kromě kořenového) má právě jednoho předchůdce

### Binární strom
- strom, ve kterém každý uzel obsahuje hodnotu a nejvýše dva odkazy, a to na levého a pravého potomka
- z pohledu teorie grafů:
  - orientovaný graf s jedním vrcholem, z něhož existuje cesta do všech ostatních vrcholů grafu

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