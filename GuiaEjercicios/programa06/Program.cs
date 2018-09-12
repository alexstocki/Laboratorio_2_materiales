using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 06";

            /* Escribir un programa que determine si un año es bisiesto
             * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos.
             * Salvo si ellos también son múltiplos de 400. 
             * Ejemplo: el año 2000 es bisiesto pero 1900 no.
             */

            int numero;
            string lectura;
            Console.WriteLine("-----DETERMINAR SI UN AÑO ES BISIESTO-----");
            Console.WriteLine(" ");
            Console.Write("Ingrese un año: ");
            lectura = Console.ReadLine();

            if(int.TryParse(lectura, out numero))
            {
                if(numero % 4 == 0 && (numero % 100 != 0 || numero % 400 == 0))
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("El año {0} es bisiesto.", numero);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("El año {0} no es bisiesto", numero);
                }
            }

            else
            {
                Console.WriteLine("EROR. Ingrese un año válido");
            }

            Console.ReadKey();
        }
    }
}
