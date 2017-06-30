using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Extensor;

namespace Clase_25_Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseSellada cs = new ClaseSellada(19);
            String s = "Como andas";

            Console.WriteLine(cs.MetodoExtendido("Chau"));

            Console.WriteLine(s.MetodoExtendido("Chau Str"));

            Console.ReadKey();
        }
    }
}
