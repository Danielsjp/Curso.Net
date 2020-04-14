using System;

namespace Fase1
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
            var concatnom = cognom1 + " " + cognom2 + " " + nom;
            string concatdata = dia.ToString() + "/" + mes.ToString() + "/" + any.ToString();
            Console.WriteLine(concatnom);
            Console.WriteLine(concatdata);
        }
    }
}
