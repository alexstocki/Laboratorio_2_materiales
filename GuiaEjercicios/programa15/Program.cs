using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 15";

            /*  Hacer un programa que permita realizar operaciones matemáticas simples 
             *  (suma, resta, multiplicación y división). Para ello se le debe pedir al usuario
             *  que ingrese dos números y la operación que desea realizar (+, -, *, /).
             *  El usuario decidirá cuándo finalizar el programa.
             *  Crear una clase llamada Calculadora que posea tres métodos estáticos de clase:
             *  1) Calcular(público): Recibirá tres parámetros, el primer número, el segundo número 
             *  y la operación a realizar. El método devolverá el resultado de la operación.
             *  2) Validar(privado): Recibirá como parámetro el segundo número. Este método solo se debe
             *  utilizar cuando la operación elegida es la división. Este método devolverá TRUE si el número
             *  es distinto de CERO.
             *  3) Mostrar(público): Este método recibe como parámetro el resultado de la operación y lo muestra
             *  por pantalla. No tiene valor de retorno.
             */

            double numero1, numero2;
            string lectura, seguir, operacion;

            do
            {
                Console.Write("Nro 1: ");
                lectura = Console.ReadLine();
                if(double.TryParse(lectura, out numero1))
                {
                    Console.Write("Nro 2: ");
                    lectura = Console.ReadLine();
                    if(double.TryParse(lectura, out numero2))
                    {
                        Console.Write("Operacion (+, -, *, /): ");
                        operacion = Console.ReadLine();

                        Calculadora.Calcular(numero1, numero2, operacion);
                    }
                }
                Console.ReadKey();

                Console.Write("Desea realizar otra operación (S|N): ");
                seguir = Console.ReadLine();

            } while (seguir == "s" || seguir == "S");
        }
    }
}
