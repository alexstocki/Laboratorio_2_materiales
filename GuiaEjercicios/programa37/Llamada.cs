using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa37
{
    public class Llamada
    {
        #region Atributos

        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion Atributos

        #region Propiedades

        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        #endregion Propiedades

        #region Constructor

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion Constructor

        #region Métodos

        public string Mostrar()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("Duracion: {0}\nOrigen: {1}   Destino: {2}", this.Duracion, this.NroOrigen, this.NroDestino);
            string retorno = constructor.ToString();
            return retorno;
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            //int retorno;
            //if(llamada1.Duracion > llamada2.Duracion)
            //{
            //    retorno = 1;
            //}
            //else if(llamada1.Duracion == llamada2.Duracion)
            //{
            //    retorno = 0;
            //}
            //else
            //{
            //    retorno = -1;
            //}
            //return retorno;
            return llamada1.Duracion.CompareTo(llamada2.Duracion);
        }
        #endregion Métodos
    }

    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }
}
