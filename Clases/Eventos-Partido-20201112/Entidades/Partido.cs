using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void AnotoGol(string quienAnota);
    public class Partido
    {
        public event AnotoGol AvisoGol;
        private List<string> goleadores;

        public Partido()
        {
            this.AvisoGol += this.MarcoGol;
            this.goleadores = new List<string>();
        }

        public void JugarPartido()
        {
            while (true) {
                Thread.Sleep(new Random().Next(2000, 7000));
                if (!object.ReferenceEquals(this.AvisoGol, null)) { // this.avisoGol != null) { 
                    this.AvisoGol.Invoke("Salvio");
                }
            }
        }

        public void MarcoGol(string nombre)
        {
            this.goleadores.Add(nombre);
        }
    }
}
