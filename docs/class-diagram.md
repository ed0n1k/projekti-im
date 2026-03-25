# Dokumentacioni i Sistemit

## Class Diagram

### 1. User
Përfaqëson përdoruesin e sistemit dhe të dhënat e tij kryesore.

| Atributi | Tipi |
| :--- | :--- |
| `id` | int |
| `name` | string |
| `email` | string |

**Metodat:**
* `Register()`: Krijon një llogari të re.
* `Login()`: Autentifikon përdoruesin.

---

### 2. Appointment
Përfaqëson takimet e rezervuara në sistem.

| Atributi | Tipi |
| :--- | :--- |
| `id` | int |
| `date` | DateTime |
| `userId` | int |

**Metodat:**
* `Book()`: Rezervon një orar të ri.
* `Cancel()`: Anulon një rezervim ekzistues.

---

### 3. Relationships
Lidhja midis klasave përcakton hierarkinë e të dhënave:

> **User** `1` --- `*` **Appointment**
> *(Një përdorues mund të ketë shumë takime, por një takim i përket vetëm një përdoruesi).*