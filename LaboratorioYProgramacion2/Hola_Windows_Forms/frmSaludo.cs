using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola_Windows_Forms
{
    public partial class frmSaludo : Form
    {
        public frmSaludo(string titulo, string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
            lblTitulo.Text = titulo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmSaludo_Load(object sender, EventArgs e)
        {

        }
    }
}
