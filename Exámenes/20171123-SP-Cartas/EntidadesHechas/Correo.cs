using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Quitar
using EntidadesAlumno;
using System.Threading;

namespace EntidadesHechas
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Paquete> paquetes;
        private List<Thread> mockPaquetes;

        public Correo()
        {
            paquetes = new List<Paquete>();
            mockPaquetes = new List<Thread>();
        }

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        #region AlumnoQuitar

        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete pAux in c.paquetes)
            {
                if (p == pAux)
                    throw new TrackingIdRepetidoException(string.Format("El Tracking ID {0} ya figura en la lista de envios.", p.TrackingID));
            }
            c.paquetes.Add(p);
            Thread t = new Thread(p.MockCicloDeVida);
            t.Start();
            c.mockPaquetes.Add(t);

            return c;
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            List<Paquete> l = (List<Paquete>)((Correo)elementos).paquetes;

            StringBuilder aux = new StringBuilder();
            foreach(Paquete p in l)
                aux.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));

            return aux.ToString();
        }

        public void FinEntregas()
        {
            foreach (Thread t in this.mockPaquetes)
            {
                if (t.IsAlive)
                    t.Abort();
            }
        }

        #endregion
    }
}
