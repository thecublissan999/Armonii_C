using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using WindowsFormsAppArmonii.Models;

namespace WindowsFormsAppArmonii
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Evita parpadeo en la UI
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
                else if (xx.contrasenya != contra)
                {
                    MessageBox.Show("La contraseña está equivocada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Menu nuevoFormulario = new Menu();
                    nuevoFormulario.Show();
                    this.Close();
                }
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logearse();
            }
        }

        // 🎨 Dibujar el fondo con un gradiente radial
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);

            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);
                using (PathGradientBrush brush = new PathGradientBrush(path))
                {
                    brush.CenterColor = ColorTranslator.FromHtml("#303030"); // Color central
                    brush.SurroundColors = new Color[] { ColorTranslator.FromHtml("#0C0C0C") }; // Color de los bordes

                    e.Graphics.FillRectangle(brush, rect);
                }
            }
        }
    }
}
