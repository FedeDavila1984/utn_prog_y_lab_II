using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    sealed class ClaseError:ClaseBase
    {

        #region Constructores

        public ClaseError()
            : base(1)
        { }

        #endregion

        #region Métodos

        public string Falla(ClaseBase t)
        {
            // Esto da error por problema de accesibilidad.
            //Console.WriteLine(t._edad);

            ClaseDerivada d;
            ClaseError e;
            if (t is ClaseDerivada)
            {
                d = (ClaseDerivada)t;
                return String.Format("Clase Derivada {0}", d.nombre);
            }
            else if (t.GetType() == typeof(ClaseError))
            {
                e = (ClaseError)t;
                return String.Format("Clase Error {0}", e.Id);
            }
            else
            {
                return "Clase Base";
            }
            
        }
        public void Compila()
        {
            Console.WriteLine(base._edad);
            Console.WriteLine(this.Id);
        }

        #endregion

    }
}
