using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_5_Igualdad_Objetos
{
    public class MiClase
    {
        public int miAlgo;

        public MiClase(int algo)
        {
            this.miAlgo = algo;
        }

        public static bool operator ==(MiClase clase1, MiClase clase2)
        {
            if (clase1.miAlgo == clase2.miAlgo)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(MiClase clase1, MiClase clase2)
        {
            return !(clase1 == clase2);
        }
    }
}
