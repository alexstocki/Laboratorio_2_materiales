using System;
using System.Collections.Generic;
using System.Text;
using Clases_Abstractas;
using static Clases_Instanciables.Universidad;
using System.Threading;
using System.Text.RegularExpressions;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos
        private Queue<EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region Métodos
        private void _randonClase()
        {
            int randomNumber;

            for (int i = 0; i < 2; i++)
            {
                System.Threading.Thread.Sleep(1000);
                randomNumber = random.Next(0, 4);
                switch (randomNumber)
                {
                    case 0:
                        {
                            this.clasesDelDia.Enqueue(EClases.Programacion);
                            break;
                        }
                    case 1:
                        {
                            this.clasesDelDia.Enqueue(EClases.Laboratorio);
                            break;
                        }
                    case 2:
                        {
                            this.clasesDelDia.Enqueue(EClases.Legislacion);
                            break;
                        }
                    default:
                        {
                            this.clasesDelDia.Enqueue(EClases.SPD);
                            break;
                        }
                }
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder profesor = new StringBuilder();
            profesor.AppendLine(base.MostrarDatos());
            profesor.AppendLine(this.ParticiparEnClase());
            return profesor.ToString();
        }

        public static bool operator ==(Profesor profesor, EClases clase)
        {
            foreach (EClases c in profesor.clasesDelDia)
            {
                if (c == clase)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Profesor profesor, EClases clase)
        {
            return !(profesor == clase);
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CLASES DEL DIA");
            foreach (EClases clase in this.clasesDelDia)
            {
                sb.AppendFormat("{0}", clase.ToString());
            }
            return sb.ToString();
        }

        public Profesor()
        {

        }

        static Profesor()
        {
            random = new Random();
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
            this.clasesDelDia = new Queue<EClases>();
            this._randonClase();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
        #endregion
    }
}
