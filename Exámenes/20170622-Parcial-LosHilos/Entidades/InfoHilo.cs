using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using Interfaces;

namespace Entidades
{
    public class InfoHilo
    {
        private IRespuesta<int> callback;
        private static Random randomizer;
        private int id;
        private Thread hilo;

        static InfoHilo()
        {
            InfoHilo.randomizer = new Random();
        }

        public InfoHilo(int id, IRespuesta<int> callback)
        {
            this.id = id;
            this.callback = callback;
            this.hilo = new Thread(this.Ejecutar);
            this.hilo.Start();
        }

        private void Ejecutar()
        {
            Thread.Sleep(InfoHilo.randomizer.Next(1000, 5000));
            this.callback.RespuestaHilo(this.id);
        }
    }
}
