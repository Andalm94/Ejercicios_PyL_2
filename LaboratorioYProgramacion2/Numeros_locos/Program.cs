using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Program
{

    public class Program
    {

        public static void Main()
        {
            List<int> numerosAleatorios = new List<int>();
            Random numeroLoco = new Random();

            for(int i=0; i<20; i++)
            {
                numerosAleatorios.Add(numeroLoco.Next(-100, 100));
            }

            Console.WriteLine("Lista aleatoria desordenada:");
            foreach(int num in numerosAleatorios)
            {
                Console.WriteLine($"{num}");
            }

            Console.WriteLine("Positivos decrecientes:");
            numerosAleatorios.Sort();
            numerosAleatorios.Reverse();
            foreach (int num in numerosAleatorios)
            {
                if(num > 0)
                {
                    Console.WriteLine($"{num}");
                }
                
            }

            Console.WriteLine("Negativos crecientes:");
            numerosAleatorios.Reverse();
            foreach (int num in numerosAleatorios)
            {
                if (num < 0)
                {
                    Console.WriteLine($"{num}");
                }
                
            }

        }

    }
}