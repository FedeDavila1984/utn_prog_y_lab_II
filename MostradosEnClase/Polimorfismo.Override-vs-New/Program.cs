using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Override_vs_New
{
    class Program
    {
        static void Main(string[] args)
        {

            // Métodos virtuales con ClaseDerivadaA
            Console.WriteLine("Con ClaseDerivadaA:");

            ClaseBase baseClaseA = new ClaseDerivadaA();
            Console.WriteLine(baseClaseA.MetodoVirtual());

            ClaseDerivadaA derivadaClaseA = new ClaseDerivadaA();
            Console.WriteLine(derivadaClaseA.MetodoVirtual());

            Console.WriteLine("<-------------------------------------------->");
            // Métodos virtuales con ClaseDerivadaB
            Console.WriteLine("Con ClaseDerivadaB:");

            ClaseBase baseClaseB = new ClaseDerivadaB();
            Console.WriteLine(baseClaseB.MetodoVirtual());

            ClaseDerivadaB derivadaClaseB = new ClaseDerivadaB();
            Console.WriteLine(derivadaClaseB.MetodoVirtual());

            Console.ReadKey();
            Console.Clear();

            // Creo una lista
            List<ClaseBase> l = new List<ClaseBase>();
            l.Add(baseClaseA);
            l.Add(derivadaClaseA);
            l.Add(baseClaseB);
            l.Add(derivadaClaseB);

            Object obj = new ClaseDerivadaB();
            l.Add((ClaseBase)obj);

            // Itero la lista
            foreach (ClaseBase b in l)
            {
                if(b is ClaseDerivadaB)
                {
                    ClaseDerivadaB aux = (ClaseDerivadaB)b;
                    Console.WriteLine(aux.MetodoVirtual());
                }
                Console.WriteLine(b.MetodoVirtual());
            }

            Console.ReadKey();
            Console.Clear();

            // Clase deribada es
            Console.WriteLine("derivadaClaseB es ClaseDerivadaB: {0}", derivadaClaseB is ClaseDerivadaB);
            Console.WriteLine("derivadaClaseB es ClaseBase: {0}", derivadaClaseB is ClaseBase);
            Console.WriteLine("derivadaClaseB es Object: {0}", derivadaClaseB is Object);

            Console.ReadKey();
        }
    }
}
