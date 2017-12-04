using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using System.Threading;

namespace Parcial_2_20170622
{
    public partial class frmPpal : Form
    {
        LosHilos hilos;
        public frmPpal()
        {
            InitializeComponent();

            hilos = new LosHilos();
            hilos.AvisoFin += this.MostrarMensajeFin;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                hilos += 1;
            }
            catch (CantidadInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(this.hilos.Bitacora);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
