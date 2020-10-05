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
    public partial class FormCargaCliente : Form
    {
        #region Atributos
        string auxNombre, auxApellido, auxDni;
        int numCliente;
        Cliente cliente;
        #endregion

        private void FormCargaCliente_Load(object sender, EventArgs e)
        {

        }

        public FormCargaCliente()
        {
            InitializeComponent();
        }

        #region botones
        private void btnCargarCliente_Click(object sender, EventArgs e)
        {
            if (Validaciones.DniNumero(this.txtboxDniCliente.Text))
            {
                auxDni = this.txtboxDniCliente.Text;
                auxNombre = this.txtboxNombreCliente.Text;
                auxApellido = this.txtboxApellidoCliente.Text;
                numCliente = Validaciones.NumeroCliente();

                cliente = new Cliente(auxNombre, auxApellido, auxDni, numCliente);

                if (Entidades.KwikEMart.AgregarCliente(cliente))
                {
                    MessageBox.Show("Cliente Agregado exitosamente.");
                }
                else
                {
                    MessageBox.Show("No se agregó al cliente, revisar los datos.");
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
