using System.Data;

namespace Tema_2
{
    internal class Program
    {
        static void Main()
        {
            // Crearea unui obiect de tip Manager si unul de tip Dezvoltator
            Manager manager = new Manager("ManagerulMeu", 5000, 3);
            Dezvoltator dezvoltator = new Dezvoltator("Dezvoltatorulmeu", 4000, "C#");

            //Afisarea informatiilor despre fiecare anagajat si bonusul lor
            AfisareInformatiiAngajat(manager);
            AfisareInformatiiAngajat(dezvoltator);
        }
        //Metoda pentru a afisa informatii despre un angajat si bonusul sau
        public static void AfisareInformatiiAngajat(Angajat angajat)
        {

            Console.WriteLine($"Nume: {angajat.Nume}");
            Console.WriteLine($"Salariu: {angajat.Salariu}");
            Console.WriteLine($"Bonus: {angajat.CalculBonus()}");
            Console.WriteLine();
        }
    }
}
