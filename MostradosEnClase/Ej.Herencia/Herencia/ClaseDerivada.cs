using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class ClaseDerivada:ClaseBase
    {

        #region Constructores

        public ClaseDerivada(long id)
            : base(id)
        {
            base._edad = 1;
        }

        #endregion

        #region Métodos

        public void Compila()
        {
            Console.WriteLine(_edad);
        }

        #endregion

    }
}
