## Úvod do relačních databází
- konceptuální návrh: entity, atributy, relační vztahy (pasivně)
- logický návrh: relace 1:1, 1:N, M:N a jejich rozklad, normalizace (1-3 normální forma), E-R diagram (vraní nohy)
- fyzický návrh: příkaz CREATE TABLE, základní domény (číselné, řetězcové, časové), základní omezení (primární a cizí klíče, NOT NULL, UNIQUE)
- manipulace s daty: vkládání INSERT INTO
- dotazy: příkaz SELECT, vnitřní a vnější spojení (FROM [INNER/LEFT/RIGHT] JOIN), selekce (WHERE), projekce (SELECT)
- řazení (ORDER BY)
- seskupování (GROUP BY)

### Užitečné odkazy
- <https://physics.ujep.cz/~jskvor/SZZ/BcAPI/SZZPP/Tahaky/URDB-SQL.pdf> (Povolený tahák)
- <https://www.youtube.com/watch?v=Oxda-LTLTOc> (Vraní nohy - v angličtině)

### 1:1
- vztah typu jedna ku jedné
- jednomu záznamu první entity odpovídá právě jeden záznam druhé entity

### 1:N
### M:N

### 1 NF
### 2 NF
### 3 NF

### Vraní nohy
- anglicky Crow's Foot notation
- notace používaná v ER diagramech pro vyjádření kardinality vztahů mezi entitami

Symboly:
- ○
    - 0
    - záznam je nepovinný
- |
    - 1
    - právě jeden záznam
- < 
    - n
    - více záznamů

Kombinace symbolů:
- ||
    - právě 1
- ○|
    - 0 nebo 1
- |<
    - 1 nebo více
- ○<
    - 0 nebo více


![](Obrázky/crows-notation.png)