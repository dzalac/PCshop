## UVID U PROJEKT

## Projektna dokumentacija
* RAZVOJNI PRISTUP - Odabrali vodopadni model
* PROJEKTNI PLAN - OK. Posebno pohvalno što je usklađen s odabranim modelom.
* PONUDA - Moguće doraditi jer se cijena temelji isključivo na cijeni rada a ne uključuje druge elemente cijene koštanja.
Projektna dokumentacija je vrlo kvalitetna i bez obzira na potrebu dorade ponude zaslužuje maksimalne bodove.

## Tehnička dokumentacija
* SRS - Molim tehničku dokumentaciju započeti sa sažetim raspisom funkcionalnih i nefunkcionalnih zahtjeva. Popis FZ već imate u prijavi. NFZ treba razraditi. Pogledajte SRS predloške. Nakon tog raspisa može slijediti detaljni raspis koji sada imate i koji je dobro strukturiran. 
* USE CASE - Ponovno razmislite o aktorima u sustavu. Ako navedete actora "Baza podataka" onda to znači da postoji dio funkcionalnosti koje taj aktor izvodi samostalno/autonomno. Ako to ne postoji, onda BP nije actor. Također, veza između Registriranog korisnika i njegovih slučajeva korištenja nije ispravno definirana. Ako imate dva UC-a od koji jedan proširuje drugoga, onda veza ne treba biti povučena na proširenje jer se podrazumijeva da se proširenje provodi uz glavni UC. Kod vas je to suprotno napravljeno.
* UML - U AD-u ste često koristili čvor odluke i spajanja u istom simbolu. Molim vas da to izmijenite. Svakoj odluci mora prethoditi aktivnost odluke, te mora biti jasno navedeno što se bira, te koji su smjerovi odabira to jest odgovori na pitanje. Čvorovi spajanja mogu ostati. Prvi dijagram, dijagram slijeda, je usiljen. Ne postoji zahtjev koji koji se odnosi na dijagrame i koji morate ispuniti, ali bilo bi dobro kada bi ste kroz vaše funkcionalnosti pronašli mjesta gdje vam je korisno koristiti dijagram aktivnosti, dijagram slijeda, dijagram stanja, dijagram komponenata/paketa/isporuke kako bi kroz vaš projekt prošli što više koncepata koje smo učili. 
* KLASE - Čini se kako je ovo prva verzija dijagrama te još dosta klasa nedostaje. Pokušajte paralelno sa razvojem ažurirati i dijagram klasa.
* ERA - Model podataka se također ne čini dovršenim. Molio bih da u podatke ugradite temporalnu komponentu. To znači da se ne smiju promijeniti postojeće/otpremljene narudže nakon što se promijeni cijena artikla.

## Implementacija
Najslabija karika projekta je verzioniranje koda. Molim vas da verzije više ne dodajete opcijom "add files via upload". Isto tako, na vašem projektu nije dobro složen .gitignore dokument, što će vam raditi probleme tijekom cijelog razvoja (ako ga naravno ne popravite). 
Kako još niste odabrali pristup u radu s podacima molim vas da to čim prije napravite i onda povežete do sada kreirane korisničke kontrole na vaš programski kod. 

## Ostalo
Korisničku dokumentaciju možete, a i ne morate pripremati kroz wiki. Sviđa mi se pristup u kojem dokumentaciju u obliku wikija razvijate paralelno s projektom, a na kraju ju samo pretvorite u unutaraplikacijsku pomoć (npr. chm dokument koji se otvara na odgovarajuću temu pomoću F1). 

Mislim da ste dobro započeli s vašim projektom. Malo implementacija kasni ali ja sam sukrivac za to. Stoga, idemo to zajedno stisnuti i dovršiti. Samo hrabro dalje s projektom i pitajte na mail što vam nije jasno.

## Bodovi
P1: 13 bodova


---


## Nakon dorade
Predloženi programski proizvod i projektna ideja su u skladu sa zahtjevima kolegija. Impelementacijom konačnog seta funkcionalnosti studenti će moći postići sve definirane ishode učenja na kolegiju. Molio bih samo da arhitektura bude temeljena na centraliziranoj bazi podataka na koju će se spajati jedna ili više aplikacija istovremeno. Ovo treba promatrati kao aspekt u programskom proizvodu kako se ne bi dogodilo da se npr. izda više računa sa istim brojem ili da se ne proda isti proizvod više puta.

## Status prijave 
Prihvaćeno

---


## Opća povratna informacija
Iz projektne prijave nije jasno je li tim planirao razvijati ASP.Net web aplikaciju ili stolnu aplikaciju koja simulira web trgovinu?
Također, u popisu tehnologija su pobrojani samo alati, ali ne i tehnologije pa ni pomoću popisa tehnologija se ne može utvrditi koja je namjera i koji programski jezik tim želi koristiti?

## Status prijave
Nije odlučeno
