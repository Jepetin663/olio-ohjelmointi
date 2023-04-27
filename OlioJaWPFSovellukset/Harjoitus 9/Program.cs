using Harjoitus_9;
using tehtävä9;

internal class Program
{
    private static void Main(string[] args)
    {
        Radio radio = new Radio();
        radio.Kytkin();
        radio.Taajuus1();
        radio.Ääni1();

        Kanava kanava1 = new Kanava();
        kanava1.kanava("Moi", 88.2f);

        if (radio.Taajuus == kanava1.TaajuusP)
        {
            Console.WriteLine("Toimii");
        }
        while (true)
        {
            Console.WriteLine("Syötä 'v' muuttaaksesi äänenvoimakkuutta, syötä 't' muuttaakksesi taajuutta, syötä 'c' katsoaksesi millä kanavalla olet, syötä 'p' sulkeaksesi radio.");
            string tark = "";
            tark = Console.ReadLine();
            if (tark == "v")
            {
                radio.Ääni1();
            }
            else if (tark == "t")
            {
                radio.Taajuus1();
            }
            else if (tark == "p")
            {
                Console.WriteLine("Poistuit radiosta.");
                break;
            }
            else if (tark == "c")
            {

            }
            else
            {
                Console.WriteLine("Syötit väärän kirjaimen");
                continue;
            }

        }


        if (radio.Taajuus == kanava1.TaajuusP)
        {
            Console.WriteLine("Toimii");
        }
    }
}p