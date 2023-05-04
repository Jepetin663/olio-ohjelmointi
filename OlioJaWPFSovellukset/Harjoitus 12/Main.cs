using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_12
{
    internal class Main
    {
        public static void Maini(string[] args)
        {
            Pelialusta pelialusta1 = new Pelialusta();
            pelialusta1.Sekoita();
            for (int i = 0; i < 52; i++)
            {
                Console.Write("(0,-19)", pelialusta1.DiilaaKortti());
                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}