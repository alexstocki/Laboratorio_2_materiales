using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa20
{
    class Euro
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Euro()
        {
            Euro.cotizRespectoDolar = 0.809f;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, float cotizacion)
           : this(cantidad)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static float GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        public static explicit operator Dolar(Euro e)
        {
            Dolar retorno = new Dolar(e.GetCantidad() / Euro.GetCotizacion()); 
            return retorno;
        }
        public static explicit operator Pesos(Euro e)
        {
            /*Pesos retorno = new Pesos(((Dolar)e).GetCantidad() / Euro.GetCotizacion());
            return retorno;*/

            return (Pesos)((Dolar)e);
        }
        public static implicit operator Euro(double d)
        {
            Euro retorno = new Euro(d);
            return retorno;
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            /*if(e1.GetCantidad() == e2.GetCantidad())
            {
                return true;
            }

            return false;*/

            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e, Dolar d)
        {
            /*if(e.GetCantidad() == ((Euro)d).GetCantidad())
            {
                return true;
            }

            return false;*/

            return e == (Euro)d;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }
        public static bool operator ==(Euro e, Pesos p)
        {
            /*if(e.GetCantidad() == ((Euro)p).GetCantidad())
            {
                return true;
            }

            return false;*/

            return e == (Euro)p;
        }
        public static bool operator !=(Euro e, Pesos p)
        {
            return !(e == p);
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            Euro retorno = new Euro(e.GetCantidad() + ((Euro)d).cantidad);
            return retorno;
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            Euro retorno = new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
            return retorno;
        }
        public static Euro operator +(Euro e, Pesos p)
        {
            Euro retorno = new Euro(e.cantidad + ((Euro)p).cantidad);
            return retorno;
        }
        public static Euro operator -(Euro e, Pesos p)
        {
            Euro retorno = new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
            return retorno;
        }
    }
}
