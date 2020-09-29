using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Inventario
    {
        #region Atributos
        List<Producto> productos;
        #endregion Atributos

        #region Propiedades
        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
        }
        #endregion Propiedades

        #region Constructor
        public Inventario()
        {
            this.productos = new List<Producto>();
        }
        #endregion Constructor

        #region Métodos
        public bool AgregarAInventario(Producto producto)
        {
            if (!(this.EstaEnInventario(this.Productos, producto)))
            {
                this.productos.Add(producto);
                return true;
            }

            return false;
        }

        private bool EstaEnInventario(List<Producto> listaProd, Producto producto)
        {
            foreach (Producto prod in listaProd)
            {
                if (prod == producto)
                {
                    return true;
                }
            }

            return false;
        }
        #endregion Métodos
    }
}
