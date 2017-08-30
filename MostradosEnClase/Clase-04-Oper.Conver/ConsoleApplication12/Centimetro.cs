using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Centimetro
    {
        public double cantidad;

        private Centimetro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static implicit operator Centimetro(double cant)
        {
            Centimetro retValue = new Centimetro(cant);
            return retValue;
        }
        public static implicit operator double(Centimetro m)
        {
            return m.cantidad;
        }

        public static Centimetro operator +(Centimetro c, Metro m)
        {
            return (Centimetro)((double)c + ((double)m * 100));
        }
    }
}
