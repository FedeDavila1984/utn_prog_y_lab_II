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

using Entidades;

namespace Carreras
{
    public partial class frmCarrera : Form
    {
        private List<Animal> carrera;
        private List<Thread> carreraHilos;

        public frmCarrera()
        {
            InitializeComponent();

            this.carrera = new List<Animal>();
            this.carreraHilos = new List<Thread>();
        }

        private void LimpiarCarriles()
        {
            this.FinalizarCarrera();

            carril1.Location = new Point(2, carril1.Location.Y);
            carril2.Location = new Point(2, carril2.Location.Y);
            carril3.Location = new Point(2, carril3.Location.Y);
            carril4.Location = new Point(2, carril4.Location.Y);

            this.carrera.Clear();
        }

        public void FinalizarCarrera()
        {
            foreach (Thread t in this.carreraHilos)
            {
                if(t.IsAlive)
                    t.Abort();
            }

            this.carreraHilos.Clear();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.LimpiarCarriles();

            //this.carrera.Add(new Humano(30, 1));
            //this.carrera.Add(new Humano(30, 2));
            //this.carrera.Add(new Humano(30, 3));
            //this.carrera.Add(new Humano(30, 4));
            this.carrera.Add(new Caballo("Silver", 30, 1));
            this.carrera.Add(new Caballo("Rocinante", 30, 2));
            this.carrera.Add(new Caballo("Pegaso", 30, 3));
            this.carrera.Add(new Caballo("Perdigón", 30, 4));

            foreach (Animal a in this.carrera)
            {
                a.AvisoAvance += this.Corren;
                this.carreraHilos.Add(new Thread(a.Correr));
            }
            // Para que no haya supuestas ventajas, inicio todos después
            foreach (Thread t in this.carreraHilos)
            {
                t.Start();
            }
        }

        private void HayGanador(int carril)
        {
            this.FinalizarCarrera();
            MessageBox.Show(String.Format("Ganador carril Nº {0}", carril),"GANADOR!", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            if (carril == nudCarril.Value)
            {
                MessageBox.Show("FELICITACIONES!!");
                lblTengo.Text = (int.Parse(lblTengo.Text) + (int)nudApuesta.Value).ToString();
            }
            else
            {
                MessageBox.Show("Será la próxima.");
                lblTengo.Text = (int.Parse(lblTengo.Text) - (int)nudApuesta.Value).ToString();
                if (int.Parse(lblTengo.Text) <= 0)
                {
                    MessageBox.Show("Chau!");
                    this.Close();
                }
            }
        }

        private void AnalizarCarrera(Caballitos.Caballito carril, int avance, int carrilNro)
        {
            int maximum = Screen.AllScreens[0].WorkingArea.Width - 180;
            int valor = 0;
            valor = carril.Location.X + avance;
            carril.MoverCaballito();
            if (valor <= maximum)
                carril.Location = new Point(valor, carril.Location.Y);
            else
            {
                carril.Location = new Point(maximum, carril.Location.Y);
                this.HayGanador(carrilNro);
            }
        }
        //delegate void CorrenCallback(int avance, int carril);
        private void Corren(int avance, int carril)
        {
            if (carril1.InvokeRequired)
            {
                AvisoAvanceCallback d = new AvisoAvanceCallback(Corren);
                object[] objs = new object[] { avance, carril };
                this.Invoke(d, objs);
            }
            else
            {
                switch (carril)
                {
                    case 1:
                        AnalizarCarrera(carril1, avance, carril);
                        break;
                    case 2:
                        AnalizarCarrera(carril2, avance, carril);
                        break;
                    case 3:
                        AnalizarCarrera(carril3, avance, carril);
                        break;
                    case 4:
                        AnalizarCarrera(carril4, avance, carril);
                        break;
                }
            }
        }
    }
}
