# Startpunt Programmeren Specialisatie - Voorbeeldtest

**Link:** https://classroom.github.com/a/yvjzGKR3

## Opdracht Programmeren Specialisatie

### Voornaam en naam (in hoofdletters): ________________________________________________________________________________

### IOEM: JA / NEE:                     ___

### Algemene richtlijnen

#### Wat is toegelaten en niet toegelaten tijdens het afleggen van de test?

Je gebruik van je Github repository en het eindresultaat dat je indient onder Chamilo tijdens de test geldt als aanwezigheidsregistratie.

Heb je *individuele onderwijs- en examenmaatregelen (IOEM)* maak deze dan *vóór de start van de test* kenbaar aan je lector - zie hierboven.

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
- Google.com, StackOverflow (of gelijkaardig)
- ChatGPT (of gelijkaardig).

Chat-applicaties en email worden uiteraard niet toegelaten (dit valt onder "contact met derden"). Het is ten stelligste verboden source code te bezorgen en te ontvangen aan en van een andere partij dan je lector.

Plagiaat plegen is evenmin toegelaten en dus verboden (weersta bijvoorbeeld de verleiding om broncode te copiëren uit een github project dat niet deel uitmaakt van de cursus).

[IMPORTANT]
====
Het niet volgen van deze regels wordt gesanctioneerd als examenfraude. Je krijgt dan een nul voor de test.
====

Installeer **Docker Desktop bovenop WSL2** en start een **SQLServer container op (Linux)**. Dit doe je **vooraleer de test start**: je kan dit thuis voorbereiden.

### Je startpunt: assemblies

#### Assignment.Console.App

Console applicatie met Generic Host ondersteuning ingebouwd.

#### Assignment.Repository

Bevat onder andere alle EF Core code, liefst geïsoleerd achter een interface (erf over van GenericRepository). Je scaffolded klassen horen hier.

## Test

### Start opname van je desktop met Panopto!

- Ga naar https://hogent.cloud.panopto.eu. Download de Panopto installer: **screenshot 1**.
- Installeer de Panopto recorder: **screenshot 2**.
- Je neemt je webcam en alle schermen op (PowerPoint hoeft niet): **screenshot 3**.
- Bewaar de opname nog een aantal weken lokaal tot je lector aangeeft dat dit niet meer nodig is: **screenshot 4**.
- Na het afronden van je test (zie verder) ga je naar je opname onder Panopto en deel je je opname met je lector: luc.vervoort@hogent.be.

[IMPORTANT]
====
Je opname moet beschikbaar zijn voor je lector: als je opname niet beschikbaar is, wordt je test beschouwd als niet geldig en krijg je een 0 voor de test.
====

### Opdracht

#### Algemeen

1. Gebruik VS2022, .NET 8.
2. Gebruik de git repository die je van de lector toegewezen kreeg via GitHub Classroom voor je opdracht.
3. Een method kan volledig op je scherm getoond worden.
4. Per klasse voorzie je een apart bestand.
5. De namespaces van je klassen komen overeen met je folderstructuur.

#### Specifiek

1. **Importeer het databankmodel** dat je terugvindt in de Database folder van je startoplossing in je SQLServer container (in dit geval: instnwndmssql.sql). Dit model bevat een set testgegevens.
2. Zorg voor gedetailleerde EF Core logging naar VS2022 "Debug" console.
3. Voer een scaffold uit (je start "database first"). Check je oplossing in onder Git eenmaal deze zonder fouten kan gebouwd worden.
4. Na deze allereerste scaffold werk je "code first".
5. Implementeer volgende LINQ queries in de Run() methode van Assignment.cs - check je oplossing in onder Git per query die zonder fouten gebouwd kan worden.

- Geef de contactnaam van alle klanten (customers).
- Geef de contactnaam, firmanaam, contacttitel en telefoonnummer van alle customers en sorteer per telefoonnummer.
- Implementeer in LINQ zonder *change tracking*: SELECT City, CompanyName, ContactName FROM customers WHERE City LIKE 'A%' OR City LIKE 'B%'
- Implementeer in LINQ: SELECT FirstName, LastName FROM employees WHERE ReportsTo IS NULL
- Implementeer in LINQ: SELECT s.SupplierID, p.ProductName, s.CompanyName FROM suppliers s JOIN products p ON s.SupplierID = p.SupplierID WHERE s.CompanyName IN ('Exotic Liquids') ORDER BY s.SupplierID

6. Voeg een leverancier (supplier) toe die als bedrijfsnaam (CompanyName) "HOGENT" heeft.
7. Verwijder klant "WOLZA".
8. Pas de bedrijfsnaam van de zelf toegevoegde leverancier aan van "HOGENT" naar "Stad Gent".
9. Voeg kolom "Email" met type **nvarchar(max)** toe aan tabel ""Customer".
10. Implementeer met GenericRepository de klasse **ProductRepository**.
11. Gebruik ProductRepository om het **product met ID 1** op te halen.
12. Haal alle producten op waarbij in de productnaam de letter "S" voorkomt.
13. **BONUS**: integreer **SeriLog/Seq** logging: voorzie maximale logging ("Verbose").
14. **BONUS**: implementeer **"soft delete"** (logische delete) voor minstens één tabel van je databank maar op een manier die kan werken voor alle tabellen van je oplossing, zonder LINQ queries aan te passen.
15. **BONUS**: implementeer 5 unit testen met **Codiumate onder Visual Studio Code**.

### Inlevering oplossing

. Verwijder de *bin* en *obj* directories en *zip* je code tot een bestand met naam *PS_<naam>_<voornaam>_<jaar>_<maand>_<dag>_<counter>.zip*.
. lever je zip-bestand op onder de bijhorende opdracht in je Chamilo-cursus.
. Beëindig de opname van je desktop met Panopto en deel je opname met je lector.

## BELANGRIJK
1. Dien in onder je *git repository* die je toegewezen kreeg voor de opdracht.
2. Dien in onder de bijhorende **opdracht in je Chamilo-cursus**, als zipped bestand zonder obj en bin directories.
3. Deel je *Panopto-opname* van je desktop tijdens het afleggen van de test met je lector.

Als je oplossing niet beschikbaar is onder één van deze vormen, krijg je een 0 voor deze test!

== Veel succes!


