using Harjoitus10;
using System;

namespace Harjoitus_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Kala ahven = new Kala("ahven", 50, "blop");

            ahven.MakeASound();
            ahven.Swim();

            Sorsa sorsa = new Sorsa("sorsa", 90, 10);

            sorsa.MakeASound();
            sorsa.Fly();
            sorsa.MakeASound();
            sorsa.Swim();
        }
    }
}
