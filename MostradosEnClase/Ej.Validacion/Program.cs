using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;

namespace Ej.Validacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string valido = "2-123-45";
            string invalido = "22-123-5";

            Console.WriteLine("Validos:");
            Console.WriteLine("Simple: {0}", Program.ValidarStringSimple(valido));
            Console.WriteLine("Split: {0}", Program.ValidarStringSplit(valido));
            Console.WriteLine("Regular Expression: {0}", Program.ValidarStringRegEx(valido));

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Invalidos:");
            Console.WriteLine("Simple: {0}", Program.ValidarStringSimple(invalido));
            Console.WriteLine("Split: {0}", Program.ValidarStringSplit(invalido));
            Console.WriteLine("Regular Expression: {0}", Program.ValidarStringRegEx(invalido));

            Console.ReadKey();
        }

        static bool ValidarStringSimple(string aux)
        {
            // Valido tamaño
            if (aux.Length == 8)
            {
                for (int i = 0; i < aux.Length; i++)
                {
                    // Valido posición de los guiones
                    if (i == 1 || i == 5)
                    {
                        if (aux[i] != '-')
                            return false;
                    }
                    else
                    {
                        // Valido posición de los números
                        if (!char.IsNumber(aux[i]))
                            return false;
                    }

                }
                return true;
            }
            return false;
        }

        static bool ValidarStringSplit(string aux)
        {
            // Valido tamaño
            if (aux.Length == 8)
            {
                // Separo la cadena de texto apartir de sus guiones
                string[] spliteado = aux.Split('-');
                // Valido que tenga 3 y sólo 3 partes, lo cual equivale a los guiones en el medio del texto
                if (spliteado.Length == 3)
                {
                    // Valido que cada parte tenga el tamaño deseado
                    if (spliteado[0].Length == 1 && spliteado[1].Length == 3 && spliteado[2].Length == 2)
                    {
                        int s;
                        // Valido que todas las partes sean numéricas
                        if(int.TryParse(spliteado[0], out s) && int.TryParse(spliteado[1], out s) && int.TryParse(spliteado[2], out s))
                            return true;
                    }
                }
            }
            return false;
        }

        static bool ValidarStringRegEx(string aux)
        {
            // Creo el patrón indicando que tendrá 1 dígito (d{1}) luego guión, luego 3 dígitos, luego guión, luego 2 dígitos
            string patron = "^\\d{1}-\\d{3}-\\d{2}$";
            if (Regex.IsMatch(aux, patron))
            {
                return true;
            }
            return false;
        }
    }
}
