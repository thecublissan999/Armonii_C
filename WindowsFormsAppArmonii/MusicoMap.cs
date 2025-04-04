using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using static WindowsFormsAppArmonii.Models.UsuarioOrm;
using WindowsFormsAppArmonii.Models;
using System.Drawing.Drawing2D;


namespace LocationMap
{
    public partial class MusicoMap : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        GMapOverlay polygonsOverlay;
        DataTable dt;

        int filaSeleccionada = 0;
        double LatInicial = 41.3851; // Coordenadas de Barcelona
        double LngInicial = 2.1734;

        public MusicoMap()
        {
            InitializeComponent();
            CenterToScreen();
            gMapControl1_Load(this, EventArgs.Empty);
            LoadMusicians();
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

        private void LoadMusicians()
        {
            var musicians = ObtenerUsuarioMusico();

            cbMusicos.Items.Clear();
            cbMusicos.Items.Add(new UsuarioMusico { nombre = "Seleccionar local", latitud = 0, longitud = 0, correo = "", telefono = "", genero = "" });
            cbMusicos.Items.AddRange(musicians.ToArray());
            //cbLocales.DataSource = locales;
            cbMusicos.DisplayMember = "nombre";
            cbMusicos.SelectedIndex = 0;
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
            polygonsOverlay = new GMapOverlay("polygons");
            gMapControl1.Overlays.Add(markerOverlay);
            gMapControl1.Overlays.Add(polygonsOverlay);
        }

        private void comboBoxMusics_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMusicos.SelectedIndex == 0)
            {
                // Limpiar los labels si se selecciona "Seleccionar músico"
                labelNombre.Text = "Nombre:";
                labelCorreo.Text = "Correo:";
                labelEdad.Text = "Edad:";
                labelTelefono.Text = "Teléfono:";
                labelGenero.Text = "Género:";
                return;
            }

            var selectedMusician = (UsuarioMusico)cbMusicos.SelectedItem;
            if (selectedMusician.latitud != null)
            {
                double lat = (double)selectedMusician.latitud;
                double lng = (double)selectedMusician.longitud;

                polygonsOverlay.Polygons.Clear();

                var circle = CreateCircle(lat, lng, 5000); // 5 km
                polygonsOverlay.Polygons.Add(circle);

                gMapControl1.Position = new PointLatLng(lat, lng);
            }
            else
            {
                MessageBox.Show("El músico no tiene coordenadas asignadas.");
            }

            // Rellenar los labels con los datos del músico seleccionado
            labelNombre.Text = "Nombre: " + selectedMusician.nombre;
            labelCorreo.Text = "Correo: " + selectedMusician.correo;
            labelEdad.Text = "Edad: " + selectedMusician.edad;
            labelTelefono.Text = "Teléfono: " + selectedMusician.telefono;
            labelGenero.Text = "Género: " + selectedMusician.genero;
        }

        private GMapPolygon CreateCircle(double lat, double lng, double radius)
        {
            List<PointLatLng> points = new List<PointLatLng>();
            int segments = 360;

            for (int i = 0; i < segments; i++)
            {
                double theta = (i * Math.PI * 2) / segments;
                double dx = radius * Math.Cos(theta);
                double dy = radius * Math.Sin(theta);
                points.Add(new PointLatLng(lat + (dx / 111320), lng + (dy / (111320 * Math.Cos(lat * Math.PI / 180)))));
            }

            GMapPolygon polygon = new GMapPolygon(points, "circle");
            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);

            return polygon;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    
}
