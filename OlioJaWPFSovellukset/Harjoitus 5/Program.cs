using Harjoitus_5;

internal class Program
{
    private static void Main(string[] args)
    {
        float a = 5.0f;
        float b = 5.0f;

        float summa = Laskin.summa(a, b);
        float erotus = Laskin.erotus(a, b);
        float kertolasku = Laskin.kertolasku(a, b);
        float jakolasku = Laskin.jakolasku(a, b);

        Console.WriteLine("numeroiden {0} ja {1}:", a, b);
        Console.WriteLine("summa: " + summa);
        Console.WriteLine("erotus: " + erotus);
        Console.WriteLine("kertolasku: " + kertolasku);
        Console.WriteLine("jakolasku: " + jakolasku);
    }
}