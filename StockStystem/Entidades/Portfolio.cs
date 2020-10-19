using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Portfolio
    {
        #region Atributos
        private List<Stock> stockList;
        #endregion

        #region Propiedades
        private List<Stock> StockList
        {
            get { return this.stockList; }
        }
        #endregion

        #region Constructor
        
        public Portfolio()
        {
            this.stockList = new List<Stock>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Suma una accion a la cartera
        /// </summary>
        /// <param name="p"></param>
        /// <param name="s"></param>
        /// <returns>true si se pudo agregar la accion a la cartera
        /// false caso contrario</returns>
        public static bool operator +(Portfolio p, Stock s)
        {
            if (!(p is null) && !(s is null))
            {
                p.stockList.Add(s);
                return true;
            }

            return false;
        }


        public override string ToString()
        {
            List<Stock> stocksDone = new List<Stock>();
            StringBuilder sb = new StringBuilder();
            bool esta = false;
                
            sb.AppendFormat("Accion\tTicker\tFecha de compra\tPrecio Promedio\n");
            foreach (Stock s in this.StockList)
            {
                foreach (Stock sto in stocksDone)
                {
                    if (sto == s)
                    {
                        esta = true;
                    }
                }

                if (esta == false)
                {
                    stocksDone.Add(s);
                    sb.AppendFormat("\n{0}{1}\nAcciones: {2}\n", s.ToString(), this.GetProm(s), this.GetCount(s));
                }
                esta = false;
            }

            return sb.ToString();
        }
        
        /// <summary>
        /// Retorna la cantidad de acciones
        /// que tenemos de la empresa pasada por
        /// parametro
        /// </summary>
        /// <param name="s">Accion a chequear</param>
        /// <returns>int que representa la cantidad de acciones de la empresa
        /// dentro del portfolio</returns>
        private int GetCount(Stock s)
        {
            int count = 0;

            foreach (Stock stock in this.StockList)
            {
                if (stock == s)
                {
                    count++;
                }
            }

            return count;
        }

        /// <summary>
        /// Obtiene el promedio de compra por accion 
        /// </summary>
        /// <param name="stock">Accion a chequear</param>
        /// <returns>float que representa el promedio de compra de
        /// la empresa</returns>
        private float GetProm(Stock stock)
        {
            float total, count;

            total = this.GetTotal(stock);
            count = this.GetCount(stock);

            return total / count;
        }

        /// <summary>
        /// Obtiene el total invertido para la compra de las acciones
        /// de la empresa pasada por parametro
        /// </summary>
        /// <param name="stock">Accion a chequear</param>
        /// <returns>float representa el monto total pagado
        /// por las acciones</returns>
        private float GetTotal(Stock stock)
        {
            float total = 0;

            foreach (Stock s in this.StockList)
            {
                if (s == stock)
                {
                    total += s.PrecioPesos;
                }
            }

            return total;
        }
        #endregion
    }
}
