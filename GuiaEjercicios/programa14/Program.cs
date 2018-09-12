using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";

            /* Realizar una clase llamada CalculoDeArea que posea tres métodos de clase(estáticos)
             * que realicen el cálculo de área que corresponda:
             * a) double CalcularCuadrado(double)
             * b) double CalcularTriangulo(double, double)
             * c) double CalcularCirculo(double)
             * El ingreso de los datos como de la visualización se deberán realizar desde el método Main()             * 
             */

            double numero, numero2, opcion;
            string lectura;
            double aCua, aTri, aCir;

            Console.WriteLine("Calculadora de áreas");
            Console.WriteLine("1) Calcular área de un cuadrado\n2) Calcular área de un triángulo\n3) Calcular área de un círculo");
            Console.Write("Opcion: ");
            lectura = Console.ReadLine();

            if(double.TryParse(lectura, out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        {
                            Console.Write("Ingrese el valor del lado: ");
                            lectura = Console.ReadLine();
                            numero = double.Parse(lectura);
                            aCua = CalculoDeArea.CalcularCuadrado(numero);
                            Console.WriteLine("El área es de: {0}", aCua);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Ingrese el valor de la base: ");
                            lectura = Console.ReadLine();
                            numero = double.Parse(lectura);
                            Console.Write("Ingrese el valos de la altura: ");
                            lectura = Console.ReadLine();
                            numero2 = double.Parse(lectura);
                            aTri = CalculoDeArea.CalcularTriangulo(numero, numero2);
                            Console.WriteLine("El área es de: {0}", aTri);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Ingrese el valor del radio: ");
                            lectura = Console.ReadLine();
                            numero = double.Parse(lectura);
                            aCir = CalculoDeArea.CalcularCirculo(numero);
                            Console.WriteLine("El área es de: {0}", aCir);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("ERROR. Opción no válida.");
                            break;
                        }
                }
            }
            else
            {
                Console.Write("ERROR. Ingrese un número válido.");
            }

            Console.ReadKey();
        }
    }
}
