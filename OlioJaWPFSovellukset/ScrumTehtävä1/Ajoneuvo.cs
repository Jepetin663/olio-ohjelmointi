using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumTehtävä1
{
    internal class Ajoneuvo
    {
        public string valmistaja;
        public int iskutilavuus;
        public int istuimet;

        public string TulostaData()
        {
            string AjoneuvonTiedot = " ajoneuvon valmistaja: " + valmistaja + " moottorin iskutilavuus: " + iskutilavuus.ToString() + " istuintenn määrä: " + istuimet.ToString();

            return AjoneuvonTiedot;
        }
    }
}
