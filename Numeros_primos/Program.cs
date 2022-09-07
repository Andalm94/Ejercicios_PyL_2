// Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
// Validar que el dato ingresado por el usuario sea un número.
// Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
// Si ingresa "salir", cerrar la consola.
// Al finalizar, preguntar al usuario si desea volver a operar.
// Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

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



        //Pedido de datos al usuario
        Console.WriteLine("Ingrese un numero: ");
        numeroIngresado = int.Parse(Console.ReadLine());


        //Informe
        Console.WriteLine("Numeros primos hasta el {0}: ", numeroIngresado);

        for (int i = 0; i < numeroIngresado; i++)
        {

            if (i % 2 == 0)
            {
                Console.WriteLine("Numero menor ingresado: {0}", i);
            }
        }


    }
}
