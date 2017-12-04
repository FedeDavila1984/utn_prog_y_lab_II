using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Interfaces;

namespace Entidades
{
    public class LosHilos : IRespuesta<int>
    {
        private List<InfoHilo> misHilos;
        private int id;

        public delegate void AvisoFinCallback(string mensaje);
        public event AvisoFinCallback AvisoFin;

        public LosHilos()
        {
            this.misHilos = new List<InfoHilo>();
            this.id = 0;
        }

        public string Bitacora
        {
            get
            {
                try
                {
                    string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar + "bitacora.txt";
                    using (System.IO.StreamReader file = new StreamReader(fullPath))
                    {
                        return file.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            set
            {
                try
                {
                    string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + Path.DirectorySeparatorChar + "bitacora.txt";
                    using (System.IO.StreamWriter file = new StreamWriter(fullPath, true))
                    {
                        file.WriteLine(value);
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        private static LosHilos AgregarHilo(LosHilos hilos)
        {
            hilos.id++;

            InfoHilo hilo = new InfoHilo(hilos.id, hilos);

            hilos.misHilos.Add(hilo);

            return hilos;
        }

        public void RespuestaHilo(int id)
        {
            string mensaje = String.Format("Terminó el hilo {0}.", id);
            try
            {
                this.Bitacora = mensaje;
            }
            catch (Exception)
            { }
            this.AvisoFin(mensaje);
        }

        public static LosHilos operator +(LosHilos hilos, int cantidad)
        {
            if (cantidad <= 0)
                throw new CantidadInvalidaException();

            for(int i = 0; i < cantidad; i++)
            {
                LosHilos.AgregarHilo(hilos);
            }
            return hilos;
        }
    }
}
