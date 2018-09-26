using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 31";

            Cliente c1 = new Cliente("Rodrigo", 1);
            Cliente c2 = new Cliente("Alejandro", 2);
            Cliente c3 = new Cliente("Pablo", 92);
            PuestoAtencion cajita1 = new PuestoAtencion(Puesto.Caja1);
            Negocio n1 = new Negocio("Farmacia");

            if(n1 + c1)
            {
                Console.WriteLine("Rodrigo está en la lista");
            }
            if(n1 + c2)
            {
                Console.WriteLine("Alejandro se agregó");
            }
            if(!(n1 + c1))
            {
                Console.WriteLine("Rodrigo se quiso anotar de nuevo. No pudo");
            }

            
            Console.WriteLine("Primer turno...");
            if (~n1)
            {
                Console.WriteLine("Que pase el que sigue");
            }
            
            

            Console.ReadKey();
        }
    }
}
