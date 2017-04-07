using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6
{
    public class Empleado
    {
        string _nombre;
        string _apellido;

        public Empleado(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public string GetNombre()
        {
            return this._nombre;
        }

        public string GetApellido()
        {
            return this._apellido;
        }

        public string Mostrar()
        {
            return this.GetNombre() + " " + this.GetApellido();
        }
    }
}
