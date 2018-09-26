using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa30
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        // ***** constructores *****
        private Competencia()
        {
            competidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
        }

        // ***** métodos *****
        public string MostrarDatos()
        {
            StringBuilder constructor = new StringBuilder();
            constructor.AppendFormat("Autos en competencia: {0}\nCantidad de vueltas: {1}", this.competidores.Count(), this.cantidadVueltas);
            string retorno = constructor.ToString();
            return retorno;
        }
        public static bool operator +(Competencia c, AutoF1 a)
        {
            if(c != a)
            {
                Random rnum = new Random();
                a.SetCantidadCombustible((short)rnum.Next(15, 101));
                a.SetEnCompetencia(true);
                a.SetVueltasRestantes(c.cantidadVueltas);
                c.competidores.Add(a);
                return true;
            }
            return false;
        }
        public static bool operator -(Competencia c, AutoF1 a)
        {
            if(c == a)
            {
                c.competidores.Remove(a);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator ==(Competencia c, AutoF1 a)
        {
            if (c.competidores.Count() <= c.cantidadCompetidores - 1)
            {
                foreach (AutoF1 competidor in c.competidores)
                {
                    if (competidor == a)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
    }
}
