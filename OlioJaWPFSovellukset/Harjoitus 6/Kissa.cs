using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_6
{
    internal class Kissa : Eläin
    {
        private static int instanssit = 0;

        public Kissa()
        {
            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("kissoja luotu " + instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("meow");
        }
    }
}
