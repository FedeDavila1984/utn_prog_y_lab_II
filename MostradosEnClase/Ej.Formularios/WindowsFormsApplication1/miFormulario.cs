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

            switch(cmbOperadores.SelectedItem)
            {       
                case "+":
                    MessageBox.Show(a + b);
                    break;
                case "-":
                    // Busco la aparición de la cadena B en la cadena A
                    MessageBox.Show(a.IndexOf(b).ToString());
                    break;
                default:
                    txtTextBox1.Text = txtTextBox2.Text;
                    break;
            }
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
