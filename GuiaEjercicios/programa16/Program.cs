using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 16";

            Alumno alumno1 = new Alumno(001, "Stocki", "Alex");
            Alumno alumno2 = new Alumno(002, "Sergio", "Agüero");
            Alumno alumno3 = new Alumno(003, "Lionel", "Messi");

            alumno1.Estudiar(10, 9);
            alumno1.CalcularFinal();
            alumno2.Estudiar(2, 7);
            alumno2.CalcularFinal();
            alumno3.Estudiar(6, 9);
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.Write("\n----------\n");
            Console.WriteLine(alumno2.Mostrar());
            Console.Write("\n----------\n");
            Console.WriteLine(alumno3.Mostrar());
            Console.ReadKey();
            
        }
    }
}
