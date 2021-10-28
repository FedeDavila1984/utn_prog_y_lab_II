using System;
using System.Threading;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms;

namespace View
{
    public partial class FrmCaminata : Form
    {
        CancellationTokenSource tokenSource;
        Persona persona;

        public FrmCaminata()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.tokenSource = new CancellationTokenSource();
            CancellationToken token = this.tokenSource.Token;

            this.persona = new Persona("Marcela");
            Task tarea = Task.Run(() => { this.persona.Caminar(token); });

            label1.Text = string.Format("Inicia a las {0}", DateTime.Now.ToString("HH: mm: ss"));

            btnConsultar.Enabled = true;
            btnFinalizar.Enabled = true;
            btnIniciar.Enabled = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            this.tokenSource.Cancel();

            label1.Text = string.Format("Finaliza a las {0} con {1} pasos.", DateTime.Now.ToString("HH:mm:ss"), this.persona.PasosDados);

            btnConsultar.Enabled = false;
            btnFinalizar.Enabled = false;
            btnIniciar.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            label2.Text = string.Format("Lleva a las {0} {1} pasos.", DateTime.Now.ToString("HH:mm:ss"), this.persona.PasosDados);
        }
    }
}
