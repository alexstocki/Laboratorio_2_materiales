using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";

            int numero;
            string lectura;
            string auxiliar, caracter = "*";

            Console.Write("Ingrese el alto de la pirámide: ");
            lectura = Console.ReadLine();
            if(int.TryParse(lectura, out numero))
            {
                for(int i = 1;i<=(numero * 2); i = i + 2)
                {
                    auxiliar = "";

                    for (int j = 1; j <= i; j++)
                    {
                        auxiliar += caracter;
                    }

                    Console.Write(CentrarCadena.StringCentering(auxiliar, numero*2));
                    Console.Write("\n");
                }
            }

            Console.ReadKey();
        }
    }
}
