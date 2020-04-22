using System;

namespace FASE3
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
            string sustitucion;
            string[] arrayCiudades = { ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6 };
            string[] ciudadesmodificadas;

            for (int i = 0; i < arrayCiudades.Length; i++) // ejecuta el proceso el numero de ciudades que tiene introducidas
            {
                if (arrayCiudades[i].Contains('a')) // comprueba si en esa posicion existe la letra a
                {
                    sustitucion = arrayCiudades[i].Replace('a', '4'); arrayCiudades[i] = sustitucion; // si existe la letra a, genera de nuevo el nombre de la ciudad                
                }

                ciudadesmodificadas = arrayCiudades;
                Array.Sort(ciudadesmodificadas);
                Console.WriteLine(ciudadesmodificadas[i]);
            }
        }
    }
}


