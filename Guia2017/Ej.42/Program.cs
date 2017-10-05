using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._42
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MiOtraClase aux = new MiOtraClase();
                aux.MiMetodoInstancia();
            }
            catch (MiException e)
            {
                Console.WriteLine(e.Message);

                if (!object.ReferenceEquals(e.InnerException, null))
                {
                    Exception ex = e.InnerException;
                    do
                    {
                        Console.WriteLine(ex.Message);
                        ex = ex.InnerException;
                    } while (!object.ReferenceEquals(ex, null));
                }
            }

            Console.ReadKey();
        }
    }
}
