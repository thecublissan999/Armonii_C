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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogearse_Click(object sender, EventArgs e)
        {
            Menu nuevoFormulario = new Menu(); // Crea una instancia del segundo formulario
            nuevoFormulario.Show();
            this.Close();
        }
    }
}
