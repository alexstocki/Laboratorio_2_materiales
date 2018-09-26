using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa36
{
    public class MotoCross : VehiculoDeCarrera
    {
        #region Atributos

        private short cilindrada;
        #endregion Atributos

        #region Propiedades

        public short Cilindrada
        {
            get
            {
                return this.cilindrada;
            }
            set
            {
                this.cilindrada = value;
            }
        }
        #endregion Propiedades

        #region Constructores

        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
        }

        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.Cilindrada = cilindrada;
        }
        #endregion Constructores

        #region Métodos

        public string MostrarDatos()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("Moto: \n{0}\n{1}", base.MostrarDatos(), this.Cilindrada);
            string retorno = constructor.ToString();
            return retorno;
        }
        #endregion Métodos

        #region Operadores

        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            bool retorno = false;
            if(a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia)
            {
                if(a1.Cilindrada == a2.Cilindrada)
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
        #endregion Operadores
    }
}
