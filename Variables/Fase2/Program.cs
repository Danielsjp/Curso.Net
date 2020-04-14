using System;

namespace Fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            String nom, cognom1, cognom2;
            int dia, mes, any;
            nom = "Dani";
            cognom1 = "Sanchez";
            cognom2 = "Jimenez";
            dia = 2;
            mes = 10;
            any = 1982;
            var concatname = cognom1 + " " + cognom2 + " " + nom;
            string concatdates = dia.ToString() + "/" + mes.ToString() + "das" + any.ToString();
            Console.WriteLine(concatname);
            Console.WriteLine(concatdates);
        }
    }
}
