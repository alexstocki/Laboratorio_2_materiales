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
    public partial class FormCargaProducto : Form
    {
        #region Atributos
        string auxNombre;
        int auxCodigo, auxStock, codProd, stoProd;
        double auxPrecio, preProd;
        Producto producto;
        #endregion

        public FormCargaProducto()
        {
            InitializeComponent();
        }

        private void FormCargaProducto_Load(object sender, EventArgs e)
        {

        }

        #region Botones
        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            auxCodigo = Validaciones.NumeroProducto();
            auxNombre = txtboxNombreProducto.Text;

            preProd = Validaciones.TextToDouble(txtboxPrecioProducto.Text);
            if (preProd >= 0)
            {
                auxPrecio = preProd;

                stoProd = Validaciones.TextToInt(txtboxStockProducto.Text);
                if (stoProd >= 0)
                {
                    auxStock = stoProd;
                    this.producto = new Producto(auxNombre, auxCodigo, auxPrecio, auxStock);
                    if (Inventario.AgregarAInventario(producto))
                    {
                        MessageBox.Show("Producto cargado exitosamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se cargó el producto al inventario.");
                    }
                }
            }
        }
        #endregion
    }
}
