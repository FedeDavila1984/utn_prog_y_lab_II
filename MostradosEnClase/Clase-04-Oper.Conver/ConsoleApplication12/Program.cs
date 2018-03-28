using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            Metro metros = (Metro)10;
            Centimetro centimetros = 10;

            // Sumo Metro y Centimetro
            Metro SumaMetros = metros + centimetros;
            // Sumo Centimetro y Metro
            Centimetro SumaCentimetros = centimetros + metros;
            // Muestro
            Console.WriteLine((double)SumaMetros);
            Console.WriteLine(SumaCentimetros);


            // Quito 1 al Metro
            metros--;
            // Sumo 1 al Centimetro
            centimetros++;
            // Muestro
            Console.WriteLine((double)metros);
            Console.WriteLine(centimetros);

            Console.ReadKey();
        }
    }
}
