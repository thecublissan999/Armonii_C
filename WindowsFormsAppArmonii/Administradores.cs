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
    public partial class Administradores : Form
    {
        public Administradores()
        {
            InitializeComponent();
            bsAdmin.DataSource = Models.AdminOrm.SelectAll();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {

            Menu nuevoFormulario = new Menu();
            nuevoFormulario.Show();
            this.Close();
        }

    }
}
