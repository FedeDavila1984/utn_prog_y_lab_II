using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17
{
    public class ClaseGenerica<T, U, V>
        where T : MetodosGenericos, new()
        //where U : MetodosGenericos
        //where T : new()
    {
        public ClaseGenerica<T, U, V> MetodoConElTipo(ClaseGenerica<T, U, V> cg)
        {
            return cg;
        }
    }
}
