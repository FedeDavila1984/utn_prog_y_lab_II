using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Clase_05
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
        /// Hago público el atributo Marca
        /// </summary>
        /// <returns></returns>
        public string GetMarca()
        {
            return this.marca;
        }
        /// <summary>
        /// Hago público el atributo Precio
        /// </summary>
        /// <returns></returns>
        public float GetPrecio()
        {
            return this.precio;
        }

        /// <summary>
        /// Muestro los datos del Producto elegido
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MARCA : " + p.marca);
            sb.AppendLine("CODIGO: " + p.codigoDeBarra);
            sb.AppendLine("PRECIO: " + p.precio);

            return sb.ToString();
        }

        /// <summary>
        /// Hago público el atributo Código de Barras de un Producto
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
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

        /// <summary>
        /// Comparo un Producto con su Marca
        /// </summary>
        /// <param name="p"></param>
        /// <param name="marca"></param>
        /// <returns>True si Marca son iguales</returns>
        public static bool operator ==(Producto p, string marca)
        {
            if (p.marca == marca)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Comparo un Producto con su Marca
        /// </summary>
        /// <param name="p"></param>
        /// <param name="marca"></param>
        /// <returns>True si Marca son distintos</returns>
        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }
    }
}
