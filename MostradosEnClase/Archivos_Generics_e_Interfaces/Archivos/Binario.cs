using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Binario : IArchivo<string>
    {
        public bool guardar(string archivo, string datos)
        {
            Console.WriteLine("No implementado");
            return false;
        }
        public bool leer(string archivo, out string datos)
        {
            Console.WriteLine("No implementado");
            datos = "";
            return false;
        }
    }
}
