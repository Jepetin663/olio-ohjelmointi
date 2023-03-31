using Harjoitus4;
using Harjoitus4;

internal class Program
{
    private static void Main(string[] args)
    {
        Albumi alb = new Albumi();

        alb.artisti = "DJ Gyrotta Zao";
        alb.nimi = "LARD";
        alb.genre = "Hardstyle";
        alb.hinta = 3;


        alb.KappaleenLis("☣ ZETRAKORE XAOS DA JUMPING GARGOYLZ ☣ مسدسات الطبيعة 1.6");
        alb.KappaleenLis("HelalaBoys[2009.by.RaRMANRiPZz z( 0 _ -@ )....]");
        alb.KappaleenLis("VALERIA BOUNZE");
        alb.KappaleenLis("▯▯▯▯");
        alb.KappaleenLis("卍");
        alb.KappaleenLis("GREEN SUN BRAIN SICK");

        alb.TulostaData();
        alb.MusiikkiTulostus();
    }
}