using System;

namespace Entidades
{
    /// <summary>
    /// No se puede instanciar un objeto clase Persona
    /// </summary>
    public abstract class Persona
    {
        #region Atributos
        private string nombre;
        private string apellido;
        private string dni;
        #endregion Atributos

        #region Propiedades
        /// <summary>
        /// Retorna el dato nombre
        /// </summary>
        public string Nombre 
        {
            get 
            {
                return this.nombre;
            } 
        }

        /// <summary>
        /// Retorna el dato apellido
        /// </summary>
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// Retorna el dato dni
        /// </summary>
        public string Dni 
        {
            get 
            {
                return this.dni;
            }
        }
        #endregion Propiedades

        #region Constructores
        /// <summary>
        /// Constructor Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = "00000000";
        }

        /// <summary>
        /// Constructor Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, string apellido, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        #endregion Constructores
    }
}
