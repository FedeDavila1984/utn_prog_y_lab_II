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

namespace HilosEventos
{
    public partial class FrmTest : Form
    {
        Thread descarga;

        public FrmTest()
        {
            InitializeComponent();
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            Descargador d = new Descargador();
            // Suscribo mi evento
            //d.FinDescarga += this.ImprimirDescarga;
            //d.FinDescarga += this.ImprimirDescarga2;
            //d.FinDescarga += this.ImprimirDescarga3;

            if (this.descarga == null || !this.descarga.IsAlive) { 
                this.descarga = new Thread(new ParameterizedThreadStart(d.DescargarMaterial));
                // this.descarga.Start("http://www.loartesanalrock.com.ar/test-file.txt");
                this.descarga.Start("http://www.loartesanalrock.com.ar/a.txt");
                // rtbArchivo.Text = d.DescargarMaterial("http://www.loartesanalrock.com.ar/test-file.txt");
            }
        }

        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.descarga != null)
                this.descarga.Abort();
        }
        public string ImprimirDescarga2(string mensaje)
        {
            MessageBox.Show("ImprimirDescarga2");
            return "2";
        }
        public string ImprimirDescarga3(string mensaje)
        {
            MessageBox.Show("ImprimirDescarga3");
            return "3";
        }

        // CREADO EN DESCARGADOR -> public delegate void Callback(string mensaje);
        public string ImprimirDescarga(string mensaje)
        {
            // if (this.InvokeRequired)
            if (this.rtbArchivo.InvokeRequired)
            {
                Callback callback = new Callback(this.ImprimirDescarga);
                object[] args = new object[] { mensaje };

                this.Invoke(callback, args);
            }
            else
            {
                this.rtbArchivo.Text = mensaje;
            }
            return "1";
        }
    }
}
