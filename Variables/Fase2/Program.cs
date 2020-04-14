using System;

namespace Fase2
{
    class Program
    {
        static void Main(string[] args)
        {
            int traspas = 1948;
            int seRepite = 4;
            int fechaNacim = 1982;
            int totaltraspas = (fechaNacim-traspas)/seRepite;
            Console.WriteLine($"Anys de Traspas desde {traspas} fins {fechaNacim}: " + totaltraspas);
        }
    }
}
