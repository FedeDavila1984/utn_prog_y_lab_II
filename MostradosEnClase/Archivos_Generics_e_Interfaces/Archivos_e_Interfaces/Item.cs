using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos_e_Interfaces
{
    [Serializable]
    public class Item
    {
        public string nombre;
        public short edad;
        public float promedio;

        public Item() { }

        public Item(string nombre,short edad,float promedio) : base()
        {
            this.nombre = nombre;
            this.edad = edad;
            this.promedio = promedio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE:   " + this.nombre);
            sb.AppendLine("EDAD:     " + this.edad);
            sb.AppendLine("PROMEDIO: " + this.promedio);
            return sb.ToString();
        }
    }
}
