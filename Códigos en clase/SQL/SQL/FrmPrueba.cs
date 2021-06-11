using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace SQL
{
    public partial class FrmPrueba : Form
    {
        ProductoDAO dao;

        public FrmPrueba()
        {
            InitializeComponent();
            this.dao = new ProductoDAO();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Producto> prods = this.dao.GetProductos();

                foreach (Producto p in prods)
                {
                    rtb.Text += p.ToString() + '\n';
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto p = new Producto(0, "Iosu");
                this.dao.Insert(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
