using System;
using System.Collections.Generic;
using System.Linq;
namespace Letras2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca su nombre");
            String nombre;
            String surName;
            nombre = Console.ReadLine();
            Console.WriteLine("El nombre introducido es: " + nombre);
            char[] arr;
            arr = nombre.ToCharArray();
            Console.WriteLine("Letra por letra");
            foreach (char c in arr)
                Console.WriteLine(c);
            List<char> list = arr.ToList();
            surName = "SANCHEZ";
            char[] surNamechar;
            surNamechar = surName.ToCharArray();
            List<char> SurNC = surNamechar.ToList();
            int i = 0;
            foreach (char c in list)
            {
                char p = list[i];
                if ((int)char.GetNumericValue(p) >= 0)
                {
                    Console.WriteLine("Los Nombres de personas no Continenen Numeros");
                }
                else
                {
                    if (p.Equals('a') | p.Equals('e') | p.Equals('i') | p.Equals('o') | p.Equals('u'))
                    {
                       // Console.WriteLine("VOCAL");
                    }
                    else
                    {
                        // Console.WriteLine("CONSONANTE");
                    }
                }
                i++;
            }
            for (int p = 0; p < arr.Length; p++)
            {
                int count = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[p] == arr[j])
                    {
                        count++;
                        if (numero(arr[p]))
                        {
                            list[p] = arr[p];
                        }
                    }
                }
                if (list[p] != 0)
                {
                    Dictionary<char, int> letr = new Dictionary<char, int>();
                    if (list[p].Equals('a') | list[p].Equals('e') | list[p].Equals('i') | list[p].Equals('o') | list[p].Equals('u'))
                    {
                        Console.WriteLine(list[p] + " se repite: " + count + "(VOCAL)");
                        letr.Add(list[p], count);
                    }
                    else
                    {
                        Console.WriteLine(list[p] + " se repite: " + count + "(CONSONANTE)");
                        letr.Add(list[p], count);
                    }
                    foreach (KeyValuePair<char, int> let in letr)
                    {
                        Console.WriteLine(let.Key + "---" + let.Value);
                    }
                }
            }
            bool numero(int num)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == num)
                    {
                        return false;
                    }
                }
                return true;
            }

             List<char> resultado = list.Concat(" ").Concat(SurNC).ToList();
            
            Console.WriteLine(resultado[4]);
            
        }
    }
}

