## Operační systémy
- základní struktura souborového systému OS Linux a příkazy pro práci se soubory a adresáři
(mkdir, cp, mv, rm, ls, find apod.)
- problematika práv v OS Linux a řízení procesů
- kolony a textové nástroje (cat, cut, tr, sort, grep apod.)
- jednoduché skripty (proměnné, cykly, podmínky)

### Užitečné odkazy
- <https://github.com/ondrejsvorc/UJEP/tree/main/1.%20year/OPS> (vypracované BASH skripty)

### man
- `man` (manual)
- slouží k zobrazení dokumentace příkazů v Linuxu

```bash
man [příkaz]
```
```bash
man ls
```

#### Navigace v manuálu
| Klávesa | Význam |
|---|---|
| `q` | ukončení |
| `/text` | hledání textu |
| `n` | další nalezený výskyt |
| `PgUp` / `PgDown` | pohyb |
| šipky | pohyb |

### Rychlá nápověda
- mnoho příkazů podporuje parametr `--help`
- alternativa k `man`

```bash
[příkaz] --help
```
```bash
ls --help
```

### pwd
- `pwd` (print working directory)
- vypíše aktuální pracovní adresář (v rámci terminálu/skriptu)

```bash
pwd
```

### ls
- `ls` (list)
- vypíše obsah konkrétního adresáře

```bash
ls [parametry] [adresář]
```

#### Výpis obsahu pracovního adresáře
```bash
ls
```

#### Výpis obsahu konkrétního adresáře

```bash
ls documents
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-l` | detailní výpis |
| `-a` | zobrazí skryté soubory |
| `-h` | čitelné velikosti souborů |
| `-R` | rekurzivní výpis |
| `-t` | řazení podle času |
| `-r` | obrácené pořadí |

### cd
- `cd` (change directory)
- slouží ke změně aktuálního pracovního adresáře

```bash
cd [adresář]
```

#### Přechod do adresáře
```bash
cd documents
```

#### Přechod o úroveň výš
```bash
cd ..
```

#### Přechod do domovského adresáře
```bash
cd ~
```

#### Přechod do absolutní cesty
```bash
cd /home/ondra/projects
```

#### Přechod do předchozího adresáře
```bash
cd -
```

#### Speciální symboly
| Symbol | Význam |
|---|---|
| `.` | aktuální adresář |
| `..` | nadřazený adresář |
| `~` | domovský adresář |

### mkdir
- `mkdir` (make directory)
- slouží k vytvoření nového adresáře

```bash
mkdir [adresář]
```

#### Vytvoření jednoho adresáře
```bash
mkdir documents
```

#### Vytvoření více adresářů
```bash
mkdir images videos backups
```

#### Vytvoření včetně nadřazených adresářů
```bash
mkdir -p projects/python/app
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-p` | vytvoří i chybějící nadřazené adresáře |

### cp
- `cp` (copy)
- slouží ke kopírování souborů a adresářů

```bash
cp [zdroj] [cíl]
```

#### Kopírování souboru
```bash
cp file.txt backup.txt
```

#### Kopírování do adresáře
```bash
cp file.txt documents/
```

#### Kopírování více souborů
```bash
cp file1.txt file2.txt backups/
```

#### Rekurzivní kopírování adresáře
```bash
cp -r projects backups/
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-r` | rekurzivní kopírování adresářů |
| `-i` | potvrzení před přepsáním |
| `-v` | verbose režim |
| `-u` | kopíruje pouze novější soubory |

### mv
- `mv` (move)
- slouží k přesouvání a přejmenování souborů a adresářů

```bash
mv [zdroj] [cíl]
```

#### Přesunutí souboru
```bash
mv file.txt documents/
```

#### Přejmenování souboru
```bash
mv old.txt new.txt
```

#### Přesunutí více souborů
```bash
mv file1.txt file2.txt backups/
```

#### Přesunutí adresáře
```bash
mv projects/ backups/
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-i` | potvrzení před přepsáním |
| `-v` | verbose režim |
| `-n` | nepřepisuje existující soubory |

### rm
- `rm` (remove)
- slouží k odstranění souborů a adresářů

```bash
rm [soubor]
```

#### Odstranění souboru
```bash
rm file.txt
```

#### Odstranění více souborů
```bash
rm file1.txt file2.txt
```

#### Rekurzivní odstranění adresáře
```bash
rm -r projects/
```

#### Vynucené odstranění
```bash
rm -f file.txt
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-r` | rekurzivní odstranění adresářů |
| `-f` | vynucené odstranění |
| `-i` | potvrzení před odstraněním |
| `-v` | verbose režim |

### find
- `find`
- slouží k vyhledávání souborů a adresářů

```bash
find [cesta] [podmínka]
```

#### Vyhledání podle názvu
```bash
find . -name "*.txt"
```

#### Vyhledání adresářů
```bash
find . -type d
```

#### Vyhledání souborů
```bash
find . -type f
```

#### Vyhledání podle velikosti
```bash
find . -size +10M
```

#### Vyhledání podle názvu bez ohledu na velikost písmen
```bash
find . -iname "*.jpg"
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-name` | hledání podle názvu |
| `-iname` | hledání bez ohledu na velikost písmen |
| `-type f` | pouze soubory |
| `-type d` | pouze adresáře |
| `-size` | hledání podle velikosti |
| `-empty` | prázdné soubory/adresáře |

### cat
- `cat` (concatenate)
- slouží k výpisu a spojování obsahu souborů

```bash
cat [soubor]
```

#### Výpis obsahu souboru
```bash
cat file.txt
```

#### Výpis více souborů
```bash
cat file1.txt file2.txt
```

#### Spojení souborů do nového souboru
```bash
cat file1.txt file2.txt > output.txt
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-n` | číslování řádků |
| `-b` | číslování neprázdných řádků |

### grep
- `grep` (global regular expression print)
- slouží k vyhledávání textu v souborech nebo výstupu příkazů

```bash
grep [vzor] [soubor]
```

#### Vyhledání textu
```bash
grep "error" log.txt
```

#### Vyhledání bez ohledu na velikost písmen
```bash
grep -i "error" log.txt
```

#### Rekurzivní vyhledávání
```bash
grep -r "TODO" .
```

#### Počet nalezených řádků
```bash
grep -c "error" log.txt
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-i` | ignoruje velikost písmen |
| `-r` | rekurzivní vyhledávání |
| `-n` | zobrazí čísla řádků |
| `-c` | počet nalezených řádků |
| `-v` | invertuje výsledek |

### cut
- `cut`
- slouží k výběru částí řádků nebo sloupců textu

```bash
cut [parametry] [soubor]
```

#### Výběr znaků
```bash
cut -c 1-5 file.txt
```

#### Výběr sloupců podle oddělovače
```bash
cut -d ":" -f 1 /etc/passwd
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-c` | výběr znaků |
| `-d` | oddělovač |
| `-f` | číslo sloupce |

### tr
- `tr` (translate)
- slouží k nahrazování nebo odstraňování znaků

```bash
tr [znaky] [znaky]
```

#### Převod na malá písmena
```bash
echo "HELLO" | tr 'A-Z' 'a-z'
```

#### Odstranění znaků
```bash
echo "hello123" | tr -d '0-9'
```

#### Nahrazení znaků
```bash
echo "a,b,c" | tr ',' ';'
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-d` | odstranění znaků |
| `-s` | sloučení opakujících se znaků |

### sort
- `sort`
- slouží k řazení řádků textu

```bash
sort [soubor]
```

#### Seřazení souboru
```bash
sort names.txt
```

#### Reverzní řazení
```bash
sort -r names.txt
```

#### Numerické řazení
```bash
sort -n numbers.txt
```

#### Odstranění duplicit
```bash
sort -u names.txt
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-r` | obrácené pořadí |
| `-n` | numerické řazení |
| `-u` | odstranění duplicit |

### uniq
- `uniq`
- slouží k odstranění duplicitních řádků

```bash
uniq [soubor]
```

#### Odstranění duplicit
```bash
uniq names.txt
```

#### Počet výskytů řádků
```bash
uniq -c names.txt
```

#### Pouze duplicitní řádky
```bash
uniq -d names.txt
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-c` | počet výskytů |
| `-d` | pouze duplicitní řádky |
| `-u` | pouze unikátní řádky |

### wc
- `wc` (word count)
- slouží k počítání řádků, slov a znaků

```bash
wc [soubor]
```

#### Počet řádků
```bash
wc -l file.txt
```

#### Počet slov
```bash
wc -w file.txt
```

#### Počet znaků
```bash
wc -c file.txt
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-l` | počet řádků |
| `-w` | počet slov |
| `-c` | počet znaků |
| `-m` | počet znaků (Unicode) |

### ps
- `ps` (process status)
- slouží k výpisu běžících procesů

```bash
ps [parametry]
```

#### Výpis procesů aktuálního shellu
```bash
ps
```

#### Výpis všech procesů
```bash
ps aux
```

#### Výpis konkrétního procesu
```bash
ps -p 1234
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `a` | procesy všech uživatelů |
| `u` | detailní informace |
| `x` | procesy bez terminálu |
| `-p` | konkrétní PID |

### top
- `top`
- slouží k interaktivnímu sledování běžících procesů

```bash
top
```

#### Ukončení programu
```text
q
```

#### Důležité informace
| Sloupec | Význam |
|---|---|
| `PID` | ID procesu |
| `%CPU` | využití CPU |
| `%MEM` | využití paměti |
| `USER` | vlastník procesu |
| `COMMAND` | spuštěný příkaz |

### kill
- `kill`
- slouží k ukončení procesu pomocí PID

```bash
kill [PID]
```

#### Ukončení procesu
```bash
kill 1234
```

#### Vynucené ukončení procesu
```bash
kill -9 1234
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-9` | SIGKILL |
| `-15` | SIGTERM |
| `-l` | seznam signálů |

### jobs
- `jobs`
- slouží k výpisu úloh spuštěných na pozadí

```bash
jobs
```

#### Výpis běžících úloh
```bash
jobs
```

#### Význam výstupu
| Symbol | Význam |
|---|---|
| `[1]` | číslo úlohy |
| `Running` | běží |
| `Stopped` | pozastaveno |

### bg
- `bg` (background)
- slouží k pokračování pozastavené úlohy na pozadí

```bash
bg [job]
```

#### Pokračování poslední úlohy
```bash
bg
```

#### Pokračování konkrétní úlohy
```bash
bg %1
```

### fg
- `fg` (foreground)
- slouží k přesunutí úlohy do popředí

```bash
fg [job]
```

#### Přesunutí poslední úlohy
```bash
fg
```

#### Přesunutí konkrétní úlohy
```bash
fg %1
```

### cron
- `cron`
- slouží k automatickému plánování a spouštění úloh

```bash
crontab [parametry]
```

#### Úprava cron úloh
```bash
crontab -e
```

#### Výpis cron úloh
```bash
crontab -l
```

#### Odstranění cron úloh
```bash
crontab -r
```

#### Formát cron výrazu
```text
* * * * * příkaz
- - - - -
| | | | |
| | | | +--- den v týdnu (0-7)
| | | +----- měsíc (1-12)
| | +------- den v měsíci (1-31)
| +--------- hodina (0-23)
+----------- minuta (0-59)
```

#### Každý den ve 3:00
```text
0 3 * * * /home/ondra/backup.sh
```

#### Každých 5 minut
```text
*/5 * * * * /home/ondra/script.sh
```

#### Každé pondělí v 8:00
```text
0 8 * * 1 /home/ondra/report.sh
```

#### Důležité parametry
| Parametr | Význam |
|---|---|
| `-e` | editace cron úloh |
| `-l` | výpis cron úloh |
| `-r` | odstranění cron úloh |

### Linux práva
- slouží k řízení přístupu k souborům a adresářům
- práva jsou rozdělena pro:
    - vlastníka (user)
    - skupinu (group)
    - ostatní (others)

#### Typy práv

| Právo | Význam |
|---|---|
| `r` | read |
| `w` | write |
| `x` | execute |

#### Výpis práv

```bash
ls -l
```

Příklad výstupu:

```text
-rwxr-xr-- 1 ondra users 120 file.sh
```

#### Význam jednotlivých částí

```text
-rwxr-xr--
```

| Část | Význam |
|---|---|
| `-` | typ souboru |
| `rwx` | práva vlastníka |
| `r-x` | práva skupiny |
| `r--` | práva ostatních |

#### Typy souborů

| Symbol | Význam |
|---|---|
| `-` | běžný soubor |
| `d` | adresář |
| `l` | symbolický odkaz |

#### Změna práv pomocí chmod

```bash
chmod [práva] [soubor]
```

#### Přidání práva pro spuštění

```bash
chmod +x script.sh
```

#### Odebrání práva zápisu

```bash
chmod -w file.txt
```

#### Numerická práva

| Hodnota | Práva |
|---|---|
| `7` | `rwx` |
| `6` | `rw-` |
| `5` | `r-x` |
| `4` | `r--` |

#### Nastavení práv numericky

```bash
chmod 755 script.sh
```

Význam:

```text
755
```

| Číslo | Význam |
|---|---|
| `7` | vlastník = `rwx` |
| `5` | skupina = `r-x` |
| `5` | ostatní = `r-x` |

#### Změna vlastníka

```bash
chown ondra file.txt
```

#### Změna skupiny

```bash
chgrp developers file.txt
```

### Řízení procesů
- proces = běžící program
- každý proces má vlastní PID (Process ID)
- Linux umožňuje procesy:
    - zobrazovat
    - ukončovat
    - pozastavovat
    - spouštět na pozadí

#### Výpis procesů

```bash
ps
```

#### Výpis všech procesů

```bash
ps aux
```

#### Interaktivní sledování procesů

```bash
top
```

#### Ukončení procesu pomocí PID

```bash
kill 1234
```

#### Vynucené ukončení procesu

```bash
kill -9 1234
```

#### Spuštění procesu na pozadí

```bash
python app.py &
```

#### Výpis úloh spuštěných na pozadí

```bash
jobs
```

#### Přesunutí úlohy na pozadí

```bash
bg %1
```

#### Přesunutí úlohy do popředí

```bash
fg %1
```

#### Pozastavení procesu

```text
Ctrl + Z
```

#### Ukončení procesu v terminálu

```text
Ctrl + C
```

#### Důležité signály

| Signál | Význam |
|---|---|
| `SIGTERM` | standardní ukončení |
| `SIGKILL` | vynucené ukončení |
| `SIGSTOP` | pozastavení procesu |
| `SIGCONT` | pokračování procesu |

#### Důležité pojmy

| Pojem | Význam |
|---|---|
| `PID` | Process ID |
| foreground | proces běžící v popředí |
| background | proces běžící na pozadí |

### Proměnná
- slouží k ukládání hodnot
- hodnotu proměnné čteme pomocí `$`

#### Vytvoření proměnné

```bash
name="Ondra"
```

#### Výpis proměnné

```bash
echo "$name"
```

#### Číselná proměnná

```bash
age=20
```

#### Použití více proměnných

```bash
first_name="Ondra"
last_name="Svorc"

echo "$first_name $last_name"
```

#### Práce s čísly

```bash
count=5

count=$((count + 1))

echo "$count"
```

#### Načtení vstupu od uživatele

```bash
read name

echo "$name"
```

#### Konstantní proměnná

```bash
readonly PI=3.14
```

#### Export proměnné

```bash
export PATH="$PATH:/custom/path"
```

#### Důležité poznámky

- při přiřazení se nepoužívá `$`

Správně:

```bash
name="Ondra"
```

Špatně:

```bash
$name="Ondra"
```

- mezery kolem `=` nejsou povolené

Správně:

```bash
name="Ondra"
```

Špatně:

```bash
name = "Ondra"
```

- proměnné je vhodné uzavírat do uvozovek

Správně:

```bash
echo "$name"
```

### Podmínka
- `if` = pokud
- `elif` = jinak pokud
- `else` = jinak
- `fi` = ukončení podmínky
- mezery kolem `[ ]` jsou povinné

#### Operátory pro porovnávání čísel

| Operátor | Význam |
|---|---|
| `-eq` | equal |
| `-ne` | not equal |
| `-gt` | greater than |
| `-lt` | lower than |
| `-ge` | greater or equal |
| `-le` | lower or equal |

#### Operátory pro porovnávání řetězců

| Operátor | Význam |
|---|---|
| `=` | equal |
| `!=` | not equal |
| `-z` | empty string |
| `-n` | non-empty string |

#### Logické operátory

| Operátor | Význam |
|---|---|
| `&&` | AND |
| `||` | OR |
| `!` | NOT |

#### Obecná syntaxe

```bash
if [ podmínka_1 ]; then
    # kód pokud platí podmínka_1

elif [ podmínka_2 ]; then
    # kód pokud platí podmínka_2

else
    # kód pokud neplatí žádná podmínka

fi
```

#### Porovnávání čísel

```bash
age=20

if [ "$age" -ge 18 ]; then
    echo "Adult"
else
    echo "Minor"
fi
```

#### Více větví

```bash
score=75

if [ "$score" -ge 90 ]; then
    echo "Grade A"

elif [ "$score" -ge 70 ]; then
    echo "Grade B"

elif [ "$score" -ge 50 ]; then
    echo "Grade C"

else
    echo "Failed"

fi
```

#### Porovnávání řetězců

```bash
name="Ondra"

if [ "$name" = "Ondra" ]; then
    echo "Hello Ondra"
else
    echo "Unknown user"
fi
```

#### Prázdný string

```bash
text=""

if [ -z "$text" ]; then
    echo "Empty string"
fi
```

#### Neprázdný string

```bash
text="hello"

if [ -n "$text" ]; then
    echo "String contains text"
fi
```

#### Logický AND

```bash
age=25

if [ "$age" -ge 18 ] && [ "$age" -le 65 ]; then
    echo "Working age"
fi
```

#### Logický OR

```bash
role="admin"

if [ "$role" = "admin" ] || [ "$role" = "moderator" ]; then
    echo "Access granted"
fi
```

#### Negace

```bash
file="data.txt"

if ! [ -f "$file" ]; then
    echo "File does not exist"
fi
```

#### Kontrola existence souboru

```bash
if [ -f "notes.txt" ]; then
    echo "File exists"
fi
```

#### Kontrola existence adresáře

```bash
if [ -d "documents" ]; then
    echo "Directory exists"
fi
```

#### Důležité poznámky

Správně:

```bash
[ "$age" -ge 18 ]
```

Špatně:

```bash
["$age" -ge 18]
```

Správně:

```bash
if [ "$name" = "Ondra" ]; then
```

Špatně:

```bash
if [ "$name" -eq "Ondra" ]; then
```

### Cyklus
- slouží k opakovanému vykonávání příkazů
- nejčastější typy:
    - `for`
    - `while`

#### Cyklus for

```bash
for proměnná in hodnoty; do
    příkazy
done
```

#### Iterace přes seznam hodnot

```bash
for name in Ondra Petr Jan; do
    echo "$name"
done
```

#### Iterace přes soubory

```bash
for file in *.txt; do
    echo "$file"
done
```

#### Iterace přes číselný rozsah

```bash
for i in {1..5}; do
    echo "$i"
done
```

#### Cyklus while

```bash
while [ podmínka ]; do
    příkazy
done
```

#### Počítání od 1 do 5

```bash
count=1

while [ "$count" -le 5 ]; do
    echo "$count"
    count=$((count + 1))
done
```

#### Nekonečný cyklus

```bash
while true; do
    echo "running"
done
```

#### Ukončení cyklu pomocí break

```bash
for i in {1..10}; do
    if [ "$i" -eq 5 ]; then
        break
    fi

    echo "$i"
done
```

#### Přeskočení iterace pomocí continue

```bash
for i in {1..5}; do
    if [ "$i" -eq 3 ]; then
        continue
    fi

    echo "$i"
done
```

### Funkce
- slouží k opakovanému použití skupiny příkazů
- mohou přijímat argumenty
- zlepšují přehlednost skriptů

#### Definice funkce

```bash
function pozdrav() {
    echo "Hello"
}
```

#### Alternativní syntaxe

```bash
pozdrav() {
    echo "Hello"
}
```

#### Volání funkce

```bash
pozdrav
```

#### Funkce s argumenty

```bash
pozdrav() {
    echo "Hello $1"
}

pozdrav Ondra
```

#### Argumenty funkce

| Argument | Význam |
|---|---|
| `$1` | první argument |
| `$2` | druhý argument |
| `$#` | počet argumentů |
| `$@` | všechny argumenty |

#### Funkce s návratovou hodnotou

```bash
is_adult() {
    if [ "$1" -ge 18 ]; then
        return 0
    else
        return 1
    fi
}
```

#### Kontrola návratové hodnoty

```bash
is_adult 20

if [ $? -eq 0 ]; then
    echo "Adult"
fi
```

#### Lokální proměnná

```bash
show_name() {
    local name="Ondra"
    echo "$name"
}
```

### Volání skriptu
```bash
./script.sh
```

### Volání skriptu s argumenty
```bash
./script.sh hello world
```
```bash
echo "$1" # hello
echo "$2" # world
```