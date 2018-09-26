using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 30";

            Competencia milan = new Competencia(10, 3);
            AutoF1 a1 = new AutoF1(10, "Ferrari");
            AutoF1 a2 = new AutoF1(3, "Renault");
            AutoF1 clonA2 = new AutoF1(3, "Renault");
            AutoF1 a3 = new AutoF1(4, "McLaren");
            AutoF1 a4 = new AutoF1(7, "Jaguar");

            Console.WriteLine("Se pudo agregar A1?: {0}", (milan + a1));
            Console.WriteLine("Se pudo agregar de nuevo a A1?: {0}", (milan + a1));
            Console.WriteLine("Se pudo agregar A2?: {0}", (milan + a2));
            Console.WriteLine("Se pudo agregar a clonA2?: {0}", (milan + clonA2));
            Console.WriteLine("Se pudo agregar A4?: {0}", (milan + a4));

            Console.ReadKey();

            Console.WriteLine(milan.MostrarDatos());

            Console.ReadKey();

            Console.WriteLine(a1.MostrarDatos());

            Console.ReadKey();

            Console.WriteLine("\n\n*** Auto 3 *** (no fue agregado para mostrar datos)\n{0}", a3.MostrarDatos());

            Console.ReadKey();
        }
    }
}
