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
            Console.WriteLine("Tengo un objeto metros con 10m y un objeto centimetros con 10cm");

            // Sumo Metro y Centimetro
            Metro SumaMetros = metros + centimetros;
            // Sumo Centimetro y Metro
            Centimetro SumaCentimetros = centimetros + metros;
            // Muestro
            Console.WriteLine("Suma de metros: {0}",(double)SumaMetros);
            double aux = SumaCentimetros; // Creo la variable para ejecutar la conversión implicita
            Console.WriteLine("Suma de centimetros: {0}", aux);


            // Quito 1 al Metro
            metros--;
            // Sumo 1 al Centimetro
            centimetros++;
            // Muestro
            Console.WriteLine("Variable metros--: {0}", (double)metros);
            aux = centimetros;
            Console.WriteLine("Variable centimetros++: {0}", aux);

            Console.ReadKey();
        }
    }
}
