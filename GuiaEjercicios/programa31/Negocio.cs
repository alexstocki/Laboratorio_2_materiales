using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa31
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        // ***** propiedades *****
        public Cliente Cliente
        {
            get
            {
                return this.clientes.Dequeue();
            }
            set
            {
                if(this != value)
                {
                    this.clientes.Enqueue(value);
                }
            }
        }

        // ***** método *****
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(Puesto.Caja1);
            
        }
        public Negocio(string nombre):this()
        {
            this.nombre = nombre;
        }

        // ***** operadores *****
        public static bool operator ==(Negocio n, Cliente c)
        {
            bool retorno = false;
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }
        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;
            if (n != c)
            {
                n.clientes.Enqueue(c);
                retorno = true;
            }
            return retorno;
        }
        public static bool operator ~(Negocio n)
        {
            bool retorno = false;
            if (n.caja.Atender(n.Cliente))
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
