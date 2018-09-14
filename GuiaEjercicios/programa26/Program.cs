using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa26
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Title = "Ejercicio 26";

      int[] numeros = new int[20];
      Random rnum = new Random();
      int valor, contador = 1;

      Console.WriteLine("ºººººººººººººººººººººººººººººººººººººººº\n\nNúmeros aleatorios\n");

      for (int i= 0; i < 20; i++)
      {
        do
        {
          valor = rnum.Next(-10,11);
        } while (valor == 0);
        
        numeros[i] = valor;
      }

      for(int i = 0; i < numeros.Length; i++)
      {
        Console.WriteLine("Posición {0}: {1}", i+1, numeros[i]);
      }

      Console.ReadKey();

      Console.WriteLine("\n\nºººººººººººººººººººººººººººººººººººººººº\n\nNúmeros positivos ordenados de forma ascendente\n");

      for(int i= 0; i < numeros.Length -1; i++)
      {
        for(int j = i + 1; j < numeros.Length; j++)
        {
          if(numeros[i] > 0)
          {
            if(numeros[i] > numeros[j])
            {
              int aux_num = numeros[i];
              numeros[i] = numeros[j];
              numeros[j] = aux_num;
            }
          }
        }
      }

      for(int i = 0;i< numeros.Length; i++)
      {
        if (numeros[i] > 0)
        {
          Console.WriteLine("Posicion {0}: {1}", contador, numeros[i]);
          contador++;
        }
      }

      Console.ReadKey();

      Console.WriteLine("\n\nºººººººººººººººººººººººººººººººººººººººº\n\nNúmeros negativos ordenados de forma ascendente\n");

      contador = 1;
      Array.Sort(numeros);
      foreach (int numero in numeros)
      {
        if(numero < 0)
        {
          Console.WriteLine("Posición {0}: {1}", contador, numero);
          contador++;
        }
      }

      Console.ReadKey();
    }
  }
}
