using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej._71
{
    public partial class FrmPrincipal : Form
    {
        FrmTestDelegados testDelegadosForm;
        FrmMostrar mostrarForm;
        FrmDatosAlumno datosAlumnoForm;
        FrmAltaAlumno altaAlumnoForm;

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

        private void tsiAlumno_Click(object sender, EventArgs e)
        {
            this.altaAlumnoForm = new FrmAltaAlumno();
            // Asigno un propietario
            this.altaAlumnoForm.Owner = this;
            // Asigno un contenedor
            this.altaAlumnoForm.MdiParent = this;
            // Muestro el formulario
            this.altaAlumnoForm.Show();
            // Habilito el menú Mostrar
            this.tsiDatosAlumno.Enabled = true;
        }

        private void datosAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.datosAlumnoForm = new FrmDatosAlumno();
            // Asigno un propietario
            this.datosAlumnoForm.Owner = this;
            // Asigno un contenedor
            this.datosAlumnoForm.MdiParent = this;
            // Muestro el formulario
            this.datosAlumnoForm.Show();
            // Asocio el evento de FrmAltaAlumno con el manejador de FrmDatosAlumno
            this.altaAlumnoForm.EventoActualizaAlumno += this.datosAlumnoForm.ActualizarAlumno;
        }
    }
}
