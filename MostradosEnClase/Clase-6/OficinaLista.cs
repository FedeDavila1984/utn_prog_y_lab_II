using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6
{
    public class OficinaLista
    {
        private List<Empleado> empleados;
        private int piso;
        private int cantidad;

        private OficinaLista(int cantidad)
        {
            this.empleados = new List<Empleado>();
            this.cantidad = cantidad;
        }

        public OficinaLista(int cantidad, int piso)
            : this(cantidad)
        {
            this.piso = piso;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Oficina Sita en Piso " + this.piso);
            foreach (Empleado e in this.empleados)
            {
                sb.AppendLine("- " + e.Mostrar());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Agrega un Empleado a la Oficina, siempre y cuando haya lugar y el Empleado no se encuentre ya dentro de la misma.
        /// </summary>
        /// <param name="oficina"></param>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public static OficinaLista operator +(OficinaLista oficina, Empleado empleado)
        {
            foreach (Empleado e in oficina.empleados)
            {
                // Si el empleado existe...
                if (e == empleado)
                {
                    return oficina;
                }
            }

            oficina.empleados.Add(empleado);

            return oficina;
        }

        /// <summary>
        /// Quita un Empleado a la Oficina, siempre y cuando el Empleado se encuentre ya dentro de la misma.
        /// </summary>
        /// <param name="oficina"></param>
        /// <param name="empleado"></param>
        /// <returns></returns>
        public static OficinaLista operator -(OficinaLista oficina, Empleado empleado)
        {
            foreach (Empleado e in oficina.empleados)
            {
                // Si el empleado existe...
                if (e == empleado)
                {
                    oficina.empleados.Remove(e);
                    break;
                }
            }

            return oficina;
        }

    }
}
