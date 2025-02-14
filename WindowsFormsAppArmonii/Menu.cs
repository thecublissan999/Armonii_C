using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppArmonii
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login nuevoFormulario = new Login();
            this.Close();
            nuevoFormulario.ShowDialog();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            Usuarios nuevoFormulario = new Usuarios();
            nuevoFormulario.Show();
            this.Hide();
        }
    }
}
