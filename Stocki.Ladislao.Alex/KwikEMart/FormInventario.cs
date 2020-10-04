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
    public partial class FormInventario : Form
    {
        List<Producto> listaProd;
        public FormInventario(Producto p1)
        {
            InitializeComponent();
            listaProd = new List<Producto>();
            listaProd.Add(p1);
            Producto pp = new Producto("manaos", 3, 57, 99);
            listaProd.Add(pp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Producto p in this.listaProd)
            {
                Inventario.AgregarAInventario(p);
            }
            List<Producto> listaPrueba = new List<Producto>();
            CargardatagridInventario();
        }

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
            this.dgv_Inventario.DataSource = Inventario.Productos;
            ConfiguracionDatagrid();
        }

        private void ConfiguracionDatagrid()
        {
            this.dgv_Inventario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Inventario.AllowUserToResizeColumns = false;
        }
    }
}
