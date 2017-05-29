using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej54_Libreria
{
    [Serializable]
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
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion

        #region Costructores
        public Provincial()
        {
        }

        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this._franjaHoraria = miFranja;
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
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LLAMADA PROVINCIAL");
            sb.Append(base.Mostrar());
            sb.AppendLine("Costo    : " + this.CostoLlamada);
            sb.AppendLine("Franja   : " + this._franjaHoraria.ToString());

            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public override bool Equals(object obj)
        {
            return (obj is Provincial);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
