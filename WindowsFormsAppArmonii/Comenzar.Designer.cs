namespace WindowsFormsAppArmonii
{
    partial class Comenzar
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
            this.btnComenzar = new WindowsFormsAppArmonii.btnRedondeado();
            this.SuspendLayout();
            // 
            // btnComenzar
            // 
            this.btnComenzar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnComenzar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnComenzar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnComenzar.BorderRadius = 20;
            this.btnComenzar.BorderSize = 0;
            this.btnComenzar.FlatAppearance.BorderSize = 0;
            this.btnComenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComenzar.ForeColor = System.Drawing.Color.White;
            this.btnComenzar.Location = new System.Drawing.Point(307, 330);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(150, 40);
            this.btnComenzar.TabIndex = 0;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.TextColor = System.Drawing.Color.White;
            this.btnComenzar.UseVisualStyleBackColor = false;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // Comenzar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComenzar);
            this.KeyPreview = true;
            this.Name = "Comenzar";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Comenzar_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private btnRedondeado btnComenzar;
    }
}

