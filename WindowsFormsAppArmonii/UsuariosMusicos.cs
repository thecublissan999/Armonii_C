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
using WindowsFormsAppArmonii.Models;
using static WindowsFormsAppArmonii.Models.UsuarioOrm;


namespace WindowsFormsAppArmonii
{
    public partial class UsuariosMusicos : Form
    {
        UsuarioMusico usuarioMusicoSeleccionado = null;
        UsuarioAdmin usuarioSeleccionado = null;

        public UsuariosMusicos(UsuarioAdmin usuarioSeleccionado)
        {
            InitializeComponent();
            bindingSource1.DataSource = ObtenerUsuarioMusico();
            this.usuarioSeleccionado = usuarioSeleccionado;
            label1.Text = "Bienvenido/a, " + usuarioSeleccionado.nombre + "!";
            dgvUsuarios.DataBindingComplete += dgvUsuarios_DataBindingComplete;

        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Menu nuevoFormulario = new Menu(usuarioSeleccionado);
            nuevoFormulario.Show();
            this.Close();
        }
        private void dgvUsuarios_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvUsuarios.ClearSelection();
        }
        private void btnAnadir_Click(object sender, EventArgs e)
        {
            usuarioMusicoSeleccionado = null;
            anadirMusico nuevoFormulario = new anadirMusico(usuarioMusicoSeleccionado);
            nuevoFormulario.Show();

            // Suscribirse al evento FormClosed usando una lambda
            nuevoFormulario.FormClosed += (s, args) =>
            {
                bindingSource1.DataSource = ObtenerUsuarioMusico();
            };
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];

                // Verificar si el objeto usuarioLocalSeleccionado está inicializado
                if (usuarioMusicoSeleccionado == null)
                {
                    usuarioMusicoSeleccionado = new UsuarioMusico(); // Inicializar el objeto si es null
                }

                try
                {
                    // Asignar los valores de las celdas de la fila seleccionada al objeto usuarioLocalSeleccionado
                    usuarioMusicoSeleccionado.id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                    usuarioMusicoSeleccionado.nombre = filaSeleccionada.Cells[1].Value?.ToString() ?? string.Empty;  // Evitar null
                    usuarioMusicoSeleccionado.apellido = filaSeleccionada.Cells[2].Value?.ToString() ?? string.Empty; // Evitar null
                    usuarioMusicoSeleccionado.correo = filaSeleccionada.Cells[3].Value?.ToString() ?? string.Empty;   // Evitar null
                    usuarioMusicoSeleccionado.contrasenya = filaSeleccionada.Cells[7].Value?.ToString() ?? string.Empty; // Evitar null
                    usuarioMusicoSeleccionado.telefono = filaSeleccionada.Cells[6].Value?.ToString() ?? string.Empty;   // Evitar null
                    usuarioMusicoSeleccionado.genero = filaSeleccionada.Cells[8].Value?.ToString() ?? string.Empty;   // Evitar null
                    usuarioMusicoSeleccionado.apodo = filaSeleccionada.Cells[4].Value?.ToString() ?? string.Empty; // Evitar null
                    usuarioMusicoSeleccionado.biografia = filaSeleccionada.Cells[10].Value?.ToString() ?? string.Empty; // Evitar null
                    usuarioMusicoSeleccionado.generoMusical = filaSeleccionada.Cells[9].Value?.ToString() ?? string.Empty; // Evitar null
                    usuarioMusicoSeleccionado.edad = Convert.ToInt32(filaSeleccionada.Cells[5].Value ?? 0);


                    // Para el campo double (valoracion)
                    usuarioMusicoSeleccionado.valoracion = filaSeleccionada.Cells[12].Value != DBNull.Value
                        ? Convert.ToDouble(filaSeleccionada.Cells[12].Value)
                        : 0.0;


                    // Crear e inicializar el formulario con el objeto usuarioLocalSeleccionado
                    anadirMusico nuevoFormulario = new anadirMusico(usuarioMusicoSeleccionado);
                    nuevoFormulario.Show();
                    nuevoFormulario.FormClosed += (s, args) =>
                    {
                        bindingSource1.DataSource = ObtenerUsuarioMusico();
                    };
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al editar los datos: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado alguna fila
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener el ID del usuario seleccionado (suponiendo que el ID está en la primera columna)
                int usuarioId = Convert.ToInt32(dgvUsuarios.SelectedRows[0].Cells[0].Value); // Aquí asumes que la primera columna contiene el ID

                // Confirmar la eliminación con un mensaje
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Aquí debes llamar a un método para eliminar el usuario de la base de datos
                        EliminarMusico(usuarioId);

                        // Eliminar la fila seleccionada del DataGridView
                        dgvUsuarios.Rows.RemoveAt(dgvUsuarios.SelectedRows[0].Index);

                        MessageBox.Show("Usuario eliminado correctamente.");
                        bindingSource1.DataSource = ObtenerUsuarioMusico(); // Actualizar el DataGridView
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hubo un error al eliminar el usuario: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un usuario para eliminar.");
            }
        }
    }
}
