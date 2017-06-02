using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string apellido;
        private int dni;

        public Persona()
        {
            this.id = 0;
        }

        public Persona(string nombre, string apellido, int dni)
            : this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public Persona(int id, string nombre, string apellido, int dni)
            : this(nombre, apellido, dni)
        {
            this.id = id;
        }

        #region Propiedades
        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }
        #endregion

        #region Base de datos
        public bool Guardar()
        {
            return PersonaDAO.InsertaPersona(this);
        }
        public bool Cargar()
        {
            Persona datos = PersonaDAO.ObtienePersona();
            if (datos == null)
                return false;
            else
            {
                this.id = datos.id;
                this.nombre = datos.nombre;
                this.apellido = datos.apellido;
                this.dni = datos.dni;
                return true;
            }
        }
        public bool Modificar()
        {
            return PersonaDAO.ModificaPersona(this);
        }
        public bool Eliminar()
        {
            return PersonaDAO.EliminaPersona(this);
        }
        #endregion

        public override string ToString()
        {
            return String.Format("{0} {1}: {2}", this.nombre, this.apellido, this.dni);
        }
    }
}
