using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    internal class Koira : Eläin
    {
        private static int instanssit = 0;

        public Koira()
        {
            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("koiria luotu " + instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("woof");
        }

    }
}
