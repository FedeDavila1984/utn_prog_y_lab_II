using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Sobrecarga
{
    public class Curso
    {
        string[] _alumnos;

        public Curso(string alumno)
            : this (new string[]{ alumno, "hola" })
        {
            //this._alumnos = new string[1];
            //this._alumnos[0] = alumno;
        }

        public Curso(string[] alumnos)
        {
            this._alumnos = alumnos;
        }

        public Curso(string[] alumnos, int a, float b)
            : this(alumnos)
        {
            //a 
            //b
        }

        /// <summary>
        /// Comparo la palabra de la clase con un tamaño
        /// </summary>
        /// <param name="c"></param>
        /// <param name="tamanio"></param>
        /// <returns></returns>
        public static bool operator >(Curso c, int tamanio)
        {
            if (c._alumnos.Length > tamanio)
                return true;
            return false;
        }
        /// <summary>
        /// Comparo la palabra de la clase con un tamaño
        /// </summary>
        /// <param name="s"></param>
        /// <param name="tamanio"></param>
        /// <returns></returns>
        public static bool operator <(Curso c, int tamanio)
        {
            if (c._alumnos.Length < tamanio)
                return true;
            return false;
        }

        /// <summary>
        /// Compara la cantidad de alumnos de dos cursos
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator >(Curso c1, Curso c2)
        {
            if (c1._alumnos.Length > c2._alumnos.Length)
                return true;
            return false;
        }
        /// <summary>
        /// Compara la cantidad de alumnos de dos cursos
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="c2"></param>
        /// <returns></returns>
        public static bool operator <(Curso c1, Curso c2)
        {
            if (c1._alumnos.Length < c2._alumnos.Length)
                return true;
            return false;
        }

        /// <summary>
        /// Retorno la palabra de la clase.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static implicit operator string(Curso c)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string a in c._alumnos)
                sb.AppendLine(a);
            return sb.ToString();
        }

        /// <summary>
        /// Retorno el tamaño de la palabra.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static explicit operator int(Curso c)
        {
            return c._alumnos.Length;
        }
    }
}
