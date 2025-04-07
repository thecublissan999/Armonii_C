namespace LocationMap
{
    partial class Mapa
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.labelEdad = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.btnAtras = new WindowsFormsAppArmonii.btnRedondeado();
            this.btnLocales = new WindowsFormsAppArmonii.btnRedondeado();
            this.btnMusicos = new WindowsFormsAppArmonii.btnRedondeado();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(495, 43);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(796, 670);
            this.gMapControl1.TabIndex = 1;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.cbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(23, 112);
            this.cbUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(445, 33);
            this.cbUsuarios.TabIndex = 2;
            this.cbUsuarios.SelectedIndexChanged += new System.EventHandler(this.comboBoxMusics_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Musico";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(23, 176);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(101, 29);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.BackColor = System.Drawing.Color.Transparent;
            this.labelCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorreo.Location = new System.Drawing.Point(23, 230);
            this.labelCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(88, 29);
            this.labelCorreo.TabIndex = 5;
            this.labelCorreo.Text = "Correo";
            // 
            // labelEdad
            // 
            this.labelEdad.AutoSize = true;
            this.labelEdad.BackColor = System.Drawing.Color.Transparent;
            this.labelEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdad.Location = new System.Drawing.Point(23, 285);
            this.labelEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEdad.Name = "labelEdad";
            this.labelEdad.Size = new System.Drawing.Size(70, 29);
            this.labelEdad.TabIndex = 6;
            this.labelEdad.Text = "Edad";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.BackColor = System.Drawing.Color.Transparent;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.Location = new System.Drawing.Point(23, 339);
            this.labelTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(110, 29);
            this.labelTelefono.TabIndex = 7;
            this.labelTelefono.Text = "Telèfono";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.BackColor = System.Drawing.Color.Transparent;
            this.labelGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.Location = new System.Drawing.Point(23, 393);
            this.labelGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(94, 29);
            this.labelGenero.TabIndex = 8;
            this.labelGenero.Text = "Genero";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnAtras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnAtras.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAtras.BorderRadius = 20;
            this.btnAtras.BorderSize = 0;
            this.btnAtras.FlatAppearance.BorderSize = 0;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Location = new System.Drawing.Point(28, 26);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(105, 40);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.Text = "Atras";
            this.btnAtras.TextColor = System.Drawing.Color.White;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnLocales
            // 
            this.btnLocales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnLocales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnLocales.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnLocales.BorderRadius = 20;
            this.btnLocales.BorderSize = 0;
            this.btnLocales.FlatAppearance.BorderSize = 0;
            this.btnLocales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocales.ForeColor = System.Drawing.Color.White;
            this.btnLocales.Location = new System.Drawing.Point(381, 26);
            this.btnLocales.Name = "btnLocales";
            this.btnLocales.Size = new System.Drawing.Size(97, 40);
            this.btnLocales.TabIndex = 21;
            this.btnLocales.Text = "Locales";
            this.btnLocales.TextColor = System.Drawing.Color.White;
            this.btnLocales.UseVisualStyleBackColor = false;
            this.btnLocales.Click += new System.EventHandler(this.btnLocales_Click);
            // 
            // btnMusicos
            // 
            this.btnMusicos.BackColor = System.Drawing.Color.Silver;
            this.btnMusicos.BackgroundColor = System.Drawing.Color.Silver;
            this.btnMusicos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMusicos.BorderRadius = 20;
            this.btnMusicos.BorderSize = 0;
            this.btnMusicos.Enabled = false;
            this.btnMusicos.FlatAppearance.BorderSize = 0;
            this.btnMusicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusicos.ForeColor = System.Drawing.Color.Black;
            this.btnMusicos.Location = new System.Drawing.Point(278, 26);
            this.btnMusicos.Name = "btnMusicos";
            this.btnMusicos.Size = new System.Drawing.Size(97, 40);
            this.btnMusicos.TabIndex = 20;
            this.btnMusicos.Text = "Musicos";
            this.btnMusicos.TextColor = System.Drawing.Color.Black;
            this.btnMusicos.UseVisualStyleBackColor = false;
            this.btnMusicos.Click += new System.EventHandler(this.btnMusicos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1101, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "label2";
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1071, 604);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLocales);
            this.Controls.Add(this.btnMusicos);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.labelGenero);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelEdad);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUsuarios);
            this.Controls.Add(this.gMapControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Mapa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.Label labelEdad;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelGenero;
        private WindowsFormsAppArmonii.btnRedondeado btnAtras;
        private WindowsFormsAppArmonii.btnRedondeado btnLocales;
        private WindowsFormsAppArmonii.btnRedondeado btnMusicos;
        private System.Windows.Forms.Label label2;
    }
}

