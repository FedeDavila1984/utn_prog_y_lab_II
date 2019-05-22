using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Puma(Animal.Sexo.Femenino);
            IComportamientos c = new Leon(Animal.Sexo.Masculino);
            IComportamientos c1 = (IComportamientos)a;

            List<IComportamientos> list = new List<IComportamientos>() { (IComportamientos)a, c, c1 };
            foreach (IComportamientos item in list)
            {
                Console.WriteLine(item.Sexo);
            }

            Console.WriteLine(a.GetUbicacion);
            Console.WriteLine(c.Sexo);

            Console.ReadKey();
        }
    }
}
