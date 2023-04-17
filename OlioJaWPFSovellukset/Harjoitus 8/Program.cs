using Harjoitus8;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        Henkilö t1 = new Työntekijä("ari", "kone", 4200, 4);
        Henkilö t2 = new Työntekijä("teuvo", "neste", 6900, 4);
        pomo p1 = new pomo();
        pomo p2 = new pomo();

        p1.pomolasku();
    }
}