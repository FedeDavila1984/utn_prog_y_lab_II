using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Metro
    {
        public double cantidad;

        private Metro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Conversión explicita del tipo double al tipo Objeto Metro
        /// </summary>
        /// <param name="cant">Cantidad de metros a convertir</param>
        /// <returns>Objeto Metro convertido</returns>
        public static explicit operator Metro(double cant)
        {
            Metro retValue = new Metro(cant);
            return retValue;
        }
        /// <summary>
        /// Conversión del tipo Objeto Metro al tipo double
        /// </summary>
        /// <param name="m">Objeto Metro a ser convertido</param>
        /// <returns>Cantidad de metros en double</returns>
        public static explicit operator double(Metro m)
        {
            return m.cantidad;
        }

        /// <summary>
        /// Suma Metros y Centimetros y retorna su resultado en Metros
        /// </summary>
        /// <param name="m">Objeto Metro para operar</param>
        /// <param name="c">Objeto Centimetro para operar</param>
        /// <returns>Objeto Centimetro sumado</returns>
        public static Metro operator +(Metro m, Centimetro c)
        {
            return (Metro)(((double)c / 100) + (double)m);
        }

        /// <summary>
        /// Decremento un Metro en 1 (una) unidad
        /// </summary>
        /// <param name="m">Objeto Metro para operar</param>
        /// <returns>Objeto Metro operado</returns>
        public static Metro operator --(Metro m)
        {
            return (Metro)((double)m - 1);
        }

    }
}
