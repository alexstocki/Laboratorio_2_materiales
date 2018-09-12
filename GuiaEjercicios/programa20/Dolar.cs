using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa20
{
    class Dolar
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, float cotizacion)
            : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static float GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            Euro retorno = new Euro(d.cantidad * Euro.GetCotizacion());
            return retorno;
        }

        public static explicit operator Pesos(Dolar d)
        {
            Pesos retorno = new Pesos(d.GetCantidad() * Pesos.GetCotizacion());
            return retorno;
        }
        public static implicit operator Dolar(double d)
        {
            Dolar retorno = new Dolar(d);
            return retorno;
        }
        public static bool operator ==(Dolar d, Euro e)
        {
            /*if(d.GetCantidad() == ((Dolar)e).GetCantidad())
            {
                return true;
            }

            return false;*/

            return d == (Dolar)e;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }
        public static bool operator ==(Dolar d, Pesos p)
        {
            /*if(d.GetCantidad() == ((Dolar)p).GetCantidad())
            {
                return true;
            }

            return false;*/

            return d == (Dolar)p;
        }
        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            /*if(d1.GetCantidad() == d2.GetCantidad())
            {
                return true;
            }

            return false;*/

            return d1.GetCantidad() == d2.GetCantidad();
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
            return retorno;
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            Dolar retorno = new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
            return retorno;
        }
        public static Dolar operator +(Dolar d, Pesos p)
        {
            Dolar retorno = new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
            return retorno;
        }
        public static Dolar operator -(Dolar d, Pesos p)
        {
            Dolar retorno = new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
            return retorno;
        }
    }
}
