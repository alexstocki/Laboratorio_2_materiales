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
    public partial class FormCargaEmpleado : Form
    {
        #region Atributos
        string auxNombre, auxApellido, auxDni;
        int numEmpleado;
        Empleado empleado;
        #endregion

        public FormCargaEmpleado()
        {
            InitializeComponent();
        }

        private void FormCargaEmpleado_Load(object sender, EventArgs e)
        {

        }

        #region Botones
        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            if (Validaciones.DniNumero(this.txtboxDniEmpleado.Text))
            {
                auxDni = this.txtboxDniEmpleado.Text;
                auxNombre = this.txtboxNombreEmpleado.Text;
                auxApellido = this.txtboxApellidoEmpleado.Text;
                numEmpleado = Validaciones.NumeroEmpleado();

                empleado = new Empleado(auxNombre, auxApellido, auxDni, numEmpleado);

                if (Entidades.KwikEMart.AgregarEmpleado(empleado))
                {
                    MessageBox.Show("Empleado Agregado exitosamente.");
                }
                else
                {
                    MessageBox.Show("No se agregó al empleado, revisar los datos.");
                }
            }
            else
            {
                MessageBox.Show("DNI invalido, revise el dato.");
            }
        }
        #endregion
    }
}
