using Entidades;
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
    public partial class FormInventario : Form
    {
        #region Atributos
        List<Producto> listaProdPocasUnidades;
        bool mostrandoTodo;
        #endregion

        public FormInventario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargardatagridInventario();
            listaProdPocasUnidades = new List<Producto>();
        }

        #region DataGridView
        /// <summary>
        /// Carga el datagridview con la información de los 
        /// productos dentro del Inventario del negocio.
        /// </summary>
        private void CargardatagridInventario()
        {
            this.dgv_Inventario.DataSource = null;
            foreach (Producto p in Inventario.Productos)
            {
                if (p is null)
                {
                    Inventario.productos.Remove(p);
                }
            }

            mostrandoTodo = true;
            this.dgv_Inventario.DataSource = Inventario.Productos;
            ConfiguracionDatagrid();
        }

        private void RecargarDatagridInventario(List<Producto> lista)
        {
            this.dgv_Inventario.DataSource = null;
            this.dgv_Inventario.DataSource = lista;
            ConfiguracionDatagrid();
        }

        /// <summary>
        /// Configuración visual del datagridview
        /// </summary>
        private void ConfiguracionDatagrid()
        {
            this.dgv_Inventario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Inventario.AllowUserToResizeColumns = false;
            this.dgv_Inventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion

        #region Botones
        /// <summary>
        /// Filtra el inventario por aquellos productos
        /// con menos de 10 unidades de stock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltrarStock10_Click(object sender, EventArgs e)
        {
            if (mostrandoTodo)
            {
                if (listaProdPocasUnidades.Count == 0)
                {
                    foreach (Producto p in Inventario.Productos)
                    {
                        if (p.StockProducto < 10)
                        {
                            listaProdPocasUnidades.Add(p);
                        }
                    }
                }

                mostrandoTodo = false;
                RecargarDatagridInventario(listaProdPocasUnidades);
            }
        }

        /// <summary>
        /// Vuelve a cargar todo el inventario de productos
        /// que contiene el sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTodoInventario_Click(object sender, EventArgs e)
        {
            if (!(mostrandoTodo))
            {
                CargardatagridInventario();
            }
        }
        #endregion

    }
}
