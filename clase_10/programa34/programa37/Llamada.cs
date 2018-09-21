using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa37
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        // propiedades
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        // métodos
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroDestino = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder constructor = new StringBuilder();
            string retorno;
            constructor.AppendFormat("Duración: {}\nNro Origen: {1}\nNro Destino: {2}", this.Duracion, this.NroDestino, this.NroOrigen);
            retorno = constructor.ToString();
            return retorno;
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno;

            if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            else if(llamada1.Duracion == llamada2.Duracion)
            {
                retorno = 0;
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }
    }

    enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }
}

