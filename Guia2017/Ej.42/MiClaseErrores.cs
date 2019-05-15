using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._42
{
    class MiClaseErrores
    {
        /// <summary>
        /// a.	Lanzar una excepción DivideByZeroException en un método estático
        /// </summary>
        public static void MetodoEstatico()
        {
            try
            {
                int aux = 0;
                int res = 10 / aux;
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// b.	Capturar la excepción del punto a en un constructor de instancia y...
        /// relanzarla hacia otro constructor de instancia.
        /// </summary>
        public MiClaseErrores()
        {
            try
            {
                MiClaseErrores.MetodoEstatico();
            }
            catch (DivideByZeroException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// c.	En este segundo constructor, crear una excepción propia llamada UnaException
        /// (utilizar innerException para almacenar la excepción original) y volver a lanzarla.
        /// </summary>
        /// <param name="a"></param>
        public MiClaseErrores(int a)
        {
            try
            {
                new MiClaseErrores();
            }
            catch (DivideByZeroException e)
            {
                throw new UnaException("2do Constructor de Instancia Exception", e);
            }
        }
    }
}
