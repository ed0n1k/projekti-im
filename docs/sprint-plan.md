🧩 Gjendja Aktuale
✔️ Çka funksionon tani?
Regjistrimi i përdoruesve (User model)
Menaxhimi i shërbimeve (Service model)
Krijimi i termineve (Appointment)
Leximi dhe ruajtja e të dhënave në CSV (FileRepository)
Struktura me shtresa (Models, Services, Data, UI)
Menu bazike në UI për ndërveprim me userin
❌ Çka nuk funksionon?
Nuk ka validim të input-it (mund të futen të dhëna gabim)
Nuk ka kontroll për termine të dyfishta (overlapping bookings)
Error handling është minimal (programi mund të crashojë)
Nuk ka funksionalitet kërkimi/filterimi
Nuk ka autentikim (login/logout)
⚙️ A kompajlohet dhe ekzekutohet programi?
Po ✅
🚀 Plani i Sprintit
🆕 Feature e Re (çka do të ndërtosh)
Kërkimi i termineve sipas emrit të klientit
Useri shkruan emrin dhe sistemi shfaq të gjitha terminet për atë klient
Do të implementohet në BookingService
Do të shtohet opsion i ri në menu (UI)

👉 Bonus ide (nëse don me e përmend):

Filtrim sipas datës ose shërbimit
🛡️ Error Handling (çka do të shtosh)
Problemet aktuale:
Input i gabuar (p.sh. string në vend të numrit)
Data në format të gabuar
File CSV nuk ekziston ose nuk lexohet
Zgjidhjet:
Validimi i input-it
Përdor TryParse() për numra dhe data
Kontrolli i gabimeve me try-catch
Rreth leximit/shkrimit në file
Mesazhe user-friendly
Në vend të crash, shfaq mesazh si:
“Ju lutem vendosni të dhëna valide”
🧪 Teste (çka do të testosh)
Metodat që do të testohen:
AddAppointment()
GetAll()
GetById()
Feature i ri (SearchAppointments)
Raste kufitare (edge cases):
Shtimi i një termini me data të njëjtë
Kërkim për emër që nuk ekziston
Input bosh ose null
File bosh ose pa të dhëna