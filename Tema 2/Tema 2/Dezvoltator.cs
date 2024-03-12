using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2
{
    public class Dezvoltator:Angajat
    {
        //Proprietate specifica pentru dezvoltator
        public string LimbajProgramare { get; set; }

        //Constructor pentru initializarea numelui, salariul si limbajul de programare
        public Dezvoltator(string nume,double salariu,string limbajProgramare):base(nume,salariu)
        {
            LimbajProgramare = limbajProgramare;
        }

        //Implementatea metodei abstracte pentru calculul bonusului
        public override double CalculBonus()
        {
            return Salariu * 0.1;
        }
    }
}
