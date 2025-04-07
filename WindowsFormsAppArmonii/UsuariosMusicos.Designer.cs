namespace WindowsFormsAppArmonii
{
    partial class UsuariosMusicos
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoMusical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biografia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnadir = new WindowsFormsAppArmonii.btnRedondeado();
            this.BtnEditar = new WindowsFormsAppArmonii.btnRedondeado();
            this.btnEliminar = new WindowsFormsAppArmonii.btnRedondeado();
            this.btnAtras = new WindowsFormsAppArmonii.btnRedondeado();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsFormsAppArmonii.Models.UsuarioOrm.UsuarioMusico);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.groupBox1.Controls.Add(this.dgvUsuarios);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(75, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1213, 474);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.AutoGenerateColumns = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellido,
            this.correoDataGridViewTextBoxColumn,
            this.apodo,
            this.edad,
            this.telefonoDataGridViewTextBoxColumn,
            this.contrasenyaDataGridViewTextBoxColumn,
            this.genero,
            this.generoMusical,
            this.biografia,
            this.fechaRegistroDataGridViewTextBoxColumn,
            this.valoracionDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.bindingSource1;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 18);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(1207, 453);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 47;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 82;
            // 
            // apellido
            // 
            this.apellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apellido.DataPropertyName = "apellido";
            this.apellido.HeaderText = "apellido";
            this.apellido.MinimumWidth = 6;
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 85;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.ReadOnly = true;
            this.correoDataGridViewTextBoxColumn.Width = 75;
            // 
            // apodo
            // 
            this.apodo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.apodo.DataPropertyName = "apodo";
            this.apodo.HeaderText = "apodo";
            this.apodo.MinimumWidth = 6;
            this.apodo.Name = "apodo";
            this.apodo.ReadOnly = true;
            this.apodo.Width = 76;
            // 
            // edad
            // 
            this.edad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "edad";
            this.edad.MinimumWidth = 6;
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Width = 68;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "telefono";
            this.telefonoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonoDataGridViewTextBoxColumn.Width = 84;
            // 
            // contrasenyaDataGridViewTextBoxColumn
            // 
            this.contrasenyaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contrasenyaDataGridViewTextBoxColumn.DataPropertyName = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.HeaderText = "contrasenya";
            this.contrasenyaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.contrasenyaDataGridViewTextBoxColumn.Name = "contrasenyaDataGridViewTextBoxColumn";
            this.contrasenyaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contrasenyaDataGridViewTextBoxColumn.Width = 110;
            // 
            // genero
            // 
            this.genero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.genero.DataPropertyName = "genero";
            this.genero.HeaderText = "genero";
            this.genero.MinimumWidth = 6;
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.Width = 79;
            // 
            // generoMusical
            // 
            this.generoMusical.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.generoMusical.DataPropertyName = "generoMusical";
            this.generoMusical.HeaderText = "generoMusical";
            this.generoMusical.MinimumWidth = 6;
            this.generoMusical.Name = "generoMusical";
            this.generoMusical.ReadOnly = true;
            this.generoMusical.Width = 125;
            // 
            // biografia
            // 
            this.biografia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.biografia.DataPropertyName = "biografia";
            this.biografia.HeaderText = "biografia";
            this.biografia.MinimumWidth = 6;
            this.biografia.Name = "biografia";
            this.biografia.ReadOnly = true;
            this.biografia.Width = 89;
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            this.fechaRegistroDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "fechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.HeaderText = "fechaRegistro";
            this.fechaRegistroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            this.fechaRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaRegistroDataGridViewTextBoxColumn.Width = 120;
            // 
            // valoracionDataGridViewTextBoxColumn
            // 
            this.valoracionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valoracionDataGridViewTextBoxColumn.DataPropertyName = "valoracion";
            this.valoracionDataGridViewTextBoxColumn.HeaderText = "valoracion";
            this.valoracionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valoracionDataGridViewTextBoxColumn.Name = "valoracionDataGridViewTextBoxColumn";
            this.valoracionDataGridViewTextBoxColumn.ReadOnly = true;
            this.valoracionDataGridViewTextBoxColumn.Width = 99;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1207, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnAnadir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnAnadir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAnadir.BorderRadius = 20;
            this.btnAnadir.BorderSize = 0;
            this.btnAnadir.FlatAppearance.BorderSize = 0;
            this.btnAnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Location = new System.Drawing.Point(982, 51);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(80, 40);
            this.btnAnadir.TabIndex = 12;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.TextColor = System.Drawing.Color.White;
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.BtnEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnEditar.BorderRadius = 20;
            this.BtnEditar.BorderSize = 0;
            this.BtnEditar.FlatAppearance.BorderSize = 0;
            this.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditar.ForeColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(1068, 51);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(80, 40);
            this.BtnEditar.TabIndex = 11;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextColor = System.Drawing.Color.White;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Red;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.Red;
            this.btnEliminar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(1154, 51);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 40);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnAtras.Location = new System.Drawing.Point(78, 51);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(76, 40);
            this.btnAtras.TabIndex = 9;
            this.btnAtras.Text = "Atras";
            this.btnAtras.TextColor = System.Drawing.Color.White;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1050, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // UsuariosMusicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1319, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.groupBox1);
            this.Name = "UsuariosMusicos";
            this.Text = "UsuariosMusicos";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoMusical;
        private System.Windows.Forms.DataGridViewTextBoxColumn biografia;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracionDataGridViewTextBoxColumn;
        private btnRedondeado btnAnadir;
        private btnRedondeado BtnEditar;
        private btnRedondeado btnEliminar;
        private btnRedondeado btnAtras;
        private System.Windows.Forms.Label label1;
    }
}