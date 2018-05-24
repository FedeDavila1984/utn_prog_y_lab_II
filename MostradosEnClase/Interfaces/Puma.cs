using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Interfaces
{
    class Puma : Animal, IComportamientos
    {
        public Puma(Sexo sexo)
            : base(sexo)
        {
        }

        public Sexo Sexo
        {
            get
            {
                return base.sexo;
            }
            set
            {
                base.sexo = value;
            }
        }
        
        /// <summary>
        /// Un Puma no podrá moverse más de 10 posiciones en x e y al mismo tiempo
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Moverse(int x, int y)
        {
            if ((x + y) <= (this.GetUbicacion.X + this.GetUbicacion.Y + 10))
            base.SetUbicacion = new Point(x, y);
        }

        public void Atacar(Animal victima)
        {
            throw new NotImplementedException();
        }
    }
}
