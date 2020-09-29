using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Cliente : Persona
    {
        #region Atributos
        int numeroDeCliente;
        List<int> codigoProductos;
        List<Compra> comprasCliente;
        #endregion Atributos

        #region Propiedades
        protected override string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        /// <summary>
        /// Retorna la lista de productos del carro del cliente.
        /// REVEER SI VALE LA PENA MANTENERLA
        /// </summary>
        public List<Compra> Productos
        {
            get
            {
                return this.comprasCliente;
            }
        }

        /// <summary>
        /// Retorna la lista de códigos de los productos del carro del cliente
        /// </summary>
        public List<int> CodigoProductos
        {
            get
            {
                return this.codigoProductos;
            }
        }
        #endregion Propiedades

        #region Constructores
        /// <summary>
        /// Constructor Cliente
        /// Deriva valores al constructor de la clase base
        /// El resto los procesa por ser exclusivos de este
        /// tipo de objeto.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="numeroCliente"></param>
        public Cliente(string nombre, string apellido, string dni, int numeroCliente) 
            : base(nombre, apellido, dni)
        {
            this.comprasCliente = new List<Compra>(); 
            this.codigoProductos = new List<int>();
            this.numeroDeCliente = numeroCliente;
        }
        #endregion Constructores

        #region Métodos
        /// <summary>
        /// Agrega un producto al carro del cliente
        /// siempre y cuando haya stock disponible del producto
        /// </summary>
        /// <param name="producto"></param>
        public void AgregarACarro(Producto producto)
        {
            if (producto - 1)
            {
                this.codigoProductos.Add(producto.CodigoProducto);
            }
        }

        public void Pagar()
        {
            Compra compra = new Compra(this.CodigoProductos, this);
            this.comprasCliente.Add(compra);
        }
        #endregion Métodos
    }
}
