using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HilosEventos
{
    public delegate void Callback(string mensaje);

    internal class Descargador
    {
        public event Callback FinDescarga;

        public void DescargarMaterial(object url)
        {
            string aux = this.DescargarMaterial((string)url);

            // int a = true ? 1 : 2;
            // this.FinDescarga?.Invoke(aux);
            if (!object.ReferenceEquals(this.FinDescarga, null))
                this.FinDescarga.Invoke(aux);
        }

        public string DescargarMaterial(string url)
        {
            string aux;
            try
            {
                using (WebClient client = new WebClient())
                {
                    aux = client.DownloadString(url);
                }
            }
            catch (Exception e)
            {
                aux = e.Message;
            }

            return aux;
        }
    }
}
