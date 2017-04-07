using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Con Arrays";

            OficinaArray of = new OficinaArray(4, 1);

            Empleado e1 = new Empleado("Manuel", "Belgrano");
            Empleado e2 = new Empleado("José", "San Martín");
            Empleado e3 = new Empleado("Juana", "Azurduy");
            Empleado e4 = new Empleado("Miguel", "Güemes");

            of += e1;
            of += e2;
            of += e3;
            of += e4;
            of += e4;

            Console.WriteLine(of.Mostrar());

            of -= e3;
            Console.WriteLine(of.Mostrar());

            Console.ReadKey();
            Console.Clear();

            Console.Title = "Con Listas";

            OficinaLista ofLista = new OficinaLista(4, 1);

            Empleado e5 = new Empleado("Manuel", "Belgrano");
            Empleado e6 = new Empleado("José", "San Martín");
            Empleado e7 = new Empleado("Juana", "Azurduy");
            Empleado e8 = new Empleado("Miguel", "Güemes");

            ofLista += e5;
            ofLista += e6;
            ofLista += e7;
            ofLista += e8;
            ofLista += e8;

            Console.WriteLine(ofLista.Mostrar());

            ofLista -= e7;
            Console.WriteLine(ofLista.Mostrar());

            Console.ReadKey();
        }
    }
}
