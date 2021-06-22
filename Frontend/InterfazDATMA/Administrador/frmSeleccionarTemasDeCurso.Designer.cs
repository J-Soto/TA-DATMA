
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.cbNumSemana = new System.Windows.Forms.ComboBox();
            this.lblSemana = new System.Windows.Forms.Label();
            this.btnCrearTema = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregarTema = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnQuitarTema = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInicial.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(302, 185);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(412, 31);
            this.dtpFechaInicial.TabIndex = 11;
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(73, 181);
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
            this.label1.Location = new System.Drawing.Point(65, 252);
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
            this.dtpFechaFin.Location = new System.Drawing.Point(302, 255);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(412, 31);
            this.dtpFechaFin.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(169, 325);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 37);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tema:";
            // 
            // cbTema
            // 
            this.cbTema.FormattingEnabled = true;
            this.cbTema.Location = new System.Drawing.Point(302, 330);
            this.cbTema.Margin = new System.Windows.Forms.Padding(4);
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semana,
            this.NombreCompleto,
            this.FechaInicio,
            this.FechaFin});
            this.dgvTemas.EnableHeadersVisualStyles = false;
            this.dgvTemas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTemas.Location = new System.Drawing.Point(129, 457);
            this.dgvTemas.Margin = new System.Windows.Forms.Padding(4);
            this.dgvTemas.Name = "dgvTemas";
            this.dgvTemas.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTemas.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvTemas.RowHeadersWidth = 62;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTemas.RowsDefaultCellStyle = dataGridViewCellStyle20;
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
            dataGridViewCellStyle17.Format = "dd/MM/yyy";
            dataGridViewCellStyle17.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle17;
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.MinimumWidth = 8;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 150;
            // 
            // FechaFin
            // 
            dataGridViewCellStyle18.Format = "dd/MM/yyyy";
            dataGridViewCellStyle18.NullValue = null;
            this.FechaFin.DefaultCellStyle = dataGridViewCellStyle18;
            this.FechaFin.HeaderText = "Fecha Fin";
            this.FechaFin.MinimumWidth = 8;
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            this.FechaFin.Width = 150;
            // 
            // cbNumSemana
            // 
            this.cbNumSemana.FormattingEnabled = true;
            this.cbNumSemana.Location = new System.Drawing.Point(302, 112);
            this.cbNumSemana.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblSemana.Location = new System.Drawing.Point(134, 107);
            this.lblSemana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(145, 37);
            this.lblSemana.TabIndex = 24;
            this.lblSemana.Text = "Semana:";
            // 
            // btnCrearTema
            // 
            this.btnCrearTema.AutoSize = true;
            this.btnCrearTema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearTema.Depth = 0;
            this.btnCrearTema.Location = new System.Drawing.Point(1053, 397);
            this.btnCrearTema.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCrearTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearTema.Name = "btnCrearTema";
            this.btnCrearTema.Primary = false;
            this.btnCrearTema.Size = new System.Drawing.Size(184, 36);
            this.btnCrearTema.TabIndex = 25;
            this.btnCrearTema.Text = "Crear Tema";
            this.btnCrearTema.UseVisualStyleBackColor = true;
            this.btnCrearTema.Click += new System.EventHandler(this.btnCrearTema_Click_1);
            // 
            // btnAgregarTema
            // 
            this.btnAgregarTema.AutoSize = true;
            this.btnAgregarTema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarTema.Depth = 0;
            this.btnAgregarTema.Location = new System.Drawing.Point(1273, 457);
            this.btnAgregarTema.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarTema.Name = "btnAgregarTema";
            this.btnAgregarTema.Primary = false;
            this.btnAgregarTema.Size = new System.Drawing.Size(32, 36);
            this.btnAgregarTema.TabIndex = 26;
            this.btnAgregarTema.Text = "+";
            this.btnAgregarTema.UseVisualStyleBackColor = true;
            this.btnAgregarTema.Click += new System.EventHandler(this.btnAgregarTema_Click_1);
            // 
            // btnQuitarTema
            // 
            this.btnQuitarTema.AutoSize = true;
            this.btnQuitarTema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarTema.Depth = 0;
            this.btnQuitarTema.Location = new System.Drawing.Point(1280, 562);
            this.btnQuitarTema.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarTema.Name = "btnQuitarTema";
            this.btnQuitarTema.Primary = false;
            this.btnQuitarTema.Size = new System.Drawing.Size(25, 36);
            this.btnQuitarTema.TabIndex = 27;
            this.btnQuitarTema.Text = "-";
            this.btnQuitarTema.UseVisualStyleBackColor = true;
            this.btnQuitarTema.Click += new System.EventHandler(this.btnQuitarTema_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = true;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Location = new System.Drawing.Point(1085, 992);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = false;
            this.btnRegresar.Size = new System.Drawing.Size(152, 36);
            this.btnRegresar.TabIndex = 28;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // frmSeleccionarTemasDeCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1648, 1056);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnQuitarTema);
            this.Controls.Add(this.btnAgregarTema);
            this.Controls.Add(this.btnCrearTema);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.cbNumSemana);
            this.Controls.Add(this.dgvTemas);
            this.Controls.Add(this.cbTema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTutoresUser);
            this.Controls.Add(this.dtpFechaInicial);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox cbNumSemana;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private MaterialSkin.Controls.MaterialFlatButton btnCrearTema;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarTema;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarTema;
        private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
    }
}