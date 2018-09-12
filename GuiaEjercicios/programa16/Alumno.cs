using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa16
{
    class Alumno
    {
        byte _nota1;
        byte _nota2;
        float _notaFinal;
        string apellido;
        int legajo;
        string nombre;

        public Alumno(int legajo, string apellido, string nombre)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }
        public void CalcularFinal()
        {
            this._notaFinal = -1;

            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                Random randomNumber = new Random();
                float notaFinal = randomNumber.Next(1, 10);
                this._notaFinal = notaFinal;
            }
        }

        public void Estudiar(byte nota1, byte nota2)
        {
            this._nota1 = nota1;
            this._nota2 = nota2;
        }

        public string Mostrar()
        {
            StringBuilder linea = new StringBuilder();
            string retorno;

            if(this._notaFinal >= 0)
            {
                linea.AppendFormat("Legajo: {0}\nApellido y nombre: {1} {2}\nPrimera nota: {3}\nSegunda nota: {4}\nNota Final: {5}", this.legajo, this.apellido, this.nombre, this._nota1, this._nota2, this._notaFinal);
            }
            else
            {
                linea.AppendFormat("Legajo: {0}\nApellido y nombre: {1} {2}\nPrimera nota: {3}\nSegunda nota: {4}\nNota Final: {5}", this.legajo, this.apellido, this.nombre, this._nota1, this._nota2, "Alumno desaprobado");
            }

            retorno = linea.ToString();
            return retorno;
        }
    }
}
