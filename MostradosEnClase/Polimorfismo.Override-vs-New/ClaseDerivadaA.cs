using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Override_vs_New
{
    class ClaseDerivadaA : ClaseBase
    {
        public override string MetodoVirtual()
        {
            string aux = base.MetodoVirtual();
            return aux + "MetodoVirtual con OVERRIDE de ClaseDerivadaA.";
        }
    }
}
