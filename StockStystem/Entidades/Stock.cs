using System;
using System.Text;

namespace Entidades
{
    public class Stock
    {
        #region Atributos
        private string name;
        private string ticker;
        private float precioPesos;
        private float precioDolares;
        private float precioCCL;
        private DateTime diaDeCompra;
        #endregion

        #region Propiedades
        public string Name { get { return this.name; } }
        public string Ticker { get { return this.ticker; } }
        public float PrecioPesos { get { return this.precioPesos; } }
        public float PrecioDolares { get { return this.precioDolares; } }
        public float PrecioCCL { get { return this.precioCCL; } }
        public DateTime DiaDeCompra { get { return this.diaDeCompra; } }
        #endregion

        #region Constructor
        private Stock()
        {
            this.precioDolares = 0;
            this.precioCCL = 0;
            this.diaDeCompra = DateTime.Today;
        }

        public Stock(string name, string ticker, float precioPesos)
            : this()
        {
            this.name = name;
            this.ticker = ticker;
            this.precioPesos = precioPesos;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}\n", this.Name);
            sb.AppendFormat("{0}\n", this.Ticker);
            sb.AppendFormat("Comprado a: {0}\n", this.PrecioPesos);
            sb.AppendFormat("Fecha de compra: {0}\n", this.DiaDeCompra.ToString("dd/MM/yyyy")); 

            return sb.ToString();
        }

        /// <summary>
        /// Dos acciones son iguales si su nombre y
        /// ticker es el mismo
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>true si son iguales, 
        /// false caso contrario</returns>
        public static bool operator ==(Stock s1, Stock s2)
        {
            if (!(s1 is null) && !(s2 is null))
            {
                if (s1.Name == s2.Name && s1.Ticker == s2.Ticker)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Dos acciones son distintas si su nombre o tiker
        /// son diferentes
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>true si son distintas, 
        /// caso contrario false</returns>
        public static bool operator !=(Stock s1, Stock s2)
        {
            return !(s1 == s2);
        }
        #endregion
    }
}
