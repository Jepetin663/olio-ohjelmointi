using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8
{
    class pomo : Henkilö
    {
        private static int määrä = 0;

        public pomo()
        {
            määrä++;

        }
        public void pomolasku()
        {
            if (pomo.määrä > 1)
            {
                Console.WriteLine("pomoja voi vain olla yksi!!! " + pomo.määrä);
            }
        }
    }

}