using System.Threading;

namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private int pasosDados;

        public event CaminoDelegate EventoCamino;

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
                this.pasosDados++;

                if (cancellationToken.IsCancellationRequested)
                    return;

                if (!(this.EventoCamino is null))
                    this.EventoCamino.Invoke(this.pasosDados);

                Thread.Sleep(1000);
            }
        }
    }
}
