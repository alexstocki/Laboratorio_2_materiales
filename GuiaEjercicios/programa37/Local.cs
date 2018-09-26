using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa37
{
    public class Local : Llamada
    {
        #region Atributos

        protected float costo;
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
            float retorno = this.Duracion * this.costo;
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

        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        #endregion Constructor
    }
}
