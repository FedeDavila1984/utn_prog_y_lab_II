using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Override_vs_New
{
    class ClaseDerivadaB : ClaseBase
    {
        public ClaseDerivadaB(int i, float f)
            : base()
        { }

        public new string MetodoVirtual()
        {
            return "MetodoVirtual con NEW de ClaseDerivadaB.";
        }
    }
}
