using Rockets.Models;
using System;
using Rockets.Dbcontext;
using Microsoft.VisualBasic.CompilerServices;
using System.Threading;

namespace Rockets
{
    class Program
    {
        static void Main(string[] args)
        {

            Thread R2 = new Thread(Acelerar);
            //Thread R1f = new Thread(Frenar);
            //Thread R2f = new Thread(Frenar);
            Thread f = new Thread(Frenar);
            static void Frenar(object s)
            {

            }
            static void Acelerar(object s)
            {
                var potenciaobjetivo = Convert.ToInt32(s);
                foreach (var dato in Rockets.Dbcontext.context.Rocket.Values)
                {
                    var potencia = 0;
                    if (potenciaobjetivo > dato.c1) { potencia = potencia++; Console.WriteLine("C1:" + potencia); }
                    else
                    {
                        Console.WriteLine("C1 ha llegado a la maxima potencia");
                    }
                    foreach (var dato2 in Rockets.Dbcontext.context.Rocket.Values)
                    {
                        var potencia2 = 0;
                        if (potenciaobjetivo > dato.c2) { potencia2 = potencia2++; Console.WriteLine("C2:" + potencia2);}
                        else { Console.WriteLine("C2 ha llegado a la maxima potencia"); }
                    }
                    foreach (var dato3 in Rockets.Dbcontext.context.Rocket.Values)
                    {
                        var potencia3 = 0;
                        if (potenciaobjetivo > dato.c3) { potencia3 = potencia3++; Console.WriteLine("C3:" + potencia3); }
                        else { Console.WriteLine("C3 ha llegado a la maxima potencia"); }
                    }
                }
            }
            var rocki = new xRockets
            {
                Id = Guid.NewGuid(),
                NameR = "32WESSDS",
                numP = 3,
                c1 = 10,
                c2 = 30,
                c3 = 80
            };
            Rockets.Dbcontext.context.Rocket.Add(rocki.Id, rocki);
            
            R2.Start(50);
            var rocki2 = new xRockets
            {
                Id = Guid.NewGuid(),
                NameR = "LDSFJA32",
                numP = 6,
                c1 = 30,
                c2 = 40,
                c3 = 50,
                c4 = 50,
                c5 = 30,
                c6 = 10
            };
            Rockets.Dbcontext.context.Rocket.Add(rocki2.Id, rocki2);
                //R2.Start();
                //var rocki2 = new xRockets
                //{
                //    Id = Guid.NewGuid(),
                //    NameR = "LDSFJA32",
                //    numP = 6
                //    //Power = 30
                //};
                //Rockets.Dbcontext.context.Rocket.Add(rocki2.Id, rocki2);
                //var propulsor = new Propulsor
                //{
                //    Rocket = rocki.NameR,
                //    Id = System.Guid.NewGuid(),
                //    actualPot = 0,
                //    maxPot = 10
                //};
                //Rockets.Dbcontext.context.Propul.Add(propulsor.Id, propulsor);
            }
        }
}


