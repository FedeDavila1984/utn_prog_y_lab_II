using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //CREO UNA LISTA DE MATERIAS
            List<Materia> materiasUTN = new List<Materia>();

            //AGREGO MATERIAS A LA LISTA
            materiasUTN.Add(new Materia(0, "Programación I"));
            materiasUTN.Add(new Materia(2, "Programación III"));
            materiasUTN.Add(new Materia(1, "Programación II"));

            //CREO UN PAR DE ALUMNOS
            Alumno alumno = new Alumno(32000444, "Valentino", 
                                        new DateTime(1986, 6, 25), 123);
            Alumno alumno2 = new Alumno(32555999, "Justina", 
                                        new DateTime(1985, 11, 28), 456);

            //CREO UN PROFESOR
            Profesor profesor = new Profesor();
            
            //AGREGO LA MATERIA QUE DICTA EL PROFESOR
            profesor.misMaterias.Add(materiasUTN[1]);

            //AGREGO LAS MATERIAS QUE CURSAN LOS ALUMNOS
            alumno.IngresarMaterias(new MateriaAlumno(materiasUTN[0]));
            alumno.IngresarMaterias(new MateriaAlumno(materiasUTN[1]));

            alumno2.IngresarMaterias(new MateriaAlumno(materiasUTN[2]));

            //EL ALUMNO ESTUDIA LA MATERIA 2
            alumno.Estudiar(materiasUTN[1]);

            //INVOCO AL MÉTODO COMER, DE LA CLASE PERSONA (CLASE BASE)
            Console.WriteLine(alumno.Comer());
            Console.WriteLine(profesor.Comer());

            //EL PROFESOR CALIFICA A LOS ALUMNOS
            Console.WriteLine(profesor.Calificar(alumno2, materiasUTN[2]));
            Console.ReadKey();
            Console.WriteLine(profesor.Calificar(alumno, materiasUTN[1]));
            Console.ReadKey();

            //MUESTRO LAS NOTAS DE CADA ALUMNO
            alumno.MostrarResultados();
            alumno2.MostrarResultados();

            Console.ReadLine();

        }
    }
}
