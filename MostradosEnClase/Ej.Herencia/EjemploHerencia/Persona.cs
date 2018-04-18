using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    class Persona
    {
        #region Atributos

        protected DateTime _fechaNacimiento;
        protected string _nombre;
        protected long _dni;

        #endregion

        #region Constructores

        public Persona(string nombre, long dni)
        {
            this._dni = dni;
            this._fechaNacimiento = DateTime.Today;
            this._nombre = nombre;
        }

        public Persona(string nombre, long dni, DateTime fechaNac)
        {
            this._dni = dni;
            this._fechaNacimiento = fechaNac;
            this._nombre = nombre;
        }


        #endregion

        #region Métodos

        public string Comer()        
        {
            return "Estoy comiendo...";
            //Console.WriteLine("Estoy comiendo...");
            //Console.ReadLine();
        }

        #endregion

    }
}
