using ScrumTehtävä1;

internal class Program
{
    private static void Main(string[] args)
    {
        Ajoneuvo Ajo = new Ajoneuvo();

        Ajo.valmistaja = "BMW";
        Ajo.iskutilavuus = 1750;
        Ajo.istuimet = 4;

        Console.WriteLine(Ajo.TulostaData());


    }
}