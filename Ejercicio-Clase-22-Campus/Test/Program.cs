using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Listado l = new Listado();

            try
            {
                l.CargaClientes();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
                // Cierro la consola
                Environment.Exit(0);
            }
            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();

                Console.WriteLine("1- Mostrar clientes con CUIT válido");
                Console.WriteLine("2- Mostrar clientes con CUIT inválido");
                Console.WriteLine("3- Salir");
                tecla = Console.ReadKey();
                Console.WriteLine();

                switch (tecla.KeyChar)
                {
                    case '1':
                        Console.WriteLine(l.MostrarClientes(Listado.Estado.Valido));
                        Console.ReadKey();
                        break;
                    case '2':
                        Console.WriteLine(l.MostrarClientes(Listado.Estado.Invalido));
                        Console.ReadKey();
                        break;
                }

            } while (tecla.KeyChar != '3');
        }
    }
}
