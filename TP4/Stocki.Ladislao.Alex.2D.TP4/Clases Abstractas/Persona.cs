using System;
using System.Security.Cryptography;

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
        public string Apellido { get { return this.apellido; } set {; } }

        public int DNI { get { return this.dni; } set {; } }

        public ENacionalidad Nacionalidad { get { return this.nacionalidad; } set {; } }

        public string Nombre { get { return this.nombre; } set {; } }

        public string StringToDNI { set {; } }
        #endregion

        #region Métodos
        public Persona()
        {

        }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {

        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
        {

        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {

        }

        public override string ToString()
        {
            return base.ToString();
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
