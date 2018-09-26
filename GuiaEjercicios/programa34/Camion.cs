using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa34
{
    public class Camion : VehiculoTerrestre
    {
        public int pesoCarga;
        public short cantidadMarchas;

        public Camion(short ruedas, short puertas, Colores color, short marchas, int peso)
            : base(ruedas, puertas, color)
        {
            this.cantidadMarchas = marchas;
            this.pesoCarga = peso;
        }
    }
}
