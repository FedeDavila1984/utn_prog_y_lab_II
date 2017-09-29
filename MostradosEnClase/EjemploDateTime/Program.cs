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
            DateTime fecha1 = new DateTime(2018, 01, 01); //AAAA,MM,DD
            DateTime fecha2 = new DateTime(2019, 01, 05, 12, 10, 30);//AAAA,MM,DD,hh,mm,ss
            DateTime fechaActual = DateTime.Now;

            Console.WriteLine("Fecha actual: " + fechaActual);
            Console.WriteLine("Fecha1: " + fecha1);
            Console.WriteLine("Fecha2: " + fecha2);

            Console.WriteLine("Diferencia entre fechas: " + (fecha2 - fecha1));

            Console.WriteLine("\n************************************************\n");

            //TotalDays devuelve un double
            Console.WriteLine("Diferencia de días entre fechas(TotalDays): " + (fecha2 - fecha1).TotalDays);
            Console.WriteLine("Diferencia de días entre fechas(TotalHours): " + (fecha2 - fecha1).TotalHours);
            Console.WriteLine("Diferencia de días entre fechas(TotalMinutes): " + (fecha2 - fecha1).TotalMinutes);
            Console.WriteLine("Diferencia de días entre fechas(TotalSeconds): " + (fecha2 - fecha1).TotalSeconds);

            Console.WriteLine("\n************************************************\n");

            //Days, Hours, Minutes y Seconds devuelven un int
            Console.WriteLine("Diferencia de días entre fechas (Days):" + (fecha2 - fecha1).Days);
            Console.WriteLine("Diferencia de días entre fechas (Hours):" + (fecha2 - fecha1).Hours);
            Console.WriteLine("Diferencia de días entre fechas (Minutes):" + (fecha2 - fecha1).Minutes);
            Console.WriteLine("Diferencia de días entre fechas (Seconds):" + (fecha2 - fecha1).Seconds);

            Console.WriteLine("\n************************************************\n");
            
            Console.WriteLine("Compara fecha1 y fecha 2 con Compare():" + DateTime.Compare(fecha1, DateTime.Now));

            Console.WriteLine("Compara fecha1 y fecha 2 con CompareTo():" + fecha1.CompareTo(fecha2));

            Console.ReadKey();

        }
    }
}
