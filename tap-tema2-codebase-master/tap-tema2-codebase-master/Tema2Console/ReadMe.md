# README

## Aplicarea Principiilor SOLID în Codul HotelReception

### Single Responsibility Principle (SRP)
- **Unde este aplicat:** 
    - Clasele `FileHandler` și `OrderSerializer` sunt responsabile fiecare pentru o singură operație: citirea din fișier și serializarea/deserializarea obiectelor.
    - Clasa `HotelReception` este responsabilă doar pentru procesarea comenzilor.
- **Ce face:**
    - Fiecare clasă îndeplinește o singură responsabilitate, ceea ce face codul mai ușor de înțeles, de întreținut și de testat.

### Open/Closed Principle (OCP)
- **Unde este aplicat:** 
    - Interfața `IOrderProcessor` și cele trei clase care o implementează (`RoomOrderProcessor`, `ProductOrderProcessor`, `BreakfastOrderProcessor`) respectă OCP.
- **Ce face:**
    - Clasa `HotelReception` este deschisă pentru extensie prin adăugarea de noi tipuri de procesare a comenzilor (prin implementarea interfeței `IOrderProcessor`), dar închisă pentru modificare, deoarece nu necesită modificări atunci când adăugăm noi tipuri de procesare a comenzilor.

### Liskov Substitution Principle (LSP)
- **Unde este aplicat:** 
    - Cele trei clase care implementează interfața `IOrderProcessor` (`RoomOrderProcessor`, `ProductOrderProcessor`, `BreakfastOrderProcessor`) respectă LSP.
- **Ce face:**
    - Aceste clase pot fi înlocuite unele cu altele fără a afecta comportamentul sistemului, ceea ce permite flexibilitate și extensibilitate.

### Interface Segregation Principle (ISP)
- **Unde este aplicat:** 
    - Interfața `IOrderProcessor` este mică și specifică, având o singură metodă `ProcessOrder`.
- **Ce face:**
    - Interfața este decuplată și specifică, astfel încât clasele care o implementează nu sunt obligate să implementeze metode pe care nu le folosesc.

### Dependency Inversion Principle (DIP)
- **Unde este aplicat:** 
    - Clasa `HotelReception` depinde de abstracția `IOrderProcessor`, nu de clasele concrete care o implementează.
- **Ce face:**
    - Aceasta inversare a dependențelor permite clasei `HotelReception` să fie mai flexibilă și mai ușor de testat, deoarece nu este legată de implementările concrete ale procesorilor de comenzi.
