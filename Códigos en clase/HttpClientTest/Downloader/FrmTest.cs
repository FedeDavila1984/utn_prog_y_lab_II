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

namespace Downloader
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void btnDescargar1_Click(object sender, EventArgs e)
        {
            this.Descargar(sender, txtUrl1.Text);
        }

        private void btnDescargar2_Click(object sender, EventArgs e)
        {
            this.Descargar(sender, txtUrl2.Text);
        }

        private void btnDescargar3_Click(object sender, EventArgs e)
        {
            this.Descargar(sender, txtUrl3.Text);
        }

        private void Descargar(object sender, string url)
        {
            Descargador d = new Descargador();
            d.FinDescarga += FinDescargaJson;
            d.ErrorDescarga += FinDescargaJson;
            d.Descargar(url, sender);
        }

        private void FinDescargaJson(string json, object originalSender)
        {
            if (originalSender == btnDescargar1)
                this.rtbResponse1.Text = json;
            else if (originalSender == btnDescargar2)
                this.rtbResponse2.Text = json;
            else if (originalSender == btnDescargar3)
                this.rtbResponse3.Text = json;
        }
    }
}
