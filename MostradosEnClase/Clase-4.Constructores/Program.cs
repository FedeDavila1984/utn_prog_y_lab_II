using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            // ¿Qué pasa al generar la PRIMERA instancia? Seguí los Breackpoints...
            MiClase c1 = new MiClase(10, 20, 30);

            // ¿Qué pasa al generar la SEGUNDA instancia? Seguí los Breackpoints...
            MiClase c2 = new MiClase(10, 20, 30);
        }
    }
}
