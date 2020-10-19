using System;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;

namespace Programa_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string cero = "0";
            int resultado;
            Console.Write("1) Dividir por cero\n2) Formato incorrecto de conversion\n" +
                "3) Excepcion propia\n-  Cualquier otra cosa, error generico\nOpcion: ");
            opcion = int.Parse(Console.ReadLine());

            try
            {
                switch (opcion)
                {
                    case 1:
                        {
                            resultado = 12 / int.Parse(cero);
                            break;
                        }
                    case 2:
                        {
                            resultado = int.Parse("haciendo cualquiera");
                            break;
                        }
                    case 3:
                        {
                            throw new MiExcepcion("Mi excepcion se lanzo correctamente\n");
                        }
                    default:
                        throw new Exception("Elegiste cualquiera man, no era una opcion valida\n");
                }
            }

            catch (DivideByZeroException ex)
            {
                Console.Clear();
                Console.WriteLine("No se puede dividir por cero");
                Console.WriteLine("{0}", ex.Message);
            }
            catch (FormatException ex)
            {
                Console.Clear();
                Console.WriteLine("El formato en la conversion no es correcto");
                Console.WriteLine("{0}", ex.Message);
            }
            catch (MiExcepcion ex) 
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("{0}", ex.Message);
            }

            Console.ReadKey();
        }
    }
}
