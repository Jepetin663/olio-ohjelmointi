using Harjoitus_6;

internal class Program
{
    private static void Main(string[] args)
    {
        Eläin.KuinkaMonta();

        Koira koir = new Koira();
        koir.Ääntele();

        Kissa kiss = new Kissa();
        kiss.Ääntele();

        Eläin.KuinkaMonta();
Harjoitus 7
        Koira koir2 = new Koira();
        Koira koir3 = new Koira();
        Koira kiss2 = new Koira();

        Koira.KuinkaMonta();
        Kissa.KuinkaMonta();
        Eläin.KuinkaMonta();
    }
}