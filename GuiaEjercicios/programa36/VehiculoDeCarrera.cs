using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa36
{
    public class VehiculoDeCarrera
    {
        #region Atributos

        private short cantidadCombustible;
        private string escuderia;
        private bool enCompetencia;
        private short numero;
        private short vueltasRestantes;
        #endregion Atributos

        #region Propiedades

        public short CantidadCombustible
        {
            get
            {
                return this.cantidadCombustible;
            }
            set
            {
                this.cantidadCombustible = value;
            }
        }

        public bool EnCompetencia
        {
            get
            {
                return this.enCompetencia;
            }
            set
            {
                this.enCompetencia = value;
            }
        }

        public string Escuderia
        {
            get
            {
                return this.escuderia;
            }
            set
            {
                this.escuderia = value;
            }
        }

        public short Numero
        {
            get
            {
                return this.numero;
            }
            set
            {
                this.numero = value;
            }
        }

        public short VueltasRestantes
        {
            get
            {
                return this.vueltasRestantes;
            }
            set
            {
                this.vueltasRestantes = value;
            }
        }
        #endregion Propiedades

        #region Métodos

        protected string MostrarDatos()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("Escuderia: {0}   Numero: {1}\nEn competencia: {2}\nVueltas restantes: {3}   Combustible restante: {4}", this.Escuderia, this.Numero, this.EnCompetencia, this.VueltasRestantes, this.CantidadCombustible);
            string retorno = constructor.ToString();
            return retorno;
        }
        #endregion Métodos

        #region Constructor

        protected VehiculoDeCarrera(short numero, string escuderia)
        {
            this.Numero = numero;
            this.Escuderia = escuderia;
        }
        #endregion Constructor
    }
}
