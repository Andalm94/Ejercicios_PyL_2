using Biblioteca_conversor_binario;

namespace Conversor_binario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numeroIngresado = txtInputBtoD.Text;

            txtResultBtoD.Text = ConversoresBinarioDecimal.ConvertirBinarioADecimal(numeroIngresado);
        }

        private void btnDtoB_Click(object sender, EventArgs e)
        {
            int numeroIngresado = int.Parse(txtInputDtoB.Text);

            txtResultDtoB.Text = ConversoresBinarioDecimal.ConvertirDecimalABinario(numeroIngresado); 

        }
    }
}