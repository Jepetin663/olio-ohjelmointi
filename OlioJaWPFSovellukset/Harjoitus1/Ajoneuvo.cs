using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
    internal class Ajoneuvo
    {
        public string nimi;
        public int nopeus;
        public int renkaat;

        public string TulostaData()
        {
            string AjoneuvonTiedot = "nimi: " + nimi + " nopeus: " + nopeus.ToString() + " renkaat: " + renkaat.ToString();

            return AjoneuvonTiedot;
        }
    }
}
