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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.tokenSource = new CancellationTokenSource();
            CancellationToken token = this.tokenSource.Token;

            this.CaminandoEvent(0);

            this.persona = new Persona("Marcela");
            this.btnConsultar_Click(sender, e);

            // Asocio el evento con su manejador
            this.persona.EventoCamino += CaminandoEvent;
            this.persona.EventoCamino += CaminandoEvent1;
            // Corro el Task
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

        private void CaminandoEvent(int pasos)
        {
            // MessageBox.Show(pasos.ToString());
            if (this.pgbMovimiento.InvokeRequired)
            {
                CaminoDelegate del = new CaminoDelegate(this.CaminandoEvent);
                object[] args = new object[] { pasos };
                // Invoco al hilo principal
                this.pgbMovimiento.Invoke(del, args);
            }
            else
            {
                this.pgbMovimiento.Value = pasos;
                if (this.pgbMovimiento.Maximum == pasos)
                    this.pgbMovimiento.Maximum += 10;
            }
        }

        private void CaminandoEvent1(int pasos)
        {
            if (pasos == 2)
            { 
                MessageBox.Show(pasos.ToString());
                this.persona.EventoCamino -= CaminandoEvent1;
            }
        }
    }
}
