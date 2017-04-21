using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Polimorfismo_Libreria
{
    public abstract class Vehiculo
    {
        private int id;
        private string modelo;

        #region Constructores
        public Vehiculo(int id, string modelo)
        {
            this.id = id;
            this.modelo = modelo;
        }
        #endregion

        #region Propiedades
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Modelo
        {
            get
            {
                return this.modelo;
            }
            set
            {
                this.modelo = value;
            }
        }
        #endregion

        #region "Métodos Abstractos"
        public abstract string Encendido();
        #endregion

        #region "Métodos Virtuales"
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ID       : " + this.ID);
            sb.AppendLine("Modelo   : " + this.Modelo);
            sb.AppendLine("Encendido: " + this.Encendido());
            return sb.ToString();
        }
        #endregion
    }
}
