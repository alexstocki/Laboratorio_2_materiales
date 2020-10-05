using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public sealed class Compra
    {
        #region Atributos
        List<int> codigoProducto;
        Cliente comprador;
        Empleado empleadoRegistro;
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna una lista con los códigos de los productos 
        /// que se compraron
        /// </summary>
        public List<int> CodigoProductos
        {
            get
            {
                return this.codigoProducto;
            }
        }

        /// <summary>
        /// Retorna el Cliente que realizó la compra
        /// </summary>
        public Cliente Comprador
        {
            get
            {
                return this.comprador;
            }
        }

        /// <summary>
        /// Retorna el Empleado que registró la compra
        /// </summary>
        public Empleado EmpleadoRegistro
        {
            get
            {
                return this.empleadoRegistro;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor privado que inicializa la lista de 
        /// códigos de productos
        /// </summary>
        private Compra()
        {
            this.codigoProducto = new List<int>();
        }

        /// <summary>
        /// Constructor Compra
        /// </summary>
        /// <param name="listaCodigos"></param>
        /// <param name="comprador"></param>
        public Compra(List<int> listaCodigos, Cliente comprador)
            : this()
        {
            this.codigoProducto = listaCodigos;
            this.comprador = comprador;
        }
        #endregion
    }
}
