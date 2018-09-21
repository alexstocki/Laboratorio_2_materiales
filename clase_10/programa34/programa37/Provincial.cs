using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa37
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        // propiedad
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        // métodos
        private float CalcularCosto()
        {
            float retorno;

            switch (franjaHoraria)
            {
                case Franja.Franja_1:
                    {
                        retorno = base.Duracion * (float)0.99;
                        break;
                    }
                case Franja.Franja_2:
                    {
                        retorno = base.Duracion * (float)1.25;
                        break;
                    }
                default:
                    {
                        retorno = base.Duracion * (float)0.66;
                        break;
                    }
            }
            return retorno;
        }

        public string Mostrar()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("{0}\nCosto de llamada: {1}, Franja horaria: {2}", base.Mostrar(), this.CostoLlamada, this.franjaHoraria);
            string retorno = constructor.ToString();
            return retorno;
        }

        public Provincial(Franja miFranja, Llamada llamada) :this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) :base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
    }

    public enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }
}
