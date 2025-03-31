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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogearse_Click(object sender, EventArgs e)
        {
            logearse();
        }

        private void logearse()
        {
            string correo = tbUser.Text;
            string contra = tbContraseña.Text;
            if (correo == "" || contra == "")
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UsuarioAdmin xx = UsuarioAdminOrm.SelectLogin(correo);
                if (xx == null)
                {
                    MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (xx.contrasenya != contra)
                    {
                        MessageBox.Show("La contraseña esta equivocada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Menu nuevoFormulario = new Menu();
                        nuevoFormulario.Show();
                        this.Close();
                    }
                }
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logearse() ;
            }
        }
    }
}
