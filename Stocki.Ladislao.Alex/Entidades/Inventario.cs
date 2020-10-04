using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.XPath;

namespace Entidades
{
    public static class Inventario
    {
        #region Atributos
        public static List<Producto> productos;
        #endregion Atributos

        #region Propiedades
        public static List<Producto> Productos
        {
            get
            {
                //Inventario.EliminarVacio();
                return productos;
            }
        }
        #endregion Propiedades

        #region Constructor
        static Inventario()
        {
            productos = new List<Producto>();
        }
        #endregion Constructor

        #region Métodos
        public static bool AgregarAInventario(Producto producto)
        {
            if (!(producto is null))
            {
                if (!EstaEnInventario(producto))
                {
                    productos.Add(producto);
                    return true;
                }
            }

            return false;
        }

        private static bool EstaEnInventario(Producto producto)
        {
           if (Productos.Count >= 1)
            {
                foreach (Producto prod in productos)
                {
                    if (prod == producto)
                    {
                        return true;
                    }
                }

           }

            return false;
        }

        private static void EliminarVacio()
        {
            foreach (Producto p in Inventario.Productos)
            {
                if (p is null)
                {
                    Inventario.Productos.Remove(p);
                }
            }
        }
        

        public static void MostrarProductos(List<int> codigosProducto)
        {
            foreach (int codigo in codigosProducto)
            {
                foreach (Producto prod in Productos)
                {
                    if (prod.CodigoProducto == codigo)
                    {

                    }
                }
            }
        }
        #endregion Métodos
    }
}
