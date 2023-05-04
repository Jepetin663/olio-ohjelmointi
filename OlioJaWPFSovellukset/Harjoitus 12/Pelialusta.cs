using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_12
{
    internal class Pelialusta
    {
        public Kortit[] pelialusta;
        public int kyseinenKortti;
        public const int KORTTIEN_MAARA = 52;
        public Random ranNumero;

        public Pelialusta()
        {
            string[] numerot = { "Ässä", "Kaksi", "Kolme", "Neljä", "Viisi", "Kuusi", "Seitsemän",
            "Kahdeksan", "Yhdeksän", "Kymmenen", "Jätka", "Kuningatar", "Kuningas"};
            string[] maa = { "Hertta", "Risti", "Ruutu", "Pata" };
            pelialusta = new Kortit[KORTTIEN_MAARA];
            kyseinenKortti = 0;
            ranNumero = new Random();
            for (int laske = 0; laske < numerot.Length; laske++) pelialusta[laske] = new Kortit(numerot[laske % 11], maa[laske / 13]);
        }

        public void Sekoita()
        {
            kyseinenKortti = 0;
            for (int first = 0; first < pelialusta.Length; first++)
            {
                int second = ranNumero.Next(KORTTIEN_MAARA);
                Kortit vara = pelialusta[first];
                pelialusta[first] = pelialusta[second];
                pelialusta[second] = vara;
            }

        }

        public Kortit DiilaaKortti()
        {
            if (kyseinenKortti < pelialusta.Length)
                return pelialusta[kyseinenKortti++];
            else
                return null;
        }
    }
}