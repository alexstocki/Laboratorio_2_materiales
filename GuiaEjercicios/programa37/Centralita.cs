using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa37
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Propiedades

        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }

        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion Propiedades

        #region Métodos

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float ganancia = 0;
            switch (tipo)
            {
                case TipoLlamada.Local:
                    {
                        foreach(Llamada llamadaLocal in listaDeLlamadas)
                        {
                            if(llamadaLocal is Local)
                            {
                                ganancia += ((Local)llamadaLocal).CostoLlamada;
                            }
                            
                        }
                        break;
                    }
                case TipoLlamada.Provincial:
                    {
                        foreach(Llamada llamadaProvincial in listaDeLlamadas)
                        {
                            if(llamadaProvincial is Provincial)
                            {
                                ganancia += ((Provincial)llamadaProvincial).CostoLlamada;
                            }
                        }
                        break;
                    }
                case TipoLlamada.Todas:
                    {
                        foreach(Llamada llamada in listaDeLlamadas)
                        {
                            ganancia = this.CalcularGanancia(TipoLlamada.Local) + this.CalcularGanancia(TipoLlamada.Provincial);
                        }
                        break;
                    }
            }
            return ganancia;
        }

        public string Mostrar()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("Razón social: {0}\nGanancia total: {1}\nGanancias locales: {2}   Ganancias provinciales: {3}\nLlamadas realizadas: {4}", this.razonSocial, this.GananciasPorTotal, this.GananciasPorLocal, this.GananciasPorProvincial, this.listaDeLlamadas.Count());
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                constructor.AppendLine("\nDetalle de llamada: " + llamada.Mostrar());
            }
            string retorno = constructor.ToString();
            return retorno;
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion Métodos

        #region Constructores

        public Centralita()
        {
            listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion Constructores
    }
}
