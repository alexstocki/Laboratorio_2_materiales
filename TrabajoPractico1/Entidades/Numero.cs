using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Numero
    {
        private double numero;

        ///// PROPIEDADES
        
        ///// FIN PROPIEDADES
        
        ///// MÉTODOS
        
        public string BinarioDecimal(string binario)
        {
            double numero = 0, contador = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                if(binario[i] == '1')
                {
                    numero += Math.Pow(1, 2 * i);
                    contador++;
                }
            }

            if(contador > 0)
            {
                return numero.ToString();
            }
            else
            {
                return "Valor inválido";
            }
        }
        public string DecimalBinario(double numero)
        {
            string retorno = ""; 

            do
            {
               if((int)numero / 2 == 1)
                {
                    retorno += "1";
                }
                else
                {
                    retorno += "0";
                }
            } while (numero >= 2);

            if(retorno == "0")
            {
                return "Valor inválido";
            }
            else
            {
                char[] charArray = retorno.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }
        }
        public string DecimalBinario(string numero)
        {
            double numeroDecimal;
            
            if(double.TryParse(numero, out numeroDecimal))
            {
               return this.DecimalBinario(numeroDecimal);
            }
            else
            {
                return "Valor inválido";
            }
        }
        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            this.numero = ValidarNumero(strNumero);
        }

        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }
        private double ValidarNumero(string strNumero)
        {
            double retorno;

            if (double.TryParse(strNumero, out retorno))
            {
                return retorno;
            }

            return retorno = 0;
        }

        ///// FIN MÉTODOS

    }
}
