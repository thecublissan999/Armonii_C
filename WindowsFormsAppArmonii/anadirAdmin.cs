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
            ConfigurarComboBox(cbPermisos, admin?.permiso);

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
        private void ConfigurarComboBox(ComboBox comboBox, int? permiso)
        {
            // Limpiar elementos anteriores
            comboBox.Items.Clear();

            // Diccionario para mapear los permisos
            Dictionary<int, string> permisosDict = new Dictionary<int, string>
    {
        { 1, "SuperAdmin" },
        { 2, "Admin" },
        { 3, "Organizador" }
    };

            // Agregar los valores al ComboBox
            foreach (var permisoItem in permisosDict.Values)
            {
                comboBox.Items.Add(permisoItem);
            }

            // Establecer el permiso si existe
            if (permiso.HasValue && permisosDict.ContainsKey(permiso.Value))
            {
                comboBox.Text = permisosDict[permiso.Value];
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
            // Convertir la selección del ComboBox a número
            int permisoSeleccionado = ObtenerNumeroPermiso(cbPermisos.Text);

            if (admin == null)
            {
                CrearAdmin(permisoSeleccionado);
            }
            else
            {
                ModificarAdmin(permisoSeleccionado);
            }
        }

        // Método para obtener el número del permiso desde el ComboBox
        private int ObtenerNumeroPermiso(string permisoTexto)
        {
            Dictionary<string, int> permisosDict = new Dictionary<string, int>
    {
        { "SuperAdmin", 1 },
        { "Admin", 2 },
        { "Organizador", 3 }
    };

            // Intentar obtener el número del diccionario, si no está, devolver 0 como inválido
            return permisosDict.ContainsKey(permisoTexto) ? permisosDict[permisoTexto] : 0;
        }


        private void ModificarAdmin(int permisoSeleccionado)
        {
            // Validar que el permiso sea válido
            if (permisoSeleccionado < 1 || permisoSeleccionado > 3)
            {
                MessageBox.Show("Por favor, seleccione un permiso válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución del método
            }
            try
            {
                if (tbContra.Text == tbRepetirContra.Text)
                {
                    admin.nombre = tbNombre.Text;
                    admin.telefono = tbTelefono.Text;
                    admin.correo = tbCorreo.Text;
                    admin.contrasenya = tbContra.Text;
                    admin.permiso = permisoSeleccionado;

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

        private void CrearAdmin(int permisoSeleccionado)
        {
            // Verificar que los campos tbNombre, tbCorreo y tbContra no estén vacíos
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || string.IsNullOrWhiteSpace(tbCorreo.Text) || string.IsNullOrWhiteSpace(tbContra.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos: Nombre, Correo, Contraseña.");
                return; // Salir del método si algún campo está vacío
            }

            // Verificar si las contraseñas coinciden
            if (tbContra.Text != tbRepetirContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, intente de nuevo.");
                return; // Salir del método si las contraseñas no coinciden
            }

            // Validar que el permiso sea válido
            if (permisoSeleccionado < 1 || permisoSeleccionado > 3)
            {
                MessageBox.Show("Por favor, seleccione un permiso válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detener la ejecución del método
            }

            // Crear un objeto UsuarioMusico
            UsuarioAdminDTO admin = new UsuarioAdminDTO();

            // Asignar los valores de los TextBox a las propiedades del objeto UsuarioMusico
            admin.nombre = tbNombre.Text;
            admin.correo = tbCorreo.Text;
            admin.contrasenya = tbContra.Text; // Asignar la contraseña
            admin.telefono = tbTelefono.Text;
            admin.permiso = permisoSeleccionado;

            // Si es necesario mostrar o usar el objeto `usuarioMusico`, puedes hacerlo aquí
            // Ejemplo de mostrar el contenido del objeto en un MessageBox
            UsuarioOrm.CrearAdmin(admin);
            MessageBox.Show("Local guardado exitosamente.");
            this.Close(); // Cerrar el formulario actual        
        }
    }
}