using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Polimorfismo_Libreria
{
    public class Automovil : Vehiculo
    {
        private string chapaPatente;

        public Automovil(int id, string modelo, string chapaPatente)
            : base(id, modelo)
        {
            this.chapaPatente = chapaPatente;
        }

        public override string Encendido()
        {
            return "Encendido por chispa de bujía.";
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.Mostrar());
            sb.AppendLine("Patente  : " + this.chapaPatente);
            return sb.ToString();
        }
    }
}
