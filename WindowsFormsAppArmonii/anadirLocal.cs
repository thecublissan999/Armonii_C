using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Net.Mail;
using System.Net;
using System.Windows.Forms;
using WindowsFormsAppArmonii.Models;

namespace WindowsFormsAppArmonii
{
    public partial class anadirLocal : Form
    {
        UsuarioOrm.UsuarioLocal local;
        private object ex;

        public anadirLocal( UsuarioOrm.UsuarioLocal usuarioLocalSeleccionado)
        {
            InitializeComponent();
            local = usuarioLocalSeleccionado;

            // Establecer los hints en los TextBox
            SetHintText(tbNombre, "Nombre del Usuario");
            SetHintText(tbDireccion, "Dirección");
            SetHintText(tbTelefono, "Teléfono");
            SetHintText(tbContra, "Contraseña");
            SetHintText(tbRepiteContra, "Repite la contraseña");
            SetHintText(tbCorreo, "Correo Electrónico");
            SetHintText(tbTipoLocal, "Tipo de Local");
            SetHintText(tbDescripcion, "Descripción del Local");

            // Comprobar si el objeto usuarioLocalSeleccionado no es nulo
            if (local != null)
            {
                // Llenar los TextBox con los valores del objeto
                FillTextBox(tbNombre, local.nombre, "Nombre del Usuario");
                FillTextBox(tbDireccion, local.direccion, "Dirección");
                FillTextBox(tbTelefono, local.telefono, "Teléfono");
                FillTextBox(tbContra, local.contrasenya, "Contraseña");
                FillTextBox(tbRepiteContra, local.contrasenya, "Repite la contraseña");
                FillTextBox(tbCorreo, local.correo, "Correo Electrónico");
                FillTextBox(tbTipoLocal, local.tipo_local, "Tipo de Local");
                FillTextBox(tbDescripcion, local.descripcion, "Descripción del Local");
            }
            else
            {
                btnContrasena.Visible = false; // Ocultar el botón si no hay local seleccionado
            }
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.ActiveControl = null; // Ningún control tendrá el foco inicial
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


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardarLocal_Click(object sender, EventArgs e)
        {
            if (local == null)
            {
                CrearLocal();

            }
            else
            {
                ModificarLocal();
            }
        }
        private void ModificarLocal()
        {
            try
            {
                if (tbContra.Text == tbRepiteContra.Text)
                {
                    local.nombre = tbNombre.Text;
                    local.direccion = tbDireccion.Text;
                    local.telefono = tbTelefono.Text;
                    local.correo = tbCorreo.Text;
                    local.contrasenya = tbContra.Text;
                    local.tipo_local = tbTipoLocal.Text;
                    local.descripcion = tbDescripcion.Text;

                    UsuarioOrm.ModificarUsuarioYLocal(local);
                    MessageBox.Show("Local modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden. Por favor, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar el local: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearLocal()
        {
            UsuarioOrm.UsuarioLocal usuarioLocalSeleccionado = new UsuarioOrm.UsuarioLocal();

            // Verificar que los campos que no pueden ser nulos no lo estén
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || tbNombre.Text == "Nombre del Usuario")
            {
                MessageBox.Show("Por favor, ingrese el nombre del local.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbCorreo.Text) || tbCorreo.Text == "Correo Electrónico")
            {
                MessageBox.Show("Por favor, ingrese el correo electrónico.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbContra.Text)) // Asegúrate de tener un TextBox para contrasena
            {
                MessageBox.Show("Por favor, ingrese la contraseña.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbRepiteContra.Text)) // Verificamos también que se haya llenado el campo de confirmación
            {
                MessageBox.Show("Por favor, repita la contraseña.");
                return;
            }

            // Verificar si las contraseñas coinciden
            if (tbContra.Text != tbRepiteContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, intente de nuevo.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbDireccion.Text) || tbDireccion.Text == "Dirección")
            {
                MessageBox.Show("Por favor, ingrese la dirección.");
                return;
            }
            bool validarCorreo = UsuarioOrm.ComprobarCorreo(tbCorreo.Text);
            if (validarCorreo)
            {
                MessageBox.Show("El correo electrónico ya está en uso. Por favor, use otro.");
                return;
            }

            // Asignamos los valores de los TextBox al objeto usuarioLocalSeleccionado
            usuarioLocalSeleccionado.nombre = tbNombre.Text;
            usuarioLocalSeleccionado.direccion = tbDireccion.Text;
            usuarioLocalSeleccionado.telefono = tbTelefono.Text;
            usuarioLocalSeleccionado.correo = tbCorreo.Text;
            usuarioLocalSeleccionado.contrasenya = tbContra.Text; // Asignar la contraseña
            usuarioLocalSeleccionado.tipo_local = tbTipoLocal.Text;
            usuarioLocalSeleccionado.descripcion = tbDescripcion.Text;
            usuarioLocalSeleccionado.estado = true; // Por defecto, el estado es 1

            // Ahora guardamos el objeto en la base de datos
            try
            {
                UsuarioOrm.CrearUsuarioYLocal(usuarioLocalSeleccionado);
                MessageBox.Show("Local guardado exitosamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al guardar: " + ex.Message);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Error interno: " + ex.InnerException.Message);
                }
                throw new Exception("Hubo un error al guardar el local: " + ex.Message);
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
                tbRepiteContra.Text = "123456789A";
                EnviarCorreo();
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }
    }
}