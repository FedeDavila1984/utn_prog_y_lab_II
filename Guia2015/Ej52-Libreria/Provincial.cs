using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej52_Libreria
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1 = 99,
            Franja_2 = 125,
            Franja_3 = 66
        }
        protected Franja _franjaHoraria;

        #region Propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Costructores
        public Provincial(Franja miFranja, Llamada llamada)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this._franjaHoraria = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : this(miFranja, new Llamada(duracion, destino, origen))
        {
        }
        #endregion

        #region Métodos
        private float CalcularCosto()
        {
            return (((float)this._franjaHoraria) / 100) * base.Duracion;
        }
        /// <summary>
        /// Genera y retorna una cadena de texto con la información de la llamada.
        /// </summary>
        /// <returns></returns>
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LLAMADA PROVINCIAL");
            sb.Append(base.Mostrar());
            sb.AppendLine("Costo    : " + this.CostoLlamada);
            sb.AppendLine("Franja   : " + this._franjaHoraria.ToString());

            return sb.ToString();
        }
        #endregion
    }
}
