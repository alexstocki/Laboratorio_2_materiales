using System;
using System.Collections.Generic;
using System.Text;
using Clases_Abstractas;
using static Clases_Instanciables.Universidad;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<EClases> clasesDelDia;
        private Random random;
        #endregion

        #region Métodos
        private void _randonClase()
        {

        }

        protected override string MostrarDatos()
        {
            StringBuilder profesor = new StringBuilder();
            profesor.AppendLine(base.MostrarDatos());
        }

        public static bool operator ==(Profesor profesor, EClases clase)
        {

        }

        public static bool operator !=(Profesor profesor, EClases clase)
        {
            return !(profesor == clase);
        }

        protected string ParticiparEnClase()
        {

        }

        public Profesor()
        {

        }

        private Profesor()
        {

        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
