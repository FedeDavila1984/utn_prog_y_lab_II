using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Leon : Animal, IComportamientos
    {
        public Leon(Sexo sexo)
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

        public void Moverse(int x, int y, int z)
        {
            throw new NotImplementedException();
        }

        public void Atacar(Animal victima)
        {
            throw new NotImplementedException();
        }
    }
}
