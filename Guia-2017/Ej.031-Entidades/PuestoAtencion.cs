using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._031_Entidades
{
    public class PuestoAtencion
    {
        public enum Puesto
        {
            Caja1, Caja2
        }

        private Puesto puesto;
        private static int numeroActual;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        /// <summary>
        /// Retorna el numero a asignarle al cliente que ingresará en la cola
        /// </summary>
        public static int NumeroActual
        {
            get
            {
                //PuestoAtencion.numeroActual++;
                return ++PuestoAtencion.numeroActual;
            }
        }

        public bool Atender(Cliente cli)
        {
            // Duermo la ejecución durante 2 segundos
            System.Threading.Thread.Sleep(2000);
            return true;
        }
    }
}
