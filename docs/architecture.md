# Architecture

## Layers

### Models
Përfaqësojnë strukturën e të dhënave si User, Appointment, Service.

### Services
Përmbajnë logjikën e biznesit si rezervimet dhe validimet.

### Data
Menaxhon ruajtjen e të dhënave përmes Repository Pattern.

### UI
Ndërfaqja e përdoruesit (console/web).

## Decisions

- U përdor Repository Pattern për ndarje të logjikës dhe të dhënave
- CSV u përdor për thjeshtësi
- Struktura me shtresa për mirëmbajtje më të lehtë


## SOLID

- Single Responsibility Principle:
Çdo klasë ka një përgjegjësi (User, BookingService, Repository)

- Dependency Inversion:
Services varen nga interface IRepository, jo implementimi konkret