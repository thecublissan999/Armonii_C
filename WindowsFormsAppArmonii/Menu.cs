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
            UsuariosLocal nuevoFormulario = new UsuariosLocal();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnMusico_Click(object sender, EventArgs e)
        {
            UsuariosMusicos nuevoFormulario = new UsuariosMusicos();
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            Calendario nuevoFormulario = new Calendario();
            nuevoFormulario.Show();
            this.Hide();
        }
    }
}
