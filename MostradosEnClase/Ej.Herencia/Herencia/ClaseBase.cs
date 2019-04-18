using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class ClaseBase
    {
        
        #region Atributos

        public string nombre;
        private long id;
        protected int edad;

        #endregion

        #region Propiedades

        public long Id 
        {
            get { return id; }
        }

        #endregion

        #region Constructores

        public ClaseBase(long id)
        {
            this.id = id;
        }

        #endregion

    }
}
