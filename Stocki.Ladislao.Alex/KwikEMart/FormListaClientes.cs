using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KwikEMart
{
    public partial class FormListaClientes : Form
    {
        public FormListaClientes()
        {
            InitializeComponent();
        }

        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            CargardatagridListaClientes();
        }

        #region DataGridView
        /// <summary>
        /// Carga el datagridview con la lista de clientes
        /// que posee el negocio
        /// </summary>
        private void CargardatagridListaClientes()
        {
            this.dgv_ListaClientes.DataSource = null;
            foreach (Cliente c in Entidades.KwikEMart.ListaClientes)
            {
                if (c is null)
                {
                    Entidades.KwikEMart.ListaClientes.Remove(c);
                }
            }
            this.dgv_ListaClientes.DataSource = Entidades.KwikEMart.ListaClientes;
            ConfiguracionDatagrid();
        }

        /// <summary>
        /// Configuración visual del datagridview
        /// </summary>
        private void ConfiguracionDatagrid()
        {
            this.dgv_ListaClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ListaClientes.AllowUserToResizeColumns = false;
            this.dgv_ListaClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion
    }
}
