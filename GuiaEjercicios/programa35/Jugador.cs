using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa35
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        /// *** propiedades ***
        public int PartidosJugados
        {
            get
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set
            {
                this.totalGoles = value;
            }
        }

        public float PromedioGoles
        {
            get
            {
                float promedioGoles = (float)this.TotalGoles / this.PartidosJugados;
                return promedioGoles;
            }
        }

        /// *** constructor ***
        public Jugador(string nombre, int totGoles, int totPartidos) : base(nombre)
        {
            this.TotalGoles = totGoles;
            this.PartidosJugados = totPartidos;
        }

        /// *** métodos ***
        public string MostrarDatos()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("Nombre: {0}   Dni: {1}\nPartidos: {2}   Goles: {3}   Promedio de gol: {4}\n", this.Nombre, this.Dni, this.PartidosJugados, this.TotalGoles, this.PromedioGoles);
            string retorno = constructor.ToString();
            return retorno;
        }

        /// *** operadores ***
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            if(j1.Dni == j2.Dni && j1.Nombre == j2.Nombre)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }
}
