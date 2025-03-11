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
    public partial class UsuariosLocal : Form
    {
        public UsuariosLocal()
        {
            InitializeComponent();
            bindingSourceUsers.DataSource = UsuarioOrm.ObtenerUsuarioLocal();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Menu nuevoFormulario = new Menu(); 
            nuevoFormulario.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSourceUsers_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
