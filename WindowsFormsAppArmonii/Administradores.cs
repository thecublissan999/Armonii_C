using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsAppArmonii.Models.AdminOrm;
using static WindowsFormsAppArmonii.Models.UsuarioOrm;

namespace WindowsFormsAppArmonii
{
    public partial class Administradores : Form
    {
        UsuarioAdminDTO administradorSeleccionado = null;

        public Administradores()
        {
            InitializeComponent();
            bsAdmin.DataSource = ObtenerAdmins();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {

            Menu nuevoFormulario = new Menu();
            nuevoFormulario.Show();
            this.Close();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            administradorSeleccionado = null;
            anadirAdmin nuevoFormulario = new anadirAdmin(administradorSeleccionado);
            nuevoFormulario.Show();
            nuevoFormulario.FormClosed += (s, args) =>
            {
                bsAdmin.DataSource = ObtenerAdmins();
            };
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verificar si hay una fila seleccionada
            if (dgvAdmins.SelectedRows.Count > 0)
            {
                // Obtener la fila seleccionada
                DataGridViewRow filaSeleccionada = dgvAdmins.SelectedRows[0];

                // Verificar si el objeto usuarioLocalSeleccionado está inicializado
                if (administradorSeleccionado == null)
                {
                    administradorSeleccionado = new UsuarioAdminDTO(); // Inicializar el objeto si es null
                }

                try
                {
                    // Asignar los valores de las celdas de la fila seleccionada al objeto usuarioLocalSeleccionado
                    administradorSeleccionado.id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                    administradorSeleccionado.nombre = filaSeleccionada.Cells[1].Value?.ToString() ?? string.Empty;  // Evitar null
                    administradorSeleccionado.correo = filaSeleccionada.Cells[2].Value?.ToString() ?? string.Empty;   // Evitar null
                    administradorSeleccionado.contrasenya = filaSeleccionada.Cells[3].Value?.ToString() ?? string.Empty; // Evitar null
                    administradorSeleccionado.telefono = filaSeleccionada.Cells[4].Value?.ToString() ?? string.Empty;   // Evitar null
                    administradorSeleccionado.permiso = filaSeleccionada.Cells[5].Value?.ToString() ?? string.Empty;   // Evitar null



                    // Crear e inicializar el formulario con el objeto usuarioLocalSeleccionado
                    anadirAdmin nuevoFormulario = new anadirAdmin(administradorSeleccionado);
                    nuevoFormulario.Show();
                    nuevoFormulario.FormClosed += (s, args) =>
                    {
                        bsAdmin.DataSource = ObtenerAdmins();
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
            if (dgvAdmins.SelectedRows.Count > 0)
            {
                // Obtener el ID del usuario seleccionado (suponiendo que el ID está en la primera columna)
                int usuarioId = Convert.ToInt32(dgvAdmins.SelectedRows[0].Cells[0].Value); // Aquí asumes que la primera columna contiene el ID

                // Confirmar la eliminación con un mensaje
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres eliminar este usuario?", "Confirmar Eliminación", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Aquí debes llamar a un método para eliminar el usuario de la base de datos
                        EliminarAdmin(usuarioId);

                        // Eliminar la fila seleccionada del DataGridView
                        dgvAdmins.Rows.RemoveAt(dgvAdmins.SelectedRows[0].Index);

                        MessageBox.Show("Usuario eliminado correctamente.");
                        bsAdmin.DataSource = ObtenerAdmins(); // Actualizar el DataGridView
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
