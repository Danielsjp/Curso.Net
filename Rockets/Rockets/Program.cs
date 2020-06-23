using Rockets.Models;
using System;
using Rockets.Dbcontext;
using Microsoft.VisualBasic.CompilerServices;
using System.Threading;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;

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
                c2 = 2,
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
                int contador = 0;               
                foreach (var dato in Rockets.Dbcontext.context.Propul.Values)
                {                 
                    for (contador = 0; contador <= potenciaobjetivo; contador++)
                    {
                        Console.WriteLine($"Velocidad Actual {dato.Name}:"+contador);
                        if (contador == dato.maxPot) { Console.WriteLine($"{dato.Name} A SU TOPE"); break; }                      
                    }
                }             
            }
            static void Frenar(object s)
            {
                
            }
            R.Start(6);
            F.Start(2);
        }
    }
}



