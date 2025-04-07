namespace WindowsFormsAppArmonii
{
    partial class Administradores
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
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permisoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAdmin = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAtras = new WindowsFormsAppArmonii.btnRedondeado();
            this.btnEliminar = new WindowsFormsAppArmonii.btnRedondeado();
            this.btnAgregar = new WindowsFormsAppArmonii.btnRedondeado();
            this.btnEditar = new WindowsFormsAppArmonii.btnRedondeado();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.groupBox1.Controls.Add(this.dgvAdmins);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(46, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1213, 488);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // dgvAdmins
            // 
            this.dgvAdmins.AllowUserToAddRows = false;
            this.dgvAdmins.AllowUserToDeleteRows = false;
            this.dgvAdmins.AllowUserToOrderColumns = true;
            this.dgvAdmins.AutoGenerateColumns = false;
            this.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.contrasenyaDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.permisoDataGridViewTextBoxColumn});
            this.dgvAdmins.DataSource = this.bsAdmin;
            this.dgvAdmins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAdmins.Location = new System.Drawing.Point(3, 18);
            this.dgvAdmins.MultiSelect = false;
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.RowHeadersVisible = false;
            this.dgvAdmins.RowHeadersWidth = 51;
            this.dgvAdmins.RowTemplate.Height = 24;
            this.dgvAdmins.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdmins.Size = new System.Drawing.Size(1207, 467);
            this.dgvAdmins.TabIndex = 1;
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
            // permisoDataGridViewTextBoxColumn
            // 
            this.permisoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.permisoDataGridViewTextBoxColumn.DataPropertyName = "permiso";
            this.permisoDataGridViewTextBoxColumn.HeaderText = "permiso";
            this.permisoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.permisoDataGridViewTextBoxColumn.Name = "permisoDataGridViewTextBoxColumn";
            this.permisoDataGridViewTextBoxColumn.ReadOnly = true;
            this.permisoDataGridViewTextBoxColumn.Width = 85;
            // 
            // bsAdmin
            // 
            this.bsAdmin.DataSource = typeof(WindowsFormsAppArmonii.Models.UsuarioAdmin);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1207, 467);
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
            this.btnAtras.Location = new System.Drawing.Point(46, 51);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(87, 40);
            this.btnAtras.TabIndex = 10;
            this.btnAtras.Text = "Atras";
            this.btnAtras.TextColor = System.Drawing.Color.White;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
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
            this.btnEliminar.Location = new System.Drawing.Point(1148, 50);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 40);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextColor = System.Drawing.Color.White;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(930, 50);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(105, 40);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(88)))), ((int)(((byte)(12)))));
            this.btnEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditar.BorderRadius = 20;
            this.btnEditar.BorderSize = 0;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(1041, 50);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 40);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1145, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // Administradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1297, 606);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.groupBox1);
            this.Name = "Administradores";
            this.Text = "Administradores";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bsAdmin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permisoDataGridViewTextBoxColumn;
        private btnRedondeado btnAtras;
        private btnRedondeado btnEliminar;
        private btnRedondeado btnAgregar;
        private btnRedondeado btnEditar;
        private System.Windows.Forms.Label label1;
    }
}