using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Colecciones
{
    class Cliente
    {
        string _nombre;

        public Cliente(string nombre)
        {
            this._nombre = nombre;
        }

        public override string ToString()
        {
            return this._nombre;
        }
    }
}
