
namespace InterfazDATMA.Administrador
{
    partial class frmInsertarCurso
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
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInscrip = new System.Windows.Forms.DateTimePicker();
            this.txtCantSemana = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvReq = new System.Windows.Forms.DataGridView();
            this.NombreCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelaccionarTemas = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVerGrupos = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregarReq = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminarReq = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGuardarCurso = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(46, 35);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(177, 29);
            this.lblTutoresUser.TabIndex = 17;
            this.lblTutoresUser.Text = "Nombre Curso:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(20, 255);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(208, 29);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Fecha Inscripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cant. Semanas:";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(230, 38);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(392, 26);
            this.txtNombreCurso.TabIndex = 22;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInicial.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(230, 98);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(310, 26);
            this.dtpFechaInicial.TabIndex = 23;
            this.dtpFechaInicial.ValueChanged += new System.EventHandler(this.dtpFechaInicial_ValueChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaFin.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(230, 152);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(310, 26);
            this.dtpFechaFin.TabIndex = 24;
            // 
            // dtpFechaInscrip
            // 
            this.dtpFechaInscrip.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInscrip.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInscrip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInscrip.Location = new System.Drawing.Point(230, 255);
            this.dtpFechaInscrip.Name = "dtpFechaInscrip";
            this.dtpFechaInscrip.Size = new System.Drawing.Size(310, 26);
            this.dtpFechaInscrip.TabIndex = 25;
            // 
            // txtCantSemana
            // 
            this.txtCantSemana.Location = new System.Drawing.Point(230, 208);
            this.txtCantSemana.Name = "txtCantSemana";
            this.txtCantSemana.Size = new System.Drawing.Size(94, 26);
            this.txtCantSemana.TabIndex = 26;
            this.txtCantSemana.TextChanged += new System.EventHandler(this.textCantSemana_TextChanged);
            this.txtCantSemana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCantSemana_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 44);
            this.label4.TabIndex = 27;
            this.label4.Text = "Pre-Requisitos:";
            // 
            // dgvReq
            // 
            this.dgvReq.AllowUserToAddRows = false;
            this.dgvReq.AllowUserToDeleteRows = false;
            this.dgvReq.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCurso,
            this.FechaInicial,
            this.FechaFinal});
            this.dgvReq.EnableHeadersVisualStyles = false;
            this.dgvReq.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReq.Location = new System.Drawing.Point(34, 111);
            this.dgvReq.Name = "dgvReq";
            this.dgvReq.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReq.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvReq.RowHeadersWidth = 62;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReq.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvReq.RowTemplate.Height = 28;
            this.dgvReq.Size = new System.Drawing.Size(756, 306);
            this.dgvReq.TabIndex = 28;
            this.dgvReq.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReq_CellFormatting);
            // 
            // NombreCurso
            // 
            this.NombreCurso.HeaderText = "Nombre";
            this.NombreCurso.MinimumWidth = 8;
            this.NombreCurso.Name = "NombreCurso";
            this.NombreCurso.ReadOnly = true;
            this.NombreCurso.Width = 150;
            // 
            // FechaInicial
            // 
            dataGridViewCellStyle17.Format = "dd/MM/yyyy";
            dataGridViewCellStyle17.NullValue = null;
            this.FechaInicial.DefaultCellStyle = dataGridViewCellStyle17;
            this.FechaInicial.HeaderText = "Fecha Inicio";
            this.FechaInicial.MinimumWidth = 8;
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.ReadOnly = true;
            this.FechaInicial.Width = 150;
            // 
            // FechaFinal
            // 
            dataGridViewCellStyle18.Format = "dd/MM/yyyy";
            dataGridViewCellStyle18.NullValue = null;
            this.FechaFinal.DefaultCellStyle = dataGridViewCellStyle18;
            this.FechaFinal.HeaderText = "Fecha Fin";
            this.FechaFinal.MinimumWidth = 8;
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.ReadOnly = true;
            this.FechaFinal.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "Temas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "Grupos:";
            // 
            // btnSelaccionarTemas
            // 
            this.btnSelaccionarTemas.AutoSize = true;
            this.btnSelaccionarTemas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelaccionarTemas.Depth = 0;
            this.btnSelaccionarTemas.Location = new System.Drawing.Point(44, 65);
            this.btnSelaccionarTemas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSelaccionarTemas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelaccionarTemas.Name = "btnSelaccionarTemas";
            this.btnSelaccionarTemas.Primary = false;
            this.btnSelaccionarTemas.Size = new System.Drawing.Size(223, 36);
            this.btnSelaccionarTemas.TabIndex = 37;
            this.btnSelaccionarTemas.Text = "Seleccionar Temas";
            this.btnSelaccionarTemas.UseVisualStyleBackColor = true;
            this.btnSelaccionarTemas.Click += new System.EventHandler(this.btnSelaccionarTemas_Click);
            // 
            // btnVerGrupos
            // 
            this.btnVerGrupos.AutoSize = true;
            this.btnVerGrupos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerGrupos.Depth = 0;
            this.btnVerGrupos.Location = new System.Drawing.Point(57, 74);
            this.btnVerGrupos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVerGrupos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerGrupos.Name = "btnVerGrupos";
            this.btnVerGrupos.Primary = false;
            this.btnVerGrupos.Size = new System.Drawing.Size(137, 36);
            this.btnVerGrupos.TabIndex = 38;
            this.btnVerGrupos.Text = "Ver Grupos";
            this.btnVerGrupos.UseVisualStyleBackColor = true;
            this.btnVerGrupos.Click += new System.EventHandler(this.btnVerGrupos_Click);
            // 
            // btnAgregarReq
            // 
            this.btnAgregarReq.AutoSize = true;
            this.btnAgregarReq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarReq.Depth = 0;
            this.btnAgregarReq.Location = new System.Drawing.Point(796, 111);
            this.btnAgregarReq.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAgregarReq.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarReq.Name = "btnAgregarReq";
            this.btnAgregarReq.Primary = false;
            this.btnAgregarReq.Size = new System.Drawing.Size(26, 36);
            this.btnAgregarReq.TabIndex = 39;
            this.btnAgregarReq.Text = "+";
            this.btnAgregarReq.UseVisualStyleBackColor = true;
            this.btnAgregarReq.Click += new System.EventHandler(this.btnAgregarReq_Click);
            // 
            // btnEliminarReq
            // 
            this.btnEliminarReq.AutoSize = true;
            this.btnEliminarReq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarReq.Depth = 0;
            this.btnEliminarReq.Location = new System.Drawing.Point(796, 166);
            this.btnEliminarReq.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEliminarReq.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarReq.Name = "btnEliminarReq";
            this.btnEliminarReq.Primary = false;
            this.btnEliminarReq.Size = new System.Drawing.Size(21, 36);
            this.btnEliminarReq.TabIndex = 40;
            this.btnEliminarReq.Text = "-";
            this.btnEliminarReq.UseVisualStyleBackColor = true;
            this.btnEliminarReq.Click += new System.EventHandler(this.btnEliminarReq_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = true;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Location = new System.Drawing.Point(1133, 882);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = false;
            this.btnRegresar.Size = new System.Drawing.Size(116, 36);
            this.btnRegresar.TabIndex = 39;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardarCurso
            // 
            this.btnGuardarCurso.AutoSize = true;
            this.btnGuardarCurso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarCurso.Depth = 0;
            this.btnGuardarCurso.Location = new System.Drawing.Point(1133, 822);
            this.btnGuardarCurso.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGuardarCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarCurso.Name = "btnGuardarCurso";
            this.btnGuardarCurso.Primary = false;
            this.btnGuardarCurso.Size = new System.Drawing.Size(108, 36);
            this.btnGuardarCurso.TabIndex = 41;
            this.btnGuardarCurso.Text = "Guardar";
            this.btnGuardarCurso.UseVisualStyleBackColor = true;
            this.btnGuardarCurso.Click += new System.EventHandler(this.btnGuardarCurso_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelaccionarTemas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(958, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 151);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temas:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnVerGrupos);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(958, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 148);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupos:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCantSemana);
            this.groupBox3.Controls.Add(this.dtpFechaInscrip);
            this.groupBox3.Controls.Add(this.dtpFechaFin);
            this.groupBox3.Controls.Add(this.dtpFechaInicial);
            this.groupBox3.Controls.Add(this.txtNombreCurso);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbl);
            this.groupBox3.Controls.Add(this.lblTutoresUser);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(83, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(656, 309);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Curso:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnEliminarReq);
            this.groupBox4.Controls.Add(this.btnAgregarReq);
            this.groupBox4.Controls.Add(this.dgvReq);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(83, 488);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(867, 448);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pre-Requisitos de Curso:";
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(1133, 545);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = false;
            this.btnModificar.Size = new System.Drawing.Size(123, 36);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.Location = new System.Drawing.Point(1133, 599);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Primary = false;
            this.btnLimpiar.Size = new System.Drawing.Size(95, 36);
            this.btnLimpiar.TabIndex = 47;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmInsertarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1381, 981);
            this.ControlBox = false;
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnGuardarCurso);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmInsertarCurso";
            this.Sizable = false;
            this.Text = "Insertar Curso";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInscrip;
        private System.Windows.Forms.TextBox txtCantSemana;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialFlatButton btnSelaccionarTemas;
        private MaterialSkin.Controls.MaterialFlatButton btnVerGrupos;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarReq;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminarReq;
        private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardarCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialFlatButton btnModificar;
        private MaterialSkin.Controls.MaterialFlatButton btnLimpiar;
    }
}