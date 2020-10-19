using System;
using System.Collections.Generic;
using System.Text;

namespace Programa_test
{
    public class MiExcepcion : Exception
    {
        public MiExcepcion(string mensaje)
            : base(mensaje)
        {

        }
    }
}
