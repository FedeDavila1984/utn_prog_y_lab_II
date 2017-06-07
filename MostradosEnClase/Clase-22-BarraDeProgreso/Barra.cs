using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarraDeProgreso
{
    public partial class Barra: UserControl
    {
        private static bool seguir;
        short incrementoBarra;

        public Barra()
        {
            InitializeComponent();

            this.progressBar1.Value = 0;
            incrementoBarra = 10;
        }

        public static bool Seguir
        {
            get
            {
                return Barra.seguir;
            }
            set
            {
                Barra.seguir = value;
            }
        }

        public ProgressBar LaBarra
        {
            get
            {
                return this.progressBar1;
            }
        }

        delegate void CorrenCallback();
        public void CorrerBarra()
        {
            //Barra.seguir = true;
            //do
            //{
                if (this.progressBar1.InvokeRequired)
                {
                    CorrenCallback d = new CorrenCallback(this.CorrerBarra);
                    this.Invoke(d);
                }
                else
                {
                    this.progressBar1.Value += incrementoBarra;

                    // Invierto a valor
                    if (this.progressBar1.Value == this.progressBar1.Maximum || this.progressBar1.Value == this.progressBar1.Minimum)
                        incrementoBarra *= -1;
                }
            //} while (Barra.seguir);
        }
    }
}
