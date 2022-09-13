using System.Text;
using System;

namespace Biblioteca_conversor_binario
{
    public class ConversoresBinarioDecimal
    {
        public static string ConvertirBinarioADecimal(string numeroIngresado)
        {
            //Recibo el numero como string.
            //Lo convierto en array de chars.
            //Lo invierto para poder operarlo.
            char[] array = numeroIngresado.ToCharArray();
            Array.Reverse(array);
            int numeroDecimal = 0;
            int aux;

            for(int i = 0; i<array.Length; i++)
            {
                numeroDecimal += int.Parse(array[i].ToString()) * (int)Math.Pow(2, i);
            }
                               
            return new StringBuilder().Append(numeroDecimal).ToString();
        }

        public static string ConvertirDecimalABinario(int numeroIngresado)
        {
            string numeroBinario = String.Empty;
            int auxiliar = 0;

            while(numeroIngresado > 0)
            {
                auxiliar = numeroIngresado % 2;
                numeroIngresado = numeroIngresado / 2;
                numeroBinario = auxiliar.ToString() + numeroBinario;
            }



            return numeroBinario;
        }

    }
}