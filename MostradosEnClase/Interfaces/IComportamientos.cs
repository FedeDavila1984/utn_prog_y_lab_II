using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IComportamientos
    {
        Animal.Sexo Sexo
        {
            get;
            set;
        }
        void Moverse(int x, int y);
        void Atacar(Animal victima);
    }
}
