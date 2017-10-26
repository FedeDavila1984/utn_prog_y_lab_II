using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSon
{
    class Pelicula
    {
        private string nombre;
        private DateTime fechaLanzamiento;
        private List<string> generos;

        public Pelicula()
        {
            this.generos = new List<string>();
        }

        public Pelicula(string nombre, DateTime lanzamiento, string genero)
        {
            this.nombre = nombre;
            this.fechaLanzamiento = lanzamiento;
            this.generos = new List<string>() { genero };
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public DateTime FechaLanzamiento
        {
            get
            {
                return this.fechaLanzamiento;
            }
            set
            {
                this.fechaLanzamiento = value;
            }
        }

        public List<string> Generos
        {
            get
            {
                return this.generos;
            }
            set
            {
                this.generos = value;
            }
        }

        public override string ToString()
        {
            string aux = "";
            foreach (string g in this.Generos)
            {
                aux += g + ", ";
            }
            return string.Format("{0} lanzada el {1}. Género: {2}", this.Nombre, this.FechaLanzamiento, aux);
        }
    }
}
