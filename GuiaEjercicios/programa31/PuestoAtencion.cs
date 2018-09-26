using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace programa31
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        // ***** propiedades *****
        public int NumeroActual
        {
            get
            {
                return numeroActual;
            }
        }

        // ***** métodos *****
        public bool Atender(Cliente cli)
        {
            Random rnum = new Random();
            Thread.Sleep(rnum.Next(1000, 3001));
            return true;
        }
        private PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public PuestoAtencion(Puesto puesto):this()
        {
            this.puesto = puesto;
        } 
    }
    public enum Puesto
    {
        Caja1,
        Caja2
    }
}
