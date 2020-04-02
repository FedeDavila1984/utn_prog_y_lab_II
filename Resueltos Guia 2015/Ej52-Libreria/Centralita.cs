using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej52_Libreria
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Propiedades
        /// <summary>
        /// Retorna la lista de llamadas de la central
        /// </summary>
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        /// <summary>
        /// Retorna las ganancias en la central sólo para llamadas Locales
        /// </summary>
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        /// <summary>
        /// Retorna las ganancias en la central sólo para llamadas Provinciales
        /// </summary>
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        /// <summary>
        /// Retorna las ganancias en la central para todas las llamadas
        /// </summary>
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        #endregion

        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Recibe un Enumerado de tipo TipoLlamada y retornará el valor de lo recaudado, según el criterio elegido.
        /// </summary>
        /// <param name="tipo">Criterio para la suma de las ganancias.</param>
        /// <returns></returns>
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float total = 0;
            // Recorro la lista de llamadas.
            foreach (Llamada l in this.listaDeLlamadas)
            {
                // Según el tipo de llamada que quiero analizar, opero.
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        // Si el TipoLlamada es Local y la clase es del tipo Local...
                        if (l is Local)
                            total += ((Local)l).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        // Si el TipoLlamada es Provincial y la clase es del tipo Provincial...
                        if (l is Provincial)
                            total += ((Provincial)l).CostoLlamada;
                        break;
                    case Llamada.TipoLlamada.Todas:
                        // Si el TipoLlamada es Todas y verifico el tipo de la llamada para castear.
                        if (l is Local)
                            total += ((Local)l).CostoLlamada;
                        else if (l is Provincial)
                            total += ((Provincial)l).CostoLlamada;
                        break;
                }
            }

            return total;
        }
        /// <summary>
        /// Genera y retorna una cadena de texto con la información de la central.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CENTRAL  : " + this.razonSocial);
            sb.AppendLine("*******************************************");

            sb.AppendLine("GANANCIAS");
            sb.AppendLine("TOTALES      : " + this.GananciasPorTotal);
            sb.AppendLine("LOCALES      : " + this.GananciasPorLocal);
            sb.AppendLine("PROVINCIALES : " + this.GananciasPorProvincial);

            sb.AppendLine("*******************************************");
            sb.AppendLine("DETALLE DE LLAMADAS");
            foreach (Llamada l in this.listaDeLlamadas)
            {
                if(l is Local)
                    sb.AppendLine(((Local)l).Mostrar());
                else if (l is Provincial)
                    sb.AppendLine(((Provincial)l).Mostrar());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion
    }
}
