using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guía2015
{
    public class Conversor
    {
        /// <summary>
        /// Convertir un decimal a una cadena de caracteres binaria
        /// </summary>
        /// <param name="numero">Número decimal a ser convertido.</param>
        /// <returns>Cadena binaria</returns>
        public static string DecimalBinario(double numero)
        {
            string binario = "";
            do
            {
                if ((numero % 2) == 0)
                    binario = "0" + binario;
                else
                    binario = "1" + binario;
                numero = (int)(numero / 2);
            } while (numero > 0);
            return binario;
        }

        /// <summary>
        /// Convertir una cadena de caracteres binaria a decimal
        /// </summary>
        /// <param name="binario">Cadena binaria a ser convertida.</param>
        /// <returns>Número decimal convertido. En caso de no poder, retornará 0.</returns>
        public static double BinarioDecimal(string binario)
        {
            double numero = 0;
            int b;
            // Recorro la cadena de atrás hacia adelante.
            for (int i = binario.Length - 1; i >= 0; i--)
            {
                // Compruebo que sea un binario (1 o 0), sino la cadena no es válida.
                if (int.TryParse(binario[binario.Length - i - 1].ToString(), out b))
                {
                    numero += b * Math.Pow(2, i);
                }
                else
                {
                    return 0;
                }
            }
            return numero;
        }
    }
}
