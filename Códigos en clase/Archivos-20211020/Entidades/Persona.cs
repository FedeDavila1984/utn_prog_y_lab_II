using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private int edad;
        private bool vive;

        public string Nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }
        public int Edad
        {
            get => this.edad;
            set => this.edad = value;
        }
        public bool Vive
        {
            get => this.vive;
            set => this.vive = value;
        }
    }
}
