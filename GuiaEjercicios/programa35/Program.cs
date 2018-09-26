using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 35";

            Equipo rojo = new Equipo(3, "Independiente");
            Jugador j1 = new Jugador("Lionel Messi", 100, 70);
            Jugador j2 = new Jugador("Cristiano Ronaldo", 90, 82);
            DateTime nacimientodt1 = new DateTime(1976, 11, 25);
            DirectorTecnico dt1 = new DirectorTecnico("Pep Guardiola", nacimientodt1);

            Console.WriteLine("Equipo de las estrellas: ");
            if(rojo + j1)
            {
                Console.WriteLine("\nMessi está en el equipo");
            }
            if(rojo + j2)
            {
                Console.WriteLine("Ronaldo está en el equipo\n");
            }

            foreach(Jugador player in rojo.jugadores)
            {
                Console.WriteLine(player.MostrarDatos());
            }

            Console.WriteLine("\nDirector técnico: ");
            Console.WriteLine(dt1.MostrarDatos());
            Console.ReadKey();
        }
    }
}
