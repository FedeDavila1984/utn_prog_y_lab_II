using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej.Colecciones
{
    class Program
    {
        private static int OrdenarDescendente(string s1, string s2)
        {
            return -s1.CompareTo(s2);
        }
        static void Main(string[] args)
        {
            //https://msdn.microsoft.com/es-es/library/ybcx56wz(v=vs.110).aspx
            // Lista de strings.
            List<string> sieteMares = new List<string>();
            // Agrego items de a uno
            sieteMares.Add("Golfo Pérsico");
            sieteMares.Add("Negro");
            sieteMares.Add("Caspio");
            sieteMares.Add("Rojo");
            sieteMares.Add("Mediterráneo");
            sieteMares.Add("Adriático");
            sieteMares.Add("de Arabia");
            // Itero la lista y muestro los 7 mares
            Console.WriteLine("Los 7 mares:");
            for (int i = 0; i < sieteMares.Count; i++)
            {
                Console.Write(sieteMares[i] + ", ");
            }
            // Freno y luego limpio la pantalla
            Console.ReadKey();
            Console.Clear();

            // Ordeno la Lista y vuelvo a mostrarla
            Console.WriteLine("Orden Ascendente");
            sieteMares.Sort();
            // Itero la lista y muestro los mares
            foreach (var mar in sieteMares)
            {
                Console.Write(mar + ", ");
            }

            Console.WriteLine("");
            Console.WriteLine("Orden Descendente");
            // Ordeno la Lista inversa y vuelvo a mostrarla
            sieteMares.Sort(Program.OrdenarDescendente);
            // Itero la lista y muestro los mares
            foreach (var mar in sieteMares)
            {
                Console.Write(mar + ", ");
            }
            // Freno y luego limpio la pantalla
            Console.ReadKey();
            Console.Clear();

            // Creo una lista, utilizando el inicializador de Colecciones.
            List<string> oceanos = new List<string> { "Ártico", "Antártico", "Pacífico", "Atlántico", "Índico" };
            // Itero la lista y muestro los oceanos
            foreach (var oceano in oceanos)
            {
                Console.Write(oceano);
                Console.Write((oceanos.IndexOf(oceano) == oceanos.Count - 1) ? "." : ", "); // (condición) ? true : false
            }
            // Shorthand IF https://msdn.microsoft.com/es-ar/library/ty67wk28.aspx
            // Freno y luego limpio la pantalla
            Console.ReadKey();
            Console.Clear();

            // Quito el primer elemento que coincida
            oceanos.Remove("Antártico");
            // Itero la lista y muestro los oceanos que quedaron
            foreach (var oceano in oceanos)
            {
                Console.WriteLine("{1} {0}", oceano, oceanos.IndexOf(oceano) + 1);
            }
            // Freno y luego limpio la pantalla
            Console.ReadKey();
            Console.Clear();

            // Quito el elemento en una posición especifica
            oceanos.RemoveAt(2); //Atlántico
            // Itero la lista y muestro los oceanos que quedaron
            foreach (var oceano in oceanos)
            {
                Console.Write("{0}, ", oceano);
            }
            // Freno y luego limpio la pantalla
            Console.ReadKey();
            Console.Clear();

            //---------------OTRAS COLECCIONES GENERICAS---------------------------
            // Diccionario
            Dictionary<string, string> miDiccionario = new Dictionary<string, string>();
            miDiccionario.Add("1ra", "Boca Juniors");
            miDiccionario.Add("2da", "Boca Unidos");
            miDiccionario.Add("3ra", "Boca Río Gallegos");
            miDiccionario.Add("4ta", "Huracán San Rafael");
            miDiccionario.Add("5ta", "Leandro N. Alem");

            // Itero y muestro el Diccionario
            foreach (KeyValuePair<string, string> entrada in miDiccionario)
            {
                Console.WriteLine("{0}. {1}", entrada.Key, entrada.Value);
            }
            // Pregundo si contiene cierta Clave
            if (miDiccionario.ContainsKey("2da"))
                Console.WriteLine("El Key '2da' es {0}", miDiccionario["2da"]);

            // Quito un ítem
            miDiccionario.Remove("3ra");
            // Modifico un ítem
            miDiccionario["2da"] = "Newcastle United";
            // Itero y muestro las claves
            foreach (string entrada in miDiccionario.Keys)
            {
                Console.WriteLine("Claves: {0}", entrada);
            }
            // Itero y muestro los valores
            foreach (string entrada in miDiccionario.Values)
            {
                Console.WriteLine("Valor: {0}", entrada);
            }

            // Freno y luego limpio la pantalla
            Console.ReadKey();
            Console.Clear();

            // Cola
            Console.WriteLine("COLA");
            Queue<Cliente> clientesCola = new Queue<Cliente>();
            clientesCola.Enqueue(new Cliente("Jorge"));
            clientesCola.Enqueue(new Cliente("Alberto"));
            clientesCola.Enqueue(new Cliente("Luis"));
            clientesCola.Enqueue(new Cliente("María"));

            Random r = new Random();
            while (clientesCola.Count > 0)
            {
                Console.WriteLine("Atender a: {0}. Quedan {1} cliente/s en espera.", clientesCola.Dequeue(), clientesCola.Count);
                // Demoro la iteración entre 1 y 3 segundos
                System.Threading.Thread.Sleep(r.Next(1000, 3000));
            }

            Console.WriteLine("");

            // Pila
            Console.WriteLine("PILA");
            Stack<Cliente> clientesPila = new Stack<Cliente>();
            clientesPila.Push(new Cliente("Jorge"));
            clientesPila.Push(new Cliente("Alberto"));
            clientesPila.Push(new Cliente("Luis"));
            clientesPila.Push(new Cliente("María"));

            while (clientesPila.Count > 0)
            {
                Console.WriteLine("Atender a: {0}. Quedan {1} cliente/s en espera.", clientesPila.Pop(), clientesPila.Count);
                // Demoro la iteración entre 1 y 3 segundos
                System.Threading.Thread.Sleep(r.Next(1000, 3000));
            }

            // Freno y luego limpio la pantalla
            Console.ReadKey();
            Console.Clear();

            SortedList<int, Cliente> listaOrdenada = new SortedList<int, Cliente>();
            listaOrdenada.Add(3, new Cliente("Miguel"));
            listaOrdenada.Add(2, new Cliente("Alejandra"));
            listaOrdenada.Add(8, new Cliente("Agostina"));
            listaOrdenada.Add(1, new Cliente("Valentino"));

            foreach (KeyValuePair<int, Cliente> entrada in listaOrdenada)
            {
                Console.WriteLine("{0}. {1}", entrada.Key, entrada.Value);
            }
            // Freno y luego limpio la pantalla
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("PILA NO GENÉRICA");
            System.Collections.Stack clientesPilaGenerica = new System.Collections.Stack();
            clientesPilaGenerica.Push(new Cliente("Jorge"));
            clientesPilaGenerica.Push(new Cliente("Alberto"));
            clientesPilaGenerica.Push(new Cliente("Luis"));
            clientesPilaGenerica.Push(new Cliente("María"));
            clientesPilaGenerica.Push(1);

            while (clientesPilaGenerica.Count > 0)
            {
                // Debo castear el contenido de la pila, ya que es del tipo Object
                Object obj = clientesPilaGenerica.Pop();
                if (obj is Cliente)
                {
                    Cliente c = (Cliente)obj;
                    Console.WriteLine("Atender a: {0}. Quedan {1} cliente/s en espera.", c, clientesPilaGenerica.Count);
                }
                else
                {
                    Console.WriteLine(obj);
                }
            }

            // Freno y luego limpio la pantalla
            Console.ReadKey();
            Console.Clear();
        }
    }
}
