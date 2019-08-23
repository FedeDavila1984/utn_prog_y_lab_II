using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._001
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumeroALeer = 5;

            int aux;
            int max = int.MinValue;
            int min = int.MaxValue;
            float promedio = 0;
            string lectura;

            for (int i = 0; i < totalNumeroALeer; i++)
            {
                Console.Write("Ingrese un número: ");
                lectura = Console.ReadLine();
                if (int.TryParse(lectura, out aux))
                {
                    if (aux > max)
                        max = aux;
                    if (aux < min)
                        min = aux;
                    promedio = (promedio + aux);
                }
                else {
                    Console.Write("Ingrese un número válido. ");
                    i--;
                }
            }
            promedio = promedio / totalNumeroALeer;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Máximo : {0}", max);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Mínimo : {0}", min);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Promedio: {0:#.##}", promedio);
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Máximo : {0,8} - Mínimo : {1,8} - Promedio: {2,8:#.##}", max, min, promedio);
            Console.ReadKey();
        }
    }
}
