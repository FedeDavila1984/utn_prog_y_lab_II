using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    class Profesor:Persona
    {

        #region Atributos

        public List<Materia> misMaterias;
        public DateTime horario;

        #endregion

        #region Constructores

        public Profesor()
            : base("José", 21666444)
        {
            this.horario = DateTime.Parse("18:30");
            this.misMaterias = new List<Materia>();
        }


        #endregion

        #region Métodos

        public string Calificar(Alumno alumno,Materia materia)
        {
            bool existeEnCurso = false;
            bool tieneMateria = false;

            foreach (Materia m in misMaterias)
            {
                if (m.codigo == materia.codigo)
                {
                    for (int i = 0; i < alumno.materias.Count; i++)
                    {
                        if (m.codigo == alumno.materias[i].codigo)
                        {
                            Random notaAlumno = new Random();
                            alumno.materias[i].nota = notaAlumno.Next(0,10);

                            tieneMateria = true;
                            break;
                        }
                    }
                    
                    existeEnCurso = true;
                    break;
                }

                if (!existeEnCurso)
                {
                    return string.Format("El alumno {0} no pertenece al curso", alumno.legajo);
                    //Console.WriteLine("El alumno {0} no pertenece al curso",alumno.legajo);
                    //Console.ReadLine();
                }
                if (!tieneMateria)
                {
                    return string.Format("El alumno {0} no estudia la materia", alumno.legajo);
                    //Console.WriteLine("El alumno {0} no estudia la materia",alumno.legajo);
                    //Console.ReadLine();
                }

            }

            return "";
        }

        #endregion

    }
}
