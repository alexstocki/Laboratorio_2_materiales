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
        /// <summary>
        /// Retorna la lista de empleados de KwikEMart
        /// </summary>
        public static List<Empleado> ListaEmpleados
        {
            get
            {
                return KwikEMart.listaEmpleados;
            }
        }

        /// <summary>
        /// Retorna la lista de clientes de KwikEMart
        /// </summary>
        public static List<Cliente> ListaClientes
        {
            get
            {
                return KwikEMart.listaClientes;
            }
        }
        #endregion Propiedades

        #region Constructor
        /// <summary>
        /// Constructor estatico que inicializa las listas
        /// </summary>
        static KwikEMart()
        {
            listaEmpleados = new List<Empleado>();
            listaClientes = new List<Cliente>();
        }
        #endregion Constructor

        #region Métodos
        /// <summary>
        /// Agrega al empleado, validando que este no se encuentre
        /// ya cargado
        /// </summary>
        /// <param name="empleado"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Agrega al cliente, validando que este no se encuentre
        /// ya cargado
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
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
