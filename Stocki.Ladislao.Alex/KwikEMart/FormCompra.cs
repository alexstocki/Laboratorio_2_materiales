using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace KwikEMart
{
    public partial class FormCompra : Form
    {
        #region Atributos
        Cliente cliente;
        List<Producto> carrito;
        #endregion

        public FormCompra()
        {
            InitializeComponent();
        }

        private void FormCompra_Load(object sender, EventArgs e)
        {
            Cargardatagrids();
        }

        #region DataGridView
        /// <summary>
        /// Carga el datagridview con ls información de clientes, 
        /// carrito del cliente seleccionado 
        /// y el inventario del negocio
        /// </summary>
        private void Cargardatagrids()
        {
            this.dgv_Cliente.DataSource = null;
            this.dgv_Carrito.DataSource = null;
            this.dgv_Inventario.DataSource = null;

            foreach (Cliente c in Entidades.KwikEMart.ListaClientes)
            {
                if (c is null)
                {
                    Entidades.KwikEMart.ListaClientes.Remove(c);
                }
            }

            if (!(cliente is null))
            {
                foreach (int numProd in cliente.CodigoProductos)
                {
                    foreach (Producto producto in Inventario.Productos)
                    {
                        if (producto.CodigoProducto == numProd)
                        {
                            carrito.Add(producto);
                        }
                    }
                }
            }

            foreach (Producto p in Inventario.Productos)
            {
                if (p is null)
                {
                    Inventario.productos.Remove(p);
                }
            }

            this.dgv_Cliente.DataSource = Entidades.KwikEMart.ListaClientes;
            this.dgv_Carrito.DataSource = carrito;
            this.dgv_Inventario.DataSource = Inventario.Productos;
            ConfiguracionDatagrid();
        }

        /// <summary>
        /// Configuración de visualización del datagridview
        /// </summary>
        private void ConfiguracionDatagrid()
        {
            this.dgv_Cliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Cliente.AllowUserToResizeColumns = false;
            this.dgv_Cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Carrito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Carrito.AllowUserToResizeColumns = false;
            this.dgv_Carrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Inventario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Inventario.AllowUserToResizeColumns = false;
            this.dgv_Inventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion

        #region Botones
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRealizarCompra_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarACarrito_Click(object sender, EventArgs e)
        {
            if(this.dgv_Inventario.SelectedRows.Count > 0)
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
