using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa12
{
    class ValidarRespuesta
    {
        public static bool ValidaS_N(char respuesta)
        {
            bool retorno;

            if (respuesta == 'S' || respuesta == 's')
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
