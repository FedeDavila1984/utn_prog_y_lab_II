using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Billetes;

namespace Ej._023
{
    public partial class FrmMonedas : Form
    {
        public FrmMonedas()
        {
            InitializeComponent();

            txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotizacionPesos.Text = Pesos.GetCotizacion().ToString();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (txtCotizacionEuro.Enabled)
            {
                btnLockCotizacion.Image = imageList.Images[0];
                txtCotizacionEuro.Enabled = false;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPesos.Enabled = false;
            }
            else
            {
                btnLockCotizacion.Image = imageList.Images[1];
                txtCotizacionEuro.Enabled = true;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPesos.Enabled = true;
            }
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(txtCotizacionEuro.Text, out aux))
                Euro.SetCotizacion(aux);
            else
                txtCotizacionEuro.Focus();
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(txtCotizacionDolar.Text, out aux))
                Dolar.SetCotizacion(aux);
            else
                txtCotizacionDolar.Focus();
        }

        private void txtCotizacionPesos_Leave(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(txtCotizacionPesos.Text, out aux))
                Pesos.SetCotizacion(aux);
            else
                txtCotizacionPesos.Focus();
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(txtEuro.Text, out aux)) {
                Euro moneda = new Euro(aux);
                txtEuroAEuro.Text = moneda.GetCantidad().ToString();
                txtEuroADolar.Text = ((Dolar)moneda).GetCantidad().ToString();
                txtEuroAPeso.Text = ((Pesos)moneda).GetCantidad().ToString();
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(txtDolar.Text, out aux))
            {
                Dolar moneda = new Dolar(aux);
                txtDolarAEuro.Text = ((Euro)moneda).GetCantidad().ToString(); 
                txtDolarADolar.Text = moneda.GetCantidad().ToString();
                txtDolarAPeso.Text = ((Pesos)moneda).GetCantidad().ToString();
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(txtPeso.Text, out aux))
            {
                Pesos moneda = new Pesos(aux);
                txtPesoAEuro.Text = ((Euro)moneda).GetCantidad().ToString();
                txtPesoADolar.Text = ((Dolar)moneda).GetCantidad().ToString();
                txtPesoAPeso.Text = moneda.GetCantidad().ToString();
            }
        }
    }
}
