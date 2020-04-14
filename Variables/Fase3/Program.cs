using System;

namespace Fase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int traspas = 1948;
            int seRepite = 4;
            int fechaNacim = 1982;
            bool condicion;

            for (int i = traspas; i<fechaNacim; i=i+1)
            {            
                int resto = i % seRepite;
                if (resto == 0) { condicion = true; string OK = $"L´any {i} es de traspas: {condicion}"; Console.WriteLine(OK); }      
                else { condicion = false; string KO = $"L´any {i} es de traspas: {condicion}"; Console.WriteLine(KO); }
            }
        }
    }
}
