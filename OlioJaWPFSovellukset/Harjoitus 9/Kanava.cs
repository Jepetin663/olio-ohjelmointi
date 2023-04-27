using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtävä9
{
    internal class Kanava
    {
        private string Nimi { get; set; }
        static double Taajuus1 { get; set; }

        public void kanava(string _nimi, double _taajuus)
        {
            Nimi = _nimi;
            Taajuus1 = _taajuus;
        }

        public double TaajuusP = Taajuus1;

    }
}