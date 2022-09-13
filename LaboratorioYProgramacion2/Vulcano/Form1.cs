using Biblioteca_conversores_de_temperatura;
using System.Text;
using System;

namespace Vulcano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConvertirFarenheit(object sender, EventArgs e)
        {

            //Recibo el dato ingresado por el usuario
            float temperaturaIngresadaFarenheit = float.Parse(txtFarenheit.Text);

            //Realizo las conversiones
            float resultadoCelsius = (float)Math.Round(Conversor.ConvertirAFarenheitACelsius(temperaturaIngresadaFarenheit), 2);
            float resultadoKelvin = (float)Math.Round(Conversor.ConvertirFarenheitAKelvin(temperaturaIngresadaFarenheit), 2);
            float resultadoFarenheit = temperaturaIngresadaFarenheit;

            //Las devuelvo por textBox
            txtFtoC.Text = new StringBuilder().Append(resultadoCelsius).ToString();
            txtFtoK.Text = new StringBuilder().Append(resultadoKelvin).ToString();
            txtFtoF.Text = new StringBuilder().Append(resultadoFarenheit).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Recibo el dato ingresado por el usuario
            float temperaturaIngresadaCelsius = float.Parse(txtCelsius.Text);

            //Realizo las conversiones
            float resultadoCelsius = temperaturaIngresadaCelsius;
            float resultadoFarenheit = (float)Math.Round(Conversor.ConvertirACelsiusAFarenheit(temperaturaIngresadaCelsius), 2);
            float resultadoKelvin = (float)Math.Round(Conversor.ConvertirFarenheitAKelvin(resultadoFarenheit), 2);

            //Las devuelvo por textBox
            txtCtoC.Text = new StringBuilder().Append(resultadoCelsius).ToString();
            txtCtoK.Text = new StringBuilder().Append(resultadoKelvin).ToString();
            txtCtoF.Text = new StringBuilder().Append(resultadoFarenheit).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Recibo el dato ingresado por el usuario
            float temperaturaIngresadaKelvin = float.Parse(txtCelsius.Text);

            //Realizo las conversiones
            float resultadoKelvin = temperaturaIngresadaKelvin;
            float resultadoFarenheit = (float)Math.Round(Conversor.ConvertirKelvinAFarenheit(temperaturaIngresadaKelvin), 2); 
            float resultadoCelsius = (float)Math.Round(Conversor.ConvertirAFarenheitACelsius(resultadoFarenheit), 2);
            

            //Las devuelvo por textBox
            txtKtoC.Text = new StringBuilder().Append(resultadoCelsius).ToString();
            txtKtoK.Text = new StringBuilder().Append(resultadoKelvin).ToString();
            txtKtoF.Text = new StringBuilder().Append(resultadoFarenheit).ToString();
        }
    }
}