using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8
{
    abstract class Henkilö
    {
        public string nimi { get; set; }

        public string työpaikka { get; set; }

        public int palkka { get; set; }

        public int tuntimäärä { get; set; }

        public void Tuntilasku()
        {
            Console.WriteLine("työntekijän tuntimäärä");
            Console.WriteLine(nimi);
            Console.WriteLine(tuntimäärä);

        }

        private static int määrä = 0;
        public Henkilö()
        {
            määrä++;
        }

        public static void Määrä()
        {
            Console.WriteLine("henkilöiden kappalemäärä" + määrä );
        }
    }

}