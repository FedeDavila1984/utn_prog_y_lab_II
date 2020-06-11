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

namespace Threads
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
            // ParameterizedThreadStart pts = new ParameterizedThreadStart(AlterarLabel);
            ThreadStart ts = new ThreadStart(ActualizarHora);
            this.t = new Thread(ts); // pts);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.t.ThreadState == ThreadState.Unstarted)
            {
                this.t.Start();
            }
        }

        public void ActualizarHora()
        {
            do
            {
                this.AlterarLabel(DateTime.Now);
                Thread.Sleep(200);
            } while (true);
        }

        delegate void DelegadoParaAlterarLabel(object t);
        public void AlterarLabel(object texto)
        {
            if (this.label1.InvokeRequired)
            {
                DelegadoParaAlterarLabel aux = new DelegadoParaAlterarLabel(AlterarLabel);
                Object[] obj = new Object[] { texto };
                this.BeginInvoke(aux, obj);
            } else { 
                this.label1.Text = texto.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if(this.t.ThreadState != ThreadState.Aborted)
            if (this.t.IsAlive)
            {
                this.t.Abort();
            }
        }
    }
}
