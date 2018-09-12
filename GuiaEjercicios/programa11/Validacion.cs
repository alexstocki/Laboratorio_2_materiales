using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa11
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno;

            if (valor >= min && valor <= max)
            {
                retorno = true;
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
