using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        public DirectorTecnico(string nombre, string apellido)
            : base(nombre, apellido)
        { }

        /// <summary>
        /// Mostrar la ficha técnica de un DT recibido como parámetro.
        /// Si el item no es del tipo DirectorTecnico, retornará vacio.
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        protected override string FichaTecnica()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1}", this.Nombre, this.Apellido);
            return sb.ToString();
        }

        /// <summary>
        /// Retorna la ficha técnica del DT.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.FichaTecnica();
        }
    }
}
