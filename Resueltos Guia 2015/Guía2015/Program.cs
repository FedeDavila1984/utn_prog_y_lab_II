using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Guía2015;

namespace Ej13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("9 convertido a binario es: {0}", Conversor.DecimalBinario(9));
            Console.WriteLine("19 convertido a binario es: {0}", Conversor.DecimalBinario(19));
            Console.WriteLine("109 convertido a binario es: {0}", Conversor.DecimalBinario(109));

            Console.WriteLine("1001 convertido a decimal es: {0}", Conversor.BinarioDecimal("1001"));
            Console.WriteLine("10011 convertido a decimal es: {0}", Conversor.BinarioDecimal("10011"));
            Console.WriteLine("1101101 convertido a decimal es: {0}", Conversor.BinarioDecimal("1101101"));

            Console.WriteLine("11a1s1 convertido a decimal es: {0}", Conversor.BinarioDecimal("11a1s1"));
            Console.ReadKey();

            bool seguir = true;
            do
            {
                // Limpio la pantalla
                Console.Clear();
                // ***** MENU *****
                Console.WriteLine("1- Decimal a Binario");
                Console.WriteLine("2- Binario a Decimal");
                Console.WriteLine("3- Salir");
                // ***** FIN MENU *****
                int opcion;
                // Corroboro que la opción sea correcta.
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    string numero;
                    // Opero según la opción ingresada
                    switch (opcion)
                    {
                        case 1: // Convierto a Binario
                            Console.Write("Ingrese el número Decimal a convertir en Binario: ");
                            numero = Console.ReadLine();
                            int n;
                            // Corroboro que sea un número.
                            if (int.TryParse(numero, out n))
                                Console.WriteLine("{1} convertido a binario es: {0}", Conversor.DecimalBinario(n), numero);
                            else
                                Console.WriteLine("{0} no es un número válido.", numero);
                            break;
                        case 2: // Convierto a Decimal
                            Console.Write("Ingrese el número Binario a convertir en Decimal: ");
                            numero = Console.ReadLine();

                            Console.WriteLine("{1} convertido a decimal es: {0}", Conversor.BinarioDecimal(numero), numero);
                            break;
                        case 3: // Salgo
                            seguir = false;
                            Console.WriteLine("Gracias por elegirnos.");
                            break;
                        default: // Si no es ninguna opción válida...
                            Console.WriteLine("Opción incorrecta.");
                            break;
                    }

                    Console.ReadKey();
                }
            } while (seguir);
        }
    }
}
