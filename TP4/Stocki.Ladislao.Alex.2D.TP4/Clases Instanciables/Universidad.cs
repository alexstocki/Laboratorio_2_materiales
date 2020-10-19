using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Clases_Instanciables
{
    public class Universidad
    {
        #region Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            set { this.alumnos = value; }
        }

        public List<Profesor> Instructores
        {
            get { return this.profesores; }
            set { this.profesores = value; }
        }

        public List<Jornada> Jornadas
        {
            get { return this.jornada; }
            set { this.jornada = value; }
        }

        public Jornada this[int i]
        {
            get 
            {
                if (i >= 0 && i < this.Jornadas.Count)
                {
                    return this.Jornadas[i];
                }
                return null;
            }
            set 
            {
                if (i >= 0 && i < this.Jornadas.Count)
                {
                    this.Jornadas[i] = value;
                }    
            }
        }
        #endregion

        #region Métodos
        public bool Guardar(Universidad uni)
        {

        }

        public Universidad Leer()
        {

        }

        private string MostrarDatos(Universidad uni)
        {

        }

        public static bool operator ==(Universidad g, Alumno a)
        {
            foreach (Alumno alumno in g.Alumnos)
            {
                if (alumno == a)
                {
                    return true; 
                }
            }
            return false;
        }

        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {
            foreach (Profesor profesor in g.Instructores)
            {
                if (profesor == i)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }

        public static Profesor operator ==(Universidad g, EClases clase)
        {

        }

        public static Profesor operator !=(Universidad g, EClases clase)
        {
            
        }

        public static Universidad operator +(Universidad g, EClases clase)
        {

        }

        public static Universidad operator +(Universidad g, Alumno a)
        {

        }

        public static Universidad operator +(Universidad g, Profesor i)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public Universidad()
        {

        }
        #endregion

        public enum EClases
        {
            Programacion, 
            Laboratorio,
            Legislacion, 
            SPD
        }
    }
}
