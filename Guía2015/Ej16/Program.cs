using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno();
            a1.nombre = "Juan";
            a1.apellido = "Pérez";
            a1.legajo = 155633;
            
            a1.Estudiar(2, 10);
            a1.CalcularFinal();
            Console.WriteLine(a1.Mostrar());

            Alumno a2 = new Alumno();
            a2.nombre = "Agostina";
            a2.apellido = "López";
            a2.legajo = 945683;
            a2.Estudiar(5, 8);
            a2.CalcularFinal();
            Console.WriteLine(a2.Mostrar());

            Alumno a3 = new Alumno();
            a3.nombre = "René";
            a3.apellido = "Lavand";
            a3.legajo = 155633;
            a3.Estudiar(4, 4);
            a3.CalcularFinal();
            Console.WriteLine(a3.Mostrar());

            Console.ReadKey();
        }
    }
}
