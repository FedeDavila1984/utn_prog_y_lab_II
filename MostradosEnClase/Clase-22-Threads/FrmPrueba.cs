using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace Clase_22_Threads
{
    public partial class FrmPrueba : Form
    {
        private Thread miHiloCaballo;
        private Thread miHiloBarra;

        public FrmPrueba()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (this.miHiloCaballo != null && this.miHiloCaballo.IsAlive)
            {
                this.miHiloCaballo.Abort();
            }
            else
            {
                this.miHiloCaballo = new Thread(this.AnimarCaballito);
                this.miHiloCaballo.Start();
            }
        }

        private void AnimarCaballito()
        {
            do
            {
                caballito1.MoverCaballito();
                Thread.Sleep(45);
            } while (true);
        }

        private void FrmPrueba_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.miHiloCaballo != null && miHiloCaballo.IsAlive)
                miHiloCaballo.Abort();
            if (this.miHiloBarra != null && miHiloBarra.IsAlive)
                miHiloBarra.Abort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.miHiloBarra != null && this.miHiloBarra.IsAlive)
            {
                this.miHiloBarra.Abort();
            }
            else
            {
                this.miHiloBarra = new Thread(this.AnimarBarra);
                this.miHiloBarra.Start();
            }
        }

        private void AnimarBarra()
        {
            do
            {
                this.barra1.CorrerBarra();
                Thread.Sleep(45);
            } while (true);
        }
    }
}
