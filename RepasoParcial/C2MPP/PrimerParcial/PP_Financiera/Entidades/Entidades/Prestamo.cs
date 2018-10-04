using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace PrestamosPersonales
    {
        public abstract class Prestamo
        {
            #region Atributos

            protected float monto;
            protected DateTime vencimiento;

            #endregion

            #region Propiedades

            public float Monto
            {
                get
                {
                    return this.monto;
                }
            }

            public DateTime Vencimiento
            {
                get
                {
                    return this.vencimiento;
                }

                set
                {
                    DateTime presente = DateTime.Now;
                    if (value > presente)
                    {
                        this.vencimiento = value;
                    }
                    else
                    {
                        this.vencimiento = presente;
                    }
                }
            }

            #endregion

            #region Constructor

            public Prestamo(float monto, DateTime vencimiento)
            {
                this.monto = monto;
                this.Vencimiento = vencimiento;
            }

            #endregion

            #region Métodos

            public abstract void ExtenderPlazo(DateTime nuevoVencimiento);

            public virtual string Mostrar()
            {
                StringBuilder cadena = new StringBuilder();
                cadena.AppendFormat("MONTO:         {0}   ", this.Monto);
                cadena.AppendFormat("VENCIMIENTO:   {0}   ", this.Vencimiento);
                return cadena.ToString();
            }

            public static int OrdenarPorFecha(Prestamo prestamo1, Prestamo prestamo2)
            {
                int retorno;
                if(prestamo1.Vencimiento > prestamo2.Vencimiento)
                {
                    retorno = 1;
                }
                else if(prestamo1.Vencimiento == prestamo2.Vencimiento)
                {
                    retorno = 0;
                }
                else
                {
                    retorno = -1;
                }
                return retorno;
            }

            #endregion
        }
    }
    
}
