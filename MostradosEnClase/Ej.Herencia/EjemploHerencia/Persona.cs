using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    class Persona
    {
        #region Atributos

        protected DateTime fechaNacimiento;
        protected string nombre;
        protected long dni;

        #endregion

        #region Constructores

        public Persona(string nombre, long dni)
        {
            this.dni = dni;
            this.fechaNacimiento = DateTime.Today;
            this.nombre = nombre;
        }

        public Persona(string nombre, long dni, DateTime fechaNac)
        {
            this.dni = dni;
            this.fechaNacimiento = fechaNac;
            this.nombre = nombre;
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
