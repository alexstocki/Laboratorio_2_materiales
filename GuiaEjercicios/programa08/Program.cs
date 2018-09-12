using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 08";

            float hourValue;
            string name, lecture;
            int years, plus = 150;
            int workedHours;
            float firstTotal, finalTotal, discount;
            string cont = "Y";

            do
            {
                Console.Write("Ingrese el valor de la hora trabajada: ");
                lecture = Console.ReadLine();
                if(float.TryParse(lecture, out hourValue))
                {
                    Console.Write("Ingrese nombre del empleado: ");
                    name = Console.ReadLine();

                    Console.Write("Ingrese antiguedad del empleado: ");
                    lecture = Console.ReadLine();
                    if(int.TryParse(lecture, out years))
                    {
                        Console.Write("Horas trabajadas en el mes: ");
                        lecture = Console.ReadLine();
                        if(int.TryParse(lecture, out workedHours))
                        {
                            firstTotal = (hourValue * workedHours) + (years * plus);
                            discount = (firstTotal * 13) / 100;
                            finalTotal = firstTotal - discount;

                            Console.WriteLine("Empleado: {0} | Antiguedad: {1} | Valor por hora: {2} | Sueldo bruto: {3} | Sueldo neto: {4}", name, years, hourValue, firstTotal, finalTotal);
                        }
                    }
                }

                Console.Write("Desea ingresar otro empleado (Y|N): ");
                cont = Console.ReadLine();

            } while (cont != "N");

            Console.ReadKey();
        }
    }
}
