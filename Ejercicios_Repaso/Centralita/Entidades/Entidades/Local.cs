using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Local : Llamada
    {
        #region Atributos
        protected float costo;
        #endregion

        #region Propiedades
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        #endregion

        #region Metodos
        public Local(Llamada llamada, float costo)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        } 

        public Local(string origen, float duracion, string destino, float costo)
            : base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n", base.Mostrar());
            sb.AppendFormat("Costo: ${0}\n", this.CostoLlamada);

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            return this.costo * this.Duracion;
        }
        #endregion
    }
}
