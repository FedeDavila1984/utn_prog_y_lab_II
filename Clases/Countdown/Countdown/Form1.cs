using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Countdown
{
    public partial class Form1 : Form
    {
        DateTime fechaParcialProg, fechaFinalProg, fechaParcialLab, fechaFinalLab;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.fechaParcialProg = new DateTime(2019, 6, 26, 18, 30, 0);
            this.fechaFinalProg = new DateTime(2019, 7, 16, 18, 30, 0);

            this.fechaParcialLab = new DateTime(2019, 6, 27, 18, 30, 0);
            this.fechaFinalLab = new DateTime(2019, 7, 11, 18, 30, 0);

            this.ActualizarCuenta();
            this.Location = Screen.AllScreens[1].WorkingArea.Location;
            this.WindowState = FormWindowState.Maximized;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.ActualizarCuenta();
        }

        private void ActualizarCuenta()
        {
            TimeSpan matchCountdown = fechaParcialProg.Subtract(DateTime.Now);//.ToString("dd HH:MM:ss");
            lblParcialCountProg.Text = String.Format("{0} días\n{1} horas, {2} minutos, {3} segundos"
                , matchCountdown.Days
                , matchCountdown.Hours
                , matchCountdown.Minutes
                , matchCountdown.Seconds);

            matchCountdown = fechaFinalProg.Subtract(DateTime.Now);//.ToString("dd HH:MM:ss");
            lblFinalCountProg.Text = String.Format("{0} días\n{1} horas, {2} minutos, {3} segundos"
                , matchCountdown.Days
                , matchCountdown.Hours
                , matchCountdown.Minutes
                , matchCountdown.Seconds);

            matchCountdown = fechaParcialLab.Subtract(DateTime.Now);//.ToString("dd HH:MM:ss");
            lblParcialCountLab.Text = String.Format("{0} días\n{1} horas, {2} minutos, {3} segundos"
                , matchCountdown.Days
                , matchCountdown.Hours
                , matchCountdown.Minutes
                , matchCountdown.Seconds);

            matchCountdown = fechaFinalLab.Subtract(DateTime.Now);//.ToString("dd HH:MM:ss");
            lblFinalCountLab.Text = String.Format("{0} días\n{1} horas, {2} minutos, {3} segundos"
                , matchCountdown.Days
                , matchCountdown.Hours
                , matchCountdown.Minutes
                , matchCountdown.Seconds);
        }
    }
}
