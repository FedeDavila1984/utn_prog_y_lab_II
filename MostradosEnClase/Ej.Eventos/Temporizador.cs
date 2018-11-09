using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Eventos
{
    public delegate void TempDelegado();
    public class Temporizador
    {
        private int interval;
        private bool isCorriendo;
        public event TempDelegado evento;
        
        public Temporizador(int interval)
        {
            this.isCorriendo = false;
            this.interval = interval;
        }

        public void Run()
        {
            this.isCorriendo = true;
            do
            {
                System.Threading.Thread.Sleep(this.interval);
                this.evento();
            } while (this.isCorriendo);
        }
    }
}
