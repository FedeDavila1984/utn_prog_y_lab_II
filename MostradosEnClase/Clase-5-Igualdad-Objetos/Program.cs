using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5_Igualdad_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase m1 = new MiClase(1);
            MiClase m2 = new MiClase(1);
            MiClase m3 = m1;

           // m3.miAlgo = 3;
            Console.WriteLine("MiAlgo de m1: {0}\nMiAlgo de m3: {1}", m1.miAlgo, m3.miAlgo);

            //if(m2 == null)
            if (!object.ReferenceEquals(m2, null))
                Console.WriteLine("gola");

            if (m1 == m2)
                Console.WriteLine("m1 y m2 son iguales");
            if (m1 == m3)
                Console.WriteLine("m1 y m3 son iguales");
            if (m2 == m3)
                Console.WriteLine("m2 y m3 son iguales");

            Console.ReadKey();
        }
    }
}
