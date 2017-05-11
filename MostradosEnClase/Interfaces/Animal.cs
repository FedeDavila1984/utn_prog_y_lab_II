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
        private Point posicion;

        public Animal(Sexo sexo)
        {
            posicion = new Point(0, 0);
            this.sexo = sexo;
        }

        public Point Posicion
        {
            get
            {
                return this.posicion;
            }
        }
    }
}
