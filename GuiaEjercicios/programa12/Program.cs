using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";

            /* 
             * 
             * 
             * 
             */

            int number, total = 0;
            string lecture;
            char answer;

            do
            {
                Console.Write("Ingrese un número: ");
                lecture = Console.ReadLine();
                if (int.TryParse(lecture, out number))
                {
                    total += number;
                }
                else
                {
                    Console.WriteLine("ERROR. Debe ingresar un número entero.");
                }

                Console.Write("Desea ingresar otro número (S|N): ");
                lecture = Console.ReadLine();
                answer = char.Parse(lecture);
                
            } while (ValidarRespuesta.ValidaS_N(answer));

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("La suma es: {0}", total);

            Console.ReadKey();
        }
    }
}
