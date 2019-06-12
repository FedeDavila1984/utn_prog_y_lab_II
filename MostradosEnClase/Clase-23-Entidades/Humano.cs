using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Humano : Animal
    {
        private string nombre;
        private string apellido;
        private static int piernas;

        static Humano()
        {
            Humano.piernas = 2;
        }

        public Humano(string nombre, string apellido, int velocidadMaxima, int carril)
            : this(velocidadMaxima, carril)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public Humano(int velocidadMaxima, int carril)
            : base(Humano.piernas, velocidadMaxima, carril)
        {
        }

        public override void Correr()
        {
            Random dormirAvance = new Random();
            do
            {
                int avance = Animal.distanciaRecorrida.Next(1, base.VelocidadMaxima);
                base.LanzarAvisoAvance(avance, this.Carril);

                System.Threading.Thread.Sleep(dormirAvance.Next(50, 100));
            } while (true);
        }
    }
}
