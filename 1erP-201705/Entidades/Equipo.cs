using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        public enum Deportes
        {
            Basquet, Futbol, Handball, Rugby
        }

        private List<Jugador> jugadores;
        private DirectorTecnico dt;
        private static Deportes deporte;
        private string nombre;

        #region Constructores
        /// <summary>
        /// Por defecto, el deporte del equipo será el fútbol.
        /// </summary>
        static Equipo()
        {
            Equipo.deporte = Deportes.Futbol;
        }

        /// <summary>
        /// Instanciará la lista de jugadores.
        /// </summary>
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre, DirectorTecnico dt)
            : this()
        {
            this.nombre = nombre;
            this.dt = dt;
        }
        public Equipo(string nombre, DirectorTecnico dt, Deportes deporte)
            : this(nombre, dt)
        {
            Equipo.deporte = deporte;
        }
        #endregion

        #region Propiedades
        public Deportes Deporte
        {
            set
            {
                Equipo.deporte = value;
            }
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Equipo e, Jugador j)
        {
            foreach (Jugador i in e.jugadores)
            {
                if (i == j)
                    return true;
            }

            return false;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j)
                e.jugadores.Add(j);
            return e;
        }

        public static Equipo operator -(Equipo e, Jugador j)
        {
            if (e == j)
                e.jugadores.Remove(j);
            return e;
        }

        public static implicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**" + e.nombre + " " + Equipo.deporte.ToString() + "**");
            sb.AppendLine("Nómina Jugadores:");
            foreach (Jugador i in e.jugadores)
                sb.Append(i.ToString());
            sb.AppendLine("Dirigido por: " + e.dt.ToString());
            return sb.ToString();
        }
        #endregion
    }
}
