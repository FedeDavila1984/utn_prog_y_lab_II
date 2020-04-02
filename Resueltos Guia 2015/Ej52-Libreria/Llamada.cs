using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej52_Libreria
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }

        #region Constructores
        public Llamada (float duracion, string nroDestino, string nroOrigen)
        {
            this._duracion = duracion;
            this._nroDestino = nroDestino;
            this._nroOrigen = nroOrigen;
        }
        #endregion

        #region Propiedades
        public float Duracion
        {
            get
            {
                return this._duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this._nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this._nroOrigen;
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Genera y retorna una cadena de texto con la información de la llamada.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Duración : " + this._duracion);
            sb.AppendLine("Origen   : " + this._nroOrigen);
            sb.AppendLine("Destino  : " + this._nroDestino);

            return sb.ToString();
        }

        /// <summary>
        /// Compara dos llamadas a través de su duración.
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns>Retornará 1 si la duración de Llamada1 es mayor, -1 si la duración de Llamada2 es mayor y 0 si son iguales.</returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
                return 1;
            else if (llamada1.Duracion < llamada2.Duracion)
                return -1;
            else
                return 0;
        }
        #endregion
    }
}
