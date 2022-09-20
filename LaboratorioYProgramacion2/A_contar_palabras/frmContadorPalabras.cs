using System.Text;

namespace A_contar_palabras
{
    public partial class frmContadorPalabras : Form
    {
        Dictionary<string, int> palabras = new Dictionary<string, int>();


        public frmContadorPalabras()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string texto = rtxtContadorPalabras.Text; //----------------------------------> 1) Recibo el texto ingresado
            texto = texto.ToLower();
            //



            string[] palabras = texto.Split(' '); //--------------------------------------> 2) Realizo un split para dividirlo en palabras
            
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>(); //--> 3) Instancio un diccionario
            

            foreach (string palabra in palabras) //---------------------------------------> 4) Recorro el array de palabras y voy guardandolas en el diccionario
            {
                if (contadorPalabras.ContainsKey(palabra))
                {
                    contadorPalabras[palabra]++;
                }
                else
                {
                    contadorPalabras.Add(palabra, 1);
                }

            }

            

            List<KeyValuePair<string, int>> listaDePalabras = contadorPalabras.ToList();//--> 5) Convierto el diccionario en una lista.
            listaDePalabras.Sort(OrdenarLista); //------------------------------------------> 6) Ordeno la lista


            MostrarResultados(listaDePalabras); //------------------------------------------> 7) Muestro la lista

        }


        private int OrdenarLista(KeyValuePair<string, int> elemento1, KeyValuePair<string, int> elemento2)
        {
            return elemento1.Value - elemento2.Value;
        }

        private void MostrarResultados(List<KeyValuePair<string, int>> resultados)
        {
            var sb = new StringBuilder();

            if (String.IsNullOrWhiteSpace(resultados[0].Key))
            {
                MessageBox.Show("No se ingresaron palabras");

            }
            else
            {
                foreach (var item in resultados)
                {
                    sb.AppendLine($"Palabra: {item.Key}  |  Cantidad: {item.Value}");
                }

                MessageBox.Show(sb.ToString());
            }

        }
    }
}