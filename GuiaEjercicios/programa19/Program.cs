using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 19";
            Console.WriteLine("Ejercicio sumador de números y strings");

            Sumador calculadora = new Sumador();
            Sumador calculadoraLimpia = new Sumador();

            Console.WriteLine("La suma de 55 y 90 es: {0}", calculadora.Sumar(55, 90));
            Console.WriteLine("Concatenación de 'La puta' y ' madre loco': {0}", calculadora.Sumar("La puta", " madre loco"));
            Console.WriteLine("Cantidad de sumas: {0}", (int)calculadora);

            Console.ReadKey();

            Console.WriteLine("---COMPARACION DE CALCULADORAS---");
            Console.WriteLine("Fue la nueva calculadora más usada que la vieja? {0}", calculadora | calculadoraLimpia);
            Console.WriteLine("Sumados los usos de las dos calculadoras tenemos: {0}", calculadora + calculadoraLimpia);
            Console.WriteLine("Tiene la calculadora vieja la misma cantidad de usos que ella misma? {0}", calculadora | calculadora);

            Console.ReadKey();
        }
    }
}
