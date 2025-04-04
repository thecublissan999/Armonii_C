using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocationMap;
using WindowsFormsAppArmonii.Models;

namespace WindowsFormsAppArmonii
{
    public partial class Menu : Form
    {
        UsuarioAdmin usuarioSeleccionado = null;
        public Menu(UsuarioAdmin usuario)
        {
            InitializeComponent();
            usuarioSeleccionado = usuario;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login nuevoFormulario = new Login();
            this.Close();
            nuevoFormulario.ShowDialog();
        }

        private void btnLocal_Click(object sender, EventArgs e)
        {
            UsuariosLocal nuevoFormulario = new UsuariosLocal(usuarioSeleccionado);
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnMusico_Click(object sender, EventArgs e)
        {
            UsuariosMusicos nuevoFormulario = new UsuariosMusicos(usuarioSeleccionado);
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            Calendario nuevoFormulario = new Calendario(usuarioSeleccionado);
            nuevoFormulario.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado.permiso == 1)
            {
                Administradores nuevoFormulario = new Administradores(usuarioSeleccionado);
                nuevoFormulario.Show();
                this.Hide();
            }
            
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

        private void btnMapa_Click(object sender, EventArgs e)
        {
            MenuMap nuevoFormulario = new MenuMap();
            nuevoFormulario.Show();
            this.Hide();
        }
    }
}
