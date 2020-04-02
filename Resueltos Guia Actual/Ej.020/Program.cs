using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Billetes;

namespace Ej020
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro e = new Euro(10, 0.809f);
            Dolar d = new Dolar(10);
            Pesos p = new Pesos(10, 20.1655f);

            Euro aux_e = e + d;
            Console.WriteLine("Euro + Dólar (€18,09xx): {0}", aux_e.GetCantidad());
            aux_e = e + p;
            Console.WriteLine("Euro + Pesos (€10,40xx): {0}", aux_e.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Dolar aux_d = d + e;
            Console.WriteLine("Dólar + Euro (U$S22,36xx): {0}", aux_d.GetCantidad());
            aux_d = d + p;
            Console.WriteLine("Dólar + Pesos (U$S10,49xx): {0}", aux_d.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Pesos aux_p = p + e;
            Console.WriteLine("Pesos + Euro ($259,26xx): {0}", aux_p.GetCantidad());
            aux_p = p + d;
            Console.WriteLine("Pesos + Dólar ($211,65xx): {0}", aux_p.GetCantidad());

            Console.ReadKey();
        }
    }
}
