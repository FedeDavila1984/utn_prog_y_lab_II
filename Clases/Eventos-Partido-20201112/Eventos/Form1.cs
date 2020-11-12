using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace Eventos
{
    public partial class Form1 : Form
    {
        Partido partido;
        Thread hilo;

        public Form1()
        {
            InitializeComponent();

            this.partido = new Partido();
            this.partido.AvisoGol += ActualizarMarcador;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.hilo = new Thread(this.partido.JugarPartido);
            this.hilo.Start();
        }

        private void ActualizarMarcador(string nombre)
        {
            if (listBox1.InvokeRequired)
            {
                AnotoGol del = new AnotoGol(ActualizarMarcador);
                this.Invoke(del, new object[] { nombre });
            }
            else
            { 
                listBox1.Items.Add(nombre);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.hilo.Abort();
        }
    }
}
