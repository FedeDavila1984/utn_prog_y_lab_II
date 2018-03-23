using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._004
{
    class Program
    {
        static void Main(string[] args)
        {
            short perfectosEncontrados = 0;
            // Número actual, comenzando en 1
            int numero = 1;

            do
            {
                int sumador = 0;
                // Busco los divisores del número actual
                //for (int i = 1; i < numero; i++)
                for (int i = numero-1; i > 0 ; i--)
                {
                    if ((numero % i) == 0)
                    {
                        // Sumo los divisores en busca del número Perfecto
                        sumador += i;

                        if (sumador > numero)
                            break;
                    }
                }
                // Si la suma de los divisores es igual al número, es PERFECTO
                if (sumador == numero)
                {
                    perfectosEncontrados++;
                    Console.WriteLine("El número {0} es PERFECTO", numero);
                }
                // Incremento el número actual
                numero++;
            } while (perfectosEncontrados < 4);

            Console.ReadKey();
        }
    }
}
