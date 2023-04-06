using Harjoitus7;
using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus7
{
    class Hissi
    {
        private int kerros;
        private int ekaKerros;
        private int vikaKerros;

        public int Kerros
        {
            set
            {
                if (value < ekaKerros)
                {
                    ErrorHelper.KirjoitaError("0001f; virheellinen kerros annettu, antamasi arvo " + value + " on pienempi kuin " + ekaKerros);
                }
                else if (value > vikaKerros)
                {
                    ErrorHelper.KirjoitaError("0002f; virheellinen kerros annettu, antamasi arvo " + value + " on suurempi kuin " + vikaKerros);
                }
                else
                {
                    kerros = value;
                }
            }
        }

        public Hissi(int _ekaKerros, int _vikaKerros)
        {
            ekaKerros = _ekaKerros;
            vikaKerros = _vikaKerros;
        }

        public void TulostaNykyinenKerros()
        {
            Console.WriteLine("nykyinen kerros on " + kerros);
        }

        public string PalautaMinMax()
        {
            return ekaKerros.ToString() + "-" + vikaKerros.ToString();
        }
    }
}