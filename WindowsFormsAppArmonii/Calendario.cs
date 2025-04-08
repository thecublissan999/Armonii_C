using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppArmonii.Models;
using static WindowsFormsAppArmonii.Models.EventosOrm;

namespace WindowsFormsAppArmonii
{
    public partial class Calendario : Form
    {
        public static int _ano, _mes;
        UsuarioAdmin usuarioSeleccionado = null;
        public Calendario(UsuarioAdmin usuarioSeleccionado)
        {
            InitializeComponent();
            this.usuarioSeleccionado = usuarioSeleccionado;
            label9.Text = "Bienvenido/a, " +usuarioSeleccionado.nombre + "!";

            dgvCalendario.DataBindingComplete += dgvCalendario_DataBindingComplete;

        }

        private void CalendarioPrueba_Load(object sender, EventArgs e) 
        {
            mostrarDias(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void dgvCalendario_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvCalendario.ClearSelection();
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

        private void imgDerecha_Click(object sender, EventArgs e)
        {
            _mes++;
            if (_mes > 12)
            {
                _mes = 1;
                _ano++;
            }
            mostrarDias(_mes, _ano);
        }

        private void imgIzquierda_Click(object sender, EventArgs e)
        {
            _mes--;
            if (_mes < 1)
            {
                _mes = 12;
                _ano--;
            }
            mostrarDias(_mes, _ano);
        }

        private void mostrarDias(int mes, int ano)
        {
            flowLayoutPanel1.Controls.Clear();
            _ano = ano;
            _mes = mes;

            string mesNombre = new DateTime(ano, mes, 1).ToString("MMMM");
            lbMes.Text = mesNombre.ToUpper() + " " + ano;

            DateTime primerDia = new DateTime(ano, mes, 1);
            int diasMes = DateTime.DaysInMonth(ano, mes);

            // Corrección para asegurar que la semana empiece en lunes
            int semana = ((int)primerDia.DayOfWeek + 6) % 7;

            // Agregar espacios vacíos antes del primer día del mes
            for (int i = 0; i < semana; i++)
            {
                ucDias uc = new ucDias("");
                uc.BackColor = Color.Transparent;
                flowLayoutPanel1.Controls.Add(uc);
            }

            // Agregar los días del mes
            for (int i = 1; i <= diasMes; i++)
            {
                ucDias uc = new ucDias(i.ToString());
                uc.BackColor = Color.White;
                // Suscribirse al evento para actualizar la Label
                uc.DiaSeleccionado += ActualizarFechaSeleccionada;
                flowLayoutPanel1.Controls.Add(uc);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu nuevoFormulario = new Menu(usuarioSeleccionado);
            nuevoFormulario.Show();
            this.Close();
        }

        // Método que actualiza la Label
        private void ActualizarFechaSeleccionada(string fecha)
        {
            // Convertir la cadena de texto 'fecha' a un objeto DateTime
            DateTime fechaSeleccionada;
            lblDia.Text = fecha;

            if (DateTime.TryParse(fecha, out fechaSeleccionada))
            {
                // Obtener los eventos para la fecha seleccionada.
                List<EventoConMusico> ListaEventos = EventosOrm.SelectAll();
                ListaEventos[0].fecha.ToString("yyyy-MM-dd");

                var eventosFiltrados = ListaEventos.Where(e => e.fecha.ToString("yyyy-MM-dd") == fecha).ToList();

                // Actualizar el DataSource del BindingSource con la lista de eventos
                bsEventos.DataSource = eventosFiltrados;
            }
            else
            {
                // Si no se puede convertir la fecha, manejar el error (por ejemplo, mostrar un mensaje)
                MessageBox.Show("Formato de fecha no válido.");
            }
        }

    }
}
