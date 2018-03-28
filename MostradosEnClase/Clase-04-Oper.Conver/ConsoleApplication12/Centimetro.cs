using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Centimetro
    {
        public double cantidad;

        private Centimetro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Conversión implicita del tipo double al tipo Objeto Centimetro
        /// </summary>
        /// <param name="cant">Cantidad de centimetros a convertir</param>
        /// <returns>Objeto Centimetro convertido</returns>
        public static implicit operator Centimetro(double cant)
        {
            Centimetro retValue = new Centimetro(cant);
            return retValue;
        }
        /// <summary>
        /// Conversión del tipo Objeto Centimetro al tipo double
        /// </summary>
        /// <param name="c">Objeto Centimetro a ser convertido</param>
        /// <returns>Cantidad de centimetros en double</returns>
        public static implicit operator double(Centimetro c)
        {
            return c.cantidad;
        }

        /// <summary>
        /// Suma Centimetros y Metros y retorna su resultado en Centimetros
        /// </summary>
        /// <param name="c">Objeto Centimetro para operar</param>
        /// <param name="m">Objeto Metro para operar</param>
        /// <returns>Objeto Centimetro sumado</returns>
        public static Centimetro operator +(Centimetro c, Metro m)
        {
            return (Centimetro)((double)c + ((double)m * 100));
        }

        /// <summary>
        /// Incremento un Centimetro
        /// </summary>
        /// <param name="c">Objeto Centimetro para operar</param>
        /// <returns>Objeto Centimetro operado</returns>
        public static Centimetro operator ++(Centimetro c)
        {
            return (Centimetro)((double)c + 1);
        }
    }
}
