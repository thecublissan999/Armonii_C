using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppArmonii
{
    public partial class ucDias : UserControl
    {
        string _dia, data, semana;
        private static ucDias diaSeleccionado = null; // Referencia al día seleccionado
        public event Action<string> DiaSeleccionado; // Evento para notificar cuando se selecciona un día
        private DateTime fecha;



        public ucDias(string dia)
        {
            InitializeComponent();
            _dia = dia;
            label1.Text = dia;
            checkBox1.Hide();

            // Crear la fecha para este día
            if (int.TryParse(dia, out int diaNumero))
            {
                fecha = new DateTime(CalendarioPrueba._ano, CalendarioPrueba._mes, diaNumero);
            }

            //if (!string.IsNullOrWhiteSpace(_dia))
            //{
            //    data = $"{CalendarioPrueba._ano}-{CalendarioPrueba._mes:D2}-{_dia.PadLeft(2, '0')}";
            //}
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (diaSeleccionado != null && diaSeleccionado != this)
            {
                diaSeleccionado.checkBox1.Checked = false;
                diaSeleccionado.BackColor = Color.White; // Restablece color del anterior
            }

            checkBox1.Checked = true;
            this.BackColor = Color.FromArgb(255, 150, 79); // Color de selección
            diaSeleccionado = this; // Almacenar el nuevo seleccionado


            if (!string.IsNullOrEmpty(_dia))
            {
                DateTime fechaSeleccionada = new DateTime(CalendarioPrueba._ano, CalendarioPrueba._mes, int.Parse(_dia));
                string fechaFormateada = fechaSeleccionada.ToString("yyyy-MM-dd"); // Formato deseado

                // Invocamos el evento pasando un DateTime (no un string)
                DiaSeleccionado?.Invoke(fechaFormateada);
            }
        }


        //private void domingo()
        //{
        //    try
        //    {
        //        DateTime dia = DateTime.Parse(data);
        //        semana = dia.ToString("ddd");
        //        if (semana == "Dom")
        //        {
        //            label1.ForeColor = Color.FromArgb(255, 128, 128);
        //        }
        //        else
        //        {
        //            label1.ForeColor = Color.FromArgb(64, 64, 64);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //    }
        //}

        private void ucDias_Load(object sender, EventArgs e)
        {
            //domingo();
        }
    }
}
