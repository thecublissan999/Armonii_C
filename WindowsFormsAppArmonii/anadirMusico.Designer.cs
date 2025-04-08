namespace WindowsFormsAppArmonii
{
    partial class anadirMusico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCorreo = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbContra = new System.Windows.Forms.TextBox();
            this.tbRepiteContra = new System.Windows.Forms.TextBox();
            this.tbBiografia = new System.Windows.Forms.TextBox();
            this.tbEdad = new System.Windows.Forms.TextBox();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.lbGenerosMusicales = new System.Windows.Forms.ListBox();
            this.cbGenerosMusicales = new System.Windows.Forms.ComboBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new WindowsFormsAppArmonii.btnRedondeado();
            this.btnCancelar = new WindowsFormsAppArmonii.btnRedondeado();
            this.btnContrasena = new WindowsFormsAppArmonii.btnRedondeado();
            this.btnQuitarGenero = new System.Windows.Forms.Button();
            this.btnAnadirGenero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(78, 57);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(118, 22);
            this.tbNombre.TabIndex = 1;
            // 
            // tbCorreo
            // 
            this.tbCorreo.Location = new System.Drawing.Point(78, 116);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Size = new System.Drawing.Size(247, 22);
            this.tbCorreo.TabIndex = 4;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(598, 116);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(210, 22);
            this.tbTelefono.TabIndex = 6;
            // 
            // tbContra
            // 
            this.tbContra.Location = new System.Drawing.Point(78, 177);
            this.tbContra.Name = "tbContra";
            this.tbContra.Size = new System.Drawing.Size(222, 22);
            this.tbContra.TabIndex = 7;
            // 
            // tbRepiteContra
            // 
            this.tbRepiteContra.Location = new System.Drawing.Point(573, 183);
            this.tbRepiteContra.Name = "tbRepiteContra";
            this.tbRepiteContra.Size = new System.Drawing.Size(237, 22);
            this.tbRepiteContra.TabIndex = 8;
            // 
            // tbBiografia
            // 
            this.tbBiografia.Location = new System.Drawing.Point(78, 336);
            this.tbBiografia.Multiline = true;
            this.tbBiografia.Name = "tbBiografia";
            this.tbBiografia.Size = new System.Drawing.Size(732, 143);
            this.tbBiografia.TabIndex = 13;
            // 
            // tbEdad
            // 
            this.tbEdad.Location = new System.Drawing.Point(420, 116);
            this.tbEdad.Name = "tbEdad";
            this.tbEdad.Size = new System.Drawing.Size(61, 22);
            this.tbEdad.TabIndex = 5;
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(304, 57);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(195, 22);
            this.tbApellido.TabIndex = 2;
            // 
            // lbGenerosMusicales
            // 
            this.lbGenerosMusicales.FormattingEnabled = true;
            this.lbGenerosMusicales.ItemHeight = 16;
            this.lbGenerosMusicales.Location = new System.Drawing.Point(397, 226);
            this.lbGenerosMusicales.Name = "lbGenerosMusicales";
            this.lbGenerosMusicales.Size = new System.Drawing.Size(411, 100);
            this.lbGenerosMusicales.TabIndex = 12;
            // 
            // cbGenerosMusicales
            // 
            this.cbGenerosMusicales.FormattingEnabled = true;
            this.cbGenerosMusicales.Location = new System.Drawing.Point(78, 270);
            this.cbGenerosMusicales.Name = "cbGenerosMusicales";
            this.cbGenerosMusicales.Size = new System.Drawing.Size(220, 24);
            this.cbGenerosMusicales.TabIndex = 9;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Location = new System.Drawing.Point(612, 56);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(193, 24);
            this.cbGenero.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnGuardar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.BorderRadius = 20;
            this.btnGuardar.BorderSize = 0;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(523, 503);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(150, 46);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextColor = System.Drawing.Color.White;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardarMusico_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnCancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(679, 503);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 46);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextColor = System.Drawing.Color.White;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnContrasena
            // 
            this.btnContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnContrasena.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnContrasena.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnContrasena.BorderRadius = 20;
            this.btnContrasena.BorderSize = 0;
            this.btnContrasena.FlatAppearance.BorderSize = 0;
            this.btnContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrasena.ForeColor = System.Drawing.Color.White;
            this.btnContrasena.Location = new System.Drawing.Point(367, 503);
            this.btnContrasena.Name = "btnContrasena";
            this.btnContrasena.Size = new System.Drawing.Size(150, 46);
            this.btnContrasena.TabIndex = 14;
            this.btnContrasena.Text = "Restablecer la contraseña";
            this.btnContrasena.TextColor = System.Drawing.Color.White;
            this.btnContrasena.UseVisualStyleBackColor = false;
            this.btnContrasena.Click += new System.EventHandler(this.btnContrasena_Click);
            // 
            // btnQuitarGenero
            // 
            this.btnQuitarGenero.Image = global::WindowsFormsAppArmonii.Properties.Resources.icons8_flecha_30__1_;
            this.btnQuitarGenero.Location = new System.Drawing.Point(332, 283);
            this.btnQuitarGenero.Name = "btnQuitarGenero";
            this.btnQuitarGenero.Size = new System.Drawing.Size(46, 42);
            this.btnQuitarGenero.TabIndex = 11;
            this.btnQuitarGenero.UseVisualStyleBackColor = true;
            this.btnQuitarGenero.Click += new System.EventHandler(this.btnQuitarGenero_Click);
            // 
            // btnAnadirGenero
            // 
            this.btnAnadirGenero.Image = global::WindowsFormsAppArmonii.Properties.Resources.icons8_flecha_30__2_;
            this.btnAnadirGenero.Location = new System.Drawing.Point(332, 235);
            this.btnAnadirGenero.Name = "btnAnadirGenero";
            this.btnAnadirGenero.Size = new System.Drawing.Size(46, 42);
            this.btnAnadirGenero.TabIndex = 10;
            this.btnAnadirGenero.UseVisualStyleBackColor = true;
            this.btnAnadirGenero.Click += new System.EventHandler(this.btnAnadirGenero_Click);
            // 
            // anadirMusico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(880, 580);
            this.Controls.Add(this.btnContrasena);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.cbGenerosMusicales);
            this.Controls.Add(this.btnQuitarGenero);
            this.Controls.Add(this.btnAnadirGenero);
            this.Controls.Add(this.lbGenerosMusicales);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.tbEdad);
            this.Controls.Add(this.tbBiografia);
            this.Controls.Add(this.tbRepiteContra);
            this.Controls.Add(this.tbContra);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbCorreo);
            this.Controls.Add(this.tbNombre);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "anadirMusico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Musicos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCorreo;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.TextBox tbContra;
        private System.Windows.Forms.TextBox tbRepiteContra;
        private System.Windows.Forms.TextBox tbBiografia;
        private System.Windows.Forms.TextBox tbEdad;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.ListBox lbGenerosMusicales;
        private System.Windows.Forms.Button btnAnadirGenero;
        private System.Windows.Forms.Button btnQuitarGenero;
        private System.Windows.Forms.ComboBox cbGenerosMusicales;
        private System.Windows.Forms.ComboBox cbGenero;
        private btnRedondeado btnGuardar;
        private btnRedondeado btnCancelar;
        private btnRedondeado btnContrasena;
    }
}