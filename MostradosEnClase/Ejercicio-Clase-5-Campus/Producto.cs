using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_5_Campus
{
    public class Producto
    {
        protected string _marca;
        protected string _codigoDeBarra;
        protected float _precio;

        public Producto(string marca, string codigo, float precio)
        {
            this._marca = marca;
            this._codigoDeBarra = codigo;
            this._precio = precio;
        }

        /// <summary>
        /// Publicará en formato de texto los datos del Producto
        /// </summary>
        /// <param name="p">Producto a mostrar</param>
        /// <returns>Cadena de Texto con los datos del Producto</returns>
        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Marca {0}",p._marca));
            sb.AppendLine(String.Format("Código de Barra {0}", p._codigoDeBarra));
            sb.AppendLine(String.Format("Precio {0}", p._precio));
            return sb.ToString();
        }

        /// <summary>
        /// Compara dos objetos Producto, considerandolos iguales si tienen la misma marca y el mismo código de barras
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1._marca == p2._marca && p1._codigoDeBarra == p2._codigoDeBarra)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Compara dos objetos Producto, considerandolos distintos si NO tienen la misma marca y el mismo código de barras
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Compara si un Producto es de una cierta marca
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator ==(Producto p1, string marca)
        {
            return (p1._marca == marca);
        }
        /// <summary>
        /// Compara si un Producto NO es de una cierta marca
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }

        /// <summary>
        /// Conversión explicita al tipo string.
        /// Uso: string s = (string)miProducto;
        /// </summary>
        /// <param name="p"></param>
        /// <returns>Código de Barras del Producto.</returns>
        public static explicit operator string (Producto p)
        {
            return p._codigoDeBarra;
        }
    }
}
