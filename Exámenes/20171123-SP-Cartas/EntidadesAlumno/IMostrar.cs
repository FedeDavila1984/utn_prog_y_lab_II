using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAlumno
{
    public interface IMostrar<T>
    {
        //string MostrarDatos(T elemento);

        string MostrarDatos(IMostrar<T> elemento);
    }
}
