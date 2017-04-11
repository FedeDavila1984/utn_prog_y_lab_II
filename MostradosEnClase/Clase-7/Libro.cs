using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    public class Libro
    {
        List<Pagina> paginas;

        public Libro()
        {
            this.paginas = new List<Pagina>();
        }

        public Libro(List<Pagina> paginas)
        {
            this.paginas = paginas;
        }

        /// <summary>
        /// Lista de páginas del libro.
        /// </summary>
        public List<Pagina> Paginas
        {
            get
            {
                return this.paginas;
            }
        }

        /// <summary>
        /// Altero o leo la página deseada.
        /// Índices apartir de 1.
        /// </summary>
        /// <param name="i">Índice de la página.</param>
        /// <returns>Página requerida, si existe.</returns>
        public Pagina this[int i]
        {
            get
            {
                if (i > 0 && i <= this.paginas.Count)
                    return this.paginas[i - 1];
                else
                    return new Pagina(i, "Página no encontrada");
            }
            set
            {
                if (i > 0 && i <= this.paginas.Count)
                    this.paginas[i - 1] = value;
            }
        }
    }
}
