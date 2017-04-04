using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Una linea");
            sb.AppendFormat("{0} es un numero, y {1} es una palabra", 10, "Hola");

            Console.WriteLine(sb.ToString());

            Console.ReadKey();
        }
    }
}
