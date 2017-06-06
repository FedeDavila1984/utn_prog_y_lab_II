using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Animal
    {
        private int _cantidadPatas;
        private int _velocidadMaxima;

        private int _carril;
        protected static Random distanciaRecorrida;

        public delegate void AvisoAvanceCallback(int avance, int carril);
        public event AvisoAvanceCallback AvisoAvance;

        public abstract void Correr();

        static Animal()
        {
            distanciaRecorrida = new Random();
        }

        public Animal(int cantidadPatas, int velocidadMaxima, int carril)
        {
            this.CantidadPatas = cantidadPatas;
            this.VelocidadMaxima = velocidadMaxima;
            this._carril = carril;
        }

        public int Carril
        {
            get
            {
                return this._carril;
            }
        }

        public int CantidadPatas
        {
            get
            {
                return this._cantidadPatas;
            }
            set
            {
                if (value > 4)
                    value = 4;
                this._cantidadPatas = value;
            }
        }

        public int VelocidadMaxima
        {
            get
            {
                return this._velocidadMaxima;
            }
            set
            {
                if (value > 100)
                    value = 100;
                this._velocidadMaxima = value;
            }
        }

        protected void LanzarAvisoAvance(int avance, int carril)
        {
            this.AvisoAvance(avance, carril);
        }
    }
}
