namespace WindowsFormsAppArmonii
{
    partial class Menu
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
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.btnMusico = new System.Windows.Forms.Button();
            this.btnGraficos = new System.Windows.Forms.Button();
            this.btnMapa = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(150, 116);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(172, 191);
            this.btnLocal.TabIndex = 0;
            this.btnLocal.Text = "Local";
            this.btnLocal.UseVisualStyleBackColor = true;
            this.btnLocal.Click += new System.EventHandler(this.btnLocal_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Location = new System.Drawing.Point(375, 395);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(172, 191);
            this.btnCalendar.TabIndex = 5;
            this.btnCalendar.Text = "Calendario";
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // btnMusico
            // 
            this.btnMusico.Location = new System.Drawing.Point(375, 116);
            this.btnMusico.Name = "btnMusico";
            this.btnMusico.Size = new System.Drawing.Size(172, 191);
            this.btnMusico.TabIndex = 1;
            this.btnMusico.Text = "Musico";
            this.btnMusico.UseVisualStyleBackColor = true;
            this.btnMusico.Click += new System.EventHandler(this.btnMusico_Click);
            // 
            // btnGraficos
            // 
            this.btnGraficos.Location = new System.Drawing.Point(808, 395);
            this.btnGraficos.Name = "btnGraficos";
            this.btnGraficos.Size = new System.Drawing.Size(171, 191);
            this.btnGraficos.TabIndex = 6;
            this.btnGraficos.Text = "Graficos";
            this.btnGraficos.UseVisualStyleBackColor = true;
            // 
            // btnMapa
            // 
            this.btnMapa.Location = new System.Drawing.Point(808, 116);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.Size = new System.Drawing.Size(171, 191);
            this.btnMapa.TabIndex = 2;
            this.btnMapa.Text = "Mapa";
            this.btnMapa.UseVisualStyleBackColor = true;
            this.btnMapa.Click += new System.EventHandler(this.btnMapa_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Location = new System.Drawing.Point(1033, 395);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(171, 191);
            this.btnAyuda.TabIndex = 7;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(1033, 116);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(171, 191);
            this.btnControl.TabIndex = 3;
            this.btnControl.Text = "Control de Versiones";
            this.btnControl.UseVisualStyleBackColor = true;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(150, 395);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(172, 191);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Administradores";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(589, 643);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(147, 42);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 777);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btnMusico);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnMapa);
            this.Controls.Add(this.btnCalendar);
            this.Controls.Add(this.btnGraficos);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnAdmin);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnMusico;
        private System.Windows.Forms.Button btnGraficos;
        private System.Windows.Forms.Button btnMapa;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}