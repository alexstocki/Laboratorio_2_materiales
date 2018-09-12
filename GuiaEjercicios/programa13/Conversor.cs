using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa13
{
    class Conversor
    {
        public static string DecimalBinario(double numDe)
        {
            string retorno = "";
            int numero = (int)numDe;

            if(numero > 0)
            {
                while(numero > 0)
                {
                    if(numero % 2 == 0)
                    {
                        retorno += "0";
                    }
                    else
                    {
                        retorno += "1";
                    }

                    numero /= 2;
                }
            }
            else
            {
                retorno = "0";
            }

            int cantidad = retorno.Length;
            return retorno;
        }

        public static double BinarioDecimal(string numBi)
        {
            double retorno = 0;

            int potencia = numBi.Length;

            for (int i = 0; i < potencia; i++)
            {
                if(numBi[i] == '1')
                {
                    retorno += Math.Pow(2, i);
                }
            }

            return retorno;
        }
    }
}
