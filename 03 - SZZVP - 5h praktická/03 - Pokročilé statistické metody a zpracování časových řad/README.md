## Pokročilé statistické metody a zpracování časových řad

### Užitečné odkazy
- <https://www.youtube.com/watch?v=CAT0Y66nPhs> (ACF, PACF)
- <https://www.youtube.com/watch?v=deV2SlJ2Dnw> (ACF)

### Obecné poznatky
- sám jsem si vylosoval časovou řadu
- výpisky níže se týkají pouze mé práce

### Časová řada
- posloupnost dat měřených v pravidelných časových intervalech
- skládá se z trendové, sezónní a náhodné složky
- osa `x`: čas
- osa `y`: pozorovaná data
- v mé práci: kvartální index obratu v ICT službách v ČR za období 2010–2023

### Sezónnost
- pravidelně se opakující vzorec v časové řadě
- opakuje se po pevně daném období (ročně, kvartálně)
- není náhodná
- způsobují ji sezónní vlivy

#### Perioda sezónnosti
- délka jednoho kompletního sezónního cyklu
- udává, po kolika pozorováních se sezónní vzorec opakuje
- závisí na frekvenci dat
- v mé práci: 4 kvartály (1 rok)

#### Sezónní vliv
- velikost a charakter sezónních odchylek od trendu
- vyjadřuje, jak jednotlivá období systematicky zvyšují nebo snižují hodnotu řady
- není náhodný
- v mé práci: 4. kvartál zvyšuje hodnoty indexu, 3. kvartál je naopak zpravidla slabší

### Trend
- dlouhodobý směr vývoje časové řady
- vyjadřuje systematický růst nebo pokles v čase
- může být lineární nebo nelineární
- nepopisuje krátkodobé výkyvy ani sezónnost
- v mé práci byl patrný dlouhodobý rostoucí trend, výraznější růst po roce 2026 a byl hlavní příčinou nestacionarity časové řady, a tak jsem ho odstranil pomocí první diference (d = 1)

#### Lineární trend
- řada roste nebo klesá přibližně konstantním tempem
- lze jej aproximovat přímkou

#### Nelineární trend
- tempo růstu nebo poklesu se v čase mění
- může zrychlovat nebo zpomalovat
- typicky exponenciální nebo logistický průběh

### Náhodná složka
- část časové řady, kterou nelze vysvětlit trendem ani sezónností
- představuje náhodné výkyvy a šum v datech
- nemá systematický vzorec
- je nepředvídatelná
- po odstranění trendu a sezónnosti by měla tvořit většinu zbývající informace v řadě
- v mé práci: cílem modelování bylo odstranit trend a sezónnost tak, aby v reziduích zůstala převážně pouze náhodná složka

### Stacionarita
- vlastnost časové řady, při které se její statistické charakteristiky v čase nemění
- průměr je přibližně konstantní
- rozptyl je přibližně konstantní
- vztahy mezi pozorováními se v čase nemění
- je základním předpokladem modelů ARIMA a SARIMA

#### Stacionární časová řada
- nevykazuje dlouhodobý trend
- nevykazuje měnící se rozptyl
- kolísá kolem přibližně konstantní úrovně

#### Nestacionární časová řada
- obsahuje trend, sezónnost nebo měnící se rozptyl
- její statistické vlastnosti se v čase mění
- nelze ji přímo modelovat pomocí ARIMA a SARIMA

### ACF
- autokorelační funkce (Autocorrelation Function)
- vyjadřuje, jak silně současná hodnota časové řady souvisí s hodnotou, která byla `k` pozic zpět v čase
- měří korelaci mezi pozorováními v různých časových okamžicích
- osa x: zpoždění (lags)
- osa y: hodnota korelace pro dané zpoždění
- používá se k identifikaci závislostí v časové řadě
- pomáhá při návrhu ARIMA/SARIMA modelů
- v mé práci: ACF potvrdila přítomnost kvartální sezónnosti (perioda 4) a pomohla při výběru struktury SARIMA modelu

#### Lag
- zpoždění
- např. lag 1 znamená jak moc souvisí dnešní hodnota s hodnotou o 1 pozorování zpět
- pokud mám třeba kvartální data (měřená 4krát do roka), tak:
  - lag 1 = 1 kvartál
  - lag 2 = 2 kvartály
  - lag 4 = 1 rok
  - lag 8 = 2 roky

#### Modré čáry
- 95% intervaly spolehlivosti
- ukazují hranici, za kterou už je korelace příliš velká na to, aby vznikla náhodou
- pokud sloupec zůstane uvnitř modrého pásma, korelace není statisticky významná
- pokud sloupec přesáhne modrou čáru, korelace je statisticky významná
- H0: Autokorelace je nulová
- H1: Autokolerace je nenulová

### PACF
- parciální autokorelační funkce (Partial Autocorrelation Function)
- vyjadřuje, jak silně současná hodnota časové řady přímo souvisí s hodnotou, která byla `k` pozic zpět v čase, po odstranění vlivu všech mezilehlých zpoždění
- používá se k identifikaci autoregresní (AR) části modelu
- osa x: zpoždění (lags)
- osa y: hodnota parciální korelace
- v mé práci: PACF byla společně s ACF použita při návrhu struktury SARIMA modelu

### Diferencování
- metoda používaná k odstranění trendu a dosažení stacionarity časové řady
- spočívá ve výpočtu rozdílů mezi hodnotami časové řady
- místo původních hodnot se modelují jejich změny

#### První diference
- počítá rozdíl mezi dvěma po sobě jdoucími pozorováními
- odstraňuje lineární trend
- odpovídá parametru $d = 1$ v ARIMA/SARIMA modelu

$$
Y_t - Y_{t-1}
$$

#### Sezónní diference
- počítá rozdíl mezi hodnotou a hodnotou o jednu sezónu zpět
- odstraňuje sezónnost
- odpovídá parametru D = 1 v SARIMA modelu

$$
Y_t - Y_{t-s}
$$

