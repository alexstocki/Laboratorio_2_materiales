using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa36
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 36";

            Competencia torneoF1 = new Competencia(10, 15, TipoCompetencia.F1);
            AutoF1 a1 = new AutoF1(15, "Ferrari", 200);
            AutoF1 a2 = new AutoF1(2, "McLaren", 190);
            AutoF1 a3 = new AutoF1(5, "Jaguar", 220);

            if(torneoF1 + a1)
            {
                Console.WriteLine("Se agregó: {0}\n", a1.MostrarDatos());
                if(torneoF1 + a2)
                {
                    Console.WriteLine("Se agregó: {0}\n", a2.MostrarDatos());
                    if (torneoF1 + a3)
                    {
                        Console.WriteLine("Se agregó: {0}\n", a3.MostrarDatos());
                        Console.ReadKey();
                        Console.WriteLine("\nCompetencia: {0}\n", torneoF1.MostrarDatos());
                    }
                }
            }
            if(torneoF1 + a1)
            {
                Console.WriteLine("Fijate que se anotó dos veces al mismo auto");
            }
            else
            {
                Console.WriteLine("Algún despistado trató de inscribir de nuevo al primer auto");
            }
            Console.ReadKey();
        }
    }
}
