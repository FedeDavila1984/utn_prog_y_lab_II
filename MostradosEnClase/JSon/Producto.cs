using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSon
{
    class Producto
    {
        private string nombre;
        private DateTime vencimiento;
        private string[] tamanios;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return this.vencimiento;
            }
            set
            {
                this.vencimiento = value;
            }
        }

        public string[] Tamanios
        {
            get
            {
                return this.tamanios;
            }
            set
            {
                this.tamanios = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", this.Nombre, this.Vencimiento);
        }
    }
}
