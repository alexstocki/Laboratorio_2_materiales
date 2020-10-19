using System;
using System.Collections.Generic;
using System.Text;
using Clases_Abstractas;
using static Clases_Instanciables.Universidad;

namespace Clases_Instanciables
{
    public class Jornada
    {
        #region Atributos
        private List<Alumno> alumnos;
        private EClases clase;
        private Profesor instructor;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos { get { return this.alumnos; } set { this.alumnos = value; } }
        
        public EClases Clase { get { return this.clase; } set {; } }

        public Profesor Instructor { get { return this.instructor; } set {; } }
        #endregion

        #region Métodos
        public bool Guardar(Jornada jornada)
        {

        }

        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(EClases clase, Profesor instructor)
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }

        public string Leer()
        {

        }

        public static bool operator ==(Jornada jornada, Alumno alumno)
        {
            foreach (Alumno a in jornada.Alumnos)
            {
                if (a == alumno)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Jornada jornada, Alumno alumno)
        {
            return !(jornada == alumno);
        }

        public static Jornada operator +(Jornada jornada, Alumno alumno)
        {
            if (jornada != alumno)
            {
                jornada.Alumnos.Add(alumno);
            }
            return jornada;
        }

        public override string ToString()
        {
            StringBuilder jornada = new StringBuilder();
            jornada.AppendFormat("CLASE: {0}\tPROFESOR: {1}\tALUMNOS: ", this.Clase, this.Instructor);
            foreach (Alumno alumno in this.Alumnos)
            {
                jornada.AppendLine(alumno.ToString());
            }
            return jornada.ToString();
        }
        #endregion
    }
}
