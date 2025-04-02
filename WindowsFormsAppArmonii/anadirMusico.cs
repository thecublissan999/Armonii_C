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
        UsuarioMusico musico;
        public anadirMusico(UsuarioMusico usuarioMusicoSeleccionado)
        {
            InitializeComponent();
            musico = usuarioMusicoSeleccionado;
            rellenarCBGenerosMusicales();
            rellenarCBGeneros();

            // Establecer los hints en los TextBox
            SetHintText(tbNombre, "Nombre");
            SetHintText(tbApellido, "Apellido");
            SetHintText(tbEdad, "Edad");
            SetHintText(tbCorreo, "Correo Electrónico");
            SetHintText(tbTelefono, "Teléfono");
            SetHintText(tbContra, "Contraseña");
            SetHintText(tbRepiteContra, "Repite la contraseña");
            SetHintText(tbBiografia, "Biografía");

            // Comprobar si el objeto usuarioMusicoSeleccionado no es nulo
            if (musico != null)
            {
                // Llenar los TextBox con los valores del objeto
                FillTextBox(tbNombre, musico.nombre, "Nombre");
                FillTextBox(tbApellido, musico.apellido, "Apellido");
                FillTextBox(tbEdad, musico.edad.ToString(), "Edad");
                FillTextBox(tbCorreo, musico.correo, "Correo Electrónico");
                FillTextBox(tbTelefono, musico.telefono, "Teléfono");
                FillTextBox(tbContra, musico.contrasenya, "Contraseña");
                FillTextBox(tbRepiteContra, musico.contrasenya, "Repite la contraseña");

                // Asignar directamente el string de generoMusical al TextBox
                // Limpiar la ListBox antes de llenarla
                lbGenerosMusicales.Items.Clear();

                // Verificar si la propiedad generoMusical no está vacía
                if (!string.IsNullOrEmpty(musico.generoMusical))
                {
                    // Dividir la cadena de géneros musicales por comas
                    string[] generosMusicales = musico.generoMusical.Split(',');

                    // Agregar los géneros a la ListBox
                    foreach (var genero in generosMusicales)
                    {
                        lbGenerosMusicales.Items.Add(genero.Trim()); // 'Trim()' para eliminar posibles espacios en blanco
                    }
                }
                FillTextBox(tbBiografia, musico.biografia, "Biografía");

                string[] generos = cbGenero.Items.Cast<string>().ToArray();
                int pos = 0;
                foreach (var genero in generos)
                {
                     if (genero == musico.genero)
                    {
                        pos = Array.IndexOf(generos, musico.genero);
                    }
                }
                cbGenero.SelectedIndex = pos;
                
            }

        }

        private void rellenarCBGeneros()
        {
            // Limpiar el ListBox antes de llenarlo (por si ya tiene elementos)
            lbGenerosMusicales.Items.Clear();

            cbGenero.Items.Add("Hombre");
            cbGenero.Items.Add("Mujer");
            cbGenero.Items.Add("Otros");
            cbGenero.SelectedIndex = 0;
        }

        private void rellenarCBGenerosMusicales()
        {
            // Llamar a la función ObtenerGeneros para obtener la lista de géneros musicales
            List<string> generos = GenerosMuscicalesOrm.ObtenerGeneros();

            // Limpiar el ListBox antes de llenarlo (por si ya tiene elementos)
            lbGenerosMusicales.Items.Clear();

            cbGenerosMusicales.Items.Add("Selecciona un género");


            // Rellenar el ListBox con los géneros musicales
            foreach (var genero in generos)
            {
                cbGenerosMusicales.Items.Add(genero);
            }
            cbGenerosMusicales.SelectedIndex = 0;
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


        private void btnAnadirGenero_Click(object sender, EventArgs e)
        {
            // Verifica si hay algún género seleccionado en el ComboBox
            if (!string.IsNullOrWhiteSpace(cbGenerosMusicales.Text) && cbGenerosMusicales.Text != "Selecciona un género")
            {
                // Verificar si el género ya está en el ListBox
                if (!lbGenerosMusicales.Items.Contains(cbGenerosMusicales.Text))
                {
                    // Agregar el género del ComboBox al ListBox
                    lbGenerosMusicales.Items.Add(cbGenerosMusicales.Text);

                    // Opcional: Limpiar el ComboBox después de agregar el género
                    cbGenerosMusicales.SelectedIndex = 0;  // Vuelve a poner el primer ítem por defecto (hint)
                }
                else
                {
                    MessageBox.Show("Este género ya está en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un género musical.");
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
            if (musico == null)
            {
                CrearMusico();

            }
            else
            {
                ModificarMusico();
            }
        }

        private void ModificarMusico()
        {
            try
            {
                // Verifica si las contraseñas coinciden
                if (tbContra.Text == tbRepiteContra.Text)
                {
                    // Asignar valores de los TextBox al objeto musico
                    musico.nombre = tbNombre.Text;
                    musico.apellido = tbApellido.Text;
                    musico.telefono = tbTelefono.Text;
                    musico.correo = tbCorreo.Text;
                    musico.contrasenya = tbContra.Text;
                    musico.biografia = tbBiografia.Text;
                    musico.genero = cbGenero.Text;

                    // Convertir la edad de texto a entero (si es válido)
                    musico.edad = int.TryParse(tbEdad.Text, out int edad) ? edad : 0;

                    // Obtener todos los géneros musicales seleccionados en el ListBox o ComboBox
                    // Si es un ListBox
                    string generosSeleccionados = string.Join(",", lbGenerosMusicales.Items.Cast<string>().ToArray());

                    // Si es un ComboBox, puedes hacer algo similar (si se seleccionan múltiples géneros)
                    // string generosSeleccionados = string.Join(",", cbGenerosMusicales.SelectedItems.Cast<string>().ToArray());

                    // Asignar los géneros musicales concatenados a la propiedad generoMusical
                    musico.generoMusical = generosSeleccionados;

                    // Modificar usuario y músico en la base de datos
                    UsuarioOrm.ModificarUsuarioYMusico(musico);

                    // Mostrar mensaje de éxito
                    MessageBox.Show("Músico modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    // Si las contraseñas no coinciden
                    MessageBox.Show("Las contraseñas no coinciden. Por favor, intente de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                MessageBox.Show("Error al modificar el músico: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CrearMusico()
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

            // Asignar los valores de los TextBox a las propiedades del objeto UsuarioMusico
            usuarioMusico.nombre = tbNombre.Text;
            usuarioMusico.apellido = tbApellido.Text;
            usuarioMusico.correo = tbCorreo.Text;
            usuarioMusico.contrasenya = tbContra.Text; // Asignar la contraseña
            usuarioMusico.telefono = tbTelefono.Text;
            usuarioMusico.genero = cbGenero.Text;


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
            string generosSeleccionados = string.Join(",", lbGenerosMusicales.Items.Cast<string>().ToArray());
            usuarioMusico.generoMusical = generosSeleccionados;

            // Si es necesario mostrar o usar el objeto `usuarioMusico`, puedes hacerlo aquí
            // Ejemplo de mostrar el contenido del objeto en un MessageBox
            CrearUsuarioYMusico(usuarioMusico);
            MessageBox.Show("Musico guardado exitosamente.");
            this.Close(); // Cerrar el formulario actual
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