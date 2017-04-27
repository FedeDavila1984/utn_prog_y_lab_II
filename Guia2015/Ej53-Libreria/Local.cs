using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej53_Libreria
{
    public class Local : Llamada
    {
        protected float _costo;

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
        public Local(Llamada llamada, float costo)
            : this (llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }
        public Local(string origen, float duracion, string destino, float costo)
            : base (duracion, destino, origen)
        {
            this._costo = costo;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Retornará el valor de la llamada a partir de la duración y el costo de la misma
        /// </summary>
        /// <returns></returns>
        private float CalcularCosto()
        {
            return this._costo * base.Duracion;
        }
        /// <summary>
        /// Genera y retorna una cadena de texto con la información de la llamada.
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LLAMADA LOCAL");
            sb.Append(base.Mostrar());
            sb.AppendLine("Costo    : " + this.CostoLlamada);

            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public override bool Equals(object obj)
        {
            return (obj is Local);
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}
