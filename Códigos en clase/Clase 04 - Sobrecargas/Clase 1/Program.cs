using System;
using Entidades;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil au0 = new Automovil();
            Automovil au1 = new Automovil(new Marca("Chevrolet"), 11);

            //au0.Acelerar();
            //au0.Acelerar();
            au0 += 1;
            au0 = au0 + 1;
            Console.WriteLine(au0.velocidadActual);
            Console.ReadKey();
            au0 = au0 + 10;
            Console.WriteLine((int)au0);
            Console.WriteLine(au0);


            Console.WriteLine(au0 == 10);
            Console.WriteLine(au0 == 13 ? "SI" : "NO");

            Console.ReadKey();
        }
    }
}
