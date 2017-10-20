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
            IArchivo<Item> archivosBinario = new Binario<Item>();

            string rutaArchivoXml = AppDomain.CurrentDomain.BaseDirectory + "xmlfile.xml";

            if (archivosXml.Guardar(rutaArchivoXml, new Item("Olga", 32, 1.5f)))
                Console.WriteLine("El archivo XML se guardó con éxito");
            else
                Console.WriteLine("El archivo XML NO se guardó");

            string rutaArchivoTexto = AppDomain.CurrentDomain.BaseDirectory + "txtfile.txt";
            if (archivosTexto.Guardar(rutaArchivoTexto, new Item("Olga", 32, 1.5f).ToString()))
                Console.WriteLine("El archivo de texto se guardó con éxito");
            else
                Console.WriteLine("El archivo de texto NO se guardó");

            string rutaArchivoBinario = AppDomain.CurrentDomain.BaseDirectory + "data.bin";
            if (archivosBinario.Guardar(rutaArchivoBinario, new Item("María", 23, 1.2f)))
                Console.WriteLine("El archivo de binario se guardó con éxito");
            else
                Console.WriteLine("El archivo de binario NO se guardó");

            Console.ReadKey();
            Console.Clear();

            Item item;
            Console.WriteLine("XML:");
            if (archivosXml.Leer(rutaArchivoXml, out item))
                Console.WriteLine(item.ToString());
            else
                Console.WriteLine("El archivo XML NO se leyó");

            Console.WriteLine("<==========================================>");
            Console.WriteLine("TXT:");
            string contenido;
            if(archivosTexto.Leer(rutaArchivoTexto, out contenido))
                Console.WriteLine(contenido);
            else
                Console.WriteLine("El archivo de texto NO se leyó");

            Console.WriteLine("<==========================================>");
            Console.WriteLine("BINARIO:");
            if (archivosBinario.Leer(rutaArchivoBinario, out item))
                Console.WriteLine(item.ToString());
            else
                Console.WriteLine("El archivo de binario NO se leyó");

            Console.ReadKey();
        }
    }
}
