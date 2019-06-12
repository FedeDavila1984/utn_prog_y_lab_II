using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo : Animal
    {
        private string nombre;
        private static int patas = 4;

        static Caballo()
        {
            Caballo.patas = 2;
        }

        public Caballo(string nombre, int velocidadMaxima, int carril)
            : base(Caballo.patas, velocidadMaxima, carril)
        {
            this.nombre = nombre;
        }

        public override void Correr()
        {
            Random dormirAvance = new Random();
            do
            {
                int avance = Animal.distanciaRecorrida.Next(10, base.VelocidadMaxima);
                base.LanzarAvisoAvance(avance, this.Carril);

                System.Threading.Thread.Sleep(dormirAvance.Next(50, 100));
            } while (true);
            //return ;
        }
    }
}
