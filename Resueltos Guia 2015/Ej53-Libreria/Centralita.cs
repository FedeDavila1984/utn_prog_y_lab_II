using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej53_Libreria
{
    public class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;

        #region Propiedades
        /// <summary>
        /// Retorna la lista de llamadas de la central
        /// </summary>
        public List<Llamada> Llamadas
        {
            get
            {
                return this._listaDeLlamadas;
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
            this._listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;
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
            foreach (Llamada l in this._listaDeLlamadas)
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
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CENTRAL  : " + this._razonSocial);
            sb.AppendLine("*******************************************");

            sb.AppendLine("GANANCIAS");
            sb.AppendLine("TOTALES      : " + this.GananciasPorTotal);
            sb.AppendLine("LOCALES      : " + this.GananciasPorLocal);
            sb.AppendLine("PROVINCIALES : " + this.GananciasPorProvincial);

            sb.AppendLine("*******************************************");
            sb.AppendLine("DETALLE DE LLAMADAS");
            foreach (Llamada llamada in this._listaDeLlamadas)
            {
                sb.AppendLine(llamada.ToString());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this._listaDeLlamadas.Add(nuevaLlamada);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            foreach(Llamada l in c.Llamadas)
            {
                if(llamada == l)
                    return true;
            }
            return false;
        }
        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            if (c != nuevaLlamada)
                c.AgregarLlamada(nuevaLlamada);
            return c;
        }

        #endregion
    }
}
