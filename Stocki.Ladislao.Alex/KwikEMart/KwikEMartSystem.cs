using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace KwikEMart
{
    public partial class KwikEMartSystem : Form
    {
        #region Atributos
        List<Empleado> auxEmpleados;
        List<Cliente> auxClientes;
        List<Producto> auxProductos;
        List<int> auxCodProductos;
        Compra auxCompra;
        #endregion

        public KwikEMartSystem()
        {
            InitializeComponent();
            
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void KwikEMartSystem_Load(object sender, EventArgs e)
        {
            auxEmpleados = new List<Empleado>();
            auxClientes = new List<Cliente>();
            auxProductos = new List<Producto>();
            auxCodProductos = new List<int>();

            Hardcodeo();
        }

        private void Hardcodeo()
        {
            auxProductos.Add(new Producto("Coca Cola", 1, 79, 150));
            auxProductos.Add(new Producto("Manaos", 2, 59, 77));
            auxProductos.Add(new Producto("Agua Villavicencio", 3, 70, 7));
            auxProductos.Add(new Producto("Leche", 4, 60, 10));
            auxProductos.Add(new Producto("Queso freso", 5, 90, 11));
            auxProductos.Add(new Producto("Atun", 6, 40, 10));
            auxProductos.Add(new Producto("Dulce de leche", 7, 89, 55));
            auxProductos.Add(new Producto("Jamon cocido", 8, 120.99, 97));
            auxProductos.Add(new Producto("Jamon Crudo", 9, 135.50, 12));
            auxProductos.Add(new Producto("Salamin", 10, 70, 33));
            auxProductos.Add(new Producto("Pan", 11, 60.99, 100));
            auxProductos.Add(new Producto("Pollo", 12, 82.50, 50));
            auxProductos.Add(new Producto("Asado", 13, 250.90, 99));
            auxProductos.Add(new Producto("Vacio", 14, 300.15, 43));
            auxProductos.Add(new Producto("Matambre", 15, 199.99, 24));
            auxProductos.Add(new Producto("Pizza", 16, 177, 150));
            auxProductos.Add(new Producto("Empanadas", 17, 37, 17));
            auxProductos.Add(new Producto("Aceitunas", 18, 100, 9));
            auxProductos.Add(new Producto("Pure de tomate", 19, 50, 5));
            auxProductos.Add(new Producto("Aceite", 20, 66, 3));
            auxProductos.Add(new Producto("Manteca", 21, 99.90, 5));
            auxProductos.Add(new Producto("Harina", 22, 49, 19));
            auxProductos.Add(new Producto("Levadura", 23, 79, 10));
            auxProductos.Add(new Producto("Vino tinto", 24, 83.86, 6));
            auxProductos.Add(new Producto("Vino blanco", 25, 71, 7));
            auxProductos.Add(new Producto("Chocolate negro", 26, 79, 1));
            auxProductos.Add(new Producto("Chocolate blanco", 27, 67.99, 17));
            auxProductos.Add(new Producto("Manzana", 28, 25.90, 90));
            auxProductos.Add(new Producto("Banana", 29, 30, 70));
            auxProductos.Add(new Producto("Cereales", 30, 79, 10));

            /// cargo los productos en el inventario del negocio
            foreach (Producto p in auxProductos)
            {
                Inventario.AgregarAInventario(p);
            }

            auxEmpleados.Add(new Empleado("David", "Napal", "23545432", 1));
            auxEmpleados.Add(new Empleado("Ernesto", "Valenga", "12343443", 2));
           
            auxClientes.Add(new Cliente("Javier", "Alonso", "23131324", 1));
            auxClientes.Add(new Cliente("Nicolas", "Garcia", "21121221", 2));


            /// cargo los empleados en el negocio
            foreach (Empleado e in auxEmpleados)
            {
                Entidades.KwikEMart.AgregarEmpleado(e);
            }

            /// cargo los clientes en el negocio
            foreach (Cliente c in auxClientes)
            {
                Entidades.KwikEMart.AgregarCliente(c);
            }



        }

        #region Listar
        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            FormInventario frmInventario = new FormInventario();
            frmInventario.Show();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FormListaEmpleados frmListaEmpleados = new FormListaEmpleados();
            frmListaEmpleados.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormListaClientes frmListaClientes = new FormListaClientes();
            frmListaClientes.Show();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            FormCompra frmCompra = new FormCompra();
            frmCompra.Show();
        }
        private void btnListarCompras_Click(object sender, EventArgs e)
        {
            FormListaCompras frmListarCompras = new FormListaCompras();
            frmListarCompras.Show();
        }
        #endregion

        #region Cargas
        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            FormCargaProducto frmCargaProducto = new FormCargaProducto();
            frmCargaProducto.Show();
        }

        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            FormCargaEmpleado frmCargaEmpleado = new FormCargaEmpleado();
            frmCargaEmpleado.Show();
        }

        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            FormCargaCliente frmCargaCliente = new FormCargaCliente();
            frmCargaCliente.Show();
        }
        #endregion

    }
}
