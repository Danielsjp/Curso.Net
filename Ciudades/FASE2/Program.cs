using System;

namespace FASE2
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

            string[] arrayCiudades = { ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6 };

            Array.Sort(arrayCiudades);
            
            foreach(string ciudades in arrayCiudades)
            {

                Console.WriteLine(ciudades);
            }
            Console.ReadKey();
        }

    }
}
