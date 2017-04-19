using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    class MateriaAlumno:Materia
    {
        public float nota;

        public MateriaAlumno(int codigo, string nombre)
            :base(codigo,nombre)
        {
        }

        public MateriaAlumno(Materia materia)
            : base(materia.codigo, materia.descripcion)
        {
        }

    }
}
