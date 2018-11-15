using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        //*******************************

        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public string TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        //*******************************

        public Paquete(string direccionEntrega, string trackingID)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1} {2}", this.TrackingID, this.DireccionEntrega, this.Estado);
            return sb.ToString();
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool retorno = false;
            if(p1.TrackingID == p2.TrackingID)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            string retorno = string.Format("{0} para {1}", ((Paquete)elemento).TrackingID, ((Paquete)elemento).DireccionEntrega);
            return retorno;
        }

        public void MockCicloDeVida()
        {
            Thread.Sleep(4000);
            // Pasar al siguiente estado
        }

        //*******************************

        //  InformaEstado : DelegadoEstado [ES UN EVENTO]

        //*******************************

        // DelegadoEstado ---> Delegado

        //*******************************

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}
