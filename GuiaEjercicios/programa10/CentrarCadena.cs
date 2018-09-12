using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa10
{
    class CentrarCadena
    {
        public static string StringCentering(string s, int desiredLength)
        {
            if (s.Length >= desiredLength)
            {
                return s;
            }
            int firstpad = (s.Length + desiredLength) / 2;
            return s.PadLeft(firstpad).PadRight(desiredLength);
        }
    }
}
