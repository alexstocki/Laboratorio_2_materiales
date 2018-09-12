using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 07";

            /* Hacer un programa que pida por pantalla la fecha de nacimiento de una persona
             * (día, mes, año) y calcule el total de días vividos por esa persona hasta la 
             * fecha actual. 
             * Tomar la fecha actual con DateTime.Now
             */
            int valido = 0;
            int diasTotales;
            string lectura;
            DateTime nacimiento;
            DateTime hoy = DateTime.Now;
            TimeSpan totalDeDias;

            do
            {
                Console.Write("Ingrese su fecha de nacimiento (DD/MM/AAAA): ");
                lectura = Console.ReadLine();
                nacimiento = DateTime.Parse(lectura);

                totalDeDias = hoy - nacimiento;
                diasTotales = totalDeDias.Days;

                Console.WriteLine("Usted vivió {0} días, por ahora.", diasTotales);
               
                valido = 1;
            } while (valido != 1);

            Console.Read();

        }
    }
}
