namespace WindowsFormsAppArmonii
{
    partial class Calendario
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
            System.Windows.Forms.GroupBox groupBox1;
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dgvEventos = new System.Windows.Forms.DataGridView();
            this.bindingSourceEventos = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLocal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArtistico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtras = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(381, 18);
            this.monthCalendar1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 2;
            this.monthCalendar1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.dgvEventos);
            groupBox1.Location = new System.Drawing.Point(12, 268);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(932, 195);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // dgvEventos
            // 
            this.dgvEventos.AllowUserToAddRows = false;
            this.dgvEventos.AllowUserToDeleteRows = false;
            this.dgvEventos.AllowUserToOrderColumns = true;
            this.dgvEventos.AutoGenerateColumns = false;
            this.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcion,
            this.fecha,
            this.nombreLocal,
            this.nombreArtistico});
            this.dgvEventos.DataSource = this.bindingSourceEventos;
            this.dgvEventos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventos.Location = new System.Drawing.Point(3, 18);
            this.dgvEventos.Name = "dgvEventos";
            this.dgvEventos.ReadOnly = true;
            this.dgvEventos.RowHeadersWidth = 51;
            this.dgvEventos.RowTemplate.Height = 24;
            this.dgvEventos.Size = new System.Drawing.Size(926, 174);
            this.dgvEventos.TabIndex = 0;
            // 
            // bindingSourceEventos
            // 
            this.bindingSourceEventos.DataSource = typeof(WindowsFormsAppArmonii.Models.EventosOrm.EventoConMusico);
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
            // fecha
            // 
            this.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 69;
            // 
            // nombreLocal
            // 
            this.nombreLocal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreLocal.DataPropertyName = "nombreLocal";
            this.nombreLocal.HeaderText = "nombreLocal";
            this.nombreLocal.MinimumWidth = 6;
            this.nombreLocal.Name = "nombreLocal";
            this.nombreLocal.ReadOnly = true;
            this.nombreLocal.Width = 115;
            // 
            // nombreArtistico
            // 
            this.nombreArtistico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nombreArtistico.DataPropertyName = "nombreArtistico";
            this.nombreArtistico.HeaderText = "nombreArtistico";
            this.nombreArtistico.MinimumWidth = 6;
            this.nombreArtistico.Name = "nombreArtistico";
            this.nombreArtistico.ReadOnly = true;
            this.nombreArtistico.Width = 129;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(15, 18);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 514);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Calendario";
            this.Text = "Calendario";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceEventos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.BindingSource bindingSourceEventos;
        private System.Windows.Forms.DataGridView dgvEventos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreLocal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArtistico;
        private System.Windows.Forms.Button btnAtras;
    }
}