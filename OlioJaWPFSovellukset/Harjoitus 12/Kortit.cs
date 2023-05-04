using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_12
{
    internal class Kortit
    {
        public string numero;
        public string maa;

        public Kortit(string korttiNumero, string korttiMaa)
        {
            numero = korttiNumero;
            maa = korttiMaa;
        }

        public override string ToString()
        {
            return numero + maa;
        }

    }
}