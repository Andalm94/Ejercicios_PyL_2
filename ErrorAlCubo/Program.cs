//Ingresar un número y mostrar el cuadrado y el cubo del mismo.
//Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".

using System;
using System.Reflection.Metadata.Ecma335;

class HelloWorld
{

    static void Main(string[] args)
    {
        //Declaracion de variables iniciales
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Beep();
        int numeroIngresado = 0;
        int flag = 0;
        double cuadrado = 0;
        double cubo = 0;

        Console.WriteLine("Ingrese un numero:");

        while (flag == 0)
        {

            if (int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                if (numeroIngresado > 0)
                {

                    cuadrado = Math.Pow(numeroIngresado, 2);
                    cubo = Math.Pow(numeroIngresado, 3);
                    flag = 1;
                }
                else
                {
                    Console.WriteLine("ERROR. Reingresar numero");
                }

            }
            else
            {
                Console.WriteLine("ERROR. El dato ingresado no es numerico");
            }
        }

        //Informes
        Console.WriteLine("Numero ingresado: {0}", numeroIngresado);
        Console.WriteLine("{0}^2 = {1}", numeroIngresado, cuadrado);
        Console.WriteLine("{0}^3 = {1}", numeroIngresado, cubo);

    }
}
