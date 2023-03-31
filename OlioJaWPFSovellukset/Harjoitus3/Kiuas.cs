using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus3
{
    class Kiuas
    {
        private string nimi { get; set; }
        private bool tila { get; set; }
        private int lämpötila { get; set; }
        private int kosteus { get; set; }

        public Kiuas(string _nimi)
        {
            nimi = _nimi;
            tila = false;
            lämpötila = 10;
            kosteus = 80;
        }

        public void TulostaData()
        {
            Console.WriteLine("kiuas: ");
            Console.WriteLine("nimi: " + nimi);
            Console.WriteLine("tila: " + NäytäTila());
            Console.WriteLine("lämpötila: " + lämpötila + " Celsius");
            Console.WriteLine("kosteus: " + kosteus + "%");
            Console.WriteLine();
        }

        public string NäytäTila()
        {
            string nykyinenTila = "pois päältä";

            if (tila == true)
            {
                nykyinenTila = "päällä";
            }

            return nykyinenTila;
        }

        public void KiuasOnOff(bool t)
        {
            tila = t;

            Console.Write("nyt kiuas on " + NäytäTila() + "\n");
        }

        public void MuutaLämpötilaa(int uusiLämpötila)
        {
            if (tila == false)
            {
                Console.WriteLine("lämpötilan muuttaminen epäonnistui, kiuas ei ole päällä\n");
                return;
            }

            lämpötila = uusiLämpötila;

            if (lämpötila < 21)
            {
                lämpötila = 21;
            }
            else if (lämpötila > 120)
            {
                lämpötila = 120;
            }

            Console.WriteLine("lämpötilaa on muutettu, lämpötila nyt: " + lämpötila + " celsius\n");
        }

        public void MuutaKosteutta(int uusiKosteus)
        {
            if (tila == false)
            {
                Console.WriteLine("kosteuden muuttaminen epäonnistui, kiuas ei ole päällä\n");
                return;
            }

            kosteus = uusiKosteus;

            if (kosteus < 0)
            {
                kosteus = 0;
            }
            else if (kosteus > 120)
            {
                kosteus = 120;
            }
            Console.WriteLine("kosteutta on muutettu, kosteus nyt: " + kosteus + "%\n");
        }
    }
}