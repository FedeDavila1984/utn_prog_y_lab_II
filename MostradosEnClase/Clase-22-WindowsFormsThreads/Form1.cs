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

namespace WindowsFormsThreads
{
    public partial class Form1 : Form
    {
        Thread t;

        public Form1()
        {
            InitializeComponent();

            t = new Thread(this.barra1.CorrerBarra);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t.IsAlive)
            {
                BarraDeProgreso.Barra.Seguir = false;
                t.Abort();
            }
            else
            {
                t = new Thread(this.Animar);
                t.Start();
            }
        }

        private void Animar()
        {
            do
            {
                this.barra1.CorrerBarra();
                System.Threading.Thread.Sleep(50);
            } while (true);
        }
    }
}
