using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Clase_05
{
    public class Estante
    {
        private int ubicacionEstante;
        private Producto[] productos;

        /// <summary>
        /// Inicializo un nuevo estante, inicializando la lista según una capacidad.
        /// </summary>
        /// <param name="capacidad">Cantidad de productos que podrá contener el estante.</param>
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        /// <summary>
        /// Inicializo un nuevo Estante, asignando los atributos capacidad y ubicación
        /// </summary>
        /// <param name="capacidad">Cantidad de productos que podrá contener el estante.</param>
        /// <param name="ubicacion">Código de ubicación del Estante</param>
        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        /// <summary>
        /// Publico la lista de Productos
        /// </summary>
        /// <returns></returns>
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        /// <summary>
        /// Muestro los datos del estante elegido
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("======================ESTANTE======================");
            sb.AppendLine("UBICACION: " + e.ubicacionEstante);
            sb.AppendLine("CAPACIDAD: " + e.productos.Length);
            sb.AppendLine("PRODUCTOS:");
            foreach (Producto p in e.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(p));
            }

            return sb.ToString();
        }

        /// <summary>
        /// Analizo si el Producto está en el Estante
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns>True si el Producto está en el Estante</returns>
        public static bool operator ==(Estante e, Producto p)
        {
            // Recorro la lista de productos del estante...
            foreach (Producto aux in e.productos)
            {
                // Valido que la posición del Array no sea null
                if (!object.ReferenceEquals(aux, null))
                {
                    // Utilizo la sobrecarga del == de Producto
                    if (p == aux)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Analizo si el Producto NO está en el Estante
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns>True si el Producto NO está en el Estante</returns>
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        /// <summary>
        /// Agrego un Producto al Estante, si hay lugar y no hay uno igual ya cargado
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator +(Estante e, Producto p)
        {
            // Si el Estante no contiene el Producto...
            if (e != p)
            {
                // Recorro la lista de productos del estante...
                for (int i = 0; i < e.productos.Length; i++ )
                {
                    // Busco un espacio vacio
                    if (object.ReferenceEquals(e.productos[i], null))
                    {
                        e.productos[i] = p;
                        // Si agregué, rompo el lazo para no volver a agregarlo.
                        return true;
                    }
                }
            }
            // Si no salió hasta acá es porque no agregó el ítem
            return false;
        }

        /// <summary>
        /// Quito un Producto del Estante
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Estante operator -(Estante e, Producto p)
        {
            // Recorro la lista de productos del estante...
            for (int i = 0; i < e.productos.Length; i++)
            {
                // Valido que la posición del Array no sea null
                if (!object.ReferenceEquals(e.productos[i], null))
                {
                    // Utilizo la sobrecarga del == de Producto
                    if (p == e.productos[i])
                    {
                        // Vacio el espacio que ocupaba dicho Producto
                        e.productos[i] = null;
                        // Rompo el lazo
                        break;
                    }
                }
            }
            return e;
        }
    }
}
