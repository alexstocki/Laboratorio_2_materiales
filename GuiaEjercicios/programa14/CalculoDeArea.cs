using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double retorno;

            retorno = Math.Pow(lado, 2);

            return retorno;
        }

        public static double CalcularTriangulo(double baseTri, double alturaTri)
        {
            double retorno;

            retorno = (baseTri * alturaTri) / 2;

            return retorno;
        }

        public static double CalcularCirculo(double radio)
        {
            double retorno;

            retorno = 3.14 * (Math.Pow(radio, 2));

            return retorno;
        }
    }
}
