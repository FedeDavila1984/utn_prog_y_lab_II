using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        public void Moverse(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void Atacar(Animal victima)
        {
            throw new NotImplementedException();
        }
    }
}
