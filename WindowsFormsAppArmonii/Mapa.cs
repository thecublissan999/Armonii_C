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
using WindowsFormsAppArmonii;
using System.Runtime.CompilerServices;


namespace LocationMap
{
    public partial class Mapa : Form
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        GMapOverlay polygonsOverlay;
        DataTable dt;

        int filaSeleccionada = 0;
        double LatInicial = 41.3851; // Coordenadas de Barcelona
        double LngInicial = 2.1734;
        UsuarioAdmin usu = null;
        bool isLocal = false;

        public Mapa(UsuarioAdmin usuario)
        {
            usu = usuario;
            InitializeComponent();
            CenterToScreen();
            gMapControl1_Load(this, EventArgs.Empty);
            LoadMusicians();
            label2.Text = "Bienvenido/a, " + usu.nombre + "!";
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
            cargarCB();
            
        }
        private void cargarCB()
        {
            cbUsuarios.Items.Clear();
            if (isLocal)
            {
                var locales = ObtenerUsuarioLocal();
                cbUsuarios.Items.Add(new UsuarioLocal { nombre = "Seleccionar local", latitud = 0, longitud = 0, correo = "", telefono = "", tipo_local = "" });
                cbUsuarios.Items.AddRange(locales.ToArray());
            }
            else
            {
                var musicians = ObtenerUsuarioMusico();
                cbUsuarios.Items.Add(new UsuarioMusico { nombre = "Seleccionar musico", latitud = 0, longitud = 0, correo = "", telefono = "", genero = "" });
                cbUsuarios.Items.AddRange(musicians.ToArray());
            }
            cbUsuarios.DisplayMember = "nombre";
            cbUsuarios.SelectedIndex = 0;
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
            if (isLocal)
            {
                if (cbUsuarios.SelectedIndex == 0)
                {
                    // Limpiar los labels si se selecciona "Seleccionar local"
                    labelNombre.Text = "Nombre:";
                    labelCorreo.Text = "Correo:";
                    labelTelefono.Text = "Teléfono:";
                    labelGenero.Text = "Tipo de local:";
                    return;
                }
                var selectedLocal = (UsuarioLocal)cbUsuarios.SelectedItem;

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
                labelTelefono.Text = "Teléfono: " + selectedLocal.telefono;
                labelGenero.Text = "Tipo de local: " + selectedLocal.tipo_local;
            }
            else
            {
                mapaMusico();
            }
        }
        private void mapaMusico()
        {
            if (cbUsuarios.SelectedIndex == 0)
            {
                // Limpiar los labels si se selecciona "Seleccionar músico"
                labelNombre.Text = "Nombre:";
                labelCorreo.Text = "Correo:";
                labelEdad.Text = "Edad:";
                labelTelefono.Text = "Teléfono:";
                labelGenero.Text = "Género:";
                return;
            }

            var selectedMusician = (UsuarioMusico)cbUsuarios.SelectedItem;
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


        private void btnAtras_Click(object sender, EventArgs e)
        {
            WindowsFormsAppArmonii.Menu nuevoFormulario = new WindowsFormsAppArmonii.Menu(usu);
            nuevoFormulario.Show();
            this.Close();
        }

        private void btnLocales_Click(object sender, EventArgs e)
        {
            btnLocales.BackColor = Color.Silver;
            btnMusicos.BackColor = Color.FromArgb(241, 88, 12);
            isLocal = true;
            label1.Text = "Local";
            btnMusicos.Enabled = true;
            btnLocales.Enabled = false;
            btnMusicos.ForeColor = Color.White;
            btnLocales.ForeColor = Color.Black;
            cargarCB();
        }

        private void btnMusicos_Click(object sender, EventArgs e)
        {
            btnLocales.BackColor = Color.FromArgb(241, 88, 12);
            btnMusicos.BackColor = Color.Silver;
            isLocal = false;
            label1.Text = "Musico";
            btnMusicos.Enabled = false;
            btnLocales.Enabled = true;
            btnLocales.ForeColor = Color.White;
            btnMusicos.ForeColor = Color.Black;
            cargarCB();
        }
    }

    
}
