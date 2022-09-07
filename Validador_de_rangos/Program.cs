using System;
using System.ComponentModel.DataAnnotations;
using Biblioteca;

namespace ValidarRangos
{

    public class Program
    {

        public static void Main()
        {
            int valorIngresado;
            int valorMinimo = -100;
            int valorMaximo = 100;
            int numerosIngresados = 0;

            int mayorNumeroIngresado = valorMinimo;
            int menorNumeroIngresado = valorMaximo;
            int acumulador = 0;
            float promedio = 0;



            Console.WriteLine("Por favor, ingrese 10 numeros entre {0} y {1}", valorMinimo, valorMaximo);
            while (numerosIngresados < 10)
            {
                if (int.TryParse(Console.ReadLine(), out valorIngresado))
                {


                    if (validador.Validar(valorIngresado, valorMinimo, valorMaximo))
                    {
                        Console.WriteLine("Ha ingresado {0}. Correcto.", valorIngresado);

                        if (valorIngresado > mayorNumeroIngresado)
                        {
                            mayorNumeroIngresado = valorIngresado;
                        }

                        if (valorIngresado < menorNumeroIngresado)
                        {
                            menorNumeroIngresado = valorIngresado;
                        }

                        acumulador += valorIngresado;
                        numerosIngresados++;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. El numero {0} no se encuentra entre {1} y {2}", valorIngresado, valorMinimo, valorMaximo);
                    }



                }
                else
                {
                    Console.WriteLine("ERROR. El valor ingresado no es numerico");
                }
            }

            promedio = acumulador / (float)numerosIngresados;

            Console.WriteLine("Informes:");
            Console.WriteLine("Mayor numero ingresado: {0}", mayorNumeroIngresado);
            Console.WriteLine("Menor numero ingresado: {0}", menorNumeroIngresado);
            Console.WriteLine("Promedio: {0}", promedio);

        }

    }
}