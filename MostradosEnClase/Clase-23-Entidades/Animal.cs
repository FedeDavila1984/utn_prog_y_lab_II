using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void AvisoAvanceCallback(int avance, int carril);

    public abstract class Animal
    {
        private int cantidadPatas;
        private int velocidadMaxima;

        private int carril;
        protected static Random distanciaRecorrida;

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
            this.carril = carril;
        }

        public int Carril
        {
            get
            {
                return this.carril;
            }
        }

        public int CantidadPatas
        {
            get
            {
                return this.cantidadPatas;
            }
            set
            {
                if (value > 4)
                    value = 4;
                this.cantidadPatas = value;
            }
        }

        public int VelocidadMaxima
        {
            get
            {
                return this.velocidadMaxima;
            }
            set
            {
                if (value > 100)
                    value = 100;
                this.velocidadMaxima = value;
            }
        }

        protected void LanzarAvisoAvance(int avance, int carril)
        {
            this.AvisoAvance.Invoke(avance, carril);
        }
    }
}
