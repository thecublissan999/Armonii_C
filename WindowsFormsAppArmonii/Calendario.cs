using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppArmonii.Models;

namespace WindowsFormsAppArmonii
{
    public partial class Calendario : Form
    {
        public Calendario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar eventos desde la base de datos
            //CargarEventosDesdeBD();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            bindingSourceEventos.DataSource = EventosOrm.ObtenerEventosConMusico(e.Start);
            dgvEventos.DataSource = bindingSourceEventos.DataSource;

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu nuevoFormulario = new Menu();
            nuevoFormulario.Show();
            this.Close();
        }
    }
}
