using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class miFormulario : Form
    {
        public miFormulario()
        {
            InitializeComponent();
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            string a = txtTextBox1.Text;
            string b = txtTextBox2.Text;

            MessageBox.Show(a + b);

            txtTextBox1.Text = txtTextBox2.Text;
        }

        private void txtTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.cambiaTextBox((TextBox)sender);
        }

        private void txtTextBox2_TextChanged(object sender, EventArgs e)
        {
            this.cambiaTextBox(txtTextBox2);
        }

        private void cambiaTextBox(TextBox t)
        {
            lblMensajes.Text = string.Format("Estás escribiendo en {0}.\nLlevás {1} caracteres escritos.", t.Name, t.Text.Length);
        }

    }
}
