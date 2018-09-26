using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa36
{
    public class AutoF1 : VehiculoDeCarrera
    {
        #region Atributos

        private short caballosDeFuerza;
        #endregion Atributos

        #region Propiedades

        public short CaballosDeFuerza
        {
            get
            {
                return this.caballosDeFuerza;
            }
            set
            {
                this.caballosDeFuerza = value;
            }
        }
        #endregion Propiedades

        #region Constructores
        public AutoF1(short numero, string escuderia) : base(numero, escuderia)
        {
        }

        public AutoF1(short numero, string escuderia, short caballos) : this(numero, escuderia)
        {
            this.CaballosDeFuerza = caballos;
        }
        #endregion Constructores

        #region Métodos
        public string MostrarDatos()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("Auto F1:\n{0}\nCaballos de fuerza: {1}", base.MostrarDatos(), this.CaballosDeFuerza);
            string retorno = constructor.ToString();
            return retorno;
        }
        #endregion Métodos

        #region Operadores
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if(a1.Numero == a2.Numero && a1.Escuderia == a2.Escuderia)
            {
                if(a1.CaballosDeFuerza == a2.CaballosDeFuerza)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion Operadores
    }
}
