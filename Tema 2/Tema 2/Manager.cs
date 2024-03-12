using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public class Manager : Angajat
    {
        //Proprietate specifica pentru manager
        public int Nivel { get; set; }

        //Constructor pentru initializarea numelui,salariul si nivelul
        public Manager(string nume, double salariu, int nivel) : base(nume, salariu)
        {
            Nivel = nivel;
        }
        //Implementarea metodei abstracte pentru calculul banusului
        public override double CalculBonus()
        {
            return Salariu = 0.2 + Nivel * 100;
        }

    }
}
