using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 9";

            int numero;
            string lectura;
            string caracter = "*";

            Console.Write("Ingrese el alto: ");
            lectura = Console.ReadLine();
            if(int.TryParse(lectura, out numero))
            {
                Console.WriteLine("\n");

                for(int i=1; i <= (numero * 2); i = i + 2)
                {
                    for(int j = 1; j <= i; j++)
                    {
                        Console.Write(caracter);
                    }

                    Console.Write("\n");
                }
            }

            Console.ReadKey();
        }
    }
}
