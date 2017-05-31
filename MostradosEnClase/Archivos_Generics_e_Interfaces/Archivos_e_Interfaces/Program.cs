using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Archivos;

namespace Archivos_e_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Xml<Item> archivosXml = new Xml<Item>();
            //Texto archivosTexto = new Texto();
            IArchivo<Item> archivosXml = new Xml<Item>();
            IArchivo<string> archivosTexto = new Texto();

            string rutaArchivoXml = AppDomain.CurrentDomain.BaseDirectory + "xmlfile.xml";

            if (archivosXml.guardar(rutaArchivoXml, new Item("Olga", 32, 1.5f)))
                Console.WriteLine("El archivo XML se guardó con éxito");
            else
                Console.WriteLine("El archivo XML NO se guardó");

            string rutaArchivoTexto = AppDomain.CurrentDomain.BaseDirectory + "txtfile.txt";
            if (archivosTexto.guardar(rutaArchivoTexto, new Item("Olga", 32, 1.5f).ToString()))
                Console.WriteLine("El archivo de texto se guardó con éxito");
            else
                Console.WriteLine("El archivo de texto NO se guardó");

            Console.ReadKey();
            Console.Clear();

            Item item;
            Console.WriteLine("XML:");
            if (archivosXml.leer(rutaArchivoXml, out item))
                Console.WriteLine(item.ToString());
            else
                Console.WriteLine("El archivo XML NO se leyó");

            Console.WriteLine("<==========================================>");
            Console.WriteLine("TXT:");
            string contenido;
            if(archivosTexto.leer(rutaArchivoTexto, out contenido))
                Console.WriteLine(contenido);
            else
                Console.WriteLine("El archivo de texto NO se leyó");

            Console.ReadKey();
        }
    }
}
