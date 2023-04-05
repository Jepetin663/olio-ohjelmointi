using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_5
{
    internal class Laskin
    {
        public static float summa(float a, float b) 
        { 
            return a + b; 
        }

        public static float erotus(float a, float b) 
        { 
            return a - b; 
        }

        public static float kertolasku(float a, float b)
        {
            return a * b;
        }

        public static float jakolasku(float a, float b)
        {
            return a / b;
        }
    }
}
