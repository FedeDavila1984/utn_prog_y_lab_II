using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._68
{
    public delegate void DelegadoString(string msg);

    public class Persona
    {
        public event DelegadoString EventoString;

        private string nombre;
        private string apellido;

        public Persona()//string nombre, string apellido)
        {
            //this.nombre = nombre;
            //this.apellido = apellido;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
                this.EventoString(this.nombre);
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
                this.EventoString(this.apellido);
            }
        }

        public string Mostrar()
        {
            return string.Format("{0} {1}", this.nombre, this.apellido);
        }
    }
}
