using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05";

            int numero;
            string lectura;
            int i, j, k;
            int valido = 0;
            int suma = 0;
            int contador = 0;

            do
            {
                Console.Write("Ingrese un numero: ");
                lectura = Console.ReadLine();

                if (int.TryParse(lectura, out numero))
                {
                    Console.WriteLine("Números céntricos hasta {0}:", numero);
                    /*logica del programa*/
                    valido = 1;

                    for (i = 1; i <= numero; i++)
                    {
                        for(j = 0; j < i; j++)
                        {
                            contador += j;
                        }

                        for(k = i + 1; k < numero; k++)
                        {
                            suma += k;
                            if(contador == suma)
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }

                        suma = 0;
                        contador = 0;
                    }
                }

                else
                {
                    Console.WriteLine("ERROR. Ingrese un número válido");
                }

            } while (valido == 0);

            Console.ReadKey();

        }
    }
}
