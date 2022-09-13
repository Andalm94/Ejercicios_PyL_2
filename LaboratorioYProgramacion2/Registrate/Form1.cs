using Biblioteca_ingresante;
using System.Windows.Forms;

namespace Registrate
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string nombre = txtNombre.Text;
            string direccion = txtDireccion.Text;
            int edad = (int)numEdad.Value;
            string genero = grpGenero.Text;
            //string[] cursos = new string[10];  ---> Averiguar como cargar la info aca
            string pais = listPais.Text;

            //frmSaludo frmSaludo = new frmSaludo(titulo, mensaje);
            //frmSaludo.ShowDialog();

            Ingresante estudiante = new Ingresante("C", direccion, edad, genero, nombre, pais);

            var result = MessageBox.Show($"{estudiante.Mostrar()}", "Alumno ingresado: ");


        }

        private void radFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}