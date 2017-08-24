using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estatico: " + MiClase.ValorEstatico());
            Console.ReadKey();

            MiClase miClase1 = new MiClase(10);
            Console.WriteLine("Estatico {0} - No Estatico {1}", MiClase.ValorEstatico(), miClase1.ValorNoEstatico());
            Console.ReadKey();

            MiClase miClase2 = new MiClase(5, 15);
            Console.WriteLine("Estatico {0} - No Estatico {1}", MiClase.ValorEstatico(), miClase2.ValorNoEstatico());
            Console.ReadKey();
        }
    }
}
