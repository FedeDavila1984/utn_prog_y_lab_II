using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class It : Persona, IArchivos<It>, IArchivos<string>
    {
        public void Guardar(string path, It datos)
        {
            throw new NotImplementedException();
        }

        public void Guardar(string path, string datos)
        {
            throw new NotImplementedException();
        }

        public It Leer(string path)
        {
            throw new NotImplementedException();
        }

        string IArchivos<string>.Leer(string path)
        {
            throw new NotImplementedException();
        }
    }
}
