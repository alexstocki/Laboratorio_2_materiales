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
        /// <summary>
        /// Retorna la lista de productos que contiene
        /// Inventario
        /// </summary>
        public static List<Producto> Productos
        {
            get
            {
                return productos;
            }
        }
        #endregion Propiedades

        #region Constructor
        /// <summary>
        /// Constructor estático de Inventario.
        /// Inicializa la lista de productos.
        /// </summary>
        static Inventario()
        {
            productos = new List<Producto>();
        }
        #endregion Constructor

        #region Métodos
        /// <summary>
        /// Agrega un producto al Inventario siempre y cuando:
        /// producto no sea nulo y no se encuentre en Inventario.
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>true si se pudo agregar el producto, 
        /// false caso contrario</returns>
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

        /// <summary>
        /// Verifica si el producto ya se encuentra en Inventario
        /// </summary>
        /// <param name="producto"></param>
        /// <returns>true si está en Inventario, false caso contrario</returns>
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
        #endregion Métodos
    }
}
