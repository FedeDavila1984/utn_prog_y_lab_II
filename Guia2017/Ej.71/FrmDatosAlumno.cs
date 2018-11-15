using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Ej._71.Entidades;

namespace Ej._71
{
    public partial class FrmDatosAlumno : FrmAltaAlumno
    {
        public FrmDatosAlumno()
        {
            InitializeComponent();
        }

        private void FrmDatosAlumno_Load(object sender, EventArgs e)
        {

        }

        public void ActualizarAlumno(Alumno alumno)
        {
            base.txtNombre.Text = alumno.Nombre;
            base.txtApellido.Text = alumno.Apellido;
            base.txtDni.Text = alumno.DNI.ToString();
            this.picture.ImageLocation = alumno.RutaDeLaFoto;
            base.txtFoto.Text = alumno.RutaDeLaFoto;
        }
    }
}
