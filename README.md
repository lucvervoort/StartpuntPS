# StartpuntPS

https://classroom.github.com/a/yvjzGKR3

## Opdracht Programmeren Specialisatie

### Voornaam en naam (in hoofdletters): ________________________________________________________________________________

### IOEM: JA / NEE (doorkruis wat fout is en omcirkel wat juist is): ___________________________________________________

### Algemene richtlijnen

#### Wat is toegelaten en niet toegelaten tijdens het afleggen van de test?

Je gebruik van je github repository en het eindresultaat dat je indient onder Chamilo tijdens de test geldt als aanwezigheidsregistratie.

Heb je *individuele onderwijs- en examenmaatregelen (IOEM)* maak deze dan *vóór de start van de test* kenbaar aan je lector.

Tijdens de test mag je **niet communiceren met je medestudenten of met derden**, noch online, noch offline, tenzij met je lector. Mobiele telefoons, smartwatches, enzovoort, moeten uitgeschakeld zijn (niet op stil, vliegtuigstand). Je mag ze ook niet gebruiken om de tijd te raadplegen. 

Als je met een Windows emulator werkt, dan switch je niet naar je hoofd-OS (vb. Windows 11 onder MacOS). Je neemt straks met Panopto het hele scherm op.

Op je laptop moeten alle voor de test niet noodzakelijke programma's uitgeschakeld zijn; zijn met andere woorden toegelaten:

- Docker Desktop met SQLServer
- Visual Studio 2022 of Visual Studio Code of Rider (je moet kiezen)
- SSMS
- een browser
- Acrobat Reader.

Via het netwerk mag je raadplegen:

- Chamilo
- StackOverflow (of gelijkaardig)
- ChatGPT (of gelijkaardig)

Chat-applicaties en email worden uiteraard niet toegelaten (dit valt onder "contact met derden"). Het is ten stelligste verboden source code te bezorgen aan een andere partij dan je lector.

[IMPORTANT]
====
Het niet volgen van deze regels wordt gesanctioneerd als examenfraude. Je krijgt dan een nul voor de test.
====

## Test

### Start opname van je desktop met Panopto!

Ga naar https://hogent.cloud.panopto.eu. Download de Panopto installer:

image::./Image-090324-041700.507.png[]

Installeer de Panopto recorder:

image::./Image-090324-041730.430.png[]

Je neemt je webcam en alle schermen op (PowerPoint hoeft niet):

image::./Image-090324-043803.751.png[]

Bewaar de opname nog een aantal weken lokaal tot je lector aangeeft dat dit niet meer nodig is:

image::./Image-090324-042212.330.png[]

Na het afronden van je test (zie verder) ga je naar je opname onder Panopto en deel je je opname met je lector: luc.vervoort@hogent.be.

[IMPORTANT]
====
Je opname moet beschikbaar zijn voor je lector: als je opname niet beschikbaar is, wordt je test beschouwd als niet geldig en krijg je een nul voor de test.
====

1. Installeer Docker Desktop bovenop WSL2 en start een SQLServer container op (Linux)

2. Importeer het databankmodel dat je terugvindt in de Database folder van je startoplossing in je SQLServer container

Dit model bevat een beperkte set testgegevens.

3. Je startoplossing

3.1. Assignment.Console.App

Console applicatie met Generic Host ondersteuning ingebouwd.

3.2. Assignment.Repository

Bevat onder andere alle EF Core code, geïsoleerd achter een interface.

Je scaffolded klassen horen hier.

4. Instructies

. Gebruik VS2022, .NET 8.
. Gebuik de git repository die je van de lector toegewezen kreeg via GitHub Classroom voor je opdracht.
. Een method kan volledig op je scherm getoond worden.
. Per klasse voorzie je een apart bestand.
. De namespaces van je klassen komen overeen met je folderstructuur.
. Zorg voor gedetailleerde EF Core logging naar VS2022 "Debug" console.
. Voer een scaffold uit (je start "database first").
. Na deze allereerste scaffold werk je "code first".
. Implementeer de vragen van set 1 als methods op de domeinlaag - toon de antwoorden minstens op de console die geïntegreerd werd in het hoofdvenster van je WPF applicatie ... of bijvoorbeeld in een DataGrid op een afzonderlijke tab.
. Pas volgende klassen aan en voer een migratie op je databank uit ("code first"):
- Employee: Name -> FirstName + LastName, BirthDate
- Shop: VAT number
- Package: Price (decimal 8,2)
. Implementeer "soft delete" voor alle tabellen van je databank
. Implementeer de vragen van set 2 als methods op de domeinlaag - toon de antwoorden op de console die geïntegreerd werd in het hoofdvenster van je WPF applicatie ... of bijvoorbeeld in een DataGrid op een afzonderlijke tab.
. Optioneel: integreer SeriLog/Seq logging.

5. Inlevering oplossing

. Verwijder de *bin* en *obj* directories en *zip* je code tot een bestand met naam *PS_<naam>_<voornaam>_<jaar>_<maand>_<dag>_<counter>.zip*.
. Dump je uiteindelijke databank als leesbare .sql in een bestand en breng dit bestand onder bij je "solution", onder folder "Database".
. lever je zip-bestand op onder de bijhorende opdracht in je Chamilo-cursus.
. Beëindig de opname van je desktop met Panopto en deel je opname met je lector.

[IMPORTANT]
====
1. Dien in onder je *git repository* die je toegewezen kreeg voor de opdracht.
2. Dien in onder de bijhorende **opdracht in je Chamilo-cursus**, als zipped bestand zonder obj en bin directories.
3. Deel je *Panopto-opname* van je desktop tijdens het afleggen van de test met je lector.

Als je oplossing niet beschikbaar is onder één van deze vormen, krijg je een nul voor deze test!
====

5. In tijdsnood?

. Breng zeker eerst de basis in orde.
. Implementeer telkens minder vragen, maar wel van elke stap minstens een enkele vraag.

[NOTE]
====
Veel succes!
====

## 7. Zet EF Core tracking af voor
## 8. BONUS: pas een object aan dat al in de databank zit, maar nog niet opgevraagd werd via EF Core
## 9. BONUS: voorzie repositories voor je klassen
## 10. Voer volgende migratie uit
## 11. Implementeer volgende queries in je Program.cs via je repositories na scaffolding en voor migratie
## 12. Voer volgende queries uit in je Program.cs via je repositories na migratie
## 13. Start met je github project
## 14. Check in onder je github project per vraag
## 15. Laad alles op naar Chamilo

