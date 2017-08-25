using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            Console.WriteLine(s1.Sumar("a", "n"));
            Console.WriteLine(s1.Sumar(1, 10001));
            Sumador s2 = new Sumador(19);

            Console.WriteLine("Suma de Sumadores");
            Console.WriteLine(s1 + s2);
            Console.WriteLine("Explicit de Sumador s1");
            Console.WriteLine((int)s1);
            Console.WriteLine("Pipe de Sumadores s1 | s2");
            Console.WriteLine(s1 | s2);
            Console.WriteLine("Pipe de Sumadores s2 | s2");
            Console.WriteLine(s2 | s2);

            Console.ReadKey();
        }
    }
}
