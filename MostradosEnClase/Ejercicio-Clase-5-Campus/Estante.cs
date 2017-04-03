using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Clase_5_Campus
{
    public class Estante
    {
        protected int _ubicacion;
        protected int _capacidad;
        protected Producto[] _productos;

        /// <summary>
        /// Constructor privado, sólo inicializa el array de productos con una cantidad de espacios dada
        /// </summary>
        /// <param name="capacidad">Tamaño fijo del Array de productos</param>
        private Estante(int capacidad)
        {
            this._productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this._capacidad = capacidad;
            this._ubicacion = ubicacion;
        }

        /// <summary>
        /// Retornará el Array de productos del estante
        /// </summary>
        /// <returns></returns>
        public Producto[] GetProductos()
        {
            return this._productos;
        }

        /// <summary>
        /// Publicará en formato de texto los datos del estante
        /// </summary>
        /// <param name="e">Estante a mostrar</param>
        /// <returns>Cadena de Texto con los datos del Estante</returns>
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad: " + e._capacidad);
            foreach (Producto p in e._productos)
            {
                if ( !(((Object)p) == null) )
                {
                    sb.AppendLine(Producto.MostrarProducto(p));
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Comprueba si un Estante ya contiene un Producto.
        /// </summary>
        /// <param name="est"></param>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static bool operator ==(Estante est, Producto prod)
        {
            foreach (Producto p in est._productos)
            {
                if (!Object.ReferenceEquals(null, p))
                {
                    if (p == prod)
                        return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Comprueba si un Estante NO contiene un Producto.
        /// </summary>
        /// <param name="est"></param>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static bool operator !=(Estante est, Producto prod)
        {
            return !(est == prod);
        }

        /// <summary>
        /// Agrega un Producto a un Estante, siempre y cuando este producto no esté ya en dicho estante y haya luguar.
        /// </summary>
        /// <param name="est"></param>
        /// <param name="prod"></param>
        /// <returns>True si pudo agregar. False en caso contrario.</returns>
        public static bool operator +(Estante est, Producto prod)
        {
            // Reutilizo la sobrecarga del operador !=
            if (est != prod)
            {
                // Busco un lugar libre ...
                for (int i = 0; i < est._productos.Length; i++)
                {
                    if (Object.ReferenceEquals(null, est._productos[i]))
                    {
                        // ... De encontrarlo, agrego el producto
                        est._productos[i] = prod;
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Quita un Producto de un Estante, si es que este es parte de dicho Estante.
        /// </summary>
        /// <param name="est"></param>
        /// <param name="prod"></param>
        /// <returns></returns>
        public static Estante operator -(Estante est, Producto prod)
        {
            for (int i = 0; i < est._productos.Length; i++)
            {
                Producto p = est._productos[i];
                if (!p.Equals(null))
                {
                    if (p == prod)
                    {
                        est._productos[i] = null;
                        break;
                    }
                }
            }

            return est;
        }
    }
}
