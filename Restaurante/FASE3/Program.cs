using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

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
            int cuenta = 0;
            string[] menu = new string[5];
            int[] precios = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Introduce Plato{i}");
                menu[i] = Console.ReadLine();
                Console.WriteLine($"Introduce Precio{i}");
                precios[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Numero:" + i + "//Plato:" + menu[i] + "//" + "Precio:" + precios[i]);
            }
            List<String> eleccion = new List<String>();
            bool Salir = false;
            while (Salir == false)
            {
                Console.WriteLine("¿Que quieres comer?");
                eleccion.Add(Console.ReadLine());
                Console.WriteLine("¿Quieres Salir? Si/No");
                string respuesta = Console.ReadLine();
                if (respuesta == "Si") { Salir = true; }
            }           
            foreach (string plato in eleccion)
            {                
                for (int i = 0; i < 5; i++)
                {                   
                    if (plato == menu[i])
                    { cuenta = cuenta + precios[i]; }                    
                }
                if (menu.Contains(plato) == false) {Console.WriteLine($"{plato} No Existe");}
            }
            Console.WriteLine("Cantidad a pagar:"+cuenta);
        }
    }
}