using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Entidades;

namespace PruebaTask
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;

            Persona persona = new Persona("Marcela");
            Task tarea = Task.Run(() => { persona.Caminar(token); });

            bool continuar = true;
            // int pasos;
            Console.WriteLine("La persona caminará 1 paso por segundo hasta que salgamos. Inicia a las {0}", DateTime.Now.ToString("HH:mm:ss"));
            do
            {
                Console.WriteLine("¿Desea continuar? S / N");
                continuar = Console.ReadKey().KeyChar == 's';
                Console.WriteLine("Lleva a las {0} {1} pasos.", DateTime.Now.ToString("HH:mm:ss"), persona.PasosDados);
            } while (continuar);

            tokenSource.Cancel();

            Console.WriteLine("Finaliza a las {0} con {1} pasos.", DateTime.Now.ToString("HH:mm:ss"), persona.PasosDados);

            Console.ReadKey();
        }
    }
}
