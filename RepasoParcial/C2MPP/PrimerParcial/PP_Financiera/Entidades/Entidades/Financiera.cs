using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.PrestamosPersonales;

namespace Entidades
{
    namespace EntidadFinanciera
    {
        public class Financiera
        {
            #region Atributos

            private List<Prestamo> listaDePrestamos;
            private string razonSocial;

            #endregion

            #region Propiedades

            public float InteresesEnDolares
            {
                get
                {
                    return this.CalcularInteresGanado(TipoDePrestamo.Dolares);
                }
            }

            public float InteresesEnPesos
            {
                get
                {
                    return this.CalcularInteresGanado(TipoDePrestamo.Pesos);
                }
            }

            public float InteresesTotales
            {
                get
                {
                    return this.CalcularInteresGanado(TipoDePrestamo.Todos);
                }
            }

            public List<Prestamo> ListaDePrestamos
            {
                get
                {
                    this.OrdenarPrestamos();
                    return this.listaDePrestamos;
                }
            }

            public string RazonSocial
            {
                get
                {
                    return this.razonSocial;
                }
            }

            #endregion

            #region Constructor

            private Financiera()
            {
                listaDePrestamos = new List<Prestamo>();
            }

            public Financiera(string razonSocial) : this()
            {
                this.razonSocial = razonSocial;
            }

            #endregion

            #region Métodos

            private float CalcularInteresGanado(TipoDePrestamo tipoPrestamos)
            {
                float retorno = 0;
                switch (tipoPrestamos)
                {
                    case TipoDePrestamo.Pesos:
                        {
                            foreach  (Prestamo p in this.ListaDePrestamos)
                            {
                                if (p is PrestamoPesos)
                                {
                                    retorno += ((PrestamoPesos)p).Interes;
                                }
                            }
                            break;
                        }
                    case TipoDePrestamo.Dolares:
                        {
                            foreach (Prestamo p in this.ListaDePrestamos)
                            {
                                if (p is PrestamoDolar)
                                {
                                    retorno += ((PrestamoDolar)p).Interes;
                                }
                            }
                            break;
                        }
                    case TipoDePrestamo.Todos:
                        {
                            retorno += this.CalcularInteresGanado(TipoDePrestamo.Dolares) + this.CalcularInteresGanado(TipoDePrestamo.Pesos);
                            break;
                        }
                    default:
                        {
                            retorno = 0;
                            break;
                        }
                }
                return retorno;
            }

            public static string Mostrar(Financiera financiera)
            {
                return (string)financiera;
            }

            public void OrdenarPrestamos()
            {
                this.listaDePrestamos.Sort(Prestamo.OrdenarPorFecha);
            }

            #endregion

            #region Operadores

            public static explicit operator string(Financiera financiera)
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendFormat("Razón Social:      {0}   ", financiera.RazonSocial);
                cadena.AppendFormat("Intereses totales: {0}   ", financiera.InteresesTotales);
                cadena.AppendFormat("Intereses pesos:   {0}   ", financiera.InteresesEnPesos);
                cadena.AppendFormat("Intereses dolares: {0}\n", financiera.InteresesEnDolares);
                foreach (Prestamo p in financiera.ListaDePrestamos)
                {
                    cadena.AppendLine(p.Mostrar());
                }
                return cadena.ToString();
            }

            public static bool operator ==(Financiera financiera, Prestamo prestamo)
            {
                foreach (Prestamo p in financiera.listaDePrestamos)
                {
                    if(p.Monto == prestamo.Monto && p.Vencimiento == prestamo.Vencimiento)
                    {
                        return true;
                    }
                }
                return false;
            }

            public static bool operator !=(Financiera financiera, Prestamo prestamo)
            {
                return !(financiera == prestamo);
            }

            public static Financiera operator +(Financiera financiera, Prestamo prestamoNuevo)
            {
                if(financiera != prestamoNuevo)
                {
                    financiera.listaDePrestamos.Add(prestamoNuevo);
                }
                return financiera;
            }

            #endregion
        }
    }
    
}
