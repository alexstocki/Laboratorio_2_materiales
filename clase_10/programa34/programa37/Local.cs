using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa37
{
    public class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }

        private float CalcularCosto()
        {
            float retorno = this.duracion * this.costo;
            return retorno;
        }

        public Local(Llamada llamada, float costo) :this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        {

        }

        public Local(string origen, float duracion, string destino, float costo) 
            :base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public string Mostrar()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("{0}\nCosto de llamada: {1}", base.Mostrar(), this.CostoLlamada);
            string retorno = constructor.ToString();
            return retorno;
        }
    }
}
