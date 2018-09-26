using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 32";

            Equipo rojo = new Equipo(4, "Independiente");
            Jugador j1 = new Jugador(38181848, "Mezza", 8, 22);
            Jugador j2 = new Jugador(40404040, "Aguero", 30, 61);
            Jugador j3 = new Jugador(36161646, "Messi", 49, 52);
            Jugador j4 = new Jugador(37171743, "Xote", 15, 8);

            if(rojo + j1)
            {
                Console.WriteLine("Fichamos a Mezza");
            }
            if(rojo + j3)
            {
                Console.WriteLine("Vino Messi, somos nosotros!");
            }
            if(rojo + j3)
            {
                Console.WriteLine("Tenemos dos Messi, algo anda mal, pero a quién le importa, tenemos dos Messi");
            }
            else
            {
                Console.WriteLine("Casi nos sale bien tener a dos Messi, pero no se pudo, así que el programa funca bien");
            }
            Console.ReadKey();

            Console.WriteLine("\nAhora algunas estadísticas: \n");
            foreach (Jugador player in rojo.jugadores)
            {
                Console.WriteLine("{0}\n", player.MostrarDatos());
            }
            Console.ReadKey();
        }
    }
}
