using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public interface IArchivos<T>
    {
        T Leer(string path);
        void Guardar(string path, T datos);
    }
}
