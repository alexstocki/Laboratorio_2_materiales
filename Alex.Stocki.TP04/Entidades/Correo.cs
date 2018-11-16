using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region Atributos
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
        #endregion
        //*********************************

        #region Propiedades
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
        #endregion

        //***********************************

        #region Constructor
        public Correo()
        {

        }
        #endregion

        #region Métodos
        public void FinEntregas()
        {
            // CIERRA TODOS LOS HILOS ACTIVOS
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            string retorno = string.Format("{0} para {1} ({2})", ((Paquete)elementos).TrackingID, ((Paquete)elementos).DireccionEntrega, ((Paquete)elementos).Estado.ToString());
            return retorno;
        }
        #endregion

        #region Operador
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
            Thread T = new Thread(p.MockCicloDeVida);
            // Crear un hilo para el método MockCicloDeVida del paquete, y agregar dicho hilo a mockPaquetes.
            // EJECUTAR HILO
            return c;
        }
        #endregion
    }
}
