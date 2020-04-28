using System;
using System.Linq;

namespace notasExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            var notasDeAlumnos = new double[10];
            double media = 0;
            Console.WriteLine("Bienvenid@ al programa para gestión de alumnos");
            Console.WriteLine("Introduzca las notas de los alumnos");
            for (int i=0;i<10;i++)
            {
                Console.WriteLine($"Nota{i}:");
                notasDeAlumnos[i] = Double.Parse(Console.ReadLine().Replace(".",","));             
            }                     
            for (int i = 0; i < 10; i++)
            {
                media = media + notasDeAlumnos[i]/notasDeAlumnos.Length;
            }
            Console.WriteLine(media);
            Console.WriteLine(notasDeAlumnos.Max());
            Console.WriteLine(notasDeAlumnos.Min());
        }        
    }
}
