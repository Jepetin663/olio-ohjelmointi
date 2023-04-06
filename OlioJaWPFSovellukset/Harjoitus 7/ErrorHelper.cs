using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus7
{
    static class ErrorHelper
    {
        public static void KirjoitaError(string virhe)
        {
            Console.WriteLine("error.msg: " + virhe);
        }
    }
}