using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 34";

            Auto a1 = new Auto(4, 4, Colores.Gris, 5, 5);
            Console.WriteLine("Auto: \nRuedas: {0}   Puertas: {1}\nColor: {2}   Marchas: {3}\n", a1.cantidadRuedas, a1.cantidadPuertas, a1.color, a1.cantidadMarchas);
            Console.ReadKey();
            Camion c1 = new Camion(8, 2, Colores.Negro, 5, 15000);
            Console.WriteLine("Camión: \nRuedas: {0}   Puertas: {1}\nColor: {2}   Marchas: {3}\nPeso de carga: {4}\n", c1.cantidadRuedas, c1.cantidadPuertas, c1.color, c1.cantidadMarchas, c1.pesoCarga);
            Console.ReadKey();
            Moto m1 = new Moto(2, 0, Colores.Rojo, 120);
            Console.WriteLine("Moto: \nRuedas: {0}    Color: {1}   Cilindrada: {2}", m1.cantidadRuedas, m1.color, m1.cilindrada);
            Console.ReadKey();
        }
    }
}
