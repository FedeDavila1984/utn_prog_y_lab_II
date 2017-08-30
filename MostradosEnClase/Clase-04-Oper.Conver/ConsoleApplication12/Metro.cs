using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Metro
    {
        public double cantidad;

        private Metro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public static explicit operator Metro(double cant)
        {
            Metro retValue = new Metro(cant);
            return retValue;
        }
        public static explicit operator double(Metro m)
        {
            return m.cantidad;
        }

        public static Metro operator +(Metro m, Centimetro c)
        {
            return (Metro)(((double)c / 100) + (double)m);
        }

    }
}
