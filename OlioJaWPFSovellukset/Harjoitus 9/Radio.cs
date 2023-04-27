using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_9
{
    internal class Radio
    {
        private bool Tila { get; set; }


        public void Kytkin()
        {
            Console.WriteLine("Kytke radio päälle painamalla p ");
            string tarkistus = Console.ReadLine();

            if (tarkistus == null)
            {
                Console.WriteLine("Virhe joudut käynnistämään radion uudestaan!");
            }
            else if (tarkistus == "p")
            {
                Tila = true;
                Console.WriteLine("Radio on kytketty päälle");
            }
            else
            {
                Console.WriteLine("Virhe joudut käynnistämään radion uudestaan!");
            }
        }

        public string TaajuusYksikkö = "MHz";

        private readonly double Minimitaajuus = 88.0f;
        private readonly double Maksimitaajuus = 107.9f;

        private double taajuus;
        public double Taajuus
        {
            get { return taajuus; }
            set
            {
                if (value > Maksimitaajuus)
                {
                    value = Maksimitaajuus;
                }
                else if (value < Minimitaajuus)
                {
                    value = Minimitaajuus;
                }
                taajuus = value;
            }
        }

        private readonly int MaxÄäni = 9;
        private readonly int MinÄäni = 0;

        private int ääni;

        public int Ääni
        {
            get { return ääni; }
            set
            {
                if (value < MinÄäni)
                {
                    value = MinÄäni;
                }
                else if (value > MaxÄäni)
                {
                    value = MaxÄäni;
                }
            }
        }

        public void Ääni1()
        {
            Console.WriteLine("Syötä äänen voimakkuus 0-9 väliltä.");
            int Äänicheck = int.Parse(Console.ReadLine());
            Ääni = Äänicheck;
            if (Äänicheck < MinÄäni)
            {
                Console.WriteLine("Syöttämäsi äänenvoimakkuus alittaa minimi äänenvoimakkuuden arvoksi asetettu : " + MinÄäni.ToString());
            }
            else if (Äänicheck > MaxÄäni)
            {
                Console.WriteLine("Syöttämäsi äänenvoimakkuus ylittää maksimi äänenvoimakkuuden arvoksi asetettu : " + MaxÄäni.ToString());
            }
        }
        public void Taajuus1()
        {
            Console.WriteLine("Syötä taajuus 88,0 - 107,9 väliltä");
            double Taajuuscheck = double.Parse(Console.ReadLine());
            Taajuus = Taajuuscheck;
            if (Taajuuscheck < Minimitaajuus)
            {
                Console.WriteLine("Syöttämäsi taajuus oli pienenpi kuin minimi taajuus joten taajuudeksi asetettu : " + Minimitaajuus.ToString()
                    + " " + TaajuusYksikkö);
            }
            else if (Taajuuscheck > Maksimitaajuus)
            {
                Console.WriteLine("Syöttämäsi taajuus oli isompi kuin maksimi taajuus joten taajuudeksi asetettu : " + Maksimitaajuus.ToString()
                    + " " + TaajuusYksikkö);
            }

        }

        private string tark;

        public string Tark
        {
            get { return tark; }
            set { tark = value; }
        }
    }
}