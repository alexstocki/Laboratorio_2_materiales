using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        #region Atributos
        string nombreProducto;
        int codigoProducto;
        double precioProducto;
        int stockProducto;
        #endregion Atributos

        #region Propiedades
        /// <summary>
        /// Retorna el nombre del producto
        /// </summary>
        public string NombreProducto
        {
            get
            {
                return this.nombreProducto;
            }
        }

        /// <summary>
        /// Retorna el código del producto
        /// </summary>
        public int CodigoProducto
        {
            get
            {
                return this.codigoProducto;
            }
        }

        /// <summary>
        /// Retorna el precio del producto
        /// </summary>
        public double PrecioProducto
        {
            get
            {
                return this.precioProducto;
            }
        }

        /// <summary>
        /// Retorna el stock del producto
        /// Modifica el stock del producto
        /// </summary>
        public int StockProducto
        {
            get
            {
                return this.stockProducto;
            }

            set
            {
                if(value < this.StockProducto || value > this.StockProducto)
                {
                    this.stockProducto = value;
                }
            }
        }
        #endregion Propiedades

        #region Constructor
        /// <summary>
        /// Constructor de Producto 
        /// </summary>
        public Producto(string nombre, int codigo, double precio, int stock)
        {
            this.nombreProducto = nombre;
            this.codigoProducto = codigo;
            this.precioProducto = precio;
            this.stockProducto = stock;
        }
        #endregion Constructor

        #region Operadores
        /// <summary>
        /// Sobrecarga del método ToString
        /// Retorna un string con los datos del producto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.CodigoProducto.ToString());
            sb.AppendLine(this.nombreProducto);
            sb.AppendLine(this.PrecioProducto.ToString());
            sb.AppendLine(this.StockProducto.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// Aumenta el stock del producto
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool operator +(Producto prod, int num)
        {
            if(prod.StockProducto > 0)
            {
                prod.StockProducto = prod.StockProducto + num;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Sobrecarga del operador -
        /// Disminuye el stock del producto
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool operator -(Producto prod, int num)
        {
            if (prod.StockProducto > 0)
            {
                prod.StockProducto = prod.StockProducto - num;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Sobrecarga del operador ==
        /// Dos productos son iguales cuando:
        /// Su codigo de producto o nombre son iguales
        /// </summary>
        /// <param name="prod1"></param>
        /// <param name="prod2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto prod1, Producto prod2)
        {
            if (!(prod1 is null) && !(prod2 is null))
            {
                if (prod1.CodigoProducto == prod2.CodigoProducto || prod1.NombreProducto == prod2.NombreProducto)
                {
                    return true;  
                }
            }

            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// Dos productos son distintos si:
        /// Su codigo de producto y nombre son distintos.
        /// </summary>
        /// <param name="prod1"></param>
        /// <param name="prod2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }
        #endregion Operadores
    }
}
