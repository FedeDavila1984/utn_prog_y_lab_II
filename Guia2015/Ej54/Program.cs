using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ej54_Libreria;

namespace Ej54
{
    class Program
    {
        static void Main(string[] args)
        {
            /***
             * La descripción del Main no está seguida paso a paso según lo dictado para el Ej 54
             * Serialicé cómo binario, haganlo como XML
             * Se modificaron partes del código para seguir lo dictado en clase
            ***/ 


            // Mi central
            Centralita c = new Centralita("Fede Center");
            c.RutaDeArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            // Mis 4 llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            try
            {
                c = c + l1;
            }
            catch (CentralitaException ce)
            {
                Console.WriteLine(ce.Message);
            }
            Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();
            try
            {
                c += l2;
            }
            catch (CentralitaException ce)
            {
                Console.WriteLine(ce.Message);
            }
            Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();
            try
            {
                c += l3;
            }
            catch (CentralitaException ce)
            {
                Console.WriteLine(ce.Message);
            }
            Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();
            try
            {
                c += l4;
            }
            catch (CentralitaException ce)
            {
                Console.WriteLine(ce.Message);
            }
            Console.WriteLine(c.ToString());
            Console.ReadKey();
            Console.Clear();

            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

            try
            {
                c.Serializarse();
            }
            catch (CentralitaException ce)
            {
                Console.WriteLine(ce.Message);
            }

            try
            {
                Centralita c2 = new Centralita("Otra Centralita");
                c2.RutaDeArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                c2.DeSerializarse();
                Console.WriteLine(c2.ToString());
            }
            catch (CentralitaException ce)
            {
                Console.WriteLine(ce.Message);
            }

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine(c.RecuperarArchivoTexto());
            Console.ReadKey();
        }
    }
}
