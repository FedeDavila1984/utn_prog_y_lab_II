using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej._70
{
    public partial class FrmPrincipal : Form
    {
        FrmTestDelegados testDelegadosForm;
        FrmMostrar mostrarForm;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void tsiMostrar_Click(object sender, EventArgs e)
        {
            this.mostrarForm = new FrmMostrar();
            // Asigno un propietario
            this.mostrarForm.Owner = this;
            // Asigno un contenedor
            this.mostrarForm.MdiParent = this;
            // Muestro el formulario
            this.mostrarForm.Show();
            // Asocio los eventos de FrmTestDelegados con los manejadores de FrmMostrar
            this.testDelegadosForm.EventoActualizaNombre += this.mostrarForm.ActualizarNombre;
            this.testDelegadosForm.EventoActualizaImagen += this.mostrarForm.ActualizarFoto;
        }

        private void tsiTestDelegados_Click(object sender, EventArgs e)
        {
            this.testDelegadosForm = new FrmTestDelegados();
            // Asigno un propietario
            this.testDelegadosForm.Owner = this;
            // Asigno un contenedor
            this.testDelegadosForm.MdiParent = this;
            // Muestro el formulario
            this.testDelegadosForm.Show();
            // Habilito el menú Mostrar
            this.tsiMostrar.Enabled = true;
        }
    }
}
