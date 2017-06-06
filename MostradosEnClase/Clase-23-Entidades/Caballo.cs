using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Caballo : Animal
    {
        private string _nombre;
        private static int _patas = 4;

        static Caballo()
        {
            Caballo._patas = 2;
        }

        public Caballo(string nombre, int velocidadMaxima, int carril)
            : base(Caballo._patas, velocidadMaxima, carril)
        {
            this._nombre = nombre;
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
