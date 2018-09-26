using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa35
{
    public abstract class Persona
    {
        private long dni;
        private string nombre;

        // *** propiedades ***
        protected long Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        protected string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        // *** método ***
        protected string MostrarDatos()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("Nombre: {0}   Dni: {1}", this.Nombre, this.Dni);
            string retorno = constructor.ToString();
            return retorno;
        }

        // *** constructor ***
        protected Persona(long dni, string nombre):this(nombre)
        {
            this.Dni = dni;
        }

        protected Persona(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
