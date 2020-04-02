using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej._026
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Queue<int> colaPos = new Queue<int>();
            Stack<int> pilaPos = new Stack<int>();
            Queue<int> colaNeg = new Queue<int>();
            Stack<int> pilaNeg = new Stack<int>();

            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                lista.Add(r.Next(-100, 100));
            }

            Console.WriteLine("Muestro Lista Original");
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Muestro Lista Ordenada");
            lista.Sort(Program.OrdenarLista);
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Muestro Lista Positivos");
            foreach (int i in lista)
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                    colaPos.Enqueue(i);
                }
                else if (i != 0)
                {
                    pilaNeg.Push(i);
                }
            }
            Console.WriteLine("Muestro Lista Negativos");
            for (int i = lista.Count-1; i >= 0; i--)
            {
                if (lista[i] > 0)
                {
                    pilaPos.Push(lista[i]);
                }
                else if(lista[i] != 0)
                {
                    Console.WriteLine(lista[i]);
                    colaNeg.Enqueue(lista[i]);
                }
            }
            Console.WriteLine("Muestro Cola Positivos");
            foreach (int i in colaPos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Muestro Pila Positivos");
            foreach (int i in pilaPos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Muestro Cola Negativos");
            foreach (int i in colaNeg)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Muestro Pila Negativos");
            foreach (int i in pilaNeg)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }

        public static int OrdenarLista(int a, int b)
        {
            if(a>b)
                return -1;
            else if(b>a)
                return 1;
            else
                return 0;
        }
    }
}
