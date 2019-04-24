using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_10_Ejemplo_PPT
{
    public partial class FrmTransparente : Form
    {
        public FrmTransparente()
        {
            InitializeComponent();
        }

        private void btnTocame_Click(object sender, EventArgs e)
        {
            C r1 = new C();
            C r2 = new C_Derivada();

            r1.N(1, 2);
            r2.N(1, 2);

            MessageBox.Show("Soy transparente!");
        }
    }
}
