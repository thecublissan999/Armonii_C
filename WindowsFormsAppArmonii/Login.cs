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
            this.DoubleBuffered = true; // Reduce parpadeos en el redibujado
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            try
            {
                base.OnPaint(e);

                // Definir colores del gradiente
                Color colorInicio = ColorTranslator.FromHtml("#000000");
                Color colorFin = ColorTranslator.FromHtml("#2B2B2B");

                // Crear el rectángulo que cubre todo el formulario
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                // Crear un pincel de gradiente lineal
                using (LinearGradientBrush brush = new LinearGradientBrush(rect, colorInicio, colorFin, LinearGradientMode.Vertical))
                {
                    e.Graphics.FillRectangle(brush, rect);
                }          
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al dibujar el fondo: {ex.Message}");
            }
        }

        private void btnLogearse_Click(object sender, EventArgs e)
        {
            logearse();
        }

        private void logearse()
        {
            string correo = tbUser.Text;
            string contra = tbContraseña.Text;

            if (string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(contra))
            {
                MessageBox.Show("El campo no puede estar vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsuarioAdmin usuario = UsuarioAdminOrm.SelectLogin(correo);
            if (usuario == null)
            {
                MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (usuario.contrasenya != contra)
            {
                MessageBox.Show("La contraseña está equivocada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Menu nuevoFormulario = new Menu(usuario);
                nuevoFormulario.Show();
                this.Close();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logearse();
            }
        }
    }
}
