
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
            this.cbNumSemana = new System.Windows.Forms.ComboBox();
            this.lblSemana = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.btnRegresar = new MaterialSkin.Controls.MaterialButton();
            this.btnQuitarTema = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarTema = new MaterialSkin.Controls.MaterialButton();
            this.btnCrearTema = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInicial.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(199, 76);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(310, 26);
            this.dtpFechaInicial.TabIndex = 11;
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(28, 73);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(154, 29);
            this.lblTutoresUser.TabIndex = 13;
            this.lblTutoresUser.Text = "Fecha Inicial:";
            this.lblTutoresUser.Click += new System.EventHandler(this.lblTutoresUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fecha de Fin:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaFin.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(199, 121);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(310, 26);
            this.dtpFechaFin.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(99, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tema:";
            // 
            // cbTema
            // 
            this.cbTema.FormattingEnabled = true;
            this.cbTema.Location = new System.Drawing.Point(199, 170);
            this.cbTema.Name = "cbTema";
            this.cbTema.Size = new System.Drawing.Size(363, 28);
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
            this.dgvTemas.Location = new System.Drawing.Point(192, 320);
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
            this.dgvTemas.Size = new System.Drawing.Size(831, 329);
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
            this.NombreCompleto.Width = 270;
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
            this.FechaInicio.Width = 170;
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
            this.FechaFin.Width = 170;
            // 
            // cbNumSemana
            // 
            this.cbNumSemana.FormattingEnabled = true;
            this.cbNumSemana.Location = new System.Drawing.Point(199, 29);
            this.cbNumSemana.Name = "cbNumSemana";
            this.cbNumSemana.Size = new System.Drawing.Size(93, 28);
            this.cbNumSemana.TabIndex = 23;
            this.cbNumSemana.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSemana.ForeColor = System.Drawing.Color.White;
            this.lblSemana.Location = new System.Drawing.Point(74, 25);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(108, 29);
            this.lblSemana.TabIndex = 24;
            this.lblSemana.Text = "Semana:";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNombreCurso.ForeColor = System.Drawing.Color.White;
            this.lblNombreCurso.Location = new System.Drawing.Point(184, 9);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(127, 46);
            this.lblNombreCurso.TabIndex = 29;
            this.lblNombreCurso.Text = "Curso";
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = false;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.HighEmphasis = true;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(1065, 593);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(124, 56);
            this.btnRegresar.TabIndex = 38;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegresar.UseAccentColor = false;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // btnQuitarTema
            // 
            this.btnQuitarTema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarTema.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnQuitarTema.Depth = 0;
            this.btnQuitarTema.HighEmphasis = true;
            this.btnQuitarTema.Icon = null;
            this.btnQuitarTema.Location = new System.Drawing.Point(1048, 378);
            this.btnQuitarTema.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnQuitarTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarTema.Name = "btnQuitarTema";
            this.btnQuitarTema.Size = new System.Drawing.Size(64, 36);
            this.btnQuitarTema.TabIndex = 37;
            this.btnQuitarTema.Text = "-";
            this.btnQuitarTema.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnQuitarTema.UseAccentColor = false;
            this.btnQuitarTema.UseVisualStyleBackColor = true;
            this.btnQuitarTema.Click += new System.EventHandler(this.btnQuitarTema_Click_1);
            // 
            // btnAgregarTema
            // 
            this.btnAgregarTema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarTema.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarTema.Depth = 0;
            this.btnAgregarTema.HighEmphasis = true;
            this.btnAgregarTema.Icon = null;
            this.btnAgregarTema.Location = new System.Drawing.Point(1048, 320);
            this.btnAgregarTema.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAgregarTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarTema.Name = "btnAgregarTema";
            this.btnAgregarTema.Size = new System.Drawing.Size(64, 36);
            this.btnAgregarTema.TabIndex = 36;
            this.btnAgregarTema.Text = "+";
            this.btnAgregarTema.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarTema.UseAccentColor = false;
            this.btnAgregarTema.UseVisualStyleBackColor = true;
            this.btnAgregarTema.Click += new System.EventHandler(this.btnAgregarTema_Click_1);
            // 
            // btnCrearTema
            // 
            this.btnCrearTema.AutoSize = false;
            this.btnCrearTema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCrearTema.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCrearTema.Depth = 0;
            this.btnCrearTema.HighEmphasis = true;
            this.btnCrearTema.Icon = null;
            this.btnCrearTema.Location = new System.Drawing.Point(579, 166);
            this.btnCrearTema.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCrearTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearTema.Name = "btnCrearTema";
            this.btnCrearTema.Size = new System.Drawing.Size(125, 40);
            this.btnCrearTema.TabIndex = 35;
            this.btnCrearTema.Text = "Crear Tema";
            this.btnCrearTema.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCrearTema.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCrearTema.UseAccentColor = false;
            this.btnCrearTema.UseVisualStyleBackColor = true;
            this.btnCrearTema.Click += new System.EventHandler(this.btnCrearTema_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCrearTema);
            this.groupBox1.Controls.Add(this.lblSemana);
            this.groupBox1.Controls.Add(this.cbNumSemana);
            this.groupBox1.Controls.Add(this.cbTema);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFechaFin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTutoresUser);
            this.groupBox1.Controls.Add(this.dtpFechaInicial);
            this.groupBox1.Location = new System.Drawing.Point(192, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 228);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Semanas:";
            // 
            // frmSeleccionarTemasDeCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1278, 814);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnQuitarTema);
            this.Controls.Add(this.btnAgregarTema);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.dgvTemas);
            this.Name = "frmSeleccionarTemasDeCurso";
            this.Sizable = false;
            this.Text = "Seleccionar Temas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        //private MaterialSkin.Controls.MaterialFlatButton btnCrearTema;
        //private MaterialSkin.Controls.MaterialFlatButton btnAgregarTema;
        //private MaterialSkin.Controls.MaterialFlatButton btnQuitarTema;
        //private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
        private System.Windows.Forms.Label lblNombreCurso;
        private MaterialSkin.Controls.MaterialButton btnRegresar;
        private MaterialSkin.Controls.MaterialButton btnQuitarTema;
        private MaterialSkin.Controls.MaterialButton btnAgregarTema;
        private MaterialSkin.Controls.MaterialButton btnCrearTema;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
    }
}