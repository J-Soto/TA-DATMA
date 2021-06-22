
namespace InterfazDATMA
{
    partial class frmModificarPrograma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTema = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSemana = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.rtxtTema = new System.Windows.Forms.RichTextBox();
            this.btnEditarDescrip = new System.Windows.Forms.Button();
            this.dgvReuniones = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnirseReunion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAsitencia = new System.Windows.Forms.Button();
            this.bntConfigurarTiempo = new System.Windows.Forms.Button();
            this.btnAgregarReunion = new System.Windows.Forms.Button();
            this.btnEliminarReunion = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReuniones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTema.ForeColor = System.Drawing.Color.White;
            this.lblTema.Location = new System.Drawing.Point(77, 73);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(503, 46);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Programa: Que aprenderás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSemana.ForeColor = System.Drawing.Color.White;
            this.lblSemana.Location = new System.Drawing.Point(142, 144);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(128, 36);
            this.lblSemana.TabIndex = 2;
            this.lblSemana.Text = "Nombre:";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.rtxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxtDescripcion.ForeColor = System.Drawing.Color.White;
            this.rtxtDescripcion.Location = new System.Drawing.Point(297, 192);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(700, 102);
            this.rtxtDescripcion.TabIndex = 5;
            this.rtxtDescripcion.Text = "Texto de Prueba";
            // 
            // rtxtTema
            // 
            this.rtxtTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.rtxtTema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rtxtTema.ForeColor = System.Drawing.Color.White;
            this.rtxtTema.Location = new System.Drawing.Point(297, 144);
            this.rtxtTema.Name = "rtxtTema";
            this.rtxtTema.Size = new System.Drawing.Size(528, 42);
            this.rtxtTema.TabIndex = 6;
            this.rtxtTema.Text = "Introduccion";
            // 
            // btnEditarDescrip
            // 
            this.btnEditarDescrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnEditarDescrip.FlatAppearance.BorderSize = 0;
            this.btnEditarDescrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarDescrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditarDescrip.ForeColor = System.Drawing.Color.White;
            this.btnEditarDescrip.Location = new System.Drawing.Point(1044, 181);
            this.btnEditarDescrip.Name = "btnEditarDescrip";
            this.btnEditarDescrip.Size = new System.Drawing.Size(168, 34);
            this.btnEditarDescrip.TabIndex = 7;
            this.btnEditarDescrip.Text = "Editar";
            this.btnEditarDescrip.UseVisualStyleBackColor = false;
            this.btnEditarDescrip.Click += new System.EventHandler(this.btnEditarDescrip_Click);
            // 
            // dgvReuniones
            // 
            this.dgvReuniones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvReuniones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReuniones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReuniones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReuniones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReuniones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.HoraInicio,
            this.HoraFin,
            this.UnirseReunion});
            this.dgvReuniones.EnableHeadersVisualStyles = false;
            this.dgvReuniones.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReuniones.Location = new System.Drawing.Point(108, 392);
            this.dgvReuniones.Name = "dgvReuniones";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReuniones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReuniones.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReuniones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReuniones.RowTemplate.Height = 28;
            this.dgvReuniones.Size = new System.Drawing.Size(1023, 306);
            this.dgvReuniones.TabIndex = 8;
            this.dgvReuniones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReuniones_CellContentClick);
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 8;
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 150;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.MinimumWidth = 8;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.Width = 150;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.MinimumWidth = 8;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.Width = 150;
            // 
            // UnirseReunion
            // 
            this.UnirseReunion.HeaderText = "Unirse Reunion";
            this.UnirseReunion.MinimumWidth = 8;
            this.UnirseReunion.Name = "UnirseReunion";
            this.UnirseReunion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnirseReunion.Width = 150;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(113, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reuniones:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1044, 221);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(168, 34);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAsitencia
            // 
            this.btnAsitencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAsitencia.FlatAppearance.BorderSize = 0;
            this.btnAsitencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsitencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAsitencia.ForeColor = System.Drawing.Color.White;
            this.btnAsitencia.Location = new System.Drawing.Point(108, 714);
            this.btnAsitencia.Name = "btnAsitencia";
            this.btnAsitencia.Size = new System.Drawing.Size(172, 40);
            this.btnAsitencia.TabIndex = 14;
            this.btnAsitencia.Text = "Asistencia";
            this.btnAsitencia.UseVisualStyleBackColor = false;
            this.btnAsitencia.Click += new System.EventHandler(this.btnAsitencia_Click);
            // 
            // bntConfigurarTiempo
            // 
            this.bntConfigurarTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.bntConfigurarTiempo.FlatAppearance.BorderSize = 0;
            this.bntConfigurarTiempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntConfigurarTiempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bntConfigurarTiempo.ForeColor = System.Drawing.Color.White;
            this.bntConfigurarTiempo.Location = new System.Drawing.Point(959, 714);
            this.bntConfigurarTiempo.Name = "bntConfigurarTiempo";
            this.bntConfigurarTiempo.Size = new System.Drawing.Size(172, 40);
            this.bntConfigurarTiempo.TabIndex = 15;
            this.bntConfigurarTiempo.Text = "Editar";
            this.bntConfigurarTiempo.UseVisualStyleBackColor = false;
            // 
            // btnAgregarReunion
            // 
            this.btnAgregarReunion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAgregarReunion.FlatAppearance.BorderSize = 0;
            this.btnAgregarReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarReunion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarReunion.Location = new System.Drawing.Point(1159, 392);
            this.btnAgregarReunion.Name = "btnAgregarReunion";
            this.btnAgregarReunion.Size = new System.Drawing.Size(40, 40);
            this.btnAgregarReunion.TabIndex = 16;
            this.btnAgregarReunion.Text = "+";
            this.btnAgregarReunion.UseVisualStyleBackColor = false;
            this.btnAgregarReunion.Click += new System.EventHandler(this.btnAgregarReunion_Click);
            // 
            // btnEliminarReunion
            // 
            this.btnEliminarReunion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnEliminarReunion.FlatAppearance.BorderSize = 0;
            this.btnEliminarReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminarReunion.ForeColor = System.Drawing.Color.White;
            this.btnEliminarReunion.Location = new System.Drawing.Point(1159, 438);
            this.btnEliminarReunion.Name = "btnEliminarReunion";
            this.btnEliminarReunion.Size = new System.Drawing.Size(40, 40);
            this.btnEliminarReunion.TabIndex = 17;
            this.btnEliminarReunion.Text = "-";
            this.btnEliminarReunion.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(959, 803);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(90, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 36);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descripcion:";
            // 
            // frmModificarPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1308, 900);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminarReunion);
            this.Controls.Add(this.btnAgregarReunion);
            this.Controls.Add(this.bntConfigurarTiempo);
            this.Controls.Add(this.btnAsitencia);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvReuniones);
            this.Controls.Add(this.btnEditarDescrip);
            this.Controls.Add(this.rtxtTema);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTema);
            this.Name = "frmModificarPrograma";
            this.Sizable = false;
            this.Text = "frmModificarPrograma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReuniones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTema;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSemana;
        private System.Windows.Forms.RichTextBox rtxtDescripcion;
        private System.Windows.Forms.RichTextBox rtxtTema;
        private System.Windows.Forms.Button btnEditarDescrip;
        private System.Windows.Forms.DataGridView dgvReuniones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewLinkColumn UnirseReunion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAsitencia;
        private System.Windows.Forms.Button bntConfigurarTiempo;
        private System.Windows.Forms.Button btnAgregarReunion;
        private System.Windows.Forms.Button btnEliminarReunion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}