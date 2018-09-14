using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_8_Libreria
{
    public class Pagina
    {
        int numero;
        string contenido;

        public Pagina(int numero, string contenido)
        {
            this.Numero = numero;
            this.Contenido = contenido;
        }

        #region "Propiedades"
        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                if(value<100)
                    this.numero = value;
            }
        }
        public string Contenido
        {
            get
            {
                return this.contenido;
            }
            set
            {
                this.contenido = value;
            }
        }
        #endregion

        /// <summary>
        /// Convierto un objeto Página en un String.
        /// </summary>
        /// <param name="pagina">Página a convertir.</param>
        /// <returns>Contenido de la página.</returns>
        public static explicit operator string (Pagina pagina)
        {
            return pagina.contenido;
        }
    }
}
