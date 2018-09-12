using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 01";

            /* Ejercicio 01. 
             * Solicitar el ingreso de 5 números y mostrar: 
             * Minimo, maximo y promedio de los numeros ingresados.
             * Agregarle color de fondo a los resultados que se imprimen por pantalla.
             */

            int numero;
            int contador = 0;
            int maximo = 0, minimo = 0, suma = 0;
            float promedio = 0;
            string lectura;

            while(contador < 5)
            {
                Console.Write("Ingrese un numero: ");
                lectura = Console.ReadLine();
                if(int.TryParse(lectura, out numero))
                {
                    if(contador == 0)
                    {
                        maximo = numero;
                        minimo = numero;
                    }

                    if(numero < minimo)
                    {
                        minimo = numero;
                    }
                    if(numero > maximo)
                    {
                        maximo = numero;
                    }

                    suma += numero;
                    contador++;
                }

                else
                {
                    Console.WriteLine("ERROR. Ingrese un numero valido");
                }
            }

            promedio = suma / 5;

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Maximo ingresado: {0}", maximo);
            Console.WriteLine("Minimo ingresado: {0}", minimo);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Promedio: {0}", promedio);

            Console.ReadKey();
        }
    }
}
