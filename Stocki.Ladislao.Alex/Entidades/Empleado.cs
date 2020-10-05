using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Entidades
{
    public class Empleado : Persona
    {
        #region Atributos
        int numeroEmpleado;
        List<Compra> listaCompras;
        #endregion

        #region Propiedades
        /// <summary>
        /// Retorna el número de empleado
        /// </summary>
        public int NumeroEmpleado
        {
            get
            {
                return this.numeroEmpleado;
            }
        }

        /// <summary>
        /// Retorna la lista de compras registradas
        /// por el Empleado
        /// </summary>
        public List<Compra> ListaCompras
        {
            get
            {
                return this.listaCompras;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor Empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="numeroEmpleado"></param>
        public Empleado(string nombre, string apellido, string dni, int numeroEmpleado)
            : base(nombre, apellido, dni)
        {
            this.numeroEmpleado = numeroEmpleado;
            this.listaCompras = new List<Compra>();
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Sobrecarga del operador ==
        /// Dos empleados son iguales si su número de empleado
        /// o DNI es igual
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns>true si son iguales, false caso contrario</returns>
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            if (e1.NumeroEmpleado == e2.NumeroEmpleado || e1.Dni == e2.Dni)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Sobrecarga del operador !=
        /// Dos empleados son distintos si su número de empleado
        /// y DNI son distintos
        /// </summary>
        /// <param name="e1"></param>
        /// <param name="e2"></param>
        /// <returns></returns>
        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }
        
        /// <summary>
        /// Sobrecarga del operador +
        /// Suma una compra a la lista de compras procesadas por el
        /// Empleado
        /// </summary>
        /// <param name="e"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator +(Empleado e, Compra c)
        {
            if (!(e is null) && !(c is null))
            {
                e.listaCompras.Add(c);
                return true;
            }

            return false;
        }
        #endregion
    }
}
