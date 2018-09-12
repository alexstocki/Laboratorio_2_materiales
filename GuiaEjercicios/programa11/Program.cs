using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 11";

            /* Ingresar 10 números enteros que puedan estar dentro de un rando de entre -100 y 100
             * Para ello realizar una clase llamada Validación que posea un método estático llamado Validar,
             * que posea la siguiente firma: bool Validar(int valor, int min, int max):
             * a) valor: dato a validar b) min y max: rango en el cual deberá estar la variable valor. 
             */

            int num;
            int count = 0;
            int min = 0, max = 0, sum = 0;
            float prom = 0;
            int vMin = -100, vMax = 100;
            string lect;

            do
            {
                Console.Write("Ingrese un número (-100 a 100): ");
                lect = Console.ReadLine();
                if (int.TryParse(lect, out num))
                {
                    if(Validacion.Validar(num, vMin, vMax))
                    {
                        if(count == 0)
                        {
                            min = num;
                            max = num;
                        }

                        if(num < min)
                        {
                            min = num;
                        }
                        if(num > max)
                        {
                            max = num;
                        }

                        sum += num;
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. Ingrese un número dentro del rango establecido. (-100 a 100)");
                    }
                }
            } while (count <= 9);

            prom = sum / 10;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Mínimo ingresado: {0}", min);
            Console.WriteLine("Máximo ingresado: {0}", max);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Promedio general: {0}", prom);

            Console.ReadKey();
        }
    }
}
