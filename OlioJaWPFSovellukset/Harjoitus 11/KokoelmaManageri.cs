using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_11
{
    static class KokoelmaManageri
    {
        public static Dictionary<string, Opiskelija> Opiskelijat = new Dictionary<string, Opiskelija>();

        public static void LisääOpiskelija(string etunimi, string sukunimi)
        {
            bool sallittu = false;
            string opiskelijaID = "";

            while (!sallittu)
            {
                try
                {
                    Console.Write("opiskelija_id: ");
                    opiskelijaID = Console.ReadLine();

                    sallittu = TarkistaID(opiskelijaID);

                }
                catch (OpiskelijaPoikkeus)
                {
                 
                }
            }

            if (sallittu)
            {
                Opiskelijat.Add(opiskelijaID, new Opiskelija(etunimi, sukunimi, opiskelijaID));
                TulostaViesti(string.Format("uusi opiskelija {0} kokoelmassa", Opiskelijat[opiskelijaID].HaeData()));
            }
        }

        public static bool TarkistaID(string id)
        {
            if (Opiskelijat.ContainsKey(id))
            {
                throw new OpiskelijaPoikkeus("opiskelija_id " + id + " ei ole uniikki, anna uusi ID");
            }
            else if (id.Length <= 4 || id.Length >= 6)
            {
                throw new OpiskelijaPoikkeus("opiskelija_id " + id + " on liian pitkä tai lyhyt, id:n pituus tulee olla tasan 5");
            }
            else
            {
                return true;
            }
        }
        public static void PoistaOpiskelija(int syötettyIndex)
        {
            int i = 0;

            foreach (string avain in Opiskelijat.Keys)
            {
                if (i == syötettyIndex)
                {
                    TulostaViesti("opiskelija " + Opiskelijat[avain].HaeData() + " kokoelmasta poistettu");
                    Opiskelijat.Remove(avain);
                    break;
                }

                i++;
            }
        }
        public static void TulostaKokoelma()
        {
            if (Opiskelijat.Count == 0)
            {
                TulostaViesti("Opiskelija kokoelma on tyhjä");
                return;
            }

            int i = 1;

            TulostaViesti("opiskelijat kokoelmassa: ");

            foreach (Opiskelija opiskelija in Opiskelijat.Values)
            {
                Console.WriteLine("{0}: {1}", i, opiskelija.HaeData());
                i++;
            }
        }
        public static void TulostaViesti(string message)
        {
            Console.WriteLine();
            Console.WriteLine("-----------");
            Console.WriteLine(message);
        }
    }
}