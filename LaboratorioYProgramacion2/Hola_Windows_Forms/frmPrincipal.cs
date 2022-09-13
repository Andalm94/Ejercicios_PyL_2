namespace Hola_Windows_Forms
{
    public partial class frmEjercicio : Form
    {
        public frmEjercicio()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludar_OnClick(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;

            string titulo = "Hola Windows Form!";
            string mensaje = $"Soy {nombre} {apellido}";

            frmSaludo frmSaludo = new frmSaludo(titulo, mensaje);
            frmSaludo.ShowDialog();
        }

        private void frmEjercicio_Load(object sender, EventArgs e)
        {

        }
    }
}