using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesYConstructores
{
    public class MiClase
    {
        public static int otroatrib;
        public static int atributoStatic;
        private int x;

        private int y;
        private int z;

        static MiClase()
        {
            MiClase.atributoStatic = 10;
        }

        public MiClase(int x)
        {
            this.x = x;
        }

        public MiClase(int x, int y)
            : this(x)
        {
            this.y = y;
        }

        public MiClase(int x, int y, int z)
            : this(x, y)
        {
            this.z = z;
        }
    }
}
