using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._009
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ingreso la cantidad de pisos de la torre
            Console.Write("Ingrese la cantidad de pisos de la torre: ");
            int alto;
            // Controlo que el valor ingresado sea numérico
            if (int.TryParse(Console.ReadLine(), out alto))
            {
                Console.WriteLine();
                Console.WriteLine();
                // Recorro los pisos de la torre
                // Como cada piso se incrementa en 2 (dos) *, multiplico el alto y lo recorro de dos en dos
                for (int i = 1; i <= (alto * 2); i = i + 2)
                {
                    // Cada piso lo formo con tantos * como sea el valor de i
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    // Ingreso un salto de línea
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
