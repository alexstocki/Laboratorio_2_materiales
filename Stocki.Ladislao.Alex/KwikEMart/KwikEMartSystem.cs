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
        Empleado e1;
        Cliente c1; 
        Producto p1;
        

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
            Inventario.AgregarAInventario(p1);
            e1 = new Empleado("Alberto", "Fernandez", "10111011", 1);
            c1 = new Cliente("Javier", "Milei", "23131324", 1);
            p1 = new Producto("Coca Cola", 1, 79, 10);
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
            FormInventario frmInventario = new FormInventario(p1);
            frmInventario.Show();
        }
    }
}
