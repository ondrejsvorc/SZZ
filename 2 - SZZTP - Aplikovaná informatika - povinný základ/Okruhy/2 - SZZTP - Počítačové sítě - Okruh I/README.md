## Základy počítačových sítí – 1. okruh

1. adresování v počítačových sítích (MAC, IPv4/6, porty TCP/UDP, CIDR, VLSM atp.), počítání subnetů
2. terminologie počítačových sítí (aktivní/pasivní prvky, fyzická/logická topologie, přístupové metody, kódování, modulace, IEEE (802.1, 802.3, 802.11 atp.), komunikace CS/P2P, NAT, MTU, rychlosti datových přenosů, ARP, DNS, DHCP, služby a jejich protokoly (FTP/SSH/RDP/HTTP(s)/SMTP/POP3/IMAP), navazování spojení TCP atp.)
3. vrstvové modely datových sítí (RM ISO/OSI, model TCP/IP, zapouzdření, hlavičky, patičky atp.)
4. základní principy bezdrátových sítí (SSID, PSK, RADIUS, IEEE 802.11a/b/g/n/ac/ad/ax (frekvence, kanály, propustnosti), šifrování atp.)
5. základy bezpečnostních funkcionalit sítě (šifrování, autentizace/autorizace/accounting, VLAN, VPN, kontrola přístupu (L2 security), (NG)FW, prevence ztráty dat, MFA, fyzická bezpečnost atp.)
6. schopnost návrhu počítačové sítě

### MAC
- unikátní fyzická adresa síťového rozhraní používaná pro identifikaci zařízení v lokální síti na 2. vrstvě OSI modelu
- délka 48 bitů (6 bytů)
- patří síťovému rozhraní, ne počítači jako celku
- jeden počítač může mít více síťových rozhraní (=> více MAC adres)
    - Ethernet - první MAC adresa
    - Wi-Fi - druhá MAC adresa
    - Bluetooth - třetí MAC adresa
    - ...
- každé síťové rozhraní má vlastní MAC adresu

#### Příklad
- 00:1A:2B:3C:4D:5E
- každá dvojice (00, 1A, ...) představuje 1 byte (8 bitů)
- celkem 6 dvojic hexadecimálních čísel
- rozdělena na 2 části (24 bitů + 24 bitů)
    - část 1.: výrobce (např. Cisco, Dell, ...) - https://www.wireshark.org/tools/oui-lookup.html
    - část 2.: konkrétní identifikátor síťové rozhraní daného výrobce

### IP
- veřejná
- privátní
- IPv4
- IPv6

### IPv4
- Internet Protocol version 4
- délka 32 bitů (4 oktety)
- zapsaná v desítkové soustavě
- problém: pouze $2^{32}$  = 4 294 967 296 (≈4,3 miliardy) možných adres
    - proto vznikli NAT a IPv6

#### Příklad
- 192.168.1.10
- každý oktet 0-255

#### Privátní IPv4 rozsahy
- nelze si zvolit úplně libovolný rozsah
- lze zvolit pouze takové privátní rozsahy, které jsou definované RFC1918
| Rozsah                        | CIDR |
| ----------------------------- | ---- |
| 10.0.0.0 – 10.255.255.255     | /8   |
| 172.16.0.0 – 172.31.255.255   | /12  |
| 192.168.0.0 – 192.168.255.255 | /16  |

### IPv6
- Internet Protocol version 6
- délka 128 bitů

### Veřejná IP adresa
- globálně unikátní IP adresa routovatelná přes Internet
- na Internetu nesmí existovat dvě stejné veřejné IP adresy
- routery na Internetu musí vědět, kam provoz doručit

### Privátní IP adresa
- IP adresa určená pro komunikaci uvnitř lokálních sítí, která není routovatelná přes veřejný Internet
- může se opakovat v různých nezávislých sítích
- pro přístup do Internetu se typicky překládá pomocí NAT na veřejnou IP adresu

### Router
- musí mít alespoň dvě síťová rozhraní, protože propojuje minimálně dvě různé sítě
- každé rozhraní je připojeno do jiné sítě, má vlastní IP adresu a vlastní MAC adresu
- neposílá pakety uvnitř jedné sítě (to dělá switch)
- principielně:
    1. přijme paket na jednom rozhraní
    2. odešle ho jiným rozhraním

### Výchozí brána
- privátní IP adresa routeru uvnitř lokální sítě
- adresa routeru, kam zařízení posílají provoz mimo svou síť

### Port

### TCP/UDP

### CIDR

### VLSM

### Počítání subnetů

### Aktivní prvek

### Pasivní prvek

### Fyzická topologie

### Logická topologie

### Přístupové metody

### Kódování

### Modulace

### IEEE 802.1
### IEEE 802.3
### IEEE 802.11

### CS/P2P

### NAT

### MTU

### Rychlosti datových přenosů

### ARP

### DNS

### DHCP

### FTP
### SSH
### RDP
### HTTP(s)
### SMTP
### POP3
### IMAP

### ISO/OSI
### TCP/IP

### SSID
### PSK
### RADIUS

### IEEE 802.11a
- frekvence:
- kanály:
- propustnosti:
### IEEE 802.11b
### IEEE 802.11g
### IEEE 802.11n
### IEEE 802.11ac
### IEEE 802.11ad
### IEEE 802.11ax

### Šifrování
### Autentizace
### Autorizace
### Accouting
### VLAN
### VPN
### L2 security
### (NG)FW
### MFA