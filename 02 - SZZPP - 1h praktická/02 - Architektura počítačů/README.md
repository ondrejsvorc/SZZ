## Architektura počítačů

### Okruh I (výběr komponent počítače)
- základní principy fungování počítače a jeho komponent (procesor, základní deska, paměť RAM, grafická karta, úložiště, napájecí zdroj atd.)
- kompatibilita komponent a jejich výběr dle zadaného rozpočtu a požadavků
- principy instalace operačního systému a ovladačů
- nastavení BIOSu a optimalizace výkonu počítače
- základní znalosti práce s počítačem a periferními zařízeními

### Okruh II (diagnostika a řešení problémů)
- základní principy fungování počítače a jeho komponent (procesor, základní deska, paměť RAM, grafická karta, úložiště, napájecí zdroj atd.)
- běžné problémy s hardwarem a jejich příčiny
- diagnostické nástroje a jejich použití
- postupy řešení běžných problémů s hardwarem
- upgrade komponent hardwaru
- kompatibilita komponent
- identifikace a diagnostika závad hardwaru
- použití diagnostických nástrojů
- řešení běžných problémů s hardwarem
- provádění upgradu komponent hardwaru

## Okruh I

### Užitečné odkazy
- https://www.itnetwork.cz/hardware-pc/stavba-pc

### Procesor
- CPU = Central Processing Unit
- hlavní řídicí jednotka počítače
- vykonává strojové instrukce programů
- koorduje tok dat mezi ostatními komponentami (RAM, disk, grafika)
- ovlivňuje celkový výkon systému
- CPU obsahuje jádra, jádra obsluhují vlákna
- CPU má alespoň 1 jádro, každé jádro má alespoň 1 vlákno
- procesor přímo určuje jaký typ RAM umí používat
    - protože řadič paměti je dnes přímo v procesoru
    - CPU ↔ RAM komunikují přímo
- CPU ↔ GPU též komunikují přímo

### Základní parametry procesoru
- počet jader (cores)
    - dnes minimum: 4 jádra / 8 vláken
    - poměr cena/výkon: 6 jader / 12 vláken
    - vyšší třída: 8 jader / 16 vláken
    - workstation: 12+ jader
- počet vláken (threads)
- frekvence
    - nízká: ~3,0 GHz a méně
    - normální: ~3,5–4,5 GHz
    - vysoká: ~5,0 GHz a více
- cache paměť
- TDP
    - nízké: 35–65 W
    - střední: 65–125 W
    - vysoké: 125–250+ W

#### Jádro
- fyzická výpočetní jednotka uvnitř procesoru
- samostatně vykonává instrukce
- má vlastní:
    - aritmeticko-logickou jednotku
    - registry
    - cache
    - řídící logiku
- prakticky 1 jádro = „malý procesor“ uvnitř CPU
- např. 6jádrový procesor obsahuje 6 fyzických jader

#### Vlákno
- nejmenší jednotka práce, kterou procesor vykonává
- posloupnost instrukcí určených ke zpracování CPU
- operační systém přiděluje vlákna jednotlivým jádrům procesoru
- prakticky: program běží jako jedno nebo více vláken
- každé vlákno vykonává vlastní část práce
- např. webový prohlížeč:
  - jedno vlákno vykresluje stránku
  - jiné přehrává video
  - další komunikuje po síti

#### Proč může mít jádro více vláken
- díky technologiím:
    - Intel Hyper-Threading
    - AMD SMT (Simultaneous Multithreading)
- jedno fyzické jádro se operačnímu systému tváří jako více logických procesorů
- např. 6 jader / 12 vláken (každé jádro obsluhuje 2 vlákna)

#### Frekvence
- rychlost, jakou procesor vykonává operace
- říká, kolik taktů proběhne za sekundu
- udává se v GHz (gigahertz)
- např.: 3,5 GHz ≈ 3,5 miliardy taktů za sekundu
- obecně vyšší frekvence = vyšší výkon

#### Takt
- základní synchronizační impulz procesoru
- určuje rytmus, podle kterého CPU koordinuje své operace

#### Cache procesoru
- existují L1/L2/L3 cache
- slouží k dočasnému ukládání často používaných dat a instrukcí
- jsou fyzicky přímo v CPU
- má velmi nízkou latenci
- má jednotky až desítky MB
- CPU potřebuje data - nejdřív je hledá v cache, až pak v RAM

#### L1 cache
- nejrychlejší a nejmenší cache přímo u jednotlivých jader procesoru

#### L2 cache
- větší a pomalejší než L1

#### L3 cache
- největší a sdílená mezi jádry
- pomalejší než L1/L2, ale stále mnohem rychlejší než RAM

#### TDP
- Thermal Design Power
- údaj o množství tepla, které musí chlazení procesoru odvést
- udává tepelnou zátěž při běžném provozu
- udává se ve wattech (W)
- např. TDP = 65 W = chladič musí zvládnout odvést přibližně 65 W tepla
- dle TDP vybíráme chladič, zdroj, airflow skříně

### Základní deska
- hlavní propojující komponenta počítače
- spojuje všechny části:
    - CPU
    - RAM
    - GPU
    - disky
    - zdroj
    - periférie
- zajišťuje komunikaci a napájení komponent
- určuje:
    - kompatibilitu procesoru
    - typ RAM
    - možnosti rozšíření
    - počet disků
    - počet USB portů

#### Socket
- fyzický konektor pro procesor
- obsahuje elektrické kontakty mezi CPU a deskou
- přes socket CPU komunikuje s deskou, dostává napájení a přenáší data
- určuje kompatibilitu mezi CPU a základní deskou
- procesor musí mít stejný socket jako deska
- Intel: sockety se mění častěji
- AMD: sockety bývají podporované déle

#### Intel sockety
- LGA1151 - Intel 6.–9. generace (DDR3/DDR4)
- LGA1200 - Intel 10.–11. generace (DDR4)
- LGA1700 - Intel 12.–14. generace (DDR4/DDR5)
- LGA1851 (DDR5)

#### AMD sockety
- AM4 - Ryzen 1000–5000 (DDR4)
- AM5 - Ryzen 7000+ (DDR5)

#### LGA
- Land Grid Array
- piny jsou v základní desce
- používá Intel

#### PGA
- Pin Grid Array
- piny jsou na procesoru
- starší AMD (AM4), moderní AMD už přešlo na LGA (AM5)

#### BGA
- CPU je připájený napevno
- notebooky, mini PC

#### Kontrola kompatibility mezi CPU a základní deskou
1. Vybereme CPU
2. Zjistíme socket CPU
3. Vybereme desku se stejným socketem
- např. vybereme procesor Ryzen 5 7600 se socketem AM5, tak musíme vybrat AM5 desku
- nejlepší je se podívat do CPU support listu výrobce desky

#### Čipset
- určuje možnosti a výbavu základní desky
- zajišťuje komunikaci mezi procesorem a ostatními zařízeními
- ovlivňuje počet USB portů, počet M.2 / SATA disků, počet PCIe linek, ...

#### Intel čipsety
- Intel H610 - levný základ
- Intel B660 / B760 - mainstream
- Intel Z690 / Z790 - high-end, overclocking

#### AMD čipsety
- AMD A620 - základ
- AMD B650 - mainstream
- AMD X670 - high-end

#### Formát
- fyzická velikost a rozložení základní desky
- určuje:
    - rozměry desky
    - počet slotů
    - možnosti rozšíření
    - kompatibilitu se skříní
- ATX (standardní velká velikost, gaming/workstation)
- Micro-ATX (střední velikost, běžný desktop)
- Mini-ITX (malé skříně)
- formát desky musí být kompatibilní s velikostí skříně, délkou GPU a velikostí chladiče

#### PCIe
- PCI Express
- vysokorychlostní sběrnice pro připojení komponent k základní desce
- přenáší data mezi CPU, čipsetem a připojenými zařízeními
- dlouhý slot (typicky grafická karta)
- krátké sloty (rozšiřující karty)
- má tzv. linky (čím více linek, tím vyšší propustnost)
- x1 (1 linka), x4 (4 linky), x8 (8 linek), x16 (16 linek)
- GPU typicky PCIe x16
- NVMe SSD typicky PCIe x4
- generace PCIe 3.0, PCIe 4.0, PCIe 5.0 (čím vyšší generace, tím rychlejší)
- generace jsou zpětně kompatibilní (PCIe 4.0 GPU funguje v PCIe 3.0 slotu, ale s nižší rychlostí)

#### Sloty na RAM
- základní deska obsahuje RAM sloty (DIMM)
- typicky 2-4 sloty

### Skříň
- určuje:
    - jaký formát zdroje podporuje
    - maximální podporovanou délku GPU
    - podporovaný formát základní desky
    - maximální podporovanou výšku chladiče CPU
    - počet ventilátorů
    - pozice ventilátorů
    - přední konektory
- typy:
    - Full Tower
    - Mid Tower (nejběžnější)
    - Mini Tower

#### Přední ventilátory
- nasávají studený vzduch dovnitř

#### Zadní/horní ventilátory
- odvádí teplý vzduch ven

### Paměť RAM
- RAM = Random Access Memory
- operační paměť počítače
- slouží k dočasnému ukládání dat a programů, se kterými CPU právě pracuje
- velmi rychlá, ale volatilní paměť
- když spustíme program:
    1. program se načte z disku (SSD/HDD) do RAM
    2. CPU si z RAM načítá potřebná data a instrukce
    3. často používaná data si CPU ukládá do své cache paměti
    4. CPU nad těmito daty provádí výpočty
- při nedostatku RAM (stránkovací soubor na SSD)
- 8 GB, 16 GB, 32 GB, 64 GB
- např. 32 GB (2×16 GB) DDR5-6000 CL30

#### Frekvence
- rychlost přenosu dat
- udává se v MHz
- např.: DDR4-3200, DDR5-6000 (vyšší frekvence, vyšší propustnost)

#### CL
- latence
- časová prodleva paměti
- např.: CL16, CLC30 (nižší latence, rychlejší odezva)
- číslo u CL znamená počet taktů (CL16 = RAM potřebuje 16 taktů než začne vracet požadovaná data po obdržení požadavku od CPU)

#### Dual Channel
- podporuje používání RAM v párech
- např. 2×8 GB místo 1×16 GB je lepší
- CPU může komunikovat s více moduly RAM paralelně (vyšší výkon)

### Typy RAM
- CPU + deska musí DDR podporovat
- DDR4
- DDR5

### Grafická karta
- GPU = Graphics Processing Unit
- komponenta určená pro zpracování grafiky a paralelních výpočtů
- vykresluje obraz pro monitor
- bývá největší spotřebitel energie v PC
- připojuje se do PCIe x16 slotu
- silnější GPU potřebují externí PCIe power konektory ze zdroje (např. 8-pin, 12VHPWR)

#### Integrovaná grafická karta
- zkratka iGPU
- součást procesoru
- sdílí RAM s CPU

#### Dedikovaná grafická karta
- samostatná komponenta v PCIe slotu
- má vlastní:
    - GPU čip
    - VRAM
    - chlazení
    - napájení

#### VRAM
- video paměť grafické karty
- je přímo na GPU
- ukládá grafická data
- 4 GB (základ), 8 GB (gaming), 12-16 GB (high end), 24+ GB (AI/workstation)

#### NVIDIA grafické karty
- RTX 4060
- RTX 4070
- RTX 4080

#### AMD grafické karty
- RX 7600
- RX 7800 XT

### Uložiště
- slouží k dlouhodobému ukládání dat
- data zůstávají zachována i po vypnutí počítače

#### Typy uložišť
- HDD
- SSD
    - SATA SSD
    - NVMe SSD
- M.2
- kapacity disku většinou tak 250 GB, 500 GB, 1 TB, 2+ TB, ...

#### HDD
- Hard Disk Drive
- mechanický disk s rotujícími plotnami
- nízká cena za GB, vysoké kapacity, ale pomalý, hlučný, vyšší latence
- smysluplné použití: archivace

#### SSD
- Solid State Drive
- bez pohyblivých částí
- velmi rychlé, tiché, nízká latence, ale dražší než HDD
- standard pro systémový disk

#### SATA SSD
- používá SATA rozhraní
- omezená rychlost (~550 MB/s)

#### NVMe SSD
- používá PCIe
- výrazně vyšší rychlosti (několik GB/s)

#### M.2
- fyzický formát SSD
- může být SATA M.2 nebo NVMe M.2

#### TBW
- Total Bytes Written
- odhadovaná životnost SSD
- kolik dat lze zapsat během životnosti disku

#### Kompatibilita
- SATA vs NVMe podpora
- počet M.2 slotů na desce
- PCIe generace
- fyzický formát

### Napájecí zdroj
- PSU = Power Supply Unit
- převádí elektrickou energii ze zásuvky na napětí potřebná pro komponenty počítače
- ze zásuvky přichází přichází střídavý proud (AC) a on ho převádí na stejnosměrný proud (DC)
- komponenty pak 
- výkon se udává ve wattech (W) (např. 550 W, 750 W, 1000 W)
- zdroj musí zvládnout maximální spotřebu celé sestavy

#### Certifikace účinnosti
- 80 PLUS
    - Bronze
    - Silver
    - Gold
    - Platinum
- vyšší účinnost, méně ztrát, méně tepla, nižší spotřeba

#### Důležité konektory
- 24-pin ATX (základní deska)
- EPS 8-pin (CPU napájení)
- PCIe power (GPU)
- SATA power (SSD/HDD)

#### Formáty
- ATX (standardní desktop)
- SFX (malé PC)

### Instalace OS

### Instalace ovladačů

### Nastavení BIOSu