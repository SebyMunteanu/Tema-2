using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public abstract class Angajat
    {
        // Proprietati private pentru incapsulare
        private string nume;
        private double salariu;

        // Constructor pentru initializarea numelui si salariul
        public Angajat(string nume, double salariu)
        {
            this.nume = nume;
            this.salariu = salariu;
        }

        // Proprietati pentru a obtine sau seta numele si salariul - incapsulare
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public double Salariu
        {
            get { return salariu; }
            set { salariu = value; }
        }

        // Metoda abstracta pentru a calcula bonusul
        public abstract double CalculBonus();
    }
}
