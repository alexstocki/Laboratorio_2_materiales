using System;
using System.Security.Cryptography;
using System.Text;

namespace Clases_Abstractas
{
    public abstract class Persona
    {
        #region Atributos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion

        #region Propiedades
        public string Apellido { get { return this.apellido; } set { this.apellido = this.ValidarNombreApellido(value); } }

        public int DNI { get { return this.dni; } set { this.dni = this.ValidarDni(this.Nacionalidad, value); } }

        public ENacionalidad Nacionalidad { get { return this.nacionalidad; } set { this.nacionalidad = value; } }

        public string Nombre { get { return this.nombre; } set { this.nombre = this.ValidarNombreApellido(value); } }

        public string StringToDNI 
        { 
            set 
            { 
                int dni = this.ValidarDni(this.Nacionalidad, value);
                this.DNI = dni;
            } 
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Constructor sin parametros
        /// necesario para la serializacion
        /// </summary>
        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        public override string ToString()
        {
            StringBuilder persona = new StringBuilder();
            persona.AppendFormat("{0}, {1}\nDNI: {2} Nacionalidad: {3}", this.Apellido, 
                this.Nombre, this.DNI, this.Nacionalidad);
            return persona.ToString();
        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato < 1 || dato  > 89999999)
                    {
                        // lanzar error
                        
                    }
                    break;
                case ENacionalidad.Extranjero:
                    if (dato < 90000000 || dato > 99999999)
                    {
                        // lanzar error
                    }
                    break;
            }
            return dato;
        }

        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            if (dato.Length >= 1 && dato.Length <= 8)
            {
                foreach (char caracter in dato)
                {
                    if (!(char.IsNumber(caracter)))
                    {
                        return dni;
                    }
                }
            }
            return this.ValidarDni(nacionalidad, int.Parse(dato));
        }

        private string ValidarNombreApellido(string dato)
        {
            foreach (char caracter in dato)
            {
                if (!(char.IsLetter(caracter)) && !(caracter != ' '))
                {
                    return "";
                }
            }
            return dato;
        }
        #endregion
 
        public enum ENacionalidad
        {
            Argentino, 
            Extranjero
        }
    }
}
