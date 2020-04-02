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
    public partial class FrmTestDelegados : Form
    {
        public delegate void ActualizaNombreDelegate(string dato);
        public event ActualizaNombreDelegate EventoActualizaNombre;
        public event ActualizaNombreDelegate EventoActualizaImagen;

        private string imagePath;

        public FrmTestDelegados()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.EventoActualizaNombre.Invoke(this.txtDatos.Text);

            this.EventoActualizaImagen.Invoke(this.imagePath);
        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Filter = "Imágenes|*.jpg;*.gif;*.png;*.bmp|Todos|*.*";
            this.openFileDialog.Multiselect = false;
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.imagePath = this.openFileDialog.FileName;
            }
        }

        private void FrmTestDelegados_Load(object sender, EventArgs e)
        {
            this.openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }
    }
}
