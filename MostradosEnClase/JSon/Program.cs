using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace JSon
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *
             * Ir al menú: Tools / Library Package Manager / Package Manager Consolo
             * Ejecutar, para VB C# 2012: Install-Package Newtonsoft.Json -Version 8.0.3
             * https://www.newtonsoft.com/json
             *
            */

            /*
             * Serialización
            */
            Producto product = new Producto();
            product.Nombre = "Apple";
            product.Vencimiento = new DateTime(2008, 12, 28);
            product.Tamanios = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);

            Console.WriteLine(json);
            // {
            //   "Name": "Apple",
            //   "Expiry": "2008-12-28T00:00:00",
            //   "Sizes": [
            //     "Small"
            //   ]
            // }

            Console.WriteLine("");
            Console.WriteLine("========================================");
            Console.WriteLine("========================================");
            Console.WriteLine("");

            /*
             * Deserialización
            */
            json = @"{
              'Nombre': 'Bad Boys',
              'FechaLanzamiento': '1995-4-7T00:00:00',
              'Generos': [
                'Acción',
                'Comedia'
              ]
            }";

            Pelicula m = JsonConvert.DeserializeObject<Pelicula>(json);

            Console.WriteLine(m.ToString());

            Console.ReadKey();
        }
    }
}
