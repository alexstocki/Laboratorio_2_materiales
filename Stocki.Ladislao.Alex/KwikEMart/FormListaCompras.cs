using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace KwikEMart
{
    public partial class FormListaCompras : Form
    {
        public FormListaCompras()
        {
            InitializeComponent();
        }

        private void FormListaCompras_Load(object sender, EventArgs e)
        {
            CargardatagridEmpleados();
        }

        #region DataGridView
        /// <summary>
        /// Carga el datagridview con los datos de los empleados y las compras
        /// </summary>
        private void CargardatagridEmpleados()
        {
            this.dgv_ListaEmpleados.DataSource = null;
            foreach (Empleado e in Entidades.KwikEMart.ListaEmpleados)
            {
                if (e is null)
                {
                    Entidades.KwikEMart.ListaEmpleados.Remove(e);
                }
            }
            this.dgv_ListaEmpleados.DataSource = Entidades.KwikEMart.ListaEmpleados;
            ConfiguracionDatagrid();
        }

        /// <summary>
        /// Configuración de la visualización del datagridview
        /// </summary>
        private void ConfiguracionDatagrid()
        {
            this.dgv_ListaEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_ListaEmpleados.AllowUserToResizeColumns = false;
            this.dgv_ListaEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion

        #region Botones
        /// <summary>
        /// Filtra las compras para que muestre solamente las del Empleado
        /// seleccionado en el datagridview de empleados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltarPorEmpleado_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
