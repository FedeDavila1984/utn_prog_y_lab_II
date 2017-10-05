using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._42
{
    class MiClaseErrores
    {
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
    }
}
