using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa33
{
    class Libro
    {
        private List<string> paginas = new List<string>();

        public string this[int i]
        {
            get
            {
                string retorno = "";
                if (i >=0 && i < paginas.Count())
                {
                    retorno = paginas[i];
                }
                return retorno;
            }

            set
            {
                if(i>= 0 && i < paginas.Count())
                {
                    paginas[i] = value;
                }
                else
                {
                    paginas.Add(value);
                }
            }
        }
    }
}
