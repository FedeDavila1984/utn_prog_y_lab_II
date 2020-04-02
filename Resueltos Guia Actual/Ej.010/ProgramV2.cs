using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._010
{
    class ProgramV2
    {
        static void Main(string[] args)
        {
            // Ingreso la cantidad de pisos de la torre
            Console.Write("Ingrese la cantidad de pisos de la torre: ");
            int alto;
            // Controlo que el valor ingresado sea numérico
            if (int.TryParse(Console.ReadLine(), out alto))
            {
                Console.WriteLine();
                Console.WriteLine();

                string aux = "*";
                // Recorro los pisos de la torre
                for (int i = 1; i <= alto; i++)
                {
                    Console.WriteLine(StringCentering(aux, (alto * 2)));

                    aux += "**";
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// StringCentering() takes two input values and it returns a formatted string.
        /// When length of s is greater than or equal to deisredLength, the function returns the original string.
        /// When length of s is smaller than desiredLength, it will be padded both ends.
        /// Due to character spacing is integer and there is no half-space, we can have an uneven split of space. In this implementation, the greater split goes to the leading end.
        /// The function requires .NET Framework due to PadLeft() and PadRight().
        /// In the last line of the function, binding is from left to right, so firstpad is applied followed by the desiredLength pad.
        /// https://stackoverflow.com/questions/644017/net-format-a-string-with-fixed-spaces
        /// </summary>
        /// <param name="s">Cadena a centrar</param>
        /// <param name="desiredLength">Ancho total pretendido</param>
        /// <returns></returns>
        static string StringCentering(string s, int desiredLength)
        {
            if(s.Length >= desiredLength)
            {
                return s;
            }
            int firstpad = (s.Length + desiredLength) / 2;
            return s.PadLeft(firstpad).PadRight(desiredLength);
        }
    }
}
