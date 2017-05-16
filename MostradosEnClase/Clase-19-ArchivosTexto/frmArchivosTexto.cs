using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Clase_19_ArchivosTexto
{
    public partial class frmArchivosTexto : Form
    {
        public frmArchivosTexto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string[] DescripcionesDeArchivos = new string[]{ "Archivos de Texto", "Imagenes" };
            string[] ExtencionesDeArchivos = new string[]{ "txt", "jpg" };
            string NombreDelArchivo = "";

            string Filtro = "";
            //Agrego los filtros de selección de archivos
            for (int I = 0; I < DescripcionesDeArchivos.Length && I < ExtencionesDeArchivos.Length; I++)
                Filtro += DescripcionesDeArchivos[I] + " (*." + ExtencionesDeArchivos[I] + ")|*." + ExtencionesDeArchivos[I] + "|";
            //Agrego filtro para todos los archivos
            Filtro += "Todos los archivos (*.*)|*.*";
            //Cargo los filtros en el objeto
            ofdAbrir.Filter = Filtro;
            //Configuraciones restantes
            ofdAbrir.AddExtension = true;
            ofdAbrir.FilterIndex = 1;
            ofdAbrir.RestoreDirectory = true;
            ofdAbrir.FileName = NombreDelArchivo;

            //Si no cancelé
            if (ofdAbrir.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = ofdAbrir.FileName;
                btnMostrar.Enabled = true;
                btnGuardar.Enabled = true;
            }
            else
            {
                txtPath.Text = "";
                btnMostrar.Enabled = false;
                btnGuardar.Enabled = false;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                //Genero el stream
                FileStream Fs = new FileStream(txtPath.Text, FileMode.Open, FileAccess.Read);
                StreamReader Sr = new StreamReader(Fs);
                //Leo todo el archivo
                string Arch = Sr.ReadToEnd();
                //Cierro el archivo
                Sr.Close();
                Fs.Close();

                rtxtContenido.Text = Arch;
            }
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message, "Error en la ruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException fex)
            {
                MessageBox.Show(fex.Message, "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Busco el Path de una carpeta de sistema
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                // Tomo el nombre del archivo abierto
                string[] partes = txtPath.Text.Split(Path.DirectorySeparatorChar);
                string file = partes[partes.Length - 1];
                // Genero el nombre del archivo con su correspondiente Path
                string filePath = folder + Path.DirectorySeparatorChar + file;

                //Genero el stream
                FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                /*
                StreamWriter sw = new StreamWriter(fs);
                //Escrito todo el archivo
                sw.Write(rtxtContenido.Text);
                //Cierro el archivo
                sw.Close();
                fs.Close();
                 */

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(rtxtContenido.Text);
                }
            }
            catch (ArgumentException aex)
            {
                MessageBox.Show(aex.Message, "Error en la ruta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FileNotFoundException fex)
            {
                MessageBox.Show(fex.Message, "Archivo no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
