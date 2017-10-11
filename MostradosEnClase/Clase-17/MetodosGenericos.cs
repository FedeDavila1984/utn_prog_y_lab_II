using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_17
{
    public class MetodosGenericos
    {
        public static void MetodoStatic<T>(T s, T t) where T : class
        {
            System.Console.WriteLine(s == t);
        }

        public void MetodoInstancia<T>(T s, T t) where T : class
        {
            System.Console.WriteLine(s == t);
        }
    }
}
