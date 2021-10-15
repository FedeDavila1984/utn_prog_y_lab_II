using System;
using System.Collections.Generic;

namespace Generics
{
    public class Personal<T>
        where T : Persona
    {
        private List<T> empleados;

        public Personal(List<T> lista)
        {
            this.empleados = lista;
        }

        public List<T> Empleados
        {
            get
            {
                return this.empleados;
            }
            set
            {
                this.empleados = value;
            }
        }

        public static Personal<T> operator +(Personal<T> p, T empleado)
        {
            p.empleados.Add(empleado);
            return p;
        }


        public Personal<T> Metodo<U>(U dato, int a)
        {
            return this;
        }
    }
}
