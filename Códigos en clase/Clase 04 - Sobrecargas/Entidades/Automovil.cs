using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil
    {
        public int velocidadActual;
        public Marca marca;

        #region Constructores
        public Automovil()
            : this(1)
        { }

        public Automovil(int velocidadInicial)
        {
            this.velocidadActual = velocidadInicial;
        }

        public Automovil(string velocidadInicial)
            : this(int.Parse(velocidadInicial))
        {
        }

        public Automovil(string marca, int velocidadInicial)
            : this (new Marca(marca), velocidadInicial)
        {
        }

        public Automovil(Marca marca, int velocidadInicial)
            : this(velocidadInicial)
        {
            this.marca = marca;
        }
        #endregion

        /// <summary>
        /// Acelera el Automovil de 1 unidad a la vez
        /// </summary>
        public void Acelerar()
        {
            this.velocidadActual++;
        }

        /// <summary>
        /// Acelera el Automovil en la cantidad de unidades indicadas
        /// </summary>
        /// <param name="incremento">Unidades de aceleracion</param>
        public void Acelerar(int incremento)
        {
            this.velocidadActual += incremento;
        }

        public static Automovil operator +(Automovil a, int incremento)
        {
            a.velocidadActual += incremento;
            return a;
        }

        public static bool operator == (Automovil a, int velocidad)
        {
            return a.velocidadActual == velocidad;
        }
        public static bool operator !=(Automovil a, int velocidad)
        {
            return !(a == velocidad);
        }

        public static explicit operator int (Automovil a)
        {
            return a.velocidadActual;
        }
    }
}
