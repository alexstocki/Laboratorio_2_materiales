using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";

            /* Un número perfecto es un entero positivo, 
               que es igual a la suma de todos los enteros positivos
               (excluido el mismo) que son divisores del número.
               El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3;
               y 1 + 2 + 3 = 6.
               Escribir una aplicación que encuentre los 4 primeros números perfectos.
            */

            int numero = 6;
            int suma = 0, perfectos = 0;
            int i;

            Console.WriteLine("Cuatro primeros números perfectos: ");

            do
            {
                for (i = 1; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        suma += i;
                    }
                }

                if (suma == numero)
                {
                    Console.WriteLine(i);
                    perfectos++;
                }

                suma = 0;
                numero++;
            } while (perfectos < 4);

            Console.ReadKey();

        }
    }
}
