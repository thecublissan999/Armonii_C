using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.MapProviders;
using GMap.NET;
using System.Data.Entity.Infrastructure;
using static WindowsFormsAppArmonii.Models.UsuarioOrm;
using System.Drawing.Drawing2D;

namespace LocationMap
{
    public partial class LocalesMapa: Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;

        int filaSeleccionada = 0;
        double LatInicial = 41.3851; // Coordenadas de Barcelona
        double LngInicial = 2.1734;

        public LocalesMapa()
        {
            InitializeComponent();
            CenterToScreen();
            gMapControl1_Load(this, EventArgs.Empty);
            LoadLocales();
        }

        

        private void LoadLocales()
        {
            var locales = ObtenerUsuarioLocal();
            cbLocales.Items.Clear();
            cbLocales.Items.Add(new UsuarioLocal { nombre = "Seleccionar local", latitud = 0, longitud = 0, correo = "", telefono = "", tipo_local = "" });
            cbLocales.Items.AddRange(locales.ToArray());
            cbLocales.DisplayMember = "nombre";
            cbLocales.SelectedIndex = 0;
        }
        private void comboBoxMusics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbLocales.SelectedIndex == 0)
            {
                // Limpiar los labels si se selecciona "Seleccionar local"
                labelNombre.Text = "Nombre:";
                labelCorreo.Text = "Correo:";
                labelTelèfono.Text = "Teléfono:";
                labelTipoDeLocal.Text = "Tipo de local:";
                return;
            }
            var selectedLocal = (UsuarioLocal)cbLocales.SelectedItem;

            if (selectedLocal.longitud != null)
            {
                double lat = (double)selectedLocal.latitud;
                double lng = (double)selectedLocal.longitud;

                markerOverlay.Markers.Clear();

                var marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.red_dot);
                markerOverlay.Markers.Add(marker);

                gMapControl1.Position = new PointLatLng(lat, lng);
            }
            else
            {
                MessageBox.Show("El músico no tiene coordenadas asignadas.");
            }



            // Rellenar los labels con los datos del local seleccionado
            labelNombre.Text = "Nombre: " + selectedLocal.nombre;
            labelCorreo.Text = "Correo: " + selectedLocal.correo;
            labelTelèfono.Text = "Teléfono: " + selectedLocal.telefono;
            labelTipoDeLocal.Text = "Tipo de local: " + selectedLocal.tipo_local;
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

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(LatInicial, LngInicial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 12;
            gMapControl1.AutoScroll = true;

            markerOverlay = new GMapOverlay("markers");
            gMapControl1.Overlays.Add(markerOverlay);
        }
    }
}
