using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Quitar
using EntidadesAlumno;

namespace EntidadesHechas
{
    public class Paquete : IMostrar<Paquete> //Quitar
    {
        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformaEstado;

        public enum EEstado
        {
            Ingresado, EnViaje, Entregado
        }

        private string direccionEntrega;
        private string trackingID;
        private EEstado estado;

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.trackingID == p2.trackingID);
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        #region AlumnoQuitar
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            return string.Format("{0} para {1}", p.trackingID, p.direccionEntrega);
        }

        public void MockCicloDeVida()
        {
            do
            {
                System.Threading.Thread.Sleep(1000);
                this.estado++;

                InformaEstado(this, new EventArgs());
            } while (this.estado != EEstado.Entregado);
            // Guardo en la base
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception)
            {
                
            }
        }
        #endregion
    }
}
