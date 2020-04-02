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
    public partial class FrmAltaAlumno : Form
    {
        public delegate void ActualizaAlumnoDelegate(Alumno alumno);
        public event ActualizaAlumnoDelegate EventoActualizaAlumno;

        public FrmAltaAlumno()
        {
            InitializeComponent();
        }

        private void FrmAltaAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int resultado;
            if (int.TryParse(this.txtDni.Text, out resultado))
            {
                Alumno a = new Alumno(this.txtNombre.Text, this.txtApellido.Text, resultado, this.txtFoto.Text);
                this.EventoActualizaAlumno(a);
            }
            else
            {
                MessageBox.Show("El DNI debe ser numérico.");
            }
        }

        private void lblFoto_DoubleClick(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Right)
            {
                this.openFileDialog.Filter = "Imágenes|*.jpg;*.gif;*.png;*.bmp|Todos|*.*";
                this.openFileDialog.Multiselect = false;
                if (this.openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.txtFoto.Text = this.openFileDialog.FileName;
                }
            }
        }
    }
}
