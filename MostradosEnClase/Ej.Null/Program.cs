using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Null
{
    class Program
    {
        static void Main(string[] args)
        {
            Producto prod = new Producto("Pepsi", "PESDS97413", (float)10.5);
            Producto prodNull = null;

            // Este IF da error!
            if (prod == null)
                Console.WriteLine("Esta comparación está mal!");

            // Formas correctas
            if (prodNull is null)
                Console.WriteLine("Comparación IS");

            if (Object.ReferenceEquals(prodNull, null))
                Console.WriteLine("Comparación Object.ReferenceEquals");

            if (Object.Equals(prodNull, null))
                Console.WriteLine("Comparación Equals");
        }
    }
}
