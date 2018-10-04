using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace PrestamosPersonales
    {
        public class PrestamoPesos : Prestamo
        {
            #region Atributo

            private float porcentajeInteres;

            #endregion

            #region Propiedad

            public float Interes
            {
                get
                {
                    return this.CalcularInteres();
                }
            }

            #endregion

            #region Constructor

            public PrestamoPesos(float monto, DateTime vencimiento, float interes)
                :base(monto, vencimiento)
            {
                this.porcentajeInteres = interes;
            }

            public PrestamoPesos(Prestamo prestamo, float porcentajeInteres)
                :this(prestamo.Monto, prestamo.Vencimiento, porcentajeInteres)
            {
            }

            #endregion

            #region Método

            private float CalcularInteres()
            {
                float retorno = (this.Monto * this.porcentajeInteres) / 100;
                return retorno;
            }

            public override void ExtenderPlazo(DateTime nuevoVencimiento)
            {
                int diferenciaDias = (nuevoVencimiento - this.Vencimiento).Days;
                float nuevoInteres = diferenciaDias * (float)0.25;
                this.porcentajeInteres += nuevoInteres;
                this.Vencimiento = nuevoVencimiento;
            }

            public override string Mostrar()
            {
                StringBuilder cadena = new StringBuilder();
                cadena.Append(base.Mostrar());
                cadena.AppendFormat("PP => % INTERES:        {0}   ", this.porcentajeInteres);
                cadena.AppendFormat("INTERES:     {0}", this.Interes);
                return cadena.ToString();
            }

            #endregion
        }
    }
  
}
