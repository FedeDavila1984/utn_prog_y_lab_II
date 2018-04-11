using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private static float cotizRespectoDolar;
        private double cantidad;

        static Pesos()
        {
            Pesos.cotizRespectoDolar = 17.55f;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, float cotizacion)
            : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public static float GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        #region Conversiones
        public static implicit operator Pesos(double d)
        {
            Pesos aux = new Pesos(d);
            return aux;
        }

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.cantidad / Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p); //.cantidad / Pesos.GetCotizacion());
        }
        #endregion

        #region Operaciones
        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos aux = new Pesos(p.cantidad + ((Pesos)e).cantidad);
            return aux;
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos aux = new Pesos(p.cantidad + ((Pesos)d).cantidad);
            return aux;
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos aux = new Pesos(p.cantidad - ((Pesos)e).cantidad);
            return aux;
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos aux = new Pesos(p.cantidad - ((Pesos)d).cantidad);
            return aux;
        }
        #endregion

        #region Comparaciones
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.cantidad == p2.cantidad;
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Pesos p, Euro e)
        {
            return p == (Pesos)e;
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Pesos p, Dolar d)
        {
            return p == (Pesos)d;
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        #endregion
    }
}
