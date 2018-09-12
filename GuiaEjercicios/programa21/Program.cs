using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 21";

            Celsius c = new Celsius(29);
            Kelvin k = new Kelvin(298.15);
            Fahrenheit f = new Fahrenheit(91.4);


            Celsius aux_c = (Celsius)k;
            Console.WriteLine("298.15 Kelvin(25 celsius): {0}", aux_c.GetGrados());
            aux_c = (Celsius)f;
            Console.WriteLine("91.4 Fahrenheit(33 celsius): {0}", aux_c.GetGrados());

            Console.WriteLine("\n/////////\n");

            Kelvin aux_k = (Kelvin)c;
            Console.WriteLine("29 Celsius(kelvin): {0}", aux_k.GetGrados());
            aux_k = (Kelvin)f;
            Console.WriteLine("91.4 Fahrenheit(kelvin): {0}", aux_k.GetGrados());

            Console.WriteLine("\n/////////\n");

            Fahrenheit aux_f = (Fahrenheit)c;
            Console.WriteLine("29 Celsius(84.2 fahrenheit): {0}", aux_f.GetGrados());
            aux_f = (Fahrenheit)k;
            Console.WriteLine("298.15 Kelvin(77 fahrenheit): {0}", aux_f.GetGrados());

            Console.ReadKey();
        }
    }
}
