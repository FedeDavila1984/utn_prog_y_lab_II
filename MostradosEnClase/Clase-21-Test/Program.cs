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
            Persona p = new Persona("Jorge", "Comas", 23567891);
            Console.WriteLine("");
            Console.WriteLine("Guardando...");
            if (p.Guardar())
                Console.WriteLine("Guardado!");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Cargando...");
            if (p.Cargar())
                Console.WriteLine(p.ToString());
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Modificando...");
            p.Apellido = "Benítez";
            if (p.Modificar())
                Console.WriteLine("Modificado!");
            Console.ReadKey();

            Console.WriteLine("");
            Console.WriteLine("Eliminando...");
            if (p.Eliminar())
                Console.WriteLine("Eliminado!");
            Console.ReadKey();
        }
    }
}
