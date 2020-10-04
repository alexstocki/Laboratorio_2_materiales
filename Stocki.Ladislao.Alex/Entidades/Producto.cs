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
        public string NombreProducto
        {
            get
            {
                return this.nombreProducto;
            }
        }

        public int CodigoProducto
        {
            get
            {
                return this.codigoProducto;
            }
        }

        public double PrecioProducto
        {
            get
            {
                return this.precioProducto;
            }
        }

        public int StockProducto
        {
            get
            {
                return this.stockProducto;
            }

            set
            {
                this.stockProducto = value;
            }
        }
        #endregion Propiedades

        #region Constructor
        public Producto()
        {
            this.stockProducto = -1;
        }

        public Producto(string nombre, int codigo, double precio)
        {
            this.nombreProducto = nombre;
            this.codigoProducto = codigo;
            this.precioProducto = precio;
        }

        public Producto(string nombre, int codigo, double precio, int stock):this(nombre, codigo, precio)
        {
            this.stockProducto = stock;
        }
        #endregion Constructor

        #region Operadores
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.CodigoProducto.ToString());
            sb.AppendLine(this.nombreProducto);
            sb.AppendLine(this.PrecioProducto.ToString());
            sb.AppendLine(this.StockProducto.ToString());

            return sb.ToString();
        }

        public static bool operator +(Producto prod, int num)
        {
            if(prod.StockProducto > 0)
            {
                prod.StockProducto = prod.StockProducto + num;
                return true;
            }

            return false;
        }

        public static bool operator -(Producto prod, int num)
        {
            if (prod.StockProducto > 0)
            {
                prod.StockProducto = prod.StockProducto - num;
                return true;
            }

            return false;
        }

        public static bool operator ==(Producto prod1, Producto prod2)
        {
            if (!(prod1 is null) && !(prod2 is null))
            {
                if (prod1.NombreProducto == prod2.NombreProducto)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }
        #endregion Operadores
    }
}
