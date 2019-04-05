using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6
{
    public class Empleado
    {
        string nombre;
        string apellido;

        public Empleado(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        {
            return this.apellido;
        }

        public string Mostrar()
        {
            return this.GetNombre() + " " + this.GetApellido();
        }
    }
}
