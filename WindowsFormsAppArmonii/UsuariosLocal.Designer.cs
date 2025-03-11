namespace WindowsFormsAppArmonii
{
    partial class UsuariosLocal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.bindingSourceUsers = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.btnatras = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioAperturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioCierreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitudDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipolocalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvUsuarios);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(48, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1213, 474);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.direccionDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.contrasenyaDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.horarioAperturaDataGridViewTextBoxColumn,
            this.horarioCierreDataGridViewTextBoxColumn,
            this.longitudDataGridViewTextBoxColumn,
            this.latitudDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.valoracionDataGridViewTextBoxColumn,
            this.tipolocalDataGridViewTextBoxColumn});
            this.dgvUsuarios.DataSource = this.bindingSourceUsers;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(3, 18);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(1207, 453);
            this.dgvUsuarios.TabIndex = 1;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // bindingSourceUsers
            // 
            this.bindingSourceUsers.DataSource = typeof(WindowsFormsAppArmonii.Models.UsuarioOrm.UsuarioLocal);
            this.bindingSourceUsers.CurrentChanged += new System.EventHandler(this.bindingSourceUsers_CurrentChanged);
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
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(1029, 81);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(75, 23);
            this.btnAnadir.TabIndex = 1;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(1110, 81);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(1191, 81);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(51, 30);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(75, 23);
            this.btnatras.TabIndex = 4;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
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
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "direccion";
            this.direccionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionDataGridViewTextBoxColumn.Width = 91;
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
            // horarioAperturaDataGridViewTextBoxColumn
            // 
            this.horarioAperturaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horarioAperturaDataGridViewTextBoxColumn.DataPropertyName = "horarioApertura";
            this.horarioAperturaDataGridViewTextBoxColumn.HeaderText = "horarioApertura";
            this.horarioAperturaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horarioAperturaDataGridViewTextBoxColumn.Name = "horarioAperturaDataGridViewTextBoxColumn";
            this.horarioAperturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioAperturaDataGridViewTextBoxColumn.Width = 129;
            // 
            // horarioCierreDataGridViewTextBoxColumn
            // 
            this.horarioCierreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horarioCierreDataGridViewTextBoxColumn.DataPropertyName = "horarioCierre";
            this.horarioCierreDataGridViewTextBoxColumn.HeaderText = "horarioCierre";
            this.horarioCierreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.horarioCierreDataGridViewTextBoxColumn.Name = "horarioCierreDataGridViewTextBoxColumn";
            this.horarioCierreDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioCierreDataGridViewTextBoxColumn.Width = 114;
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
            // tipolocalDataGridViewTextBoxColumn
            // 
            this.tipolocalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipolocalDataGridViewTextBoxColumn.DataPropertyName = "tipo_local";
            this.tipolocalDataGridViewTextBoxColumn.HeaderText = "tipo_local";
            this.tipolocalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipolocalDataGridViewTextBoxColumn.Name = "tipolocalDataGridViewTextBoxColumn";
            this.tipolocalDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipolocalDataGridViewTextBoxColumn.Width = 94;
            // 
            // UsuariosLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 605);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.groupBox1);
            this.Name = "UsuariosLocal";
            this.Text = "Locales";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.BindingSource bindingSourceUsers;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnatras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioAperturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioCierreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitudDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipolocalDataGridViewTextBoxColumn;
    }
}