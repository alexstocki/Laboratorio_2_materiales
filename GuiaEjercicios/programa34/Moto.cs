using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa34
{
    public class Moto : VehiculoTerrestre
    {
        public short cilindrada;

        public Moto(short ruedas, short puertas, Colores color, short cilindros)
            : base(ruedas, puertas, color)
        {
            this.cilindrada = cilindros;
        }
    }
}
