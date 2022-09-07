using System;

namespace Biblioteca
{

    public class validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = false;
            if (valor > min && valor < max)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
