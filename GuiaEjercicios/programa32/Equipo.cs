using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa32
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        public List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad ,string nombre) 
            :this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }

        public static bool operator +(Equipo e, Jugador j)
        {
            foreach (Jugador player in e.jugadores)
            {
                if(player == j)
                {
                    return false;
                }
            }

            e.jugadores.Add(j);
            return true;
        }
    }
}
