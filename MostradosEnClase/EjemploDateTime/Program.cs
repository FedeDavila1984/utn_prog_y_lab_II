using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1 = new DateTime(2003, 09, 11); //AAAA,MM,DD
            DateTime fecha2 =  new DateTime(2018, 04, 19, 20, 10, 30);//AAAA,MM,DD,hh,mm,ss
            DateTime fechaActual = DateTime.Now;

            Console.WriteLine("* ************************************************************ *\n");

            Console.WriteLine(String.Format("* {0,-39}: {1, -19} *", "Fecha actual ", fechaActual));
            Console.WriteLine(String.Format("* {0,-39}: {1, -19} *", "Fecha 1 ", fecha1));
            Console.WriteLine(String.Format("* {0,-39}: {1, -19} *", "Fecha 2 ", fecha2));
            Console.WriteLine(String.Format("* {0,-39}: {1, -19} *", "Diferencia entre fechas ", (fecha2 - fecha1)));
            /*
            Console.WriteLine("* Fecha actual: {0} *", fechaActual);
            Console.WriteLine("* Fecha1: {0} *", fecha1);
            Console.WriteLine("* Fecha2: {0} *", fecha2);
            Console.WriteLine("* Diferencia entre fechas: {0} *", (fecha2 - fecha1));*/

            Console.WriteLine("\n* ************************************************************ *\n");

            //TotalDays devuelve un double
            Console.WriteLine(String.Format("* {0,-46}: {1, -12} *", "Diferencia de días entre fechas (TotalDays)", (fecha2 - fecha1).TotalDays));
            Console.WriteLine(String.Format("* {0,-46}: {1, -12} *", "Diferencia de días entre fechas (TotalHours)", (fecha2 - fecha1).TotalHours));
            Console.WriteLine(String.Format("* {0,-46}: {1, -12} *", "Diferencia de días entre fechas (TotalMinutes)", (fecha2 - fecha1).TotalMinutes));
            Console.WriteLine(String.Format("* {0,-46}: {1, -12} *", "Diferencia de días entre fechas (TotalSeconds)", (fecha2 - fecha1).TotalSeconds));
            /*
            Console.WriteLine("* Diferencia de días entre fechas(TotalDays): {0} *", (fecha2 - fecha1).TotalDays);
            Console.WriteLine("* Diferencia de días entre fechas(TotalHours): {0} *", (fecha2 - fecha1).TotalHours);
            Console.WriteLine("* Diferencia de días entre fechas(TotalMinutes): {0} *", (fecha2 - fecha1).TotalMinutes);
            Console.WriteLine("* Diferencia de días entre fechas(TotalSeconds): {0} *", (fecha2 - fecha1).TotalSeconds);
            */
            Console.WriteLine("\n* ************************************************************ *\n");

            //Days, Hours, Minutes y Seconds devuelven un int
            Console.WriteLine(String.Format("* {0,-46}: {1, -12} *", "Diferencia de días entre fechas (Days)", (fecha2 - fecha1).Days));
            Console.WriteLine(String.Format("* {0,-46}: {1, -12} *", "Diferencia de días entre fechas (Hours)", (fecha2 - fecha1).Hours));
            Console.WriteLine(String.Format("* {0,-46}: {1, -12} *", "Diferencia de días entre fechas (Minutes)", (fecha2 - fecha1).Minutes));
            Console.WriteLine(String.Format("* {0,-46}: {1, -12} *", "Diferencia de días entre fechas (Seconds)", (fecha2 - fecha1).Seconds));
            /*
            Console.WriteLine("* Diferencia de días entre fechas (Days): {0} *", (fecha2 - fecha1).Days);
            Console.WriteLine("* Diferencia de días entre fechas (Hours): {0} *", (fecha2 - fecha1).Hours);
            Console.WriteLine("* Diferencia de días entre fechas (Minutes): {0} *", (fecha2 - fecha1).Minutes);
            Console.WriteLine("* Diferencia de días entre fechas (Seconds): {0} *", (fecha2 - fecha1).Seconds);
            */
            Console.WriteLine("\n* ************************************************************ *\n");
            Console.WriteLine(String.Format("* {0,-46}: {1, -12} *", "Compara fecha1 y Now con Compare()", DateTime.Compare(fecha1, DateTime.Now)));
            Console.WriteLine(String.Format("* {0,-46}: {1, -12} *", "Compara fecha1 y fecha2 con CompareTo()", fecha1.CompareTo(fecha2)));
            Console.WriteLine(String.Format("* {0,-46}: {1, -12} *", "Compara fecha2 y fecha1 con CompareTo()", fecha2.CompareTo(fecha1)));
            /*
            Console.WriteLine("* Compara fecha1 y Now con Compare(): {0} *", DateTime.Compare(fecha1, DateTime.Now));
            Console.WriteLine("* Compara fecha1 y fecha2 con CompareTo(): {0} *", fecha1.CompareTo(fecha2));
            Console.WriteLine("* Compara fecha2 y fecha1 con CompareTo(): {0} *", fecha2.CompareTo(fecha1));
            */
            Console.WriteLine("\n* ************************************************************ *\n");

            Console.ReadKey();

        }
    }
}
