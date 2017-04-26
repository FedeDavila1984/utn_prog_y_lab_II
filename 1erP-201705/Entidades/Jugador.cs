using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private int numero;
        private bool capitan;

        #region Constructores
        /// <summary>
        /// Por defecto asignará numero 0 y capitan false
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Jugador(string nombre, string apellido)
            : this(nombre, apellido, 0, false)
        { }

        /// <summary>
        /// Instancia un nuevo jugador.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="numero"></param>
        /// <param name="capitan"></param>
        public Jugador(string nombre, string apellido, int numero, bool capitan)
            : base(nombre, apellido)
        {
            this.numero = numero;
            this.capitan = capitan;
        }
        #endregion

        #region Propiedades
        public int Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }
        public bool esCapitan
        {
            get
            {
                return this.capitan;
            }
            set
            {
                this.capitan = value;
            }
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Mostrar la ficha técnica de un jugador recibido como parámetro.
        /// Deberá usar StringBuilder, al menos una vez el método Append, AppendFormat y AppendLine.
        /// Deberá utilizar al menos una vez el método Format de la clase String.
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        protected override string FichaTecnica()
        {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("{0} {1}", this.Nombre, this.Apellido);
                if (this.esCapitan)
                    sb.Append(", capitán del equipo,");
                sb.AppendLine(String.Format(" camiseta número {0}", this.Numero));
                return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Retorna la ficha técnica del jugador.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.FichaTecnica();
        }

        public override bool Equals(object obj)
        {
            if(obj is Jugador)
                return this == (Jugador)obj;
            return false;
        }

        /// <summary>
        /// Dos jugadores serán iguales si comparten nombre, apellido y número.
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if (j1.Nombre == j2.Nombre && j1.Apellido == j2.Apellido && j1.Numero == j2.Numero)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Dos jugadores serán distintos si no comparten nombre, apellido o número.
        /// </summary>
        /// <param name="j1"></param>
        /// <param name="j2"></param>
        /// <returns></returns>
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

        /// <summary>
        /// Retornará el número de camiseta del jugador.
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        public static explicit operator int(Jugador jugador)
        {
            return jugador.Numero;
        }
        #endregion
    }
}
