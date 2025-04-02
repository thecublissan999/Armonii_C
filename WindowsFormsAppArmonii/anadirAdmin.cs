using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppArmonii.Models;
using static WindowsFormsAppArmonii.Models.AdminOrm;
using static WindowsFormsAppArmonii.Models.PermisosOrm;
using static WindowsFormsAppArmonii.Models.UsuarioOrm;

namespace WindowsFormsAppArmonii
{
    public partial class anadirAdmin : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;
        UsuarioAdminDTO admin;
        public anadirAdmin(UsuarioAdminDTO administradorSeleccionado)
        {
            InitializeComponent();
            admin = administradorSeleccionado;

            // Configurar el ComboBox con el permiso del administrador
            ConfigurarComboBox(cbPermisos, admin.permiso);

            // Establecer los hints en los TextBox
            SetHintText(tbNombre, "Nombre");
            SetHintText(tbCorreo, "Correo Electrónico");
            SetHintText(tbTelefono, "Teléfono");
            SetHintText(tbContra, "Contraseña");
            SetHintText(tbRepetirContra, "Repite la contraseña");

            // Comprobar si el objeto administradorSeleccionado no es nulo
            if (admin != null)
            {
                // Llenar los TextBox con los valores del objeto
                FillTextBox(tbNombre, admin.nombre, "Nombre");
                FillTextBox(tbCorreo, admin.correo, "Correo Electrónico");
                FillTextBox(tbTelefono, admin.telefono, "Teléfono");
                FillTextBox(tbContra, admin.contrasenya, "Contraseña");
                FillTextBox(tbRepetirContra, admin.contrasenya, "Repite la contraseña");
            }
        }

        // Método para configurar el ComboBox con hint y valores, y seleccionar el permiso si existe
        private void ConfigurarComboBox(ComboBox comboBox, string permisoNombre)
        {
            // Limpiar elementos anteriores
            comboBox.Items.Clear();

            // Obtener la lista de permisos desde la base de datos
            List<PermisoDTO> permisos = ObtenerPermisos();

            // Agregar los valores al ComboBox
            foreach (var permisoItem in permisos)
            {
                comboBox.Items.Add(permisoItem.nombre); // Solo agregamos el nombre
            }

            // Establecer el permiso si existe
            if (!string.IsNullOrEmpty(permisoNombre) && permisos.Any(p => p.nombre == permisoNombre))
            {
                comboBox.SelectedItem = permisoNombre;
                comboBox.ForeColor = Color.Black; // Texto en color normal
            }
            else
            {
                // Si no hay permiso, establecer el hint
                comboBox.Text = "Seleccione un permiso";
                comboBox.ForeColor = Color.Gray;
            }

            // Manejar el evento DropDown para borrar el hint cuando se despliega
            comboBox.DropDown += (sender, e) => {
                if (comboBox.Text == "Seleccione un permiso")
                {
                    comboBox.Text = "";
                    comboBox.ForeColor = Color.Black;
                }
            };

            // Manejar el evento LostFocus para restaurar el hint si no hay selección
            comboBox.LostFocus += (sender, e) => {
                if (string.IsNullOrWhiteSpace(comboBox.Text))
                {
                    comboBox.Text = "Seleccione un permiso";
                    comboBox.ForeColor = Color.Gray;
                }
            };
        }


        // Método para llenar los TextBox de forma segura
        private void FillTextBox(TextBox textBox, string value, string hintText)
        {
            if (!string.IsNullOrEmpty(value)) // Si el valor no es null o vacío
            {
                textBox.Text = value;
                textBox.ForeColor = Color.Black; // Asegurarse de que el color sea negro
            }
            else
            {
                // Si el valor está vacío, establecer el hint
                SetHintText(textBox, hintText);
            }
        }

        // Método para configurar los hints
        private void SetHintText(TextBox textBox, string hintText)
        {
            textBox.Text = hintText;
            textBox.ForeColor = Color.Gray; // Color gris para el hint
            textBox.GotFocus += (sender, e) => RemoveHintText(textBox, hintText);
            textBox.LostFocus += (sender, e) => AddHintText(textBox, hintText);
        }

        // Método para quitar el hint cuando el textbox recibe el foco
        private void RemoveHintText(TextBox textBox, string hintText)
        {
            if (textBox.Text == hintText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black; // Texto de usuario
            }
        }

        // Método para agregar el hint cuando el textbox pierde el foco y está vacío
        private void AddHintText(TextBox textBox, string hintText)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = hintText;
                textBox.ForeColor = Color.Gray; // Color gris para el hint
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (admin == null)
            {
                CrearAdmin();
            }
            else
            {
                ModificarAdmin();
            }
        }




        private void ModificarAdmin()
        {
            try
            {

                if (tbContra.Text == tbRepetirContra.Text)
                {
                    admin.nombre = tbNombre.Text;
                    admin.telefono = tbTelefono.Text;
                    admin.correo = tbCorreo.Text;
                    admin.contrasenya = tbContra.Text;
                    admin.permiso = cbPermisos.Text;

                    UsuarioOrm.ModificarAdmin(admin);
                    MessageBox.Show("Músico modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden. Por favor, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el músico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearAdmin()
        {
            // Verificar que los campos tbNombre, tbCorreo y tbContra no estén vacíos
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || string.IsNullOrWhiteSpace(tbCorreo.Text) || string.IsNullOrWhiteSpace(tbContra.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos: Nombre, Correo, Contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si algún campo está vacío
            }

            // Verificar si las contraseñas coinciden
            if (tbContra.Text != tbRepetirContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si las contraseñas no coinciden
            }

            // Validar si se ha seleccionado un permiso válido
            if (cbPermisos.SelectedItem == null || cbPermisos.Text == "Seleccione un permiso")
            {
                MessageBox.Show("Por favor, seleccione un permiso válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener el nombre del permiso seleccionado
            string permisoSeleccionadoNombre = cbPermisos.SelectedItem.ToString();

            // Obtener la lista de permisos desde la base de datos
            List<PermisoDTO> permisos = ObtenerPermisos();

            // Buscar el ID del permiso seleccionado
            int permisoId = ObtenerIdPermiso(permisoSeleccionadoNombre);

            // Verificar si se encontró un permiso válido
            if (permisoId == 0)
            {
                MessageBox.Show("Error al obtener el ID del permiso seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear un objeto UsuarioAdminDTO
            UsuarioAdmin admin = new UsuarioAdmin
            {
                nombre = tbNombre.Text,
                correo = tbCorreo.Text,
                contrasenya = tbContra.Text, // Asignar la contraseña
                telefono = tbTelefono.Text,
                permiso = permisoId // Asignar el ID del permiso obtenido
            };

            // Llamar al método para crear el administrador en la base de datos
            UsuarioOrm.CrearAdmin(admin);

            MessageBox.Show("Administrador guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cerrar el formulario actual
        }

    }
}