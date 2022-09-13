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
            string texto = rtxtContadorPalabras.Text;
            string[] palabras = texto.Split(' ');
            
            Dictionary<string, int> contadorPalabras = new Dictionary<string, int>();
            //List<KeyValuePair<string, int>> listaDePalabras = contadorPalabras.ToList();

            foreach (string palabra in palabras)
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

            var result = MessageBox.Show($"{palabras}");



        }
    }
}