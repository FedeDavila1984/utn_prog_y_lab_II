using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej54_Libreria
{
    public class CentralitaException : Exception
    {
        string nombreClase;
        string nombreMetodo;

        public Exception ExcepcionInterna
        {
            get
            {
                return this.InnerException;
            }
        }

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public CentralitaException(string mensaje, string clase, string metodo)
            : this(mensaje, clase, metodo, null)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
        }
    }
}
