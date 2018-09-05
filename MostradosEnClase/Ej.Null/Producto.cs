using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Null
{
    public class Producto
    {
        private string marca;
        private string codigoDeBarra;
        private float precio;

        /// <summary>
        /// Inicializo un nuevo Producto, asignando todos sus atributos
        /// </summary>
        /// <param name="marca">Marca comercial del Producto</param>
        /// <param name="codigo">Código de Barras del Producto</param>
        /// <param name="precio">Valor comercial del Producto</param>
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        /// <summary>
        /// Comparo dos objetos Producto a través de su Marca y Código de Barras
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>True si Marca y Código de Barras son iguales</returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Comparo dos objetos Producto a través de su Marca y Código de Barras
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns>True si Marca y Código de Barras son distintos</returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
