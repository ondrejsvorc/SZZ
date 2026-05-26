## Pokročilé statistické metody a zpracování časových řad

### Ukázková úloha

#### Zadání
Cílem je najít optimální model pro výšku hladiny v řece (na čem a jakým způsobem výška
hladiny závisí). K dispozici jsou data o různých ukazatelích, která mohou mít na výšku hladiny vliv.

#### Klíčové fáze řešení
- zhodnotit, zda máme k dispozici časovou řadu, nebo nezávislá pozorování,
a podle toho vybrat modely (modely časových řad nebo klasické regresní modely)
- identifikovat závisle proměnnou, případně podle jejího charakteru upřesnit volbu modelů
(klasická nebo logistická regrese)
- vizualizace průběhu závisle proměnné a vykreslení vhodných grafů závislostí na ostatních
proměnných (bodové grafy pro nezávislá měření, korelační funkce pro časové řady)
- stručná interpretace grafů – které závislosti je možné očekávat, jsou-li v datech závislé regresory atd.
- návrh více modelů a jejich porovnání (např. u časových řad model trendu a sezónnosti,
SARIMA model, model závislosti na ostatních řadách; pro nezávislá pozorování lineární
i polynomická regrese, modely s interakcemi i bez nich, kroková regrese)
- výpočet indikátorů kvality modelu (Akaikeho nebo Bayesovské kriterium, procento vysvětlené
variability, významnost koeficientů, střední chyba residuí)
- kontrola splnění předpokladů (nezávislost a normalita residuí, stabilita rozptylu)
a případné nápravné kroky (přidání členů ARMA, logaritmování závisle proměnné atd.)
- interpretace výsledků – porovnání modelů, výběr optimálního modelu, ohodnocení jeho kvality

#### Doporučený výstup
- report (R nebo Python) obsahující analýzy, vizualizace a především interpretace
- zápis modelu formou rovnice
- popis způsobu, jakým jednotlivé faktory v modelu ovlivňují závisle proměnnou

#### Seznam dostupných materiálů a technologií
Prostředí pro R a Python.
