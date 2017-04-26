using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo e = new Equipo("Huracán de San Rafael", new DirectorTecnico("Jorge", "Habbeger"));
            string datosEquipo = "";
            // Instancio jugadores
            Jugador j1 = new Jugador("Fernando", "Pandolfi", 11, false);
            Jugador j2 = new Jugador("Julio", "Marchant", 8, false);
            Jugador j3 = new Jugador("Ezequiel", "Medran", 12, false);
            Jugador j4 = new Jugador("José", "Pereda", 24, false);
            Jugador j5 = new Jugador("Hernán", "Florentin", 6, false);
            Jugador j6 = new Jugador("Fernando", "Navas", 11, true);
            // Agrego jugadores
            e += j1;
            e += j2;
            e += j3;
            e += j4;
            e += new Jugador("José", "Pereda", 24, false);
            e += j5;
            e += j6;
            // Muestro el equipo
            datosEquipo = e;
            Console.WriteLine(datosEquipo);
            Console.ReadKey();
            Console.Clear();

            // Quito jugadores
            e = e - j3;
            e = e - new Jugador("Fernando", "Navas", 11, false);
            // Cambio el deporte
            e.Deporte = Equipo.Deportes.Handball;
            // Muestro el equipo
            datosEquipo = e;
            Console.WriteLine(datosEquipo);
            Console.ReadKey();
        }
    }
}
