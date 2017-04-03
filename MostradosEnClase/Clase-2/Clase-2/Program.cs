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

            MiClase miClase = new MiClase(10);
            Console.WriteLine("No Estatico: " + miClase.ValorNoEstatico());

            Console.ReadKey();
        }
    }
}
