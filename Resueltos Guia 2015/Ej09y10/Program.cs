using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej09y10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 9 y 10 - Guía";
            int tamanio = 0;
            char continuar;

            //string s = Console.ReadLine();
            //int a = int.Parse(s);
            //Console.WriteLine(a);
            //Console.ReadKey();

            do
            {
                Console.Clear();
                Console.Write("Ingrese el tamaño de la pirámide: ");
                // Convierto el valor ingresa a entero
                if (int.TryParse(Console.ReadLine(), out tamanio))
                {
                    // Si tengo 5 pisos, mi numero máximo de * será 10 en la base
                    tamanio = tamanio * 2;
                    // EJERCICIO 9
                    Console.WriteLine("===========EJERCICIO 09===========");
                    // Recorro el alto de la pirámide
                    for (int i = tamanio; i >= 0; i--)
                    {
                        if (((tamanio - i) % 2) != 0)
                        {
                            // Recorro el ancho del piso de la pirámide
                            for (int j = 0; j < tamanio - i; j++)
                            {
                                Console.Write("*");
                            }
                            // Salto de línea
                            Console.WriteLine();
                        }
                    }

                    // EJERCICIO 10
                    Console.WriteLine();
                    Console.WriteLine("===========EJERCICIO 10===========");
                    // Recorro el alto de la pirámide
                    for (int i = tamanio; i >= 0; i--)
                    {
                        if (((tamanio - i) % 2) != 0)
                        {
                            // Recorro el ancho del piso de la pirámide
                            for (int j = 0; j < i / 2; j++)
                            {
                                Console.Write(" ");
                            }
                            // Recorro el ancho del piso de la pirámide
                            for (int j = 0; j < tamanio - i; j++)
                            {
                                Console.Write("*");
                            }
                            // Salto de línea
                            Console.WriteLine();
                        }
                    }
                }
                else
                    Console.WriteLine("Valor ingresado inválido!");

                Console.WriteLine("Presione s para continuar");
                continuar = Console.ReadKey().KeyChar;
            } while (continuar == 's' || continuar == 'S');
        }
    }
}
