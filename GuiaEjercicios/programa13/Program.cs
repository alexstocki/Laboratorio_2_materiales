using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";

            /* Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
             * string DecimalBinario(double): convierte un número de decimal a binario.
             * double BinarioDecimal(string): convierte un número de binario a decimal.
             */

            string lectura, binarioDesdeDecimal;
            double numero, decimalDesdeBinario;

            Console.Write("Ingrese un número binario (1's y 0's): ");
            lectura = Console.ReadLine();
            decimalDesdeBinario = Conversor.BinarioDecimal(lectura);

            Console.Write("Ingrese un número decimal positivo: ");
            lectura = Console.ReadLine();
            numero = double.Parse(lectura);
            binarioDesdeDecimal = Conversor.DecimalBinario(numero);
            

            Console.WriteLine("Binario transformado en decimal: {0}", decimalDesdeBinario);
            Console.WriteLine("Decimal transformado en binario: {0}", binarioDesdeDecimal);

            Console.ReadKey();
        }
    }
}
