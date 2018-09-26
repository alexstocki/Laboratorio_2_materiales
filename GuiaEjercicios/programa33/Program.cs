using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 33";

            Libro gameOfThrones = new Libro();

            gameOfThrones[0] = "Agradecimientos";
            gameOfThrones[1] = "Acá menciona a los white walkers";
            gameOfThrones[2] = "Conocemos a Ned Stark";
            gameOfThrones[2] = "Además de Ned, conocemos a los hijos";

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(gameOfThrones[i]);
            }

            Console.ReadKey();
        }
    }
}
