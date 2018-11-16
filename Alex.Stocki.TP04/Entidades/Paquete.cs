using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        #region Atributos
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        #endregion

        #region Delegado
        public delegate void DelegadoEstado();
        public event DelegadoEstado InformaEstado;
        #endregion

        #region Propiedades
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
        #endregion

        #region Constructor
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} {1} {2}", this.TrackingID, this.DireccionEntrega, this.Estado);
            return sb.ToString();
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
        #endregion

        #region Operadores
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
        #endregion

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}
