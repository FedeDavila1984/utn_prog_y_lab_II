using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Perro : IArchivos<string>
    {
        public void Guardar(string path, string datos)
        {
            throw new NotImplementedException();
        }

        public string Leer(string path)
        {
            throw new NotImplementedException();
        }
    }
}
