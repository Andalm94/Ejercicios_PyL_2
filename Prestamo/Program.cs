/*
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

Deberá tener los atributos:

-titular que contendrá la razón social del titular de la cuenta.
-cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.

Construir los siguientes métodos para la clase:

-Un constructor que permita inicializar todos los atributos.
-Un método getter para cada atributo.
-mostrar: retornará una cadena de texto con todos los datos de la cuenta.
-ingresar: recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
-retirar: recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.

En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.
*/

using System;
using System.Security.Cryptography.X509Certificates;
using Prestamo;

namespace Program
{

    public class Program
    {

        public static void Main()
        {

            Cuenta c1 = new Cuenta("Andres", 100);
            int opcionMenu = 0;
            int monto;

            while (opcionMenu != 4)
            {
                opcionMenu = MostrarMenu();
                if (opcionMenu != -1)
                {
                    switch (opcionMenu)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el monto");
                            if (int.TryParse(Console.ReadLine(), out monto))
                            {
                                c1.Ingresar(monto);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el monto");
                            if (int.TryParse(Console.ReadLine(), out monto))
                            {
                                c1.Retirar(monto);
                            }
                            break;
                        case 3:
                            Console.WriteLine(c1.Mostrar());
                            break;
                    }
                }
            }






        }

        private static int MostrarMenu()
        {
            int retorno = -1;
            Console.WriteLine("Ingresar una opcion.");
            Console.WriteLine("1) Ingresar saldo");
            Console.WriteLine("2) Retirar saldo");
            Console.WriteLine("3) Consultar informacion de la cuenta");
            Console.WriteLine("4) Salir");

            int.TryParse(Console.ReadLine(), out retorno);
            return retorno;

        }


    }
}