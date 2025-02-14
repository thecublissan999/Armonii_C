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
            this.tbUser = new System.Windows.Forms.TextBox();
            this.btnLogearse = new System.Windows.Forms.Button();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(280, 209);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(187, 22);
            this.tbUser.TabIndex = 0;
            this.tbUser.Text = "Usuario";
            // 
            // btnLogearse
            // 
            this.btnLogearse.Location = new System.Drawing.Point(332, 338);
            this.btnLogearse.Name = "btnLogearse";
            this.btnLogearse.Size = new System.Drawing.Size(75, 23);
            this.btnLogearse.TabIndex = 2;
            this.btnLogearse.Text = "Entrar";
            this.btnLogearse.UseVisualStyleBackColor = true;
            this.btnLogearse.Click += new System.EventHandler(this.btnLogearse_Click);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(280, 275);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(187, 22);
            this.tbContraseña.TabIndex = 0;
            this.tbContraseña.Text = "Contraseña";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogearse);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUser);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btnLogearse;
        private System.Windows.Forms.TextBox tbContraseña;
    }
}