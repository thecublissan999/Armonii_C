using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppArmonii.Models;
using static WindowsFormsAppArmonii.Models.AdminOrm;
using static WindowsFormsAppArmonii.Models.PermisosOrm;
using static WindowsFormsAppArmonii.Models.UsuarioAdminOrm;

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
            ConfigurarComboBox(cbPermisos);

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
                tbContra.Enabled = false;
                tbRepetirContra.Enabled = false;
            }
            else
            {
                btnContrasena.Visible = false; // Ocultar el botón de restablecer contraseña si no hay administrador seleccionado
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

        // Método para configurar el ComboBox con hint y valores, y seleccionar el permiso si existe
        private void ConfigurarComboBox(ComboBox comboBox)
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
            string permiso = admin?.permiso;

            // Establecer el permiso si existe
            if (!string.IsNullOrEmpty(permiso) && permisos.Any(p => p.nombre == permiso))
            {
                comboBox.SelectedItem = permiso;
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
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null; // Ningún control tendrá el foco inicial
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

                    UsuarioAdminOrm.ModificarAdmin(admin);
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
            bool correoValido = UsuarioAdminOrm.ComprobarCorreo(tbCorreo.Text);
            if (correoValido)
            {
                MessageBox.Show("El correo ya está en uso. Por favor, use otro correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            UsuarioAdminOrm.CrearAdmin(admin);

            MessageBox.Show("Administrador guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Cerrar el formulario actual
        }

        private void btnContrasena_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "¿Quieres restablecer la contraseña a \"123456789A\"?",
            "Confirmar restablecimiento",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
            if (resultado == DialogResult.Yes)
            {
                tbContra.Text = "123456789A";
                tbRepetirContra.Text = "123456789A";
                EnviarCorreo();
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }
        private void EnviarCorreo()
        {
            try
            {
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("soportearmonii@gmail.com");
                mensaje.To.Add(tbCorreo.Text);
                mensaje.Subject = "Cambio de su contraseña";
                mensaje.Body = "Buenas,\n\nLe enviamos este correo para informarle que la contraseña de su cuenta en Armonii ha sido restablecida a: \"123456789A\".\nLe pedimos que cambie la contraseña en su perfil.\n\nEste es un correo enviado de forma automática, no hace falta responder.";
                SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com", 587);
                clienteSmtp.Credentials = new NetworkCredential("soportearmonii@gmail.com", "hpnupcwxnfpuaxkh");
                clienteSmtp.EnableSsl = true;

                clienteSmtp.Send(mensaje);
                MessageBox.Show("Correo enviado con éxito!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar el correo: " + ex.Message);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario actual
        }
    }
}