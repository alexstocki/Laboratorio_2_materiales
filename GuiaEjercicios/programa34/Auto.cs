using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa34
{
    public enum Colores
    {
        Rojo,
        Blanco, 
        Azul,
        Gris,
        Negro
    }

    public class Auto : VehiculoTerrestre
    {
        public int cantidadPasajeros;
        public short cantidadMarchas;

        public Auto(short ruedas, short puertas, Colores color, short marchas, int pasajeros)
            : base(ruedas, puertas, color)
        {
            this.cantidadMarchas = marchas;
            this.cantidadPasajeros = pasajeros;
        }
    }
}
