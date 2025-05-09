﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppArmonii
{
    public partial class Comenzar : Form
    {
        public Comenzar()
        {
            InitializeComponent();
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Comenzar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login nuevoFormulario = new Login();
                nuevoFormulario.Show();
                this.Hide();
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
    }
}
