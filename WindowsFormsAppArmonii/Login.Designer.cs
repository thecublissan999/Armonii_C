namespace WindowsFormsAppArmonii
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbContrasena = new System.Windows.Forms.TextBox();
            this.btnRedondeado1 = new WindowsFormsAppArmonii.btnRedondeado();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSourceLogin = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(367, 284);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(227, 22);
            this.tbUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(310, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(282, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Contraseña:";
            // 
            // tbContrasena
            // 
            this.tbContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbContrasena.Location = new System.Drawing.Point(367, 350);
            this.tbContrasena.Name = "tbContrasena";
            this.tbContrasena.PasswordChar = '·';
            this.tbContrasena.Size = new System.Drawing.Size(227, 22);
            this.tbContrasena.TabIndex = 2;
            // 
            // btnRedondeado1
            // 
            this.btnRedondeado1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnRedondeado1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnRedondeado1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRedondeado1.BorderRadius = 20;
            this.btnRedondeado1.BorderSize = 0;
            this.btnRedondeado1.FlatAppearance.BorderSize = 0;
            this.btnRedondeado1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedondeado1.ForeColor = System.Drawing.Color.White;
            this.btnRedondeado1.Location = new System.Drawing.Point(376, 400);
            this.btnRedondeado1.Name = "btnRedondeado1";
            this.btnRedondeado1.Size = new System.Drawing.Size(194, 40);
            this.btnRedondeado1.TabIndex = 3;
            this.btnRedondeado1.Text = "Entrar";
            this.btnRedondeado1.TextColor = System.Drawing.Color.White;
            this.btnRedondeado1.UseVisualStyleBackColor = false;
            this.btnRedondeado1.Click += new System.EventHandler(this.btnRedondeado1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsAppArmonii.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(398, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // bindingSourceLogin
            // 
            this.bindingSourceLogin.DataSource = typeof(WindowsFormsAppArmonii.Models.Usuario);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(961, 566);
            this.Controls.Add(this.tbContrasena);
            this.Controls.Add(this.btnRedondeado1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.BindingSource bindingSourceLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private btnRedondeado btnRedondeado1;
        private System.Windows.Forms.TextBox tbContrasena;
    }
}