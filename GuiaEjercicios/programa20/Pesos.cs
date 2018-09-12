using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa20
{
    class Pesos
    {
        private double cantidad;
        private static float cotizRespectoDolar;

        private Pesos()
        {
            Pesos.cotizRespectoDolar = 17.55f;
        }
        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Pesos(double cantidad, float cotizacion)
            : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static float GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static explicit operator Dolar(Pesos p)
        {
            Dolar retorno = new Dolar(p.GetCantidad() / Pesos.GetCotizacion());
            return retorno;
        }

        public static explicit operator Euro(Pesos p)
        {
            Euro retorno = new Euro(((Dolar)p).GetCantidad() * Euro.GetCotizacion());
            return retorno;
        }       
        public static implicit operator Pesos(double d)
        {
            Pesos retorno = new Pesos(d);
            return retorno;
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            /*if(p1.GetCantidad() == p2.GetCantidad())
            {
                return true;
            }

            return false;*/

            return p1.GetCantidad() == p2.GetCantidad();
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Pesos p, Dolar d)
        {
            /*if(p.GetCantidad() == ((Pesos)d).GetCantidad())
            {
                return true;
            }

            return false;*/

            return p == (Pesos)d;
        }
        public static bool operator !=(Pesos p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator ==(Pesos p, Euro e)
        {
            /*if(p.GetCantidad() == ((Pesos)e).GetCantidad())
            {
                return true;
            }

            return false;*/

            return p == (Pesos)e;
         }
        public static bool operator !=(Pesos p, Euro e)
        {
            return !(p == e);
        }
        public static Pesos operator +(Pesos p, Dolar d)
        {
            Pesos retorno = new Pesos(p.GetCantidad() + ((Pesos)d).GetCantidad());
            return retorno;
        }
        public static Pesos operator -(Pesos p, Dolar d)
        {
            Pesos retorno = new Pesos(p.GetCantidad() - ((Pesos)d).GetCantidad());
            return retorno;
        }
        public static Pesos operator +(Pesos p, Euro e)
        {
            Pesos retorno = new Pesos(p.GetCantidad() + ((Pesos)e).GetCantidad());
            return retorno;
        }
        public static Pesos operator -(Pesos p, Euro e)
        {
            Pesos retorno = new Pesos(p.GetCantidad() - ((Pesos)e).GetCantidad());
            return retorno;
        }
    }
}
