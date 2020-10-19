using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Provincial : Llamada
    {
        #region Atributos
        protected Franja franjaHoraria;
        #endregion

        #region Propiedades
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }
        #endregion

        #region Metodos
        public Provincial(Franja miFranja, Llamada llamada)
            : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            double costo = 0;

            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = this.Duracion * 0.99;
                    break;
                case Franja.Franja_2:
                    costo = this.Duracion * 1.25;
                    break;
                case Franja.Franja_3:
                    costo = this.Duracion * 0.66;
                    break;
                default:
                    costo = 0;
                    break;
            }

            return (float)costo;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n", base.Mostrar());
            sb.AppendFormat("Costo: ${0}\n", this.CostoLlamada);

            return sb.ToString();
        }
        #endregion

        public enum Franja
        {
            Franja_1, 
            Franja_2,
            Franja_3
        }
    }
}
