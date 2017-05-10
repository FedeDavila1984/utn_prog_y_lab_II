using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManejoDeErrores
{
    class MiClaseException : Exception
    {
        
        /// <summary>
        /// CONSTRUCTOR POR DEFECTO
        /// </summary>
        public MiClaseException():base()
        {
        }
    
        /// <summary>
        /// PASO EL MENSAJE DE ERROR PERSONALIZADO
        /// </summary>
        /// <param name="mensaje">MENSAJE DE ERROR PERSONALIZADO</param>
        public MiClaseException(string mensaje) : base(mensaje) 
        { 
        }

        /// <summary>
        /// PASO EL MENSAJE DE ERROR PERSONALIZADO
        /// Y LA CLASE QUE PROVOCO LA EXCEPCION
        /// </summary>
        /// <param name="mensaje">MENSAJE DE ERROR PERSONALIZADO</param>
        /// <param name="origenError">CLASE QUE PROVOCO LA EXCEPCION</param>
        public MiClaseException(string mensaje,string origenError)
            : base(mensaje)
        {
            base.Source = origenError;
        }

        /// <summary>
        /// PASO EL MENSAJE DE ERROR PERSONALIZADO
        /// Y LA EXCEPCION 
        /// </summary>
        /// <param name="mensaje">MENSAJE DE ERROR PERSONALIZADO</param>
        /// <param name="innerException">EXCEPCION</param>
        public MiClaseException(string mensaje, Exception innerException)
            : base(mensaje, innerException) 
        { 
        }

        /// <summary>
        /// PASO EL MENSAJE DE ERROR PERSONALIZADO,
        /// LA CLASE QUE PROVOCO LA EXCEPCION
        /// Y LA EXCEPCION 
        /// </summary>
        /// <param name="mensaje">MENSAJE DE ERROR PERSONALIZADO</param>
        /// <param name="origenError">CLASE QUE PROVOCO LA EXCEPCION</param>
        /// <param name="innerException">EXCEPCION</param>
        public MiClaseException(string mensaje, string origenError, Exception innerException)
            : base(mensaje, innerException)
        {
            base.Source = origenError;        
        }

        //SOBREESCRIBO EL METODO TOSTRING
        public override string ToString()
        {
           return "Mensaje: " + base.Message + ", Origen del error: " + base.Source;
        }
    }
}
