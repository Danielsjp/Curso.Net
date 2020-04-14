using System;

namespace Fase4
{
    class Program
    {
        static void Main(string[] args)
        {

            String nom= "Dani", cognom1= "Sanchez", cognom2= "Jimenez";
            int dia=02, mes=10, any=1982;
            var concatnom = nom + " " + cognom1 + " " + cognom2;
            string concatdata = dia.ToString() + "/" + mes.ToString() + "/" + any.ToString();
            Console.WriteLine("El meu nom es: "+concatnom);
            Console.WriteLine("La meva data de naixement es: "+concatdata);         
            bool condicion;
            int resto = any % 4;
            if (resto == 0) { condicion = true; Console.WriteLine("El meu any de naixement es de traspas."); }
            else { condicion = false; Console.WriteLine("El meu any de naixement no es de traspas."); }
        }
    }
}

