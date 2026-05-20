## Multimédia a základy počítačové grafiky
- základní principy multimediálních aplikací (obraz, zvuk, video)
- formáty multimediálních souborů, komprese dat
- křivky v počítačové grafice
- uživatelské rozhraní (UI) a návrh interakcí
- schopnost aplikovat znalosti z oblasti zpracování signálu, světla a barev, multimediálního hardwaru, komprese dat, digitální fotografie, záznamu videa a zvuku, kompresních standardů pro multimédia, křivek a ploch, streamování, aplikací pro práci s multimédii a API při navrhování a implementaci multimediálních aplikací
- schopnost pracovat s multimediálními daty (obraz, video, zvuk)
- schopnost analyzovat a optimalizovat multimediální aplikace z hlediska výkonu a kvality

### Multimédia
- kombinace více typů digitálních dat
    - obraz
    - zvuk
    - video

### Multimediální aplikace
- aplikace, která umožňuje multimédia:
    - získávat
    - zpracovávat
    - ukládat
    - přenášet
    - zobrazovat/přehrávat
- mnoho aplikací používá multimediální prvky, ale ne každá aplikace je multimediální aplikace v odborném slova smyslu (např. kalkulačka, správce souborů, terminál, ...)
- aby byla aplikace multimediální, musí být multimédia jejím ústředním prvkem

#### Příklady
- video přehrávač (VLC media player)
- editor fotografií (Adobe Photoshop)
- streamovací platforma (Netflix)
- hra (Minecraft)

### Digitální obraz
- obraz reprezentovaný pomocí pixelů (mřížkou pixelů)

### Pixel
- nejmenší zobrazitelný bod na digitálním obrazu
- obsahuje hodnoty popisující vlastnosti digitálního obrazu v daném bodě
    - barva, jas, průhlednost
- může obsahovat různé typy dat podle formátu nebo barevného modelu

### RGB
- barevný model
- barva je reprezentována kombinací:
    - red
    - green
    - blue

Pixel pak obsahuje trojici hodnot:

$$
(R,G,B)
$$

Např.:

$$
(255,0,0)
$$

= červená

### RGBA
- rozšíření RGB modelu
- obsahuje:
    - red
    - green
    - blue
    - alpha

- alpha určuje průhlednost pixelu

Pixel pak obsahuje čtveřici hodnot:

$$
(R,G,B,A)
$$

Např.:

$$
(255,0,0,128)
$$

= poloprůhledná červená

Použití:
- UI
- efekty
- compositing
- hry

### CMYK
- barevný model používaný hlavně pro tisk
- obsahuje:
    - cyan
    - magenta
    - yellow
    - key (black)

- funguje na principu absorbce světla inkoustem
- čím více barvy, tím tmavší výsledek

Použití:
- tiskárny
- polygrafie
- tiskové materiály

### HSV
- barevný model založený na lidském vnímání barev
- obsahuje:
    - hue (odstín)
    - saturation (sytost)
    - value (jas)

- vhodný pro intuitivní práci s barvami

Použití:
- grafické editory
- výběr barev
- image processing

### YCbCr
- barevný model používaný hlavně pro video a kompresi obrazu
- obsahuje:
    - Y: jasová složka (luminance)
    - Cb: modrá chrominanční složka
    - Cr: červená chrominanční složka

- odděluje jas od barevné informace
- lidské oko je citlivější na jas než na barvu
- umožňuje efektivnější kompresi videa

Použití:
- JPEG
- MPEG
- H.264
- digitální video

### Digitální zvuk
- digitální reprezentace analogového zvukového signálu
- vzniká převodem spojitého zvuku na diskrétní data

Vzniká:
1. samplingem
2. kvantizací

- digitální zvuk je tvořen posloupností vzorků

Použití:
- hudba
- telefonie
- video
- streamování
- hry

### Digitální video
- digitální reprezentace pohyblivého obrazu
- tvořeno sekvencí digitálních snímků (framů)

Video obsahuje:
- obraz
- časovou složku
- často také zvuk

Vlastnosti:
- FPS (frames per second)
- rozlišení
- komprese
- synchronizace obrazu a zvuku

Použití:
- filmy
- streamování
- videokonference
- hry
- sociální sítě

### Warping
### Morphing