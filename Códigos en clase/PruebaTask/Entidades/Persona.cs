using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private int pasosDados;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public int PasosDados { get => this.pasosDados; }

        public override string ToString()
        {
            return this.nombre;
        }

        public void Caminar(CancellationToken cancellationToken)
        {
            while(true)
            {
                pasosDados++;
                if (cancellationToken.IsCancellationRequested)
                    return;
                Thread.Sleep(1000);
            }
        }
    }
}
