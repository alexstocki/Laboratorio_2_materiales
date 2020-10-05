using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public static class Validaciones
    {
        /// <summary>
        /// Intenta convertir en Int el string que recibe
        /// </summary>
        /// <param name="txtNum"></param>
        /// <returns>Conversión del string a int, caso contrario
        /// retorna -1</returns>
        public static int TextToInt(string txtNum)
        {
            int intNum;

            if (int.TryParse(txtNum, out intNum))
            {
                return intNum;
            }

            return -1;
        }

        /// <summary>
        /// Intenta convertir en double el string que recibe
        /// </summary>
        /// <param name="txtNum"></param>
        /// <returns>Conversión del string a double, caso contrario
        /// retorna -1</returns>
        public static double TextToDouble(string txtNum)
        {
            double doubleNum;
            txtNum = Validaciones.PonerComa(txtNum);

            if (double.TryParse(txtNum, out doubleNum))
            {
                return doubleNum;
            }

            return -1;
        }

        /// <summary>
        /// Controla si el string tiene punto o coma en los decimales
        /// Si tiene punto retorna un string con coma
        /// </summary>
        /// <param name="txtDouble"></param>
        /// <returns>string con el formato correcto para poder
        /// convertir en double</returns>
        private static string PonerComa(string txtDouble)
        {
            string auxTxtDouble = txtDouble;

            foreach (char letra in txtDouble)
            {
                if (letra == '.')
                {
                    auxTxtDouble = txtDouble.Replace('.', ',');
                }
            }

            return auxTxtDouble;
        }

        /// <summary>
        /// Verifica que el string esté compuesto por números
        /// </summary>
        /// <param name="txtDni"></param>
        /// <returns>true si solo esta compuesto por números
        /// caso contrario retorna false</returns>
        public static bool DniNumero(string txtDni)
        {
            foreach (char letra in txtDni)
            {
                if (char.IsLetter(letra))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Busca el número más alto de empleado registrado
        /// y retorna el siguiente
        /// </summary>
        /// <returns>número de empleado disponible</returns>
        public static int NumeroEmpleado()
        {
            int maxNum = 0;

            foreach (Empleado e in KwikEMart.ListaEmpleados)
            {
                if (e.NumeroEmpleado >= maxNum)
                {
                    maxNum = e.NumeroEmpleado;
                }
            }
            maxNum++;
            return maxNum;
        }

        /// <summary>
        /// Busca el número más alto de cliente registrado
        /// y retorna el siguiente
        /// </summary>
        /// <returns>número de cliente disponible</returns>
        public static int NumeroCliente()
        {
            int maxNum = 0;

            foreach (Cliente c in KwikEMart.ListaClientes)
            {
                if (c.NumeroDeCliente >= maxNum)
                {
                    maxNum = c.NumeroDeCliente;
                }
            }
            maxNum++;
            return maxNum;
        }
    }
}
