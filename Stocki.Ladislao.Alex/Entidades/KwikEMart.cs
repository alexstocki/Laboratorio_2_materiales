using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Text;

namespace Entidades
{
    public static class KwikEMart
    {
        #region Atributos
        public static List<Empleado> listaEmpleados;
        public static List<Cliente> listaClientes;
        #endregion Atributos

        #region Propiedades
        #endregion Propiedades

        #region Constructor
        static KwikEMart()
        {
            listaEmpleados = new List<Empleado>();
            listaClientes = new List<Cliente>();
        }
        #endregion Constructor

        #region Métodos
        public static bool AgregarEmpleado(Empleado empleado)
        {
            foreach (Empleado emp in listaEmpleados)
            {
                if (emp == empleado)
                {
                    return false;
                }
            }

            listaEmpleados.Add(empleado);
            return true;
        }

        public static bool AgregarCliente(Cliente cliente)
        {
            foreach (Cliente cli in listaClientes)
            {
                if (cli == cliente)
                {
                    return false;
                }
            }

            listaClientes.Add(cliente);
            return true;
        }
        #endregion Métodos
    }
}
