using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6
{
    public class OficinaArray
    {
        private Empleado[] _empleados;
        private int _piso;

        private OficinaArray(int cantidad)
        {
            this._empleados = new Empleado[cantidad];
        }

        public OficinaArray(int cantidad, int piso)
            : this(cantidad)
        {
            this._piso = piso;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Oficina Sita en Piso " + this._piso);
            foreach (Empleado e in this._empleados)
            {
                // Comparo si la referencia en memoria al objeto es null.
                if (!Object.ReferenceEquals(e, null))
                {
                    sb.AppendLine("- " + e.Mostrar());
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Agrega un Empleado a la Oficina, siempre y cuando haya lugar y el Empleado no se encuentre ya dentro de la misma.
        /// </summary>
        /// <param name="oficina"></param>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public static OficinaArray operator +(OficinaArray oficina, Empleado empleado)
        {
            // Variable donde guardaré el primer lugar libre que encuentre.
            int lugarLibre = -1;

            for (int i = 0; i < oficina._empleados.Length; i++)
            {
                // Comparo si la referencia en memoria al objeto es null.
                if (!Object.ReferenceEquals(oficina._empleados[i], null))
                {
                    // Si el empleado existe, salgo.
                    if (oficina._empleados[i] == empleado)
                        return oficina;
                }
                else
                {
                    // Me quedo con el primer lugar libre, null.
                    if (lugarLibre == -1)
                        lugarLibre = i;
                }
            }

            // Si el Empleado no existe y hay lugar libre, agrego.
            if (lugarLibre != -1)
                oficina._empleados[lugarLibre] = empleado;

            return oficina;
        }

        /// <summary>
        /// Quita un Empleado a la Oficina, siempre y cuando el Empleado se encuentre ya dentro de la misma.
        /// </summary>
        /// <param name="oficina"></param>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public static OficinaArray operator -(OficinaArray oficina, Empleado empleado)
        {
            for (int i = 0; i < oficina._empleados.Length - 1; i++)
            {
                // Comparo si la referencia en memoria al objeto es null.
                if (!Object.ReferenceEquals(oficina._empleados[i], null))
                {
                    // Si el empleado existe...
                    if (oficina._empleados[i] == empleado)
                    {
                        // ... elimino su referencia y salgo del lazo.
                        oficina._empleados[i] = null;
                        break;
                    }
                }
            }
            return oficina;
        }
    }
}
