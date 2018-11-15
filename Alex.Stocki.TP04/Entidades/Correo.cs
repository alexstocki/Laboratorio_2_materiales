using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        //*********************************

        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {

            }
        }

        //***********************************

        public Correo()
        {

        }

        public void FinEntregas()
        {
            // CIERRA TODOS LOS HILOS ACTIVOS
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString())
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete paquete in c.paquetes)
            {
                if (paquete == p)
                {
                    throw new TrackingIdRepetidoException("El paquete ya se encuentra " +
                        "incluído en la lista");
                }
            }
            c.paquetes.Add(p);
            // CREAR UN HILO 
            // AGREGAR HILO A MOCKPAQUETES
            // EJECUTAR HILO
            return c;
        }
    }
}
