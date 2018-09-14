using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa27
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 27";

      List<int> numeros;
      numeros = new List<int>();
      Random rnum = new Random();
      int cantidad = 20, valor, contador;

      Console.WriteLine("Lista de 20 números seleccionados aleatoriamente\n");
      for (int i = 0; i < cantidad; i++)
      {
        // Genero un número aleatorio
        do
        {
          valor = rnum.Next(-10, 11);
        } while (valor == 0);
        // Agrego el número aleatorio a la lista numeros
        numeros.Add(valor);
      }

      // Imprimo la lista tal cual se cargó
      contador = 0;
      foreach (int numero in numeros)
      {
        Console.WriteLine("Posición {0}: {1}", contador + 1, numero);
        contador++;
      }
      Console.ReadKey();

      Console.WriteLine("\n\n°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°\n\nLista de números positivos ordenados\n");
      numeros.Sort();
      contador = 1;
      foreach (int numero in numeros)
      {
        if (numero > 0)
        {
          Console.WriteLine("Posición {0}: {1}", contador, numero);
          contador++;
        }
      }
      Console.ReadKey();

      Console.WriteLine("\n\n°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°\n\nLista de números negativos ordenados\n");
      contador = 1;
      foreach (int numero in numeros)
      {
        if (numero < 0)
        {
          Console.WriteLine("Posición {0}: {1}", contador, numero);
          contador++;
        }
      }
      Console.ReadKey();

      Console.WriteLine("\n\n°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°°\n\nCola de números aleatorios\n");
      Random rnumero = new Random();
      // Creo la cola
      Queue cola = new Queue(20);
      contador = 1;

      for (int i = 0; i < 20; i++)
      {
        do
        {
          valor = rnumero.Next(-10, 10);
        } while (valor == 0);
        // Le cargo valor
        cola.Enqueue(valor);
      }

      for (int i = 0; i < 20; i++)
      {
        // Imprimo por consola
        Console.WriteLine("Posición {0}: {1}", contador, cola.Dequeue());
        contador++;
      }
      Console.ReadKey();
    }
  }
}
