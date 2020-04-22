using System;
using System.Net.Http.Headers;
using System.Runtime;
using System.Runtime.InteropServices.WindowsRuntime;

namespace FASE4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce Nombre Ciudad 1");
            string ciudad1 = Console.ReadLine();
            Console.WriteLine("Introduce Nombre Ciudad 2");
            string ciudad2 = Console.ReadLine();
            Console.WriteLine("Introduce Nombre Ciudad 3");
            string ciudad3 = Console.ReadLine();
            Console.WriteLine("Introduce Nombre Ciudad 4");
            string ciudad4 = Console.ReadLine();
            Console.WriteLine("Introduce Nombre Ciudad 5");
            string ciudad5 = Console.ReadLine();
            Console.WriteLine("Introduce Nombre Ciudad 6");
            string ciudad6 = Console.ReadLine();

            char[] ciudadZ = ciudad1.ToCharArray();
            Array.Reverse(ciudadZ);
            Console.WriteLine(string.Join("",ciudadZ));

            char[] ciudadX = ciudad2.ToCharArray();
            Array.Reverse(ciudadX);
            Console.WriteLine(string.Join("", ciudadX));

            char[] ciudadC = ciudad3.ToCharArray();
            Array.Reverse(ciudadC);
            Console.WriteLine(string.Join("", ciudadC));

            char[] ciudadV = ciudad4.ToCharArray();
            Array.Reverse(ciudadV);
            Console.WriteLine(string.Join("", ciudadV));
            
            char[] ciudadB = ciudad5.ToCharArray();
            Array.Reverse(ciudadB);
            Console.WriteLine(string.Join("", ciudadB));

            char[] ciudadN = ciudad6.ToCharArray();
            Array.Reverse(ciudadN);
            Console.WriteLine(string.Join("", ciudadN));

        }
    }
}


