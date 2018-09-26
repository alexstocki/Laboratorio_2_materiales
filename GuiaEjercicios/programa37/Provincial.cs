using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa37
{
    public class Provincial : Llamada
    {
        #region Atributos

        protected Franja franjaHoraria;
        #endregion Atributos

        #region Propiedades

        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        #endregion Propiedades

        #region Métodos

        private float CalcularCosto()
        {
            float retorno;
            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    {
                        retorno = this.Duracion * 0.99f;
                        break;
                    }
                case Franja.Franja_2:
                    {
                        retorno = this.Duracion * 1.25f;
                        break;
                    }
                default:
                    {
                        retorno = this.Duracion * 0.66f;
                        break;
                    }
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("{0}\nCosto de llamada: {1}", base.Mostrar(), this.CostoLlamada);
            string retorno = constructor.ToString();
            return retorno;
        }
        #endregion Métodos

        #region Constructor

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion Constructor

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
    }
}
