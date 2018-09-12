using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 02";

            int valido = 0;
            int numero = 0;
            string lectura;
            double cubo = 0, cuadrado = 0;

            while(valido == 0)
            {
                Console.Write("Ingrese un numero (debe ser mayor a 0): ");
                lectura = Console.ReadLine();

                if (int.TryParse(lectura, out numero))
                {
                    if(numero > 0)
                    {
                        valido = 1;

                        cuadrado = Math.Pow(numero, 2);
                        cubo = Math.Pow(numero, 3);
                    }

                    else
                    {
                        Console.WriteLine("ERROR. El numero debe ser mayor a 0");
                    }
                    
                }
                else
                {
                    Console.WriteLine("ERROR. Debe ingresar un numero valido");
                }
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Numero: {0}", numero);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Cuadrado: {0}", cuadrado);
            Console.WriteLine("Cubo: {0}", cubo);

            Console.ReadKey();
        }
    }
}
