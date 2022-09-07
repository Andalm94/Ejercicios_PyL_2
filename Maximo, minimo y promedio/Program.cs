// See Ingresar 5 números por consola, guardándolos en una variable escalar.
// Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

using System;

class HelloWorld
{
    static void Main(string[] args)
    {
        //Declaracion de variables iniciales
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Beep();
        int[] arrayInt = new int[5];
        int intMax;
        int intMin;
        float promedio;


        //Pedido de datos al usuario
        Console.WriteLine("Ingrese 5 numeros: ");
        for (int i = 0; i < 5; i++)
        {
            arrayInt[i] = int.Parse(Console.ReadLine());
        }

        intMin = arrayInt.Min();
        intMax = arrayInt.Max();
        promedio = arrayInt.Sum() / (float)arrayInt.Length;

        //Informes
        Console.WriteLine("Numero menor ingresado: {0}", intMin);
        Console.WriteLine("Numero mayor ingresado: {0}", intMax);
        Console.WriteLine("Promedio: {0}", promedio);

    }
}
