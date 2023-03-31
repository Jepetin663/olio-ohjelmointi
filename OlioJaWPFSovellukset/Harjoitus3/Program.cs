using System;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas ks = new Kiuas("harvia");

            ks.TulostaData();

            ks.MuutaLämpötilaa(70);

            ks.KiuasOnOff(true);
            ks.MuutaLämpötilaa(120);
            ks.MuutaKosteutta(70);

            ks.TulostaData();

            ks.KiuasOnOff(true);
        }
    }
}