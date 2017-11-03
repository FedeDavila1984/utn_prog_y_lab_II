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
            String s = "Prefijo";

            Console.WriteLine(cs.MetodoExtendido("Sufijo ClaseSellada1", "a"));
            Console.WriteLine(cs.MetodoExtendido("Sufijo ClaseSellada2"));

            Console.WriteLine(s.MetodoExtendido("Sufijo String"));

            Console.ReadKey();
        }
    }
}
