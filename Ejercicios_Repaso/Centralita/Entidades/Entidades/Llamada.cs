using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Entidades
{
    public class Llamada
    {
        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Propiedades
        public float Duracion
        {
            get { return this.duracion; }
        }

        public string NroDestino
        {
            get { return this.nroDestino; }
        }

        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }
        #endregion

        #region Metodos
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Duracion: {0}\n", this.Duracion);
            sb.AppendFormat("Numero Origen: {0}\tNumero Destino: {1}", this.NroOrigen, this.NroDestino);

            return sb.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (!(llamada1 is null) && !(llamada2 is null))
            {
                if (llamada1.Duracion > llamada2.Duracion)
                {
                    return 1;
                }
                else if (llamada1.Duracion < llamada2.Duracion)
                {
                    return -1;
                }
            }

            return 0;
        }
        #endregion

        public enum TipoLlamada
        {
            Local, 
            Provincial, 
            Todas
        }
    }
}
