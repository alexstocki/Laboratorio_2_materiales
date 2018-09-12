using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";

            /* Ejercicio 03:
             * Mostrar todos los numeros primos que haya 
             * hasta el numero que ingreso el usuario
             */

            int numero = 0;
            int i, j;
            int valido = 0, contador = 0;
            string lectura;

            while (valido == 0)
            {
                Console.Write("Ingrese un numero: ");
                lectura = Console.ReadLine();

                if(int.TryParse(lectura, out numero))
                {
                    valido = 1;
                }
                else
                {
                    Console.WriteLine("ERROR. Ingrese un numero");
                }
            }

            for(i = 1; i <= numero; i++)
            {
                for(j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        contador++;
                    }
                }

                if(contador <= 2)
                {
                    Console.WriteLine("Numero {0} es primo", i);
                }

                contador = 0;
            }

            Console.ReadKey();
        }
    }
}
