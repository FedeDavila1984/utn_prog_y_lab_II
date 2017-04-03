using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_5_Campus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Repaso Laboratorio II - 2017";

            Estante est1 = new Estante(3, 1);
            Estante est2 = new Estante(2, 2);

            Producto p1 = new Producto("222", "Manaos", 50.25f);
            Producto p2 = new Producto("113", "Pitusas", 250f);
            Producto p3 = new Producto("111", "Diversión", 500f);
            Producto p4 = new Producto("112", "Naranjú", 500f);
            Producto p5 = new Producto("333", "Swift", 500f);
            Producto p6 = new Producto("222", "Manaos", 500f);

            if (!(est1 + p2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + p3))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + p2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est1 + p4))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + p5))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + p6))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }
            if (!(est2 + p2))
            {
                Console.WriteLine("No se pudo agregar el producto al estante!!!");
            }

            Console.WriteLine("Contenido Estante1:\n{0}", Estante.MostrarEstante(est1));

            est1 = est1 - p2;
            Console.WriteLine("Estante1 sin Manaos: {0}", Estante.MostrarEstante(est1));

            Console.WriteLine("Contenido Estante2:\n{0}", Estante.MostrarEstante(est2));
            est2 -= p5;
            Console.WriteLine("Contenido Estante2:\n{0}", Estante.MostrarEstante(est2));

            Console.ReadLine();
        }
    }
}
