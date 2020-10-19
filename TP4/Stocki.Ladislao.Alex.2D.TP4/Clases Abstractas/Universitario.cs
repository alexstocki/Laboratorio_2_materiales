using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;

namespace Clases_Abstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributo
        private int legajo;
        #endregion

        #region Metodos
        public override bool Equals(object obj)
        {
            if (obj is Universitario)
            {
                if (((Universitario)obj).DNI == this.DNI || ((Universitario)obj).legajo == this.legajo)
                {
                    return true;
                }
            }
            return false;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder universitario = new StringBuilder();
            universitario.AppendLine(base.ToString());
            universitario.AppendFormat("Legajo: {0}", this.legajo);
            return universitario.ToString();
        }

        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return pg1.Equals(pg2);
        }

        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        protected abstract string ParticiparEnClase()
        {

        }

        public Universitario()
        {

        }

        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion
    }
}
