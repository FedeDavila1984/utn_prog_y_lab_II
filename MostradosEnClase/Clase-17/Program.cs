using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17
{
    class Program
    {
        static void Main(string[] args)
        {
            MetodosGenericos p = new MetodosGenericos();
            p.MetodoInstancia<string>("hola", "chau");
            MetodosGenericos.MetodoStatic<MetodosGenericos>(p, p);

            //Dictionary<int, MetodosGenericos> lista = new Dictionary<int, MetodosGenericos>();
            ClaseGenerica<MetodosGenericos, MetodosGenericos, String> claseGen = new ClaseGenerica<MetodosGenericos, MetodosGenericos, String>();
            claseGen.MetodoConElTipo(claseGen);

            Console.ReadKey();
        }
    }
}
