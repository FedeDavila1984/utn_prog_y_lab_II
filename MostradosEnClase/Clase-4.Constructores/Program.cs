using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntidadesYConstructores;

namespace Clase3.Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase.otroatrib = 1000;
            MiClase.atributoStatic = 1;

            MiClase a = new MiClase(100);
            MiClase b = new MiClase(10);
            MiClase c = new MiClase(102);
            new MiClase(100);
            MiClase d = new MiClase(100);
            MiClase e = new MiClase(100);

            Console.ReadKey();










            /*
            // ¿Qué pasa al generar la PRIMERA instancia? Seguí los Breackpoints...
            MiClase c1 = new MiClase(10, 20, 30);

            // ¿Qué pasa al generar la SEGUNDA instancia? Seguí los Breackpoints...
            MiClase c2 = new MiClase(10, 20, 30);*/
        }
    }
}
