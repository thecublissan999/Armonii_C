namespace LocationMap
{
    partial class MenuMap
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
            this.buttonMusicos = new System.Windows.Forms.Button();
            this.buttonLocales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMusicos
            // 
            this.buttonMusicos.Location = new System.Drawing.Point(246, 192);
            this.buttonMusicos.Name = "buttonMusicos";
            this.buttonMusicos.Size = new System.Drawing.Size(75, 23);
            this.buttonMusicos.TabIndex = 0;
            this.buttonMusicos.Text = "Musicos";
            this.buttonMusicos.UseVisualStyleBackColor = true;
            this.buttonMusicos.Click += new System.EventHandler(this.buttonMusicos_Click);
            // 
            // buttonLocales
            // 
            this.buttonLocales.Location = new System.Drawing.Point(415, 192);
            this.buttonLocales.Name = "buttonLocales";
            this.buttonLocales.Size = new System.Drawing.Size(75, 23);
            this.buttonLocales.TabIndex = 1;
            this.buttonLocales.Text = "Locales";
            this.buttonLocales.UseVisualStyleBackColor = true;
            this.buttonLocales.Click += new System.EventHandler(this.buttonLocales_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLocales);
            this.Controls.Add(this.buttonMusicos);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMusicos;
        private System.Windows.Forms.Button buttonLocales;
    }
}