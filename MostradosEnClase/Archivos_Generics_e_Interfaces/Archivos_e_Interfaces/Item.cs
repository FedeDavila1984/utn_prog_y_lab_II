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
        public string _nombre;
        public short _edad;
        public float _promedio;

        public Item() { }

        public Item(string nombre,short edad,float promedio) : base()
        {
            this._nombre = nombre;
            this._edad = edad;
            this._promedio = promedio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("NOMBRE:   " + this._nombre);
            sb.AppendLine("EDAD:     " + this._edad);
            sb.AppendLine("PROMEDIO: " + this._promedio);
            return sb.ToString();
        }
    }
}
