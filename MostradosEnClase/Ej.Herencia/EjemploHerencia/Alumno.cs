using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    class Alumno:Persona
    {

        #region Atributos

        public int legajo;
        public List<MateriaAlumno> materias;

        #endregion 

        #region Constructores

        public Alumno(long dni, string nombre, DateTime fechaNac, int legajo)
            : base(nombre,dni,fechaNac)
        {
            this.legajo = legajo;
            this.materias = new List<MateriaAlumno>();
        }

        #endregion

        #region Métodos

        public void Estudiar(Materia materia)
        {
            Console.WriteLine("Estoy estudiando {0}",materia.descripcion);
            Console.ReadLine();
        }

        public void IngresarMaterias(Materia materia)
        {
            MateriaAlumno miMateria = new MateriaAlumno(materia);
            this.materias.Add(miMateria);
        }

        public void MostrarResultados()
        {
            Console.WriteLine("Nombre: {0} Legajo: {1}", this._nombre, this.legajo);
            foreach (MateriaAlumno miMateria in this.materias)
            {
                Console.WriteLine("Materia: {0} Codigo: {1} Nota: {2}", miMateria.descripcion, 
                                    miMateria.codigo, miMateria.nota);
            }

        }

        #endregion

    }
}
