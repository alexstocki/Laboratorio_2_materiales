using System;
using System.ComponentModel.DataAnnotations.Schema;
using Entidades;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Cliente p1 = new Cliente("Alberto", "Fernandez", "12121212", 100);
            Empleado e1 = new Empleado("Juan", "Perez", "38181848", 1);
            Producto coca = new Producto("Coca-Cola", 1, 75.90, 10);
            Producto queso = new Producto("Tregar", 2, 85, 5);
            Producto agua = new Producto("Villavicencio", 5, 65, 20);
            Producto pan = new Producto("Fargo", 4, 50, 7);

            if (Inventario.AgregarAInventario(coca))
            {
                Console.WriteLine("se agrego coca al inventario");
                if (Inventario.AgregarAInventario(queso))
                {
                    Console.WriteLine("se agrego queso al inventario");
                    if (Inventario.AgregarAInventario(agua))
                    {
                        Console.WriteLine("se agrego agua al inventario");
                        if (Inventario.AgregarAInventario(pan))
                        {
                            Console.WriteLine("se agrego pan al inventario");
                            if (Inventario.AgregarAInventario(coca))
                            {
                                Console.WriteLine("volviste a agregar coca, todo mal");
                            }
                            else
                            {
                                Console.WriteLine("Bieeen, no se volvio a agregar coca\n");
                            }
                        }
                    }
                }

                if (KwikEMart.AgregarCliente(p1))
                {
                    Console.WriteLine("Agregaste cliente p1");
                    if (KwikEMart.AgregarCliente(p1))
                    {
                        Console.WriteLine("APA se volvio a agregar al mismo cliente man");
                    }
                    else
                    {
                        Console.WriteLine("Bien, no se volvio a agregar al p1");
                    }

                    if (KwikEMart.AgregarEmpleado(e1))
                    {
                        Console.WriteLine("Se agrego al empleado 1");
                        if (KwikEMart.AgregarEmpleado(e1))
                        {
                            Console.WriteLine("MMM se agrego de nuevo al empleado C1. Revisar.");
                        }

                        else
                        {
                            Console.WriteLine("Biennnnn no se volvio a agregar al empleado E1");
                        }
                    }
                }
            }
           



            

            

            

            Console.ReadKey();
        }
    }
}
