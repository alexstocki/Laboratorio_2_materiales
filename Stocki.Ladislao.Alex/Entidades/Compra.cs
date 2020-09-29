using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public sealed class Compra
    {
        List<int> codigoProducto;
        Cliente comprador;
        Empleado empleadoRegistro;

        private Compra()
        {
            this.codigoProducto = new List<int>();
        }

        public Compra(List<int> listaCodigos, Cliente comprador)
            : this()
        {
            this.codigoProducto = listaCodigos;
            this.comprador = comprador;
        }
    }
}
