
namespace InterfazDATMA.Administrador
{
    partial class frmSeleccionarTemasDeCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTema = new System.Windows.Forms.ComboBox();
            this.dgvTemas = new System.Windows.Forms.DataGridView();
            this.Semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarTema = new System.Windows.Forms.Button();
            this.btnQuitarTema = new System.Windows.Forms.Button();
            this.btnCrearTema = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.cbNumSemana = new System.Windows.Forms.ComboBox();
            this.lblSemana = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInicial.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(300, 134);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(412, 31);
            this.dtpFechaInicial.TabIndex = 11;
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(71, 130);
            this.lblTutoresUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(205, 37);
            this.lblTutoresUser.TabIndex = 13;
            this.lblTutoresUser.Text = "Fecha Inicial:";
            this.lblTutoresUser.Click += new System.EventHandler(this.lblTutoresUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha de Fin:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaFin.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(300, 204);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(412, 31);
            this.dtpFechaFin.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(167, 274);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tema:";
            // 
            // cbTema
            // 
            this.cbTema.FormattingEnabled = true;
            this.cbTema.Location = new System.Drawing.Point(300, 279);
            this.cbTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTema.Name = "cbTema";
            this.cbTema.Size = new System.Drawing.Size(483, 33);
            this.cbTema.TabIndex = 17;
            // 
            // dgvTemas
            // 
            this.dgvTemas.AllowUserToAddRows = false;
            this.dgvTemas.AllowUserToDeleteRows = false;
            this.dgvTemas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvTemas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTemas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semana,
            this.NombreCompleto,
            this.FechaInicio,
            this.FechaFin});
            this.dgvTemas.EnableHeadersVisualStyles = false;
            this.dgvTemas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTemas.Location = new System.Drawing.Point(127, 406);
            this.dgvTemas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTemas.Name = "dgvTemas";
            this.dgvTemas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTemas.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTemas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTemas.RowTemplate.Height = 28;
            this.dgvTemas.Size = new System.Drawing.Size(1108, 449);
            this.dgvTemas.TabIndex = 18;
            this.dgvTemas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTemas_CellFormatting);
            // 
            // Semana
            // 
            this.Semana.HeaderText = "Sem.";
            this.Semana.MinimumWidth = 8;
            this.Semana.Name = "Semana";
            this.Semana.ReadOnly = true;
            this.Semana.Width = 50;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Tema";
            this.NombreCompleto.MinimumWidth = 8;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 200;
            // 
            // FechaInicio
            // 
            dataGridViewCellStyle2.Format = "dd/MM/yyy";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.MinimumWidth = 8;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 150;
            // 
            // FechaFin
            // 
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.FechaFin.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.MinimumWidth = 8;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 150;
            // 
            // btnAgregarTema
            // 
            this.btnAgregarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAgregarTema.FlatAppearance.BorderSize = 0;
            this.btnAgregarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarTema.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTema.Location = new System.Drawing.Point(1259, 406);
            this.btnAgregarTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarTema.Name = "btnAgregarTema";
            this.btnAgregarTema.Size = new System.Drawing.Size(67, 56);
            this.btnAgregarTema.TabIndex = 19;
            this.btnAgregarTema.Text = "+";
            this.btnAgregarTema.UseVisualStyleBackColor = false;
            this.btnAgregarTema.Click += new System.EventHandler(this.btnAgregarTema_Click);
            // 
            // btnQuitarTema
            // 
            this.btnQuitarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnQuitarTema.FlatAppearance.BorderSize = 0;
            this.btnQuitarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnQuitarTema.ForeColor = System.Drawing.Color.White;
            this.btnQuitarTema.Location = new System.Drawing.Point(1259, 482);
            this.btnQuitarTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitarTema.Name = "btnQuitarTema";
            this.btnQuitarTema.Size = new System.Drawing.Size(67, 56);
            this.btnQuitarTema.TabIndex = 20;
            this.btnQuitarTema.Text = "-";
            this.btnQuitarTema.UseVisualStyleBackColor = false;
            this.btnQuitarTema.Click += new System.EventHandler(this.btnQuitarTema_Click);
            // 
            // btnCrearTema
            // 
            this.btnCrearTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnCrearTema.FlatAppearance.BorderSize = 0;
            this.btnCrearTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrearTema.ForeColor = System.Drawing.Color.White;
            this.btnCrearTema.Location = new System.Drawing.Point(853, 279);
            this.btnCrearTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrearTema.Name = "btnCrearTema";
            this.btnCrearTema.Size = new System.Drawing.Size(291, 52);
            this.btnCrearTema.TabIndex = 21;
            this.btnCrearTema.Text = "Crear Nuevo Tema";
            this.btnCrearTema.UseVisualStyleBackColor = false;
            this.btnCrearTema.Click += new System.EventHandler(this.btnCrearTema_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(1361, 926);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(215, 62);
            this.btnRegresar.TabIndex = 22;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // cbNumSemana
            // 
            this.cbNumSemana.FormattingEnabled = true;
            this.cbNumSemana.Location = new System.Drawing.Point(300, 61);
            this.cbNumSemana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNumSemana.Name = "cbNumSemana";
            this.cbNumSemana.Size = new System.Drawing.Size(123, 33);
            this.cbNumSemana.TabIndex = 23;
            this.cbNumSemana.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSemana.ForeColor = System.Drawing.Color.White;
            this.lblSemana.Location = new System.Drawing.Point(132, 56);
            this.lblSemana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(145, 37);
            this.lblSemana.TabIndex = 24;
            this.lblSemana.Text = "Semana:";
            // 
            // frmSeleccionarTemasDeCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1648, 1056);
            this.ControlBox = false;
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.cbNumSemana);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCrearTema);
            this.Controls.Add(this.btnQuitarTema);
            this.Controls.Add(this.btnAgregarTema);
            this.Controls.Add(this.dgvTemas);
            this.Controls.Add(this.cbTema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTutoresUser);
            this.Controls.Add(this.dtpFechaInicial);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSeleccionarTemasDeCurso";
            this.Sizable = false;
            this.Text = "Seleccionar Temas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTema;
        private System.Windows.Forms.DataGridView dgvTemas;
        private System.Windows.Forms.Button btnAgregarTema;
        private System.Windows.Forms.Button btnQuitarTema;
        private System.Windows.Forms.Button btnCrearTema;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.ComboBox cbNumSemana;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
    }
}