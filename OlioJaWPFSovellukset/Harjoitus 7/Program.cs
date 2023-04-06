using Harjoitus7;
using System;

namespace Harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(1, 6);

            int uusiKerros;
            string lukija;

            Console.WriteLine("tervetuloa hissiin, voit poistua hissistä sanan 'poistu' kirjoittamalla");

            while (true)
            {
                Console.WriteLine();
                Console.Write("anna uusi kerros ({0}) < ", hissi.PalautaMinMax());

                lukija = Console.ReadLine();

                if (lukija.Equals("poistu"))
                    break;

                bool tarkistus = int.TryParse(lukija, out uusiKerros);

                if (tarkistus)
                {
                    hissi.Kerros = uusiKerros;
                }
                else
                {
                    ErrorHelper.KirjoitaError("0003f; virheellinen syöttö, kokeileppa uudelleen.");
                }

                hissi.TulostaNykyinenKerros();
            }

            Console.WriteLine("hissistä poistuttiin");
        }
    }
}
