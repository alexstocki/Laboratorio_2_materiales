using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 29";

            Equipo rojo;
            rojo = new Equipo(4, "Independiente");

            Jugador player1 = new Jugador(37171743, "Alex", 22, 10);
            Jugador player2 = new Jugador(38181848, "Mezza", 20, 30);
            Jugador player3 = new Jugador(37171743, "Xote", 100, 30);
            Jugador player4 = new Jugador(40101030, "Santiago", 8, 20);

            Console.WriteLine("Son el mismo jugador el 0 y el 3?: {0}", player1 == player3);
           
            if(rojo + player1)
            {
                Console.WriteLine("Se agregó a " + player1.MostrarDatos());
            }
            if(rojo + player3)
            {
                Console.WriteLine("Se agregó a xote y no tendria que haber pasado");
            }

            //Console.WriteLine(rojo + plantel[5]);
            Console.ReadKey();
        }
    }
}
