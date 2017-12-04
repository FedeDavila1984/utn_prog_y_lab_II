using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CantidadInvalidaException : Exception
    {
        public CantidadInvalidaException() : base("La cantidad debe ser de al menos uno (1).") { }
    }
}
