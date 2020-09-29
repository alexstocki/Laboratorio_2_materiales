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
            Producto coca = new Producto("Coca-Cola", 1, 75.90, 10);
            Producto queso = new Producto("Tregar", 2, 85, 5);
            Producto agua = new Producto("Villavicencio", 5, 65, 20);
            Producto pan = new Producto("Fargo", 4, 50, 7);

            Inventario inventario = new Inventario();
            inventario.AgregarAInventario(coca);
            inventario.AgregarAInventario(pan);
            inventario.AgregarAInventario(agua);
            inventario.AgregarAInventario(queso);
            if (inventario.AgregarAInventario(coca))
            {
                Console.WriteLine("\nSe agregó otra coca, esta mal eso\n");
            }

            Console.WriteLine("\nNo se agregó otra coca, esta bien eso\n");

            Console.WriteLine("Coca, primer STOCK: " + coca.StockProducto + "\n");
            p1.AgregarACarro(coca);
            p1.AgregarACarro(pan);
            p1.AgregarACarro(coca);

            Console.WriteLine("Listo todas las cosas del inventario:\n");

            foreach (Producto prod in inventario.Productos)
            {
                Console.WriteLine("{0}\t${1}\t{2}", prod.NombreProducto, prod.PrecioProducto, prod.StockProducto);
            }



            

            

            Console.WriteLine("\nNUEVO -- Coca, segundo STOCK: " + coca.StockProducto + "\n");

            Console.ReadKey();
        }
    }
}
