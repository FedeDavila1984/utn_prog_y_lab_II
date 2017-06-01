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
            Persona p = new Persona(1, "Jorge", "Comas", 23567891);
            if (p.Guardar())
                Console.WriteLine("Guardado!");
            Console.ReadKey();
        }
    }
}
