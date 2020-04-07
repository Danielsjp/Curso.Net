// C#
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenid@ al programa para gestión de alumnos");
            Console.WriteLine("Introduzca las notas de los alumnos");


            // 1 cambiar el tamaño del array a 10 y meter 10 notas en vez 5
            var notasDeAlumnos = new double[10];

            notasDeAlumnos[0] = 4.6;
            notasDeAlumnos[1] = 2.3;
            notasDeAlumnos[2] = 6;
            notasDeAlumnos[3] = 3.9;
            notasDeAlumnos[4] = 8.5;
            notasDeAlumnos[5] = 1.5;
            notasDeAlumnos[6] = 2;
            notasDeAlumnos[7] = 5;
            notasDeAlumnos[8] = 5.2;
            notasDeAlumnos[9] = 8;

            // 2 ajustar la medianotasDeAlumnos[4] = 8.5;
            var suma =  notasDeAlumnos[0] +
                        notasDeAlumnos[1] +
                        notasDeAlumnos[2] +
                        notasDeAlumnos[3] +
                        notasDeAlumnos[4] +
                        notasDeAlumnos[5] +
                        notasDeAlumnos[6] +
                        notasDeAlumnos[7] +
                        notasDeAlumnos[8] +
                        notasDeAlumnos[9];

            var media = suma / notasDeAlumnos.Length;
            Console.WriteLine($"la media es {media}");

            // 3 extraer la nota más alta del array y enseñarla en pantalla

            double maxima = notasDeAlumnos.Max();
            Console.WriteLine($"la nota mas alta es: {maxima}");
            // 4 extraer la nota más baja del array y enseñarña en pantalla
            double minima = notasDeAlumnos.Min();
            Console.WriteLine($"la nota mas baja es: {minima}");
        }

    }
}