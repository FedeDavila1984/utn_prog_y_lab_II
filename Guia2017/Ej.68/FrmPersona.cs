using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej._68
{
    public partial class FrmPersona : Form
    {
        private Persona persona;

        public FrmPersona()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (object.ReferenceEquals(persona, null))
            {
                this.btnCrear.Text = "Actualizar";
                this.persona = new Persona(); // this.txtNombre.Text, this.txtApellido.Text);
                this.persona.EventoString += NotificarCambio;
            }

            if (this.txtNombre.Text.CompareTo(this.persona.Nombre) != 0)
            {
                this.persona.Nombre = this.txtNombre.Text;
            }
            if (this.txtApellido.Text.CompareTo(this.persona.Apellido) != 0)
            {
                this.persona.Apellido = this.txtApellido.Text;
            }

            MessageBox.Show(this.persona.Mostrar());
        }

        public void NotificarCambio(string cambio)
        {
            MessageBox.Show(cambio);
        }
    }
}
