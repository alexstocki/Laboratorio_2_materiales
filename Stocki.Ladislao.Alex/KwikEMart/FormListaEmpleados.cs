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
    public partial class FormListaEmpleados : Form
    {
        public FormListaEmpleados()
        {
            InitializeComponent();
        }

        private void FormListaEmpleados_Load(object sender, EventArgs e)
        {
            CargardatagridListaEmpleados();
        }

        #region DataGridView
        /// <summary>
        /// Carga el datagridview con la lista de empleados 
        /// que posee el negocio
        /// </summary>
        private void CargardatagridListaEmpleados()
        {
            this.dgv_Empleados.DataSource = null;
            foreach (Empleado e in Entidades.KwikEMart.ListaEmpleados)
            {
                if (e is null)
                {
                    Entidades.KwikEMart.ListaEmpleados.Remove(e);
                }
            }
            this.dgv_Empleados.DataSource = Entidades.KwikEMart.ListaEmpleados;
            ConfiguracionDatagrid();
        }

        /// <summary>
        /// Configuración visual del datagridview
        /// </summary>
        private void ConfiguracionDatagrid()
        {
            this.dgv_Empleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Empleados.AllowUserToResizeColumns = false;
            this.dgv_Empleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        #endregion
    }
}
