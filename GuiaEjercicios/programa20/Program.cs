﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";

            Pesos p = new Pesos(10, 20.1655f);
            Euro e = new Euro(10, 0.809f);
            Dolar d = new Dolar(10);

            Euro euuuro = e + d;
            Console.WriteLine("Euro + Dólar (€18,09xx): {0}", euuuro.GetCantidad());
            euuuro = e + p;
            Console.WriteLine("Euro + Pesos (€10,40xx): {0}", euuuro.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Dolar aux_d = d + e;
            Console.WriteLine("Dólar + Euro (U$S22,36xx): {0}", aux_d.GetCantidad());
            aux_d = d + p;
            Console.WriteLine("Dólar + Pesos (U$S10,49xx): {0}", aux_d.GetCantidad());
            Console.WriteLine("----------------------------------------------");

            Pesos aux_p = p + e;
            Console.WriteLine("Pesos + Euro ($259,26xx): {0}", aux_p.GetCantidad());
            aux_p = p + d;
            Console.WriteLine("Pesos + Dólar ($211,65xx): {0}", aux_p.GetCantidad());

            Console.ReadKey();
        }
    }
}
