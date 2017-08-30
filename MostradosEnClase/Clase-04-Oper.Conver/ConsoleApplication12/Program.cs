using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            Metro metros = (Metro)10;
            Centimetro centimetros = 10;

            Metro SumaMetros = metros + centimetros;
            Centimetro SumaCentimetros = centimetros + metros;

            Console.WriteLine((double)SumaMetros);
            Console.WriteLine(SumaCentimetros);

            Console.ReadKey();
        }
    }
}
