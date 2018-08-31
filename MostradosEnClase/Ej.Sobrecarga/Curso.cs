 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Sobrecarga
{
    public class Curso
    {
        int curso;
        char division;
        string[] alumnos;

        #region Constructores
        /// <summary>
        /// Sobrecarga del Constructor: Recibe un string con el Alumno, lo convierte a array y se lo pasa al Constructor que corresponde.
        /// </summary>
        /// <param name="alumno">Cadena de Texto con un alumno</param>
        public Curso(string alumno)
            : this (new string[]{ alumno })
        {
        }

        /// <summary>
        /// Sobrecarga del Constructor: Recibe un array de cadenas de texto y lo guarda en alumnos
        /// </summary>
        /// <param name="alumnos">Array de cadenas de texto con los alumnos</param>
        public Curso(string[] alumnos)
        {
            this.alumnos = alumnos;
        }

        /// <summary>
        /// Sobrecarga del Constructor: recibe un array de cadenas de texto y lo pasa al constructor correspondiente.
        /// También recibe un entero con el curso y un char con la división.
        /// </summary>
        /// <param name="alumnos">Array de cadenas de texto con los alumnos</param>
        /// <param name="curso">Entero con el número de curso</param>
        /// <param name="division">Char con la división</param>
        public Curso(string[] alumnos, int curso, char division)
            : this(alumnos)
        {
            this.curso = curso;
            this.division = division;
        }

        #endregion

        #region Operadores y Conversiones
        /// <summary>
        /// Comparo la palabra de la clase con un tamaño
        /// </summary>
        /// <param name="c">Objeto Curso</param>
        /// <param name="tamanio">Entero con la cantidad a comparar</param>
        /// <returns></returns>
        public static bool operator >(Curso c, int tamanio)
        {
            if (c.alumnos.Length > tamanio)
                return true;
            return false;
        }
        /// <summary>
        /// Comparo la palabra de la clase con un tamaño
        /// </summary>
        /// <param name="c">Objeto Curso</param>
        /// <param name="tamanio">Entero con la cantidad a comparar</param>
        /// <returns></returns>
        public static bool operator <(Curso c, int tamanio)
        {
            if (c.alumnos.Length < tamanio)
                return true;
            return false;
        }

        /// <summary>
        /// Compara la cantidad de alumnos de dos cursos
        /// </summary>
        /// <param name="c1">Objeto Curso</param>
        /// <param name="c2">Objeto Curso</param>
        /// <returns></returns>
        public static bool operator >(Curso c1, Curso c2)
        {
            if (c1.alumnos.Length > c2.alumnos.Length)
                return true;
            return false;
        }
        /// <summary>
        /// Compara la cantidad de alumnos de dos cursos
        /// </summary>
        /// <param name="c1">Objeto Curso</param>
        /// <param name="c2">Objeto Curso</param>
        /// <returns></returns>
        public static bool operator <(Curso c1, Curso c2)
        {
            if (c1.alumnos.Length < c2.alumnos.Length)
                return true;
            return false;
        }

        /// <summary>
        /// Retorno la palabra de la clase.
        /// </summary>
        /// <param name="c">Objeto Curso</param>
        /// <returns></returns>
        public static implicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string a in c.alumnos)
                sb.AppendLine(a);
            return sb.ToString();
        }

        /// <summary>
        /// Retorno el tamaño de la palabra.
        /// </summary>
        /// <param name="c">Objeto Curso</param>
        /// <returns></returns>
        public static explicit operator int(Curso c)
        {
            return c.alumnos.Length;
        }
        #endregion
    }
}
