using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa15
{
    class Calculadora
    {
        public static void Calcular(double num1, double num2, string op)
        {
            double resultado;

            switch (op)
            {
                case "+":
                    {
                        resultado = num1 + num2;
                        break;
                    }
                case "-":
                    {
                        resultado = num1 - num2;
                        break;
                    }
                case "*":
                    {
                        resultado = num1 * num2;
                        break;
                    }
                case "/":
                    {
                        if (Validar(num2))
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            resultado = -123456;
                        }
                        break;
                    }
                default:
                    {
                        resultado = -7890;
                        break;
                    }
            }

            Mostrar(resultado);
        }

        private static bool Validar(double numero2)
        {
            bool retorno = false;

            if(numero2 > 0)
            {
                retorno = true;
            }

            return retorno;
        }

        public static void Mostrar(double result)
        {
            if(result == -123456)
            {
                Console.WriteLine("El divisor debe ser mayor a 0 (CERO) para poder dividir.");
            }
            else if(result == -7890)
            {
                Console.WriteLine("Debe ingresar una de las operaciones válidas.");
            }
            else
            {
                Console.WriteLine("Resultado: {0}", result);
            }
        }
    }
}
