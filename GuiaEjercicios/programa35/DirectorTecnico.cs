using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa35
{
    public class DirectorTecnico : Persona
    {
        private DateTime fechaNacimiento;

        // *** constructor ***
        private DirectorTecnico(string nombre) : base(nombre)
        {

        }
        public DirectorTecnico(string nombre, DateTime nacimiento) : this(nombre)
        {
            this.fechaNacimiento = nacimiento;
        }

        // *** métodos ***
        public string MostrarDatos()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("{0} {1}", this.Nombre, this.fechaNacimiento);
            string retorno = constructor.ToString();
            return retorno;
        }

        // *** operadores ***
        public static bool operator ==(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            bool retorno = false;
            if(dt1.fechaNacimiento == dt2.fechaNacimiento && dt1.Nombre == dt2.Nombre)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(DirectorTecnico dt1, DirectorTecnico dt2)
        {
            return !(dt1 == dt2);
        }
    }
}
