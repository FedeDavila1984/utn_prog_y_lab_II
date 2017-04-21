using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ej.Polimorfismo_Libreria;

namespace Ej.Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo terrestre = new Automovil(1, "Mondeo", "ASDW2323");
            Automovil auto = new Automovil(2, "Aveo", "YUFJD144");
            Vehiculo aereo = new Avion(3, "747");
            Avion avion1 = new Avion(4, "737");
            Avion avion2 = new Avion(avion1);

            Console.WriteLine("Vehiculo Terrestre:\n" + terrestre.Mostrar());
            Console.WriteLine("Automovil:\n" + auto.Mostrar());
            Console.WriteLine("Vehiculo Aereo:\n" + aereo.Mostrar());
            Console.WriteLine("Avion 1:\n" + avion1.Mostrar());
            Console.WriteLine("Avion 2:\n" + avion2.Mostrar());

            Console.ReadKey();
        }
    }
}
