using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EntidadesHechas;
using EntidadesAlumno;

namespace _20171123_SP_Cartas
{
    public partial class FrmPpal : Form
    {
        Correo correo;

        public FrmPpal()
        {
            InitializeComponent();

            correo = new Correo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete paq = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
            paq.InformaEstado += paq_InformaEstado;
            try
            {
                correo += paq;
            }
            catch (TrackingIdRepetidoException te)
            {
                MessageBox.Show(te.Message, "Paquete repetido", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            this.ActualizarEstados();
        }

        void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke( d, new object[] {sender, e} );
            }
            else
                ActualizarEstados();
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostrar<List<Paquete>>)correo);
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostrar<Paquete>)lstEstadoEntregado.SelectedItem);
        }

        private void MostrarInformacion<T>(IMostrar<T> elemento)
        {
            if(!object.ReferenceEquals(elemento, null))
            {
                this.rtbMostrar.Text = elemento.MostrarDatos(elemento);
                this.rtbMostrar.Text.Guardar("salida.txt");
            }
        }

        private void ActualizarEstados()
        {
            // Limpio las listas
            lstEstadoIngresado.Items.Clear();
            lstEstadoEnViaje.Items.Clear();
            lstEstadoEntregado.Items.Clear();

            foreach (Paquete item in correo.Paquetes)
            {
                switch (item.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        lstEstadoIngresado.Items.Add(item);
                        break;
                    case Paquete.EEstado.EnViaje:
                        lstEstadoEnViaje.Items.Add(item);
                        break;
                    case Paquete.EEstado.Entregado:
                        lstEstadoEntregado.Items.Add(item);
                        break;
                }
            }
        }
    }
}
