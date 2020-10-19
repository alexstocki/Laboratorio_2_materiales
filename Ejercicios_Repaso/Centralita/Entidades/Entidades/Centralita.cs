using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Entidades
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region Propiedades
        public float GananciasPorLocal
        {
            get {return this.CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get {return this.listaDeLlamadas; }
        }
        #endregion

        #region Metodos
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            double ganancias = 0;

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada llamadaLocal in this.Llamadas)
                    {
                        if (llamadaLocal is Local)
                        {
                            ganancias += ((Local)llamadaLocal).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada llamadaProvincial in this.Llamadas)
                    {
                        if (llamadaProvincial is Provincial)
                        {
                            ganancias += ((Provincial)llamadaProvincial).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada llamada in this.Llamadas)
                    {
                        ganancias += this.CalcularGanancia(Llamada.TipoLlamada.Provincial) + this.CalcularGanancia(Llamada.TipoLlamada.Local);
                    }
                    break;
            }

            return (float)ganancias;
        }

        private Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public string Mostrar()
        {

        }

        public void OrdenarLlamada()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion
    }
}
