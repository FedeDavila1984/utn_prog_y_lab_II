using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_8_Libreria;

namespace Clase_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pagina> paginas = new List<Pagina>();
            paginas.Add(new Pagina(1, "Contenido de Página Nº1"));
            paginas.Add(new Pagina(2, "Contenido de Página Nº2"));
            paginas.Add(new Pagina(3, "Contenido de Página Nº3"));
            paginas.Add(new Pagina(4, "Contenido de Página Nº4"));

            Libro miLibro = new Libro(paginas);

            for (int i = 1; i <= miLibro.Paginas.Count; i++)
            {
                Console.WriteLine((string)miLibro[i]);
            }
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine();

            miLibro[2] = new Pagina(2, "Nuevo contenido de Página Nº2");

            for (int i = 1; i <= miLibro.Paginas.Count; i++)
            {
                Console.WriteLine((string)miLibro[i]);
            }
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("*****************************************");
            Console.WriteLine();

            Console.WriteLine("Primera Página: " + (string)miLibro[Libro.PaginasEspeciales.PrimerPagina]);
            Console.WriteLine("Última Página: " + (string)miLibro[Libro.PaginasEspeciales.UltimaPagina]);

            Console.WriteLine((string)miLibro[10]);

            Console.ReadKey();
        }
    }
}
