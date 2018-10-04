using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace PrestamosPersonales
    {
        public class PrestamoDolar : Prestamo
        {
            #region Atributo

            private PeriodicidadDePagos periodicidad;

            #endregion

            #region Propiedad

            public float Interes
            {
                get
                {
                    return this.CalcularInteres();
                }
            }

            public PeriodicidadDePagos Periodicidad
            {
                get
                {
                    return this.periodicidad;
                }
            }

            #endregion

            #region Constructores

            public PrestamoDolar(float monto, DateTime vencimiento, PeriodicidadDePagos periodicidad)
                :base(monto, vencimiento)
            {
                this.periodicidad = periodicidad;
            }

            public PrestamoDolar(Prestamo prestamo, PeriodicidadDePagos periodicidad)
                :this(prestamo.Monto, prestamo.Vencimiento, periodicidad)
            {
            }

            #endregion

            #region Métodos

            private float CalcularInteres()
            {
                float retorno = 0;
                //PeriodicidadDePagos periodo = this.Periodicidad;
                switch (this.Periodicidad)
                {
                    case PeriodicidadDePagos.Mensual:
                        {
                            retorno = 25;
                            break;
                        }
                    case PeriodicidadDePagos.Bimestral:
                        {
                            retorno = 35;
                            break;
                        }
                    case PeriodicidadDePagos.Trimestral:
                        {
                            retorno = 40;
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

            public override void ExtenderPlazo(DateTime nuevoVencimiento)
            {
                if(nuevoVencimiento > this.Vencimiento)
                {
                    int diasDiferencia = (nuevoVencimiento - this.Vencimiento).Days;
                    float nuevoMonto = diasDiferencia * 2.5f;
                    this.monto += nuevoMonto;
                }
                this.Vencimiento = nuevoVencimiento;
            }

            public override string Mostrar()
            {
                StringBuilder cadena = new StringBuilder();
                cadena.Append(base.Mostrar());
                cadena.AppendFormat("PD => PERIODICIDAD:     {0}   ", this.Periodicidad);
                cadena.AppendFormat("INTERES:          {0}", this.Interes);
                return cadena.ToString();
            }

            #endregion
        }
    }
}
