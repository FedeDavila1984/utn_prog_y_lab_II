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

namespace Ej._62
{
    public partial class Form1 : Form
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Asigno la hora al inicio
            this.AsignarHora();
            // Sin Threads
            //this.EjecutarAsignarHoraPorSegundo();
            // Con Timer
            //this.timer1.Enabled = true;
            // Con Threads
            t = new Thread(new ParameterizedThreadStart(this.EjecutarAsignarHoraPorSegundo));
            t.Start(1000);
        }

        private void EjecutarAsignarHoraPorSegundo(object sleep)
        {
            do
            {
                this.AsignarHora();
                Thread.Sleep((int)sleep);
            } while (true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.AsignarHora();
        }

        private void AsignarHora()
        {
            if (this.lblHora.InvokeRequired)
            {
                this.lblHora.BeginInvoke((MethodInvoker)delegate() { this.lblHora.Text = DateTime.Now.ToString(); });
            }
            else
            {
                this.lblHora.Text = DateTime.Now.ToString(); ;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t.IsAlive)
                t.Abort();
        }
    }
}
