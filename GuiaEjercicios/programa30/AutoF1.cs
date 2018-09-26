using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa30
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;

        public AutoF1(short numero, string escuderia)
        {
            this.enCompetencia = false;
            this.vueltasRestantes = 0;
            this.escuderia = escuderia;
            this.numero = numero;
        }

        public string MostrarDatos()
        {
            StringBuilder constructor = new StringBuilder();
            string compite;
            if(GetEnCompetencia() == true)
            {
                compite = "sí";
            }
            else
            {
                compite = "no";
            }
            constructor.AppendFormat("Escudería: {0}, Número: {1}\nEn competencia: {2}, Vueltas restantes: {3}\nCombustible restante: {4}", this.escuderia, this.numero, compite, GetVueltasRestantes(), GetCantidadCombustible());
            string retorno = constructor.ToString();
            return retorno;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            if(a1.numero == a2.numero && a1.escuderia == a2.escuderia)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }

        // setters y getters
        public void SetCantidadCombustible(short combustible)
        {
            this.cantidadCombustible = combustible;
        }
        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public void SetEnCompetencia(bool compite)
        {
            this.enCompetencia = compite;
        }
        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void SetVueltasRestantes(short vueltas)
        {
            this.vueltasRestantes = vueltas;
        }
        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }
    }
}
