﻿using System;

namespace FASE2
{
    class Program
    {
        static void Main(string[] args)
        {
            int billete5 = 5;
            int billete10 = 10;
            int billete20 = 20;
            int billete50 = 50;
            int billete100 = 100;
            int billete200 = 200;
            int billete500 = 500;
            int cuentaTotal;

            string[] menu = new string[5];
            int[] precios = new int[5];

            for(int i=0;i<5;i++)
            {
                Console.WriteLine($"Introduce Plato{i}");
                menu[i]= Console.ReadLine();
                Console.WriteLine($"Introduce Precio{i}");
                precios[i] = Int32.Parse(Console.ReadLine());

            }

        }
    }
}
