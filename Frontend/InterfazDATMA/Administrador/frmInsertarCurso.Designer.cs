
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
            this.dgvReq = new System.Windows.Forms.DataGridView();
            this.NombreCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarReq = new System.Windows.Forms.Button();
            this.btnEliminarReq = new System.Windows.Forms.Button();
            this.btnSelaccionarTemas = new System.Windows.Forms.Button();
            this.btnVerGrupos = new System.Windows.Forms.Button();
            this.btnGuardarCurso = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(117, 81);
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
            this.lbl.Location = new System.Drawing.Point(83, 356);
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
            this.label1.Location = new System.Drawing.Point(149, 156);
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
            this.label2.Location = new System.Drawing.Point(187, 228);
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
            this.label3.Location = new System.Drawing.Point(117, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 37);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cant. Semanas:";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(363, 86);
            this.txtNombreCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(521, 31);
            this.txtNombreCurso.TabIndex = 22;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInicial.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(363, 160);
            this.dtpFechaInicial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(412, 31);
            this.dtpFechaInicial.TabIndex = 23;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaFin.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(363, 229);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(412, 31);
            this.dtpFechaFin.TabIndex = 24;
            // 
            // dtpFechaInscrip
            // 
            this.dtpFechaInscrip.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInscrip.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInscrip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInscrip.Location = new System.Drawing.Point(363, 356);
            this.dtpFechaInscrip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInscrip.Name = "dtpFechaInscrip";
            this.dtpFechaInscrip.Size = new System.Drawing.Size(412, 31);
            this.dtpFechaInscrip.TabIndex = 25;
            // 
            // txtCantSemana
            // 
            this.txtCantSemana.Location = new System.Drawing.Point(363, 296);
            this.txtCantSemana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.label4.Location = new System.Drawing.Point(107, 461);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 37);
            this.label4.TabIndex = 27;
            this.label4.Text = "Requerimientos:";
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
            this.dgvReq.Location = new System.Drawing.Point(108, 522);
            this.dgvReq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.dgvReq.Size = new System.Drawing.Size(1008, 446);
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
            // btnAgregarReq
            // 
            this.btnAgregarReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAgregarReq.FlatAppearance.BorderSize = 0;
            this.btnAgregarReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarReq.ForeColor = System.Drawing.Color.White;
            this.btnAgregarReq.Location = new System.Drawing.Point(1148, 522);
            this.btnAgregarReq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarReq.Name = "btnAgregarReq";
            this.btnAgregarReq.Size = new System.Drawing.Size(67, 56);
            this.btnAgregarReq.TabIndex = 29;
            this.btnAgregarReq.Text = "+";
            this.btnAgregarReq.UseVisualStyleBackColor = false;
            this.btnAgregarReq.Click += new System.EventHandler(this.btnAgregarReq_Click);
            // 
            // btnEliminarReq
            // 
            this.btnEliminarReq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnEliminarReq.FlatAppearance.BorderSize = 0;
            this.btnEliminarReq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminarReq.ForeColor = System.Drawing.Color.White;
            this.btnEliminarReq.Location = new System.Drawing.Point(1148, 606);
            this.btnEliminarReq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminarReq.Name = "btnEliminarReq";
            this.btnEliminarReq.Size = new System.Drawing.Size(67, 56);
            this.btnEliminarReq.TabIndex = 30;
            this.btnEliminarReq.Text = "-";
            this.btnEliminarReq.UseVisualStyleBackColor = false;
            this.btnEliminarReq.Click += new System.EventHandler(this.btnEliminarReq_Click);
            // 
            // btnSelaccionarTemas
            // 
            this.btnSelaccionarTemas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnSelaccionarTemas.FlatAppearance.BorderSize = 0;
            this.btnSelaccionarTemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelaccionarTemas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSelaccionarTemas.ForeColor = System.Drawing.Color.White;
            this.btnSelaccionarTemas.Location = new System.Drawing.Point(1125, 140);
            this.btnSelaccionarTemas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelaccionarTemas.Name = "btnSelaccionarTemas";
            this.btnSelaccionarTemas.Size = new System.Drawing.Size(357, 69);
            this.btnSelaccionarTemas.TabIndex = 31;
            this.btnSelaccionarTemas.Text = "Seleccionar Temas";
            this.btnSelaccionarTemas.UseVisualStyleBackColor = false;
            this.btnSelaccionarTemas.Click += new System.EventHandler(this.btnSelaccionarTemas_Click);
            // 
            // btnVerGrupos
            // 
            this.btnVerGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnVerGrupos.FlatAppearance.BorderSize = 0;
            this.btnVerGrupos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerGrupos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnVerGrupos.ForeColor = System.Drawing.Color.White;
            this.btnVerGrupos.Location = new System.Drawing.Point(1125, 260);
            this.btnVerGrupos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerGrupos.Name = "btnVerGrupos";
            this.btnVerGrupos.Size = new System.Drawing.Size(357, 69);
            this.btnVerGrupos.TabIndex = 32;
            this.btnVerGrupos.Text = "Ver Grupos";
            this.btnVerGrupos.UseVisualStyleBackColor = false;
            this.btnVerGrupos.Click += new System.EventHandler(this.btnVerGrupos_Click);
            // 
            // btnGuardarCurso
            // 
            this.btnGuardarCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnGuardarCurso.FlatAppearance.BorderSize = 0;
            this.btnGuardarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardarCurso.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCurso.Location = new System.Drawing.Point(1232, 915);
            this.btnGuardarCurso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarCurso.Name = "btnGuardarCurso";
            this.btnGuardarCurso.Size = new System.Drawing.Size(357, 56);
            this.btnGuardarCurso.TabIndex = 33;
            this.btnGuardarCurso.Text = "Guardar";
            this.btnGuardarCurso.UseVisualStyleBackColor = false;
            this.btnGuardarCurso.Click += new System.EventHandler(this.btnGuardarCurso_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(1232, 996);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(357, 56);
            this.btnRegresar.TabIndex = 34;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmInsertarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1704, 1175);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardarCurso);
            this.Controls.Add(this.btnVerGrupos);
            this.Controls.Add(this.btnSelaccionarTemas);
            this.Controls.Add(this.btnEliminarReq);
            this.Controls.Add(this.btnAgregarReq);
            this.Controls.Add(this.dgvReq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantSemana);
            this.Controls.Add(this.dtpFechaInscrip);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblTutoresUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInsertarCurso";
            this.Sizable = false;
            this.Text = "frmInsertarCurso";
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
        private System.Windows.Forms.DataGridView dgvReq;
        private System.Windows.Forms.Button btnAgregarReq;
        private System.Windows.Forms.Button btnEliminarReq;
        private System.Windows.Forms.Button btnSelaccionarTemas;
        private System.Windows.Forms.Button btnVerGrupos;
        private System.Windows.Forms.Button btnGuardarCurso;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
    }
}