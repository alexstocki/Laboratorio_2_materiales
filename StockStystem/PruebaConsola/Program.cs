using System;
using System.Reflection;
using Entidades;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Portfolio portfolio = new Portfolio();

            if (portfolio + (new Stock("Coca-Cola", "KO", 1590)))
            {
                if (portfolio + (new Stock("Coca-Cola", "KO", 1200)))
                {
                    if (portfolio + (new Stock("Apple", "APPL", 1790)))
                    {
                        if (portfolio + (new Stock("Apple", "APPL", 1590)))
                        {
                            if (portfolio + (new Stock("Amazon", "AMZN", 6500)))
                            {
                                Console.WriteLine(portfolio);
                            }
                        }
                    }
                }
            }
            ;

            //Stock accion = new Stock("Coca-Cola", "KO", 1055);


        }
    }
}
