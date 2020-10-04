using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Empleado : Persona
    {
        int numeroEmpleado;
        List<Compra> listaCompras;

        #region Propiedades
        public int NumeroEmpleado
        {
            get
            {
                return this.numeroEmpleado;
            }
        }
        #endregion

        #region Constructor
        private Empleado(string nombre, string apellido, string dni)
            : base(nombre, apellido, dni)
        {
            numeroEmpleado = -1;
        }

        public Empleado(string nombre, string apellido, string dni, int numeroEmpleado)
            : this(nombre, apellido, dni)
        {
            this.numeroEmpleado = numeroEmpleado;
        }
        #endregion
    }
}
