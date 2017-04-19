using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    class Materia
    {

        #region Atributos

        public int codigo;
        public string descripcion;

        #endregion

        #region Constructores

        public Materia(int codigo, string descripcion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
        }

        #endregion

    }
}
