using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDialogs
{
    public partial class frmFormPpal : Form
    {
        public frmFormPpal()
        {
            InitializeComponent();
        }

        private void btnFormDialog_Click(object sender, EventArgs e)
        {
            frmFormSecundario form = new frmFormSecundario();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtRespuesta.Text = form.TextoCargado;
            }
        }
    }
}
