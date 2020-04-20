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
            string[] arrayCiudades = {ciudad1, ciudad2, ciudad3, ciudad4, ciudad5, ciudad6};
            string[] ciudadesmodificadas;
            
           
                for (int i=0; i<arrayCiudades.Length; i++)
                {

                   if (arrayCiudades[i].Contains('a')) 
                            
                                { 
                        
                        sustitucion = arrayCiudades[i].Replace('a', '4'); arrayCiudades[i] = sustitucion; ciudadesmodificadas = arrayCiudades; 
                            
                                foreach (string hola in ciudadesmodificadas)
                                {   
                            
                                    Console.WriteLine(hola); 
                        
                                }
                                }
                   

                }
               

            }
           
            
        }

    }


