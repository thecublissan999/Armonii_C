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
using static WindowsFormsAppArmonii.Models.UsuarioOrm;

namespace WindowsFormsAppArmonii
{
    public partial class anadirMusico : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, string lParam);

        private const int EM_SETCUEBANNER = 0x1501;

        public anadirMusico()
        {
            InitializeComponent();

            // Agregar los hints a los TextBox (para TextBox no multilinea)
            SendMessage(tbNombre.Handle, EM_SETCUEBANNER, 0, "Nombre");
            SendMessage(tbApellido.Handle, EM_SETCUEBANNER, 0, "Apellido");
            SendMessage(tbEdad.Handle, EM_SETCUEBANNER, 0, "Edad");
            SendMessage(tbCorreo.Handle, EM_SETCUEBANNER, 0, "Correo");
            SendMessage(tbTelefono.Handle, EM_SETCUEBANNER, 0, "Teléfono");
            SendMessage(tbContra.Handle, EM_SETCUEBANNER, 0, "Contraseña");
            SendMessage(tbRepiteContra.Handle, EM_SETCUEBANNER, 0, "Repite Contraseña");
            SendMessage(tbGeneroMusical.Handle, EM_SETCUEBANNER, 0, "Género");

            // Agregar hint al TextBox Multilinea de Biografía
            SetBiografiaHint(tbBiografia);
        }

        // Método para agregar el hint al TextBox Multilinea
        private void SetBiografiaHint(TextBox tbBiografia)
        {
            tbBiografia.Text = "Biografía";
            tbBiografia.ForeColor = Color.Gray;
            tbBiografia.Enter += RemoveBiografiaHint;
            tbBiografia.Leave += SetBiografiaHint;
        }

        // Evento cuando el TextBox Biografía obtiene foco (se borra el hint)
        private void RemoveBiografiaHint(object sender, EventArgs e)
        {
            if (tbBiografia.Text == "Biografía")
            {
                tbBiografia.Text = "";
                tbBiografia.ForeColor = Color.Black;
            }
        }

        // Evento cuando el TextBox Biografía pierde foco (si está vacío, se restablece el hint)
        private void SetBiografiaHint(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbBiografia.Text))
            {
                tbBiografia.Text = "Biografía";
                tbBiografia.ForeColor = Color.Gray;
            }
        }

        private void btnAnadirGenero_Click(object sender, EventArgs e)
        {
            // Verifica si el campo tbGeneroMusical no está vacío
            if (!string.IsNullOrWhiteSpace(tbGeneroMusical.Text))
            {
                // Verificar si el género ya está en el ListBox
                if (!lbGenerosMusicales.Items.Contains(tbGeneroMusical.Text))
                {
                    // Agregar el texto de tbGeneroMusical al ListBox lbGeneroMusical
                    lbGenerosMusicales.Items.Add(tbGeneroMusical.Text);

                    // Opcional: Limpiar el TextBox tbGeneroMusical después de agregar el género
                    tbGeneroMusical.Clear();
                }
                else
                {
                    MessageBox.Show("Este género ya está en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un género musical.");
            }
        }


        private void btnQuitarGenero_Click(object sender, EventArgs e)
        {
            // Verificar si hay un ítem seleccionado en el ListBox
            if (lbGenerosMusicales.SelectedIndex != -1)
            {
                // Eliminar el ítem seleccionado
                lbGenerosMusicales.Items.RemoveAt(lbGenerosMusicales.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un género para eliminar.");
            }
        }

        private void btnGuardarMusico_Click(object sender, EventArgs e)
        {
            // Verificar que los campos tbNombre, tbCorreo y tbContra no estén vacíos
            if (string.IsNullOrWhiteSpace(tbNombre.Text) || string.IsNullOrWhiteSpace(tbCorreo.Text) || string.IsNullOrWhiteSpace(tbContra.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos requeridos: Nombre, Correo, Contraseña.");
                return; // Salir del método si algún campo está vacío
            }

            // Verificar si las contraseñas coinciden
            if (tbContra.Text != tbRepiteContra.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, intente de nuevo.");
                return; // Salir del método si las contraseñas no coinciden
            }

            // Validar si la edad es un número válido
            if (string.IsNullOrWhiteSpace(tbEdad.Text) || !int.TryParse(tbEdad.Text, out int edad))
            {
                MessageBox.Show("Por favor, ingrese una edad válida (números enteros).");
                return; // Salir del método si la edad no es válida
            }

            // Crear un objeto UsuarioMusico
            UsuarioMusico usuarioMusico = new UsuarioMusico();
            Usuario usuario = new Usuario();
            Musico musico = new Musico();
            usuario.nombre = tbNombre.Text;
            usuario.correo = tbCorreo.Text;
            usuario.contrasenya = tbContra.Text;
            usuario.telefono = tbTelefono.Text;
            usuario.fechaRegistro = DateTime.Now;
            usuario.estado = true;
            musico.edad = edad;
            musico.biografia = tbBiografia.Text;
            musico.genero = string.Join(", ", lbGenerosMusicales.Items.Cast<string>());

            // Asignar los valores de los TextBox a las propiedades del objeto UsuarioMusico
            usuarioMusico.nombre = tbNombre.Text;
            usuarioMusico.apellido = tbApellido.Text;
            usuarioMusico.correo = tbCorreo.Text;
            usuarioMusico.contrasenya = tbContra.Text; // Asignar la contraseña
            usuarioMusico.telefono = tbTelefono.Text;

            // Asignar la edad como valor entero
            usuarioMusico.edad = edad;

            // Asignar la biografía
            usuarioMusico.biografia = tbBiografia.Text;

            // Asignar la fecha de registro (fecha actual)
            usuarioMusico.fechaRegistro = DateTime.Now;

            // Asignar el estado (suponiendo que está habilitado por defecto)
            usuarioMusico.estado = true; // Puedes cambiar esto si es necesario

            // Asignar la valoración (puedes asignar un valor por defecto si es necesario)
            usuarioMusico.valoracion = 0.0; // Si no hay valor de valoración, lo dejamos en 0

            // Convertir la lista de géneros a un string (con un delimitador como coma)
            usuarioMusico.genero = string.Join(", ", lbGenerosMusicales.Items.Cast<string>());

            // Si es necesario mostrar o usar el objeto `usuarioMusico`, puedes hacerlo aquí
            // Ejemplo de mostrar el contenido del objeto en un MessageBox
            MessageBox.Show($"Usuario guardado: {musico.genero} - {usuarioMusico.genero}");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario actual
        }

        private void anadirMusico_Load(object sender, EventArgs e)
        {

        }
    }
}