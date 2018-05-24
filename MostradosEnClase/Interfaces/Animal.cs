using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Interfaces
{
    abstract class Animal
    {
        public enum Sexo
        {
            Femenino,
            Masculino
        }
        protected Sexo sexo;
        private Point ubicacion;

        public Animal(Sexo sexo)
        {
            ubicacion = new Point(0, 0);
            this.sexo = sexo;
        }

        public Point GetUbicacion
        {
            get
            {
                return this.ubicacion;
            }
        }

        protected Point SetUbicacion
        {
            set
            {
                this.ubicacion = value;
            }
        }
    }
}
