using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppArmonii.Models;

namespace WindowsFormsAppArmonii
{
    public partial class UsuariosMusicos : Form
    {
        public UsuariosMusicos()
        {
            InitializeComponent();
            bindingSource1.DataSource = UsuarioOrm.ObtenerUsuarioMusico();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Menu nuevoFormulario = new Menu();
            nuevoFormulario.Show();
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            anadirMusico nuevoFormulario = new anadirMusico();
            nuevoFormulario.Show();
        }
    }
}
