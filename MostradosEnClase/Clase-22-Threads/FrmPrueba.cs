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
        Thread miHilo;

        public FrmPrueba()
        {
            InitializeComponent();

            this.miHilo = new Thread(this.AnimarCaballito);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (this.miHilo.IsAlive)
            {
                this.miHilo.Abort();
            }
            else
            {
                this.miHilo = new Thread(this.AnimarCaballito);
                this.miHilo.Start();
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
            if (miHilo.IsAlive)
                miHilo.Abort();
        }

    }
}
