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
using System.Text.Json;

namespace Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Persona> personas = new List<Persona>();
            Persona p1 = new Persona();
            p1.Nombre = "Pepe";
            p1.Edad = 93;
            p1.Vive = false;
            Persona p2 = new Persona();
            p2.Nombre = "Lola";
            p2.Edad = 23;
            p2.Vive = true;

            personas.Add(p1);
            personas.Add(p2);

            string json = JsonSerializer.Serialize(personas);

            richTextBox1.Text = json;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Persona> personas = JsonSerializer.Deserialize<List<Persona>>(richTextBox1.Text);

            richTextBox1.Text = "";
            foreach (Persona p in personas)
            {
                richTextBox1.Text += p.Nombre + '\n';
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                List<Persona> personas = Persona.GetLista();

                foreach (Persona p in personas)
                {
                    richTextBox1.Text += p.Nombre + '\n';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                Persona.Delete(nudId.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
