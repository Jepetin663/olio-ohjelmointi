using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8
{
    class Työntekijä : Henkilö
    {

        public Työntekijä(string _nimi, string _työpaikka, int _palkka, int tunnit)
        {
            nimi = _nimi;

            työpaikka = _työpaikka;

            palkka = _palkka;

            tuntimäärä = tunnit;


        }

        public void Tuntilasku()
        {
            Console.WriteLine("työntekijän tuntimäärä");
            Console.WriteLine(nimi);
            Console.WriteLine(tuntimäärä);

        }
    }
}