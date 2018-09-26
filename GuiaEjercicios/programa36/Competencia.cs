using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa36
{
    public class Competencia
    {
        #region Atributos

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;
        #endregion Atributos

        #region Propiedades

        public short CantidadCompetidores
        {
            get
            {
                return this.cantidadCompetidores;
            }
            set
            {
                this.cantidadCompetidores = value;
            }
        }

        public short CantidadVueltas
        {
            get
            {
                return this.cantidadVueltas;
            }
            set
            {
                this.cantidadVueltas = value;
            }
        }

        public VehiculoDeCarrera this[int i]
        {
            get
            {
                return this.competidores[i];
            }
        }

        public TipoCompetencia Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }
        #endregion Propiedades

        #region Constructores

        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) :this()
        {
            this.CantidadCompetidores = cantidadCompetidores;
            this.CantidadVueltas = cantidadVueltas;
            this.Tipo = tipo;
        }
        #endregion Constructores

        #region Métodos

        public string MostrarDatos()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("Autos en competencia: {0}\nCantidad de vueltas: {1}\nTipo: {2}", this.competidores.Count(), this.cantidadVueltas, this.Tipo);
            string retorno = constructor.ToString();
            return retorno;
        }
        #endregion Métodos

        #region Operadores

        public static bool operator +(Competencia c, VehiculoDeCarrera v)
        {
            if(c != v)
            {
                Random rnum = new Random();
                v.CantidadCombustible = (short)rnum.Next(15, 101);
                v.EnCompetencia = true;
                v.VueltasRestantes = (c.cantidadVueltas);
                c.competidores.Add(v);
                return true;
            }
            return false;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera v)
        {
            if(c == v)
            {
                c.competidores.Remove(v);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera v)
        {
            if (c.competidores.Count() <= c.cantidadCompetidores - 1)
            {
                foreach (VehiculoDeCarrera competidor in c.competidores)
                {
                    if (competidor == v)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera v)
        {
            return !(c == v);
        }
        #endregion Operadores
    }

    public enum TipoCompetencia
    {
        F1,
        MotoCross
    }
}
