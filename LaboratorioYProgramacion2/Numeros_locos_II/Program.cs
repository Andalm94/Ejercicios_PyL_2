using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Program
{

    public class Program
    {

        public static void Main()
        {

            /*Uso de stack y list
             * Random
             * Pasaje de stack a list y list a stack
             */

            Stack <int> numerosLocos = new Stack<int>();
            List <int> listaAuxiliar = new List<int>();
            Random rand = new Random();

            for(int i=0; i<20; i++)
            {
                numerosLocos.Push(rand.Next(-100, 100));
            }

            Console.WriteLine("Lista de pila desordenada");
            foreach(int item in numerosLocos)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Positivos de pila decrecientes");
            listaAuxiliar = numerosLocos.ToList();
            listaAuxiliar.Sort();
            numerosLocos = new Stack<int>(listaAuxiliar);
            foreach (int item in numerosLocos)
            {
                if (item > 0)
                {
                    Console.WriteLine(item);
                }
                
            }

            Console.WriteLine("Negativos de pila crecientes");
            listaAuxiliar.Reverse();
            numerosLocos = new Stack<int>(listaAuxiliar);
            foreach (int item in numerosLocos)
            {
                if (item < 0)
                {
                    Console.WriteLine(item);
                }

            }



        }

    }
}