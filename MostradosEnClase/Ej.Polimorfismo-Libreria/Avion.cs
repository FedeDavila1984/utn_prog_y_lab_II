using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Polimorfismo_Libreria
{
    public class Avion : Vehiculo
    {
        public Avion(int id, string modelo)
            : base(id, modelo)
        {

        }
        public Avion(Vehiculo v)
            : this(v.ID, v.Modelo)
        {

        }

        public override string Encendido()
        {
            return "Encendido por chispa de magneto.";
        }
    }
}
