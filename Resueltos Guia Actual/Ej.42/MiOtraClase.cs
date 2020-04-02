using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._42
{
    class MiOtraClase
    {
        /// <summary>
        /// d.	Luego crear un método de instancia que capture la excepción anterior.
        /// Este método generará una excepción propia llamada MiException y la lanzará.
        /// </summary>
        public void MiMetodoInstancia()
        {
            try
            {
                new MiClaseErrores(0);
            }
            catch (UnaException e)
            {
                MiException ex = new MiException("MiOtraClase Exception", e);
                throw ex;
            }
        }
    }
}
