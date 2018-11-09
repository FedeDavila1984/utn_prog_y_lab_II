using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej.Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Temporizador t = new Temporizador(1000);
            t.evento += T_evento;
            System.Threading.Thread hilo = new System.Threading.Thread(t.Run);
            hilo.Start();
        }

        private void T_evento()
        {
            if (this.lblMostrar.InvokeRequired)
            {
                TempDelegado d = new TempDelegado(T_evento);
                this.Invoke(d);
            }
            else
            {
                this.lblMostrar.Text = DateTime.Now.ToString();
            }
        }
    }
}
