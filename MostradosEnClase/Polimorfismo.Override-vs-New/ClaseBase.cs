using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Override_vs_New
{
    abstract class ClaseBase
    {
        public virtual string MetodoVirtual()
        {
            return "MetodoVirtual de ClaseBase.";
        }
    }
}
