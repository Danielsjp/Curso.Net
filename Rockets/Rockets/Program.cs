using Rockets.Models;
using System;
using Rockets.Dbcontext;
using Microsoft.VisualBasic.CompilerServices;
using System.Threading;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Linq;

namespace Rockets
{
    class Program
    {
        static void Main(string[] args)
        {
            var Rocki = new xRockets
            {
                Id = Guid.NewGuid(),
                NameR = "32WESSDS",
                numP = 3,
                c1 = 10,
                c2 = 30,
                c3 = 80
            };
            Rockets.Dbcontext.context.Rocket.Add(Rocki.Id, Rocki);
            var propulsor = new Propulsor
            {
                Rocket = Rocki.NameR,
                Name = "C1",
                Id = Guid.NewGuid(),
                actualPot = 0,
                maxPot = 10,
            };
            Rockets.Dbcontext.context.Propul.Add(propulsor.Id, propulsor);
            var propulsor2 = new Propulsor
            {
                Rocket = Rocki.NameR,
                Name = "C2",
                Id = Guid.NewGuid(),
                actualPot = 0,
                maxPot = 2,
            };
            Rockets.Dbcontext.context.Propul.Add(propulsor2.Id, propulsor2);
            var propulsor3 = new Propulsor
            {
                Rocket = Rocki.NameR,
                Name = "C3",
                Id = Guid.NewGuid(),
                actualPot = 0,
                maxPot = 80,
            };
            Rockets.Dbcontext.context.Propul.Add(propulsor3.Id, propulsor3);
            Thread R = new Thread(Acelerar);
            Thread F = new Thread(Frenar);
            static void Acelerar(object s)
            {
                var potenciaobjetivo = Convert.ToInt32(s);                                     
                foreach (var dato in Rockets.Dbcontext.context.Propul.Values)
                {                 
                    for (dato.actualPot = 0; dato.actualPot <= potenciaobjetivo; dato.actualPot++)
                    {

                        
                        Console.WriteLine($"ACELERANDO {dato.Name} : {dato.actualPot}");
                        //foreach (var student in myList.Where(r => r.Name == "Tom")) { student.Marks = 35; }
                       
                        if (dato.actualPot == dato.maxPot) {Console.WriteLine($"{dato.Name} A SU TOPE DE {dato.maxPot}"); break; }
                        
                        if (dato.actualPot == potenciaobjetivo) {Console.WriteLine(dato.Name + " POTENCIA DE :" + potenciaobjetivo + " CONSEGUIDA"); } 
                        
                    }

                }
                
            }
            static void Frenar(object s)
            {
                var potenciaobjetivo = Convert.ToInt32(s);
                foreach (var dato in Rockets.Dbcontext.context.Propul.Values)
                {
                    Console.WriteLine("............");
                    Console.WriteLine($"{dato.Name} tiene actualmete una potencia de {dato.actualPot}");

                }
            }
            R.Start(6);
            F.Start(2);
            //F.Start(5);
            //R.Start(20);
        }
    }
}



