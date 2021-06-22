
namespace InterfazDATMA
{
    partial class frmInformacionCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraIni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInfCurso = new System.Windows.Forms.DataGridView();
            this.lblTituloDescripcion = new System.Windows.Forms.Label();
            this.lblDescripcionCurso = new System.Windows.Forms.Label();
            this.lblTituloEncargado = new System.Windows.Forms.Label();
            this.lblInformacionEncargada = new System.Windows.Forms.Label();
            this.txtBoxFechaIni = new System.Windows.Forms.TextBox();
            this.txtBoxFechaFin = new System.Windows.Forms.TextBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblNumeroModulo = new System.Windows.Forms.Label();
            this.lblTituloGeneral = new System.Windows.Forms.Label();
            this.lblNombreModulo = new System.Windows.Forms.Label();
            this.lblFechaIni = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.pictBoxEncargada = new System.Windows.Forms.PictureBox();
            this.btnAnterior = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSig = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVerMas = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxEncargada)).BeginInit();
            this.SuspendLayout();
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora de Fin";
            this.HoraFin.MinimumWidth = 8;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Width = 150;
            // 
            // HoraIni
            // 
            this.HoraIni.HeaderText = "Hora de Inicio";
            this.HoraIni.MinimumWidth = 8;
            this.HoraIni.Name = "HoraIni";
            this.HoraIni.Width = 150;
            // 
            // TipoActividad
            // 
            this.TipoActividad.HeaderText = "Tipo de Actividad";
            this.TipoActividad.MinimumWidth = 8;
            this.TipoActividad.Name = "TipoActividad";
            this.TipoActividad.Width = 150;
            // 
            // dgvInfCurso
            // 
            this.dgvInfCurso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvInfCurso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInfCurso.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfCurso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInfCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoActividad,
            this.HoraIni,
            this.HoraFin,
            this.Fecha});
            this.dgvInfCurso.EnableHeadersVisualStyles = false;
            this.dgvInfCurso.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvInfCurso.Location = new System.Drawing.Point(240, 556);
            this.dgvInfCurso.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInfCurso.Name = "dgvInfCurso";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfCurso.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInfCurso.RowHeadersWidth = 62;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInfCurso.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvInfCurso.RowTemplate.Height = 28;
            this.dgvInfCurso.Size = new System.Drawing.Size(1244, 310);
            this.dgvInfCurso.TabIndex = 18;
            // 
            // lblTituloDescripcion
            // 
            this.lblTituloDescripcion.AutoSize = true;
            this.lblTituloDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblTituloDescripcion.Location = new System.Drawing.Point(846, 79);
            this.lblTituloDescripcion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTituloDescripcion.Name = "lblTituloDescripcion";
            this.lblTituloDescripcion.Size = new System.Drawing.Size(219, 25);
            this.lblTituloDescripcion.TabIndex = 8;
            this.lblTituloDescripcion.Text = "Acerca de este Curso";
            // 
            // lblDescripcionCurso
            // 
            this.lblDescripcionCurso.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionCurso.Location = new System.Drawing.Point(882, 129);
            this.lblDescripcionCurso.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDescripcionCurso.Name = "lblDescripcionCurso";
            this.lblDescripcionCurso.Size = new System.Drawing.Size(604, 138);
            this.lblDescripcionCurso.TabIndex = 9;
            this.lblDescripcionCurso.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam vulputate fringil" +
    "la ante, id varius purus mollis non.";
            // 
            // lblTituloEncargado
            // 
            this.lblTituloEncargado.AutoSize = true;
            this.lblTituloEncargado.ForeColor = System.Drawing.Color.White;
            this.lblTituloEncargado.Location = new System.Drawing.Point(852, 227);
            this.lblTituloEncargado.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTituloEncargado.Name = "lblTituloEncargado";
            this.lblTituloEncargado.Size = new System.Drawing.Size(240, 25);
            this.lblTituloEncargado.TabIndex = 10;
            this.lblTituloEncargado.Text = "Encargado(a) del Curso";
            // 
            // lblInformacionEncargada
            // 
            this.lblInformacionEncargada.ForeColor = System.Drawing.Color.White;
            this.lblInformacionEncargada.Location = new System.Drawing.Point(1092, 300);
            this.lblInformacionEncargada.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblInformacionEncargada.Name = "lblInformacionEncargada";
            this.lblInformacionEncargada.Size = new System.Drawing.Size(474, 65);
            this.lblInformacionEncargada.TabIndex = 11;
            this.lblInformacionEncargada.Text = "Caballera Mellanois\nEducación: Abogada Penalista";
            // 
            // txtBoxFechaIni
            // 
            this.txtBoxFechaIni.Location = new System.Drawing.Point(432, 258);
            this.txtBoxFechaIni.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxFechaIni.Name = "txtBoxFechaIni";
            this.txtBoxFechaIni.Size = new System.Drawing.Size(196, 31);
            this.txtBoxFechaIni.TabIndex = 6;
            // 
            // txtBoxFechaFin
            // 
            this.txtBoxFechaFin.Location = new System.Drawing.Point(432, 323);
            this.txtBoxFechaFin.Margin = new System.Windows.Forms.Padding(6);
            this.txtBoxFechaFin.Name = "txtBoxFechaFin";
            this.txtBoxFechaFin.Size = new System.Drawing.Size(196, 31);
            this.txtBoxFechaFin.TabIndex = 7;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.ForeColor = System.Drawing.Color.White;
            this.lblMes.Location = new System.Drawing.Point(466, 483);
            this.lblMes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(129, 25);
            this.lblMes.TabIndex = 17;
            this.lblMes.Text = "MAYO 2021";
            // 
            // lblNumeroModulo
            // 
            this.lblNumeroModulo.AutoSize = true;
            this.lblNumeroModulo.ForeColor = System.Drawing.Color.White;
            this.lblNumeroModulo.Location = new System.Drawing.Point(130, 81);
            this.lblNumeroModulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumeroModulo.Name = "lblNumeroModulo";
            this.lblNumeroModulo.Size = new System.Drawing.Size(101, 25);
            this.lblNumeroModulo.TabIndex = 3;
            this.lblNumeroModulo.Text = "Modulo 1";
            // 
            // lblTituloGeneral
            // 
            this.lblTituloGeneral.AutoSize = true;
            this.lblTituloGeneral.ForeColor = System.Drawing.Color.White;
            this.lblTituloGeneral.Location = new System.Drawing.Point(122, 144);
            this.lblTituloGeneral.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTituloGeneral.Name = "lblTituloGeneral";
            this.lblTituloGeneral.Size = new System.Drawing.Size(221, 25);
            this.lblTituloGeneral.TabIndex = 2;
            this.lblTituloGeneral.Text = "Información del Curso";
            // 
            // lblNombreModulo
            // 
            this.lblNombreModulo.AutoSize = true;
            this.lblNombreModulo.ForeColor = System.Drawing.Color.White;
            this.lblNombreModulo.Location = new System.Drawing.Point(234, 202);
            this.lblNombreModulo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombreModulo.Name = "lblNombreModulo";
            this.lblNombreModulo.Size = new System.Drawing.Size(181, 25);
            this.lblNombreModulo.TabIndex = 0;
            this.lblNombreModulo.Text = "Modulo nro1-3.52";
            // 
            // lblFechaIni
            // 
            this.lblFechaIni.AutoSize = true;
            this.lblFechaIni.ForeColor = System.Drawing.Color.White;
            this.lblFechaIni.Location = new System.Drawing.Point(234, 258);
            this.lblFechaIni.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaIni.Name = "lblFechaIni";
            this.lblFechaIni.Size = new System.Drawing.Size(158, 25);
            this.lblFechaIni.TabIndex = 5;
            this.lblFechaIni.Text = "Fecha de Inicio";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.ForeColor = System.Drawing.Color.White;
            this.lblFechaFin.Location = new System.Drawing.Point(234, 323);
            this.lblFechaFin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(138, 25);
            this.lblFechaFin.TabIndex = 4;
            this.lblFechaFin.Text = "Fecha de Fin";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.ForeColor = System.Drawing.Color.White;
            this.lblHorario.Location = new System.Drawing.Point(130, 483);
            this.lblHorario.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(82, 25);
            this.lblHorario.TabIndex = 14;
            this.lblHorario.Text = "Horario";
            // 
            // pictBoxEncargada
            // 
            this.pictBoxEncargada.Image = global::InterfazDATMA.Properties.Resources.avatarPsicologa;
            this.pictBoxEncargada.Location = new System.Drawing.Point(888, 273);
            this.pictBoxEncargada.Margin = new System.Windows.Forms.Padding(6);
            this.pictBoxEncargada.Name = "pictBoxEncargada";
            this.pictBoxEncargada.Size = new System.Drawing.Size(156, 115);
            this.pictBoxEncargada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBoxEncargada.TabIndex = 12;
            this.pictBoxEncargada.TabStop = false;
            // 
            // btnAnterior
            // 
            this.btnAnterior.AutoSize = true;
            this.btnAnterior.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnterior.Depth = 0;
            this.btnAnterior.Location = new System.Drawing.Point(240, 483);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnterior.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Primary = false;
            this.btnAnterior.Size = new System.Drawing.Size(147, 36);
            this.btnAnterior.TabIndex = 23;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnSig
            // 
            this.btnSig.AutoSize = true;
            this.btnSig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSig.Depth = 0;
            this.btnSig.Location = new System.Drawing.Point(700, 477);
            this.btnSig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSig.Name = "btnSig";
            this.btnSig.Primary = false;
            this.btnSig.Size = new System.Drawing.Size(152, 36);
            this.btnSig.TabIndex = 24;
            this.btnSig.Text = "Siguiente";
            this.btnSig.UseVisualStyleBackColor = true;
            // 
            // btnVerMas
            // 
            this.btnVerMas.AutoSize = true;
            this.btnVerMas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerMas.Depth = 0;
            this.btnVerMas.Location = new System.Drawing.Point(268, 75);
            this.btnVerMas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerMas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerMas.Name = "btnVerMas";
            this.btnVerMas.Primary = false;
            this.btnVerMas.Size = new System.Drawing.Size(133, 36);
            this.btnVerMas.TabIndex = 25;
            this.btnVerMas.Text = "Ver Mas";
            this.btnVerMas.UseVisualStyleBackColor = true;
            this.btnVerMas.Click += new System.EventHandler(this.btnVerMas_Click);
            // 
            // frmInformacionCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1744, 1125);
            this.ControlBox = false;
            this.Controls.Add(this.btnVerMas);
            this.Controls.Add(this.btnSig);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.dgvInfCurso);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.pictBoxEncargada);
            this.Controls.Add(this.lblInformacionEncargada);
            this.Controls.Add(this.lblTituloEncargado);
            this.Controls.Add(this.lblDescripcionCurso);
            this.Controls.Add(this.lblTituloDescripcion);
            this.Controls.Add(this.txtBoxFechaFin);
            this.Controls.Add(this.txtBoxFechaIni);
            this.Controls.Add(this.lblFechaIni);
            this.Controls.Add(this.lblFechaFin);
            this.Controls.Add(this.lblNumeroModulo);
            this.Controls.Add(this.lblTituloGeneral);
            this.Controls.Add(this.lblNombreModulo);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmInformacionCurso";
            this.Text = "Informacion del Curso";
            this.Load += new System.EventHandler(this.frmInformacionCurso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxEncargada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraIni;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoActividad;
        private System.Windows.Forms.DataGridView dgvInfCurso;
        private System.Windows.Forms.Label lblTituloDescripcion;
        private System.Windows.Forms.Label lblDescripcionCurso;
        private System.Windows.Forms.Label lblTituloEncargado;
        private System.Windows.Forms.Label lblInformacionEncargada;
        private System.Windows.Forms.PictureBox pictBoxEncargada;
        private System.Windows.Forms.TextBox txtBoxFechaIni;
        private System.Windows.Forms.TextBox txtBoxFechaFin;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblNumeroModulo;
        private System.Windows.Forms.Label lblTituloGeneral;
        private System.Windows.Forms.Label lblNombreModulo;
        private System.Windows.Forms.Label lblFechaIni;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblHorario;
        private MaterialSkin.Controls.MaterialFlatButton btnAnterior;
        private MaterialSkin.Controls.MaterialFlatButton btnSig;
        private MaterialSkin.Controls.MaterialFlatButton btnVerMas;
    }
}