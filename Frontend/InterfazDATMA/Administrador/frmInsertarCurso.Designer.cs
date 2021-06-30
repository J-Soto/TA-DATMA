
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelaccionarTemas = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVerGrupos = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModificar = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardarCurso = new MaterialSkin.Controls.MaterialButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarReq = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarReq = new MaterialSkin.Controls.MaterialButton();
            this.dgvReq = new System.Windows.Forms.DataGridView();
            this.NombreCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(61, 44);
            this.lblTutoresUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(236, 37);
            this.lblTutoresUser.TabIndex = 17;
            this.lblTutoresUser.Text = "Nombre Curso:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(27, 319);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(277, 37);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Fecha Inscripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(131, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 37);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cant. Semanas:";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(307, 48);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(521, 31);
            this.txtNombreCurso.TabIndex = 22;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInicial.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(307, 122);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(412, 31);
            this.dtpFechaInicial.TabIndex = 23;
            this.dtpFechaInicial.ValueChanged += new System.EventHandler(this.dtpFechaInicial_ValueChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaFin.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(307, 190);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(412, 31);
            this.dtpFechaFin.TabIndex = 24;
            // 
            // dtpFechaInscrip
            // 
            this.dtpFechaInscrip.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInscrip.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInscrip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInscrip.Location = new System.Drawing.Point(307, 319);
            this.dtpFechaInscrip.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaInscrip.Name = "dtpFechaInscrip";
            this.dtpFechaInscrip.Size = new System.Drawing.Size(412, 31);
            this.dtpFechaInscrip.TabIndex = 25;
            // 
            // txtCantSemana
            // 
            this.txtCantSemana.Location = new System.Drawing.Point(307, 260);
            this.txtCantSemana.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantSemana.Name = "txtCantSemana";
            this.txtCantSemana.Size = new System.Drawing.Size(124, 31);
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
            this.label4.Size = new System.Drawing.Size(179, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Pre-Requisitos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 39);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 37);
            this.label5.TabIndex = 35;
            this.label5.Text = "Temas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 37);
            this.label6.TabIndex = 36;
            this.label6.Text = "Grupos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelaccionarTemas);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1277, 170);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(397, 189);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temas:";
            // 
            // btnSelaccionarTemas
            // 
            this.btnSelaccionarTemas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelaccionarTemas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelaccionarTemas.Depth = 0;
            this.btnSelaccionarTemas.HighEmphasis = true;
            this.btnSelaccionarTemas.Icon = null;
            this.btnSelaccionarTemas.Location = new System.Drawing.Point(135, 95);
            this.btnSelaccionarTemas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelaccionarTemas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelaccionarTemas.Name = "btnSelaccionarTemas";
            this.btnSelaccionarTemas.Size = new System.Drawing.Size(171, 36);
            this.btnSelaccionarTemas.TabIndex = 36;
            this.btnSelaccionarTemas.Text = "Seleccionar Temas";
            this.btnSelaccionarTemas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelaccionarTemas.UseAccentColor = false;
            this.btnSelaccionarTemas.UseVisualStyleBackColor = true;
            this.btnSelaccionarTemas.Click += new System.EventHandler(this.btnSelaccionarTemas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerGrupos);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1277, 371);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(397, 185);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grupos:";
            // 
            // btnVerGrupos
            // 
            this.btnVerGrupos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerGrupos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerGrupos.Depth = 0;
            this.btnVerGrupos.HighEmphasis = true;
            this.btnVerGrupos.Icon = null;
            this.btnVerGrupos.Location = new System.Drawing.Point(117, 104);
            this.btnVerGrupos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerGrupos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerGrupos.Name = "btnVerGrupos";
            this.btnVerGrupos.Size = new System.Drawing.Size(109, 36);
            this.btnVerGrupos.TabIndex = 37;
            this.btnVerGrupos.Text = "Ver Grupos";
            this.btnVerGrupos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerGrupos.UseAccentColor = false;
            this.btnVerGrupos.UseVisualStyleBackColor = true;
            this.btnVerGrupos.Click += new System.EventHandler(this.btnVerGrupos_Click);
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
            this.groupBox3.Location = new System.Drawing.Point(111, 170);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(875, 386);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informacion Curso:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgvReq);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.ForeColor = System.Drawing.Color.White;
            this.groupBox5.Location = new System.Drawing.Point(64, 726);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(875, 386);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Informacion Curso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 53);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 37);
            this.label7.TabIndex = 28;
            this.label7.Text = "Pre-Requisitos:";
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificar.Depth = 0;
            this.btnModificar.HighEmphasis = true;
            this.btnModificar.Icon = null;
            this.btnModificar.Location = new System.Drawing.Point(1516, 764);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 36);
            this.btnModificar.TabIndex = 38;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificar.UseAccentColor = false;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.HighEmphasis = true;
            this.btnLimpiar.Icon = null;
            this.btnLimpiar.Location = new System.Drawing.Point(1516, 953);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(79, 36);
            this.btnLimpiar.TabIndex = 46;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardarCurso
            // 
            this.btnGuardarCurso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarCurso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarCurso.Depth = 0;
            this.btnGuardarCurso.HighEmphasis = true;
            this.btnGuardarCurso.Icon = null;
            this.btnGuardarCurso.Location = new System.Drawing.Point(1516, 1028);
            this.btnGuardarCurso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardarCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarCurso.Name = "btnGuardarCurso";
            this.btnGuardarCurso.Size = new System.Drawing.Size(88, 36);
            this.btnGuardarCurso.TabIndex = 47;
            this.btnGuardarCurso.Text = "Guardar";
            this.btnGuardarCurso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarCurso.UseAccentColor = false;
            this.btnGuardarCurso.UseVisualStyleBackColor = true;
            this.btnGuardarCurso.Click += new System.EventHandler(this.btnGuardarCurso_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.HighEmphasis = true;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(1516, 1114);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(94, 36);
            this.btnRegresar.TabIndex = 48;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegresar.UseAccentColor = false;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnAgregarReq
            // 
            this.btnAgregarReq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarReq.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarReq.Depth = 0;
            this.btnAgregarReq.HighEmphasis = true;
            this.btnAgregarReq.Icon = null;
            this.btnAgregarReq.Location = new System.Drawing.Point(1022, 833);
            this.btnAgregarReq.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarReq.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarReq.Name = "btnAgregarReq";
            this.btnAgregarReq.Size = new System.Drawing.Size(64, 36);
            this.btnAgregarReq.TabIndex = 49;
            this.btnAgregarReq.Text = "+";
            this.btnAgregarReq.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarReq.UseAccentColor = false;
            this.btnAgregarReq.UseVisualStyleBackColor = true;
            this.btnAgregarReq.Click += new System.EventHandler(this.btnAgregarReq_Click);
            // 
            // btnEliminarReq
            // 
            this.btnEliminarReq.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarReq.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarReq.Depth = 0;
            this.btnEliminarReq.HighEmphasis = true;
            this.btnEliminarReq.Icon = null;
            this.btnEliminarReq.Location = new System.Drawing.Point(1022, 921);
            this.btnEliminarReq.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarReq.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarReq.Name = "btnEliminarReq";
            this.btnEliminarReq.Size = new System.Drawing.Size(64, 36);
            this.btnEliminarReq.TabIndex = 50;
            this.btnEliminarReq.Text = "-";
            this.btnEliminarReq.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarReq.UseAccentColor = false;
            this.btnEliminarReq.UseVisualStyleBackColor = true;
            this.btnEliminarReq.Click += new System.EventHandler(this.btnEliminarReq_Click);
            // 
            // dgvReq
            // 
            this.dgvReq.AllowUserToAddRows = false;
            this.dgvReq.AllowUserToDeleteRows = false;
            this.dgvReq.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCurso,
            this.FechaInicial,
            this.FechaFinal});
            this.dgvReq.EnableHeadersVisualStyles = false;
            this.dgvReq.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReq.Location = new System.Drawing.Point(28, 94);
            this.dgvReq.Margin = new System.Windows.Forms.Padding(4);
            this.dgvReq.Name = "dgvReq";
            this.dgvReq.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReq.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReq.RowHeadersWidth = 62;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReq.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReq.RowTemplate.Height = 28;
            this.dgvReq.Size = new System.Drawing.Size(819, 259);
            this.dgvReq.TabIndex = 51;
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
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaInicial.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaInicial.HeaderText = "Fecha Inicio";
            this.FechaInicial.MinimumWidth = 8;
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.ReadOnly = true;
            this.FechaInicial.Width = 150;
            // 
            // FechaFinal
            // 
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            dataGridViewCellStyle3.NullValue = null;
            this.FechaFinal.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaFinal.HeaderText = "Fecha Fin";
            this.FechaFinal.MinimumWidth = 8;
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.ReadOnly = true;
            this.FechaFinal.Width = 150;
            // 
            // frmInsertarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1841, 1226);
            this.ControlBox = false;
            this.Controls.Add(this.btnEliminarReq);
            this.Controls.Add(this.btnAgregarReq);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardarCurso);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInsertarCurso";
            this.Padding = new System.Windows.Forms.Padding(4, 80, 4, 4);
            this.Sizable = false;
            this.Text = "Insertar Curso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        //private MaterialSkin.Controls.MaterialFlatButton btnSelaccionarTemas;
        //private MaterialSkin.Controls.MaterialFlatButton btnVerGrupos;
        //private MaterialSkin.Controls.MaterialFlatButton btnAgregarReq;
        //private MaterialSkin.Controls.MaterialFlatButton btnEliminarReq;
        //private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
        //private MaterialSkin.Controls.MaterialFlatButton btnGuardarCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialButton btnSelaccionarTemas;
        private MaterialSkin.Controls.MaterialButton btnVerGrupos;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnGuardarCurso;
        private MaterialSkin.Controls.MaterialButton btnRegresar;
        private MaterialSkin.Controls.MaterialButton btnAgregarReq;
        private MaterialSkin.Controls.MaterialButton btnEliminarReq;
        private System.Windows.Forms.DataGridView dgvReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
        //private MaterialSkin.Controls.MaterialFlatButton btnLimpiar;
        //private MaterialSkin.Controls.MaterialFlatButton btnModificar;
    }
}