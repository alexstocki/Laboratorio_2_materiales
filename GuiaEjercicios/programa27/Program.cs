using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace programa27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 27";

            List<int> numeros = new List<int>();
            int cantidad = 20, num;
            Random rnum = new Random();

            for(int i = 0; i < cantidad; i++)
            {
                do
                {
                    num = rnum.Next(-10, 11);
                } while (num == 0);

                numeros.Add(num);
            }

            Console.WriteLine("Recorro la lista que acabo de crear y llené con números aleatorios: ");
            int posicion = 1;
            foreach (int numero in numeros)
            {
                Console.WriteLine("Posición {0}: {1}", posicion, numero);
                posicion++;
            }

            Console.ReadKey();

            Console.WriteLine("\n\nMuestro los números positivos de la lista, ordenados de menor a mayor: ");
            numeros.Sort();
            posicion = 1;
            foreach (int numero in numeros)
            {
                if(numero > 0)
                {
                    Console.WriteLine("Número: {0}", numero);
                }
            }

            Console.ReadKey();

            Console.WriteLine("\n\nAhora los números negativos: ");
            posicion = 1;
            foreach (int numero in numeros)
            {
                if(numero < 0)
                {
                    Console.WriteLine("Número {0}: {1}", posicion, numero);
                }
            }

            Console.ReadKey();

            Console.WriteLine("\n********** AHORA COLA **********");
            Queue cola = new Queue();
            int numCola;
            for(int i= 0; i < cantidad; i++)
            {
                do
                {
                    numCola = rnum.Next(-10, 11);
                } while (numCola == 0);
                
                cola.Enqueue(numCola);
            }

            Console.WriteLine("\n\nImprimo la cola, sin ordenar porque no se las puede organizar: ");
           for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(cola.Dequeue().ToString());
            }


            Console.ReadKey();

            Console.WriteLine("\n********** AHORA PILA **********");
            Stack pila = new Stack();
            int numPila;
            for(int i = 0; i < cantidad; i++)
            {
                do
                {
                    numPila = rnum.Next(-10, 11);
                } while (numPila == 0);

                pila.Push(numPila);
            }

            Console.WriteLine("\n\nImprimo la pila, también sin ordenar porque no se puede: ");
            for(int i = 0; i < cantidad; i++)
            {
                Console.WriteLine(pila.Pop());
            }

            Console.ReadKey();
        }
    }
}
