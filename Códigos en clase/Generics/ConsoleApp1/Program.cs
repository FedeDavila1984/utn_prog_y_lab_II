using System;
using Generics;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            It personaIt = new It();
            personaIt.nombre = "Algun nombre";
            Personal<It> personal = new Personal<It>(new List<It> { personaIt });
            Personal<Persona> personal2;

            List<It> empleados = personal.Empleados;
            personal += new It();



            Personal<It> personal3 = personal.Metodo<string>("", 0);











            List<string> listast;
            Queue<Persona> colaPersona;













            It it = new It();
            Perro perro = new Perro();

            List<IArchivos<string>> lista = new List<IArchivos<string>>();

            lista.Add(it);
            lista.Add(perro);

            foreach (IArchivos<string> elem in lista)
            {
                elem.Guardar("", "");
            }
        }
    }

}
