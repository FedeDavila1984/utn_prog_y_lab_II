using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso curso2A = new Curso(new string[] { "Juan", "Pedro" });
            Curso curso2E = new Curso("Juan");
                
            if (curso2A > 1)
            {
                Console.WriteLine("Alumnos {0}", curso2A);
                string alumnos = curso2A;
                Console.WriteLine("Alumnos {0}", alumnos);
            }
            // Comparo dos cursos
            if (curso2A > curso2E)
            {
                Console.WriteLine("2A tiene más alumnos que 2E");
            }
            Console.ReadKey();
        }
    }
}
