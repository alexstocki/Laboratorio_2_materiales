using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        // ***** propiedades *****
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int Numero
        {
            get
            {
                return this.numero;
            }
        }

        // ***** métodos ******
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(string nombre, int numero) : this(numero)
        {
            this.Nombre = nombre;
        }

        // ***** operadores *****
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            bool retorno = false;
            if(c1.Numero == c2.Numero)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }
    }

}
