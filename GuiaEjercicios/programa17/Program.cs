using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 17";

            string impresion1, impresion2;

            Boligrafo lapiceraAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo lapiceraRoja = new Boligrafo(ConsoleColor.Red, 50);

            lapiceraAzul.Pintar(12, out impresion1);
            lapiceraRoja.Pintar(22, out impresion2);

            Console.BackgroundColor = lapiceraAzul.GetColor();
            Console.WriteLine(impresion1);
            Console.BackgroundColor = lapiceraRoja.GetColor();
            Console.WriteLine(impresion2);


            Console.ReadKey();
        }
    }
}
