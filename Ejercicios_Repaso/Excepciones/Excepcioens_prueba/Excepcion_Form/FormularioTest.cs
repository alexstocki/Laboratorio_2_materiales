using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepcion_Form
{
    public partial class FormularioTest : Form
    {
        public FormularioTest()
        {
            InitializeComponent();
        }

        private void btnExcepcion_Click(object sender, EventArgs e)
        {
            try
            {
                throw new MiExcepcion("Excepcion personalizada lanzada correctamente");
            }

            catch (MiExcepcion ex)
            {
                this.lblMensaje.Text = ex.Message;
                MessageBox.Show(ex.Message);
            }
            
            catch (Exception)
            {
                this.lblMensaje.Text = "Excepcion no tomada en cuenta";
                MessageBox.Show("Este error no lo tenias eh...");
            }
        }
    }
}
