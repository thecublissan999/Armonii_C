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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_local = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioApertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioCierre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceUsers = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAtras = new WindowsFormsAppArmonii.btnRedondeado();
            this.btnEliminar = new WindowsFormsAppArmonii.btnRedondeado();
            this.BtnEditar = new WindowsFormsAppArmonii.btnRedondeado();
            this.btnAnadir = new WindowsFormsAppArmonii.btnRedondeado();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.groupBox1.Controls.Add(this.dgvUsuarios);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(48, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1213, 474);
            this.groupBox1.TabIndex = 0;
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
            this.nombre,
            this.correo,
            this.direccion,
            this.tipo_local,
            this.descripcion,
            this.telefono,
            this.contrasenya,
            this.horarioApertura,
            this.horarioCierre,
            this.valoracion});
            this.dgvUsuarios.DataSource = this.bindingSourceUsers;
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
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 82;
            // 
            // correo
            // 
            this.correo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.correo.DataPropertyName = "correo";
            this.correo.HeaderText = "correo";
            this.correo.MinimumWidth = 6;
            this.correo.Name = "correo";
            this.correo.ReadOnly = true;
            this.correo.Width = 75;
            // 
            // direccion
            // 
            this.direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 91;
            // 
            // tipo_local
            // 
            this.tipo_local.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tipo_local.DataPropertyName = "tipo_local";
            this.tipo_local.HeaderText = "tipo_local";
            this.tipo_local.MinimumWidth = 6;
            this.tipo_local.Name = "tipo_local";
            this.tipo_local.ReadOnly = true;
            this.tipo_local.Width = 94;
            // 
            // descripcion
            // 
            this.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 106;
            // 
            // telefono
            // 
            this.telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "telefono";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 84;
            // 
            // contrasenya
            // 
            this.contrasenya.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contrasenya.DataPropertyName = "contrasenya";
            this.contrasenya.HeaderText = "contrasenya";
            this.contrasenya.MinimumWidth = 6;
            this.contrasenya.Name = "contrasenya";
            this.contrasenya.ReadOnly = true;
            this.contrasenya.Width = 110;
            // 
            // horarioApertura
            // 
            this.horarioApertura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horarioApertura.DataPropertyName = "horarioApertura";
            this.horarioApertura.HeaderText = "horarioApertura";
            this.horarioApertura.MinimumWidth = 6;
            this.horarioApertura.Name = "horarioApertura";
            this.horarioApertura.ReadOnly = true;
            this.horarioApertura.Width = 129;
            // 
            // horarioCierre
            // 
            this.horarioCierre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.horarioCierre.DataPropertyName = "horarioCierre";
            this.horarioCierre.HeaderText = "horarioCierre";
            this.horarioCierre.MinimumWidth = 6;
            this.horarioCierre.Name = "horarioCierre";
            this.horarioCierre.ReadOnly = true;
            this.horarioCierre.Width = 114;
            // 
            // valoracion
            // 
            this.valoracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valoracion.DataPropertyName = "valoracion";
            this.valoracion.HeaderText = "valoracion";
            this.valoracion.MinimumWidth = 6;
            this.valoracion.Name = "valoracion";
            this.valoracion.ReadOnly = true;
            this.valoracion.Width = 99;
            // 
            // bindingSourceUsers
            // 
            this.bindingSourceUsers.DataSource = typeof(WindowsFormsAppArmonii.Models.UsuarioOrm.UsuarioLocal);
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
            this.btnAtras.Location = new System.Drawing.Point(51, 64);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(76, 40);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atras";
            this.btnAtras.TextColor = System.Drawing.Color.White;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnatras_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(1139, 64);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(103, 40);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.BtnEditar.Location = new System.Drawing.Point(1053, 64);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(80, 40);
            this.BtnEditar.TabIndex = 7;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextColor = System.Drawing.Color.White;
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.btnAnadir.Location = new System.Drawing.Point(967, 64);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(80, 40);
            this.btnAnadir.TabIndex = 8;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.TextColor = System.Drawing.Color.White;
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1050, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // UsuariosLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1294, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.groupBox1);
            this.Name = "UsuariosLocal";
            this.Text = "Locales";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceUsers;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_local;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenya;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioApertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoracion;
        private btnRedondeado btnAtras;
        private btnRedondeado btnEliminar;
        private btnRedondeado BtnEditar;
        private btnRedondeado btnAnadir;
        private System.Windows.Forms.Label label1;
    }
}