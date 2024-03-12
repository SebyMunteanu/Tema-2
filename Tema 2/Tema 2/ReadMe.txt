1. Abstractie
   Am folosit o clasa abstracta "Angajat" pentru a reprezenta un angajat generic. Aceasta 
clasa abstracta contine o metoda abstracta "CalculBnous", pe care clasele derivate trebuie
sa o implementeze
   Am definit proprietatile si metodele abstracte pentru a stabilii o interfata comuna 
pentru toate clasele derivate

2. Incapsularea
   Am folosit proprietati private ("nume" si "salariu" in clasa "Angajat") pentru a proteja
datele interne ale clasei ai am oferit acces la aceste date prin intermediul metodelor 
publice ("Nume", "Salariu")

3. Mosterinea
   Am creat clasele derivate("Manager" si "Dezvoltator") care mostenesc caracteristicile 
si comportamentul clasei de baza "Angajat".
   Am extins functionalitatea clasei de baza, adaugand proprietati specifice pentru fiecare
tip de angajat (exemplu: "Nivel" pentru "Manager","LimbajProgramare" pentru "Dezvoltator")

4. Polimorfism
   Am folosit polimorfismul atunci cand am declarat o lista de obiecte de tip "Angajat" si 
am adaugat atat obiecte de tip "Manager", cat si "Dezvoltator" in aceasta lista
   Am apelat metoda "CalculBonus" pe obiectele de tip "Angajat" din lista, iar in timpul 
   executiei, a fost apelata implementarea corespunzatoare din clasele derivate, conform 
   polimorfismului dinamic