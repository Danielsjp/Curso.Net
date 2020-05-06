using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace FASE1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = new int[] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };
            string[] nombres = new string[] { "David", "Sergios", "Maria", "Laura", "Oscarcito", "Julia", "Oriol" };
            var letraO = nombres.Where(x => x.StartsWith("O"));
            var numLetras = nombres.Where(x => x.Length > 6);
            var ordenado = nombres.OrderByDescending(s => s);
            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            var numQuery2 =
               from num in numbers
               where (num > 5) 
               select num;

            var numQuery3 =
               from num in numbers
               where (num < 5) 
               select num;

            double media = numbers.Average();
             int nMax = numbers.Max();
             int nMin = numbers.Min();

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }
            Console.WriteLine("--");
            foreach (int num in numQuery2)
            {
                Console.Write("{0,1} ", num);
            }
            Console.WriteLine("--");
            foreach (int num in numQuery3)
            {
                Console.Write("{0,1} ", num);
            }
            Console.WriteLine("--");
            foreach (string num in letraO)
            {
                Console.Write("{0,1} ", num);
            }
            Console.WriteLine("--");
            foreach (string num in numLetras)
            {
                Console.Write("{0,1} ", num);
            }
            Console.WriteLine("//////////////////////");
            foreach (var item in ordenado)
            {
                Console.Write(item);
            }
            Console.WriteLine("la nota maxima es" + nMax);
            Console.WriteLine("la nota minima es"+ nMin);
        }
    }
}
