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
            int max = 0;
            int min = 0;
            float promedio = 0;
            string lectura;

            for (int i = 0; i < totalNumeroALeer; i++)
            {
                Console.Write("Ingrese un número: ");
                lectura = Console.ReadLine();
                if (int.TryParse(lectura, out aux))
                {
                    if (i == 0)
                    {
                        max = aux;
                        min = aux;
                        promedio = aux;
                    }
                    else
                    {
                        if (aux > max)
                            max = aux;
                        if (aux < min)
                            min = aux;
                        promedio = (promedio + aux);
                    }
                }
                else
                    i--;
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
        }
    }
}
