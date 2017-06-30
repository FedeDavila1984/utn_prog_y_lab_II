using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_25_Extension
{
    public sealed class ClaseSellada
    {
        private int id;
        public ClaseSellada(int id)
        {
            this.id = id;
        }

        public int ID
        {
            get
            {
                return this.id;
            }
        }
    }
}
