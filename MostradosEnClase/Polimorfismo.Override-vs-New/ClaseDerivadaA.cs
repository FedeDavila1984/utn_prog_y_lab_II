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
            return "MetodoVirtual con OVERRIDE de ClaseDerivadaA.";
        }
    }
}
