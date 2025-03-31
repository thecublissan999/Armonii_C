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
using static WindowsFormsAppArmonii.Models.UsuarioOrm;

namespace WindowsFormsAppArmonii
{
    public partial class UsuariosLocal : Form
    {
        UsuarioLocal usuarioLocalSeleccionado = null;
        public UsuariosLocal()
        {
            InitializeComponent();
            bindingSourceUsers.DataSource = ObtenerUsuarioLocal();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            Menu nuevoFormulario = new Menu(); 
            nuevoFormulario.Show();
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            anadirLocal nuevoFormulario = new anadirLocal(usuarioLocalSeleccionado);
            nuevoFormulario.Show();

            // Suscribirse al evento FormClosed usando una lambda
            nuevoFormulario.FormClosed += (s, args) =>
            {
                bindingSourceUsers.DataSource = ObtenerUsuarioLocal();
            };
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvUsuarios.SelectedRows[0];

                // Verificar si el objeto usuarioLocalSeleccionado está inicializado
                if (usuarioLocalSeleccionado == null)
                {
                    usuarioLocalSeleccionado = new Models.UsuarioOrm.UsuarioLocal(); // Inicializar el objeto si es null
                }

                try
                {
                    // Asignar los valores de las celdas de la fila seleccionada al objeto usuarioLocalSeleccionado
                    usuarioLocalSeleccionado.id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                    usuarioLocalSeleccionado.nombre = filaSeleccionada.Cells[1].Value?.ToString() ?? string.Empty;  // Evitar null
                    usuarioLocalSeleccionado.direccion = filaSeleccionada.Cells[3].Value?.ToString() ?? string.Empty; // Evitar null
                    usuarioLocalSeleccionado.correo = filaSeleccionada.Cells[2].Value?.ToString() ?? string.Empty;   // Evitar null
                    usuarioLocalSeleccionado.contrasenya = filaSeleccionada.Cells[7].Value?.ToString() ?? string.Empty; // Evitar null
                    usuarioLocalSeleccionado.telefono = filaSeleccionada.Cells[6].Value?.ToString() ?? string.Empty;   // Evitar null
                    usuarioLocalSeleccionado.descripcion = filaSeleccionada.Cells[5].Value?.ToString() ?? string.Empty; // Evitar null

                    // Para los campos TimeSpan (horarioApertura y horarioCierre)
                    usuarioLocalSeleccionado.horarioApertura = TimeSpan.TryParse(filaSeleccionada.Cells[8].Value?.ToString(), out var apertura) ? apertura : TimeSpan.Zero;
                    usuarioLocalSeleccionado.horarioCierre = TimeSpan.TryParse(filaSeleccionada.Cells[9].Value?.ToString(), out var cierre) ? cierre : TimeSpan.Zero;

                    // Para el campo double (valoracion)
                    usuarioLocalSeleccionado.valoracion = filaSeleccionada.Cells[10].Value != DBNull.Value
                        ? Convert.ToDouble(filaSeleccionada.Cells[10].Value)
                        : 0.0;

                    // Para el tipo de local
                    usuarioLocalSeleccionado.tipo_local = filaSeleccionada.Cells[4].Value?.ToString() ?? string.Empty; // Evitar null

                    // Crear e inicializar el formulario con el objeto usuarioLocalSeleccionado
                    anadirLocal nuevoFormulario = new anadirLocal(usuarioLocalSeleccionado);
                    nuevoFormulario.Show();
                    nuevoFormulario.FormClosed += (s, args) =>
                    {
                        bindingSourceUsers.DataSource = ObtenerUsuarioLocal();
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

        private void buttonEliminar_Click(object sender, EventArgs e)
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
                        EliminarLocal(usuarioId);

                        // Eliminar la fila seleccionada del DataGridView
                        dgvUsuarios.Rows.RemoveAt(dgvUsuarios.SelectedRows[0].Index);

                        MessageBox.Show("Usuario eliminado correctamente.");
                        bindingSourceUsers.DataSource = ObtenerUsuarioLocal(); // Actualizar el DataGridView
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
