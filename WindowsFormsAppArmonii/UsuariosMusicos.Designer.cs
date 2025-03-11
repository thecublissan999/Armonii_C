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
            this.btnatras = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArtisticoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biografiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(78, 29);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(75, 23);
            this.btnatras.TabIndex = 9;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(1218, 80);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 8;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1137, 80);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(1056, 80);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 6;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // groupBox1
            // 
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
            this.nombreArtisticoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.contrasenyaDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.biografiaDataGridViewTextBoxColumn,
            this.longitudDataGridViewTextBoxColumn,
            this.latitudDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.valoracionDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.bindingSource1;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 18);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
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
            // nombreArtisticoDataGridViewTextBoxColumn
            // 
            this.nombreArtisticoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreArtisticoDataGridViewTextBoxColumn.DataPropertyName = "nombreArtistico";
            this.nombreArtisticoDataGridViewTextBoxColumn.HeaderText = "nombreArtistico";
            this.nombreArtisticoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nombreArtisticoDataGridViewTextBoxColumn.Name = "nombreArtisticoDataGridViewTextBoxColumn";
            this.nombreArtisticoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreArtisticoDataGridViewTextBoxColumn.Width = 129;
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
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "edad";
            this.edadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            this.edadDataGridViewTextBoxColumn.ReadOnly = true;
            this.edadDataGridViewTextBoxColumn.Width = 68;
            // 
            // biografiaDataGridViewTextBoxColumn
            // 
            this.biografiaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.biografiaDataGridViewTextBoxColumn.DataPropertyName = "biografia";
            this.biografiaDataGridViewTextBoxColumn.HeaderText = "biografia";
            this.biografiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.biografiaDataGridViewTextBoxColumn.Name = "biografiaDataGridViewTextBoxColumn";
            this.biografiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.biografiaDataGridViewTextBoxColumn.Width = 89;
            // 
            // longitudDataGridViewTextBoxColumn
            // 
            this.longitudDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.longitudDataGridViewTextBoxColumn.DataPropertyName = "longitud";
            this.longitudDataGridViewTextBoxColumn.HeaderText = "longitud";
            this.longitudDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.longitudDataGridViewTextBoxColumn.Name = "longitudDataGridViewTextBoxColumn";
            this.longitudDataGridViewTextBoxColumn.ReadOnly = true;
            this.longitudDataGridViewTextBoxColumn.Width = 83;
            // 
            // latitudDataGridViewTextBoxColumn
            // 
            this.latitudDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.latitudDataGridViewTextBoxColumn.DataPropertyName = "latitud";
            this.latitudDataGridViewTextBoxColumn.HeaderText = "latitud";
            this.latitudDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.latitudDataGridViewTextBoxColumn.Name = "latitudDataGridViewTextBoxColumn";
            this.latitudDataGridViewTextBoxColumn.ReadOnly = true;
            this.latitudDataGridViewTextBoxColumn.Width = 71;
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
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 78;
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
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "genero";
            this.generoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            this.generoDataGridViewTextBoxColumn.ReadOnly = true;
            this.generoDataGridViewTextBoxColumn.Width = 79;
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
            // UsuariosMusicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 600);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.groupBox1);
            this.Name = "UsuariosMusicos";
            this.Text = "UsuariosMusicos";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArtisticoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biografiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}