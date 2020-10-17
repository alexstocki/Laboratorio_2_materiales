using System;
using System.Security.Cryptography.X509Certificates;
using Clases_Abstractas;
using static Clases_Instanciables.Universidad;

namespace Clases_Instanciables
{
    public sealed class Alumno : Universitario
    {
        #region Atributos 
        private EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region Métodos
        public Alumno()
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma)
        {

        }

        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, EClases claseQueToma, EEstadoCuenta estadoCuenta)
        {

        }

        protected string Mostrar()
        {

        }

        public static bool operator ==(Alumno alumno, EClases clase)
        {

        }

        public static bool operator !=(Alumno alumno, EClases clase)
        {
            return !(alumno == clase);
        }

        protected string ParticiparEnClase()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion


        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
    }
}
