1. Përshkrimi i shkurtër i projektit

Ky projekt është një aplikacion Barbershop Management System i ndërtuar si console app në C#.
Qëllimi i tij është të menaxhojë shërbimet e berberit (services) si prerje flokësh, rruajtje, etj.

Përdoruesit kryesorë:

Berberi (admin)
Stafi i barbershop-it

Funksionaliteti kryesor:

Listimi i shërbimeve
Shtimi i shërbimeve të reja
Kërkimi sipas ID
Përditësimi i shërbimeve
Fshirja e shërbimeve

Të dhënat ruhen në një file CSV përmes Repository Pattern.

2. Çka funksionon mirë?
✅ Arkitektura është e ndarë në shtresa (Models, Services, Data, UI)
✅ CRUD operacionet funksionojnë (Create, Read, Update, Delete)
✅ Repository Pattern është implementuar dhe ndan logjikën nga data access
✅ Programi ekzekutohet nga menu dhe ka flow të qartë për user-in
3. Dobësitë e projektit
❌ Nuk ka validim të fortë të input-it (p.sh. mund të futet tekst në vend të numrit)
❌ Error handling është shumë bazik (vetëm try-catch i përgjithshëm)
❌ UI është shumë i thjeshtë (console, jo user-friendly)
❌ Nuk ka testime (unit tests mungojnë totalisht)
❌ Përdorimi i CSV si storage nuk është shumë i sigurt dhe nuk është scalable
❌ Nuk ka kontroll për ID unike (mund të ketë duplikate)
❌ Emërtimet në disa vende nuk janë konsistente (Service vs BarberService)
❌ Nuk ka logging (gabimet nuk ruhen askund)
❌ Nuk ka validim për vlera negative (price, duration)
4. 3 përmirësime që do t’i implementoj
🔹 Përmirësimi 1: Validimi i input-it

Problemi:
User mund të fusë input të gabuar (string në vend të number, vlera negative)

Zgjidhja:
Do të shtoj validim në Service layer:

Name ≠ empty
Price > 0
Duration > 0

Pse ka rëndësi:
Parandalon crash dhe ruan integritetin e të dhënave

🔹 Përmirësimi 2: Përmirësim i error handling

Problemi:
Gabimet kapen vetëm me try-catch të përgjithshëm

Zgjidhja:
Do të përdor:

try-catch specifik (FormatException, NullException)
mesazhe më të qarta për user

Pse ka rëndësi:
E bën aplikacionin më stabil dhe më të kuptueshëm për përdoruesin

🔹 Përmirësimi 3: Kontroll për ID unike

Problemi:
ID gjenerohet random → mund të ketë duplikate

Zgjidhja:

Kontroll në Repository që ID të mos ekzistojë
OSE
Auto-increment ID

Pse ka rëndësi:
Shmang konflikte në të dhëna dhe rrit besueshmërinë e sistemit

5. Një pjesë që ende nuk e kuptoj plotësisht

Një pjesë që ende nuk e kuptoj plotësisht është implementimi i plotë i Dependency Injection dhe si përdoret në projekte më të mëdha (sidomos në ASP.NET).

Gjithashtu, dua të kuptoj më mirë:

si të kaloj nga file CSV në database (p.sh. SQL)
si të organizoj projektin për aplikacione më të mëdha me shumë module