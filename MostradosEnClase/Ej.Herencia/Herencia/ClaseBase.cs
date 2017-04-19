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
        private long _id;
        protected int _edad;

        #endregion

        #region Propiedades

        public long Id 
        {
            get { return _id; }
        }

        #endregion

        #region Constructores

        public ClaseBase(long id)
        {
            this._id = id;
        }

        #endregion

    }
}
