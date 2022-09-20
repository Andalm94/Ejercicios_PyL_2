using System;
using System.ComponentModel.DataAnnotations;
using Biblioteca_libro;


namespace Program
{

    public class Program
    {

        public static void Main()
        {

            Libro libro = new Libro();

            int opcion = 0;
            int numPagina;
            string textoIngresado;


            while (opcion != 4)
            {
                Console.WriteLine("1- Leer pagina del libro");
                Console.WriteLine("2- Escribir pagina del libro");
                Console.WriteLine("3- Leer todo el libro");
                Console.WriteLine("3- Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Que pagina desea leer?");
                        numPagina = int.Parse(Console.ReadLine());
                        Console.WriteLine(libro[numPagina]);
                        break;

                    case 2:
                        Console.WriteLine("Escriba el texto");
                        textoIngresado = new string(Console.ReadLine());
                        Console.WriteLine("Seleccione la pagina");
                        numPagina = int.Parse(Console.ReadLine());
                        libro[numPagina] = textoIngresado;
                        break;


                    case 3:
                        for (int i=0; i<libro.Paginas; i++)
                        {
                            Console.WriteLine($"------------------------------------------------");
                            Console.WriteLine($"Pagina {i+1}");
                            Console.WriteLine($"{libro[i]}");
                        }
                        break;
                }
            }
        }
    }
}
