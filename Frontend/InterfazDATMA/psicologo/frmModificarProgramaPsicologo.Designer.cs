﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTema = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSemana = new System.Windows.Forms.Label();
            this.rtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.rtxtTema = new System.Windows.Forms.RichTextBox();
            this.dgvReuniones = new System.Windows.Forms.DataGridView();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnirseReunion = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEditarDescrip = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminarReunion = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregarReunion = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAsitencia = new MaterialSkin.Controls.MaterialFlatButton();
            this.bntConfigurarTiempo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReuniones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTema
            // 
            this.lblTema.AutoSize = true;
            this.lblTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTema.ForeColor = System.Drawing.Color.White;
            this.lblTema.Location = new System.Drawing.Point(103, 91);
            this.lblTema.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTema.Name = "lblTema";
            this.lblTema.Size = new System.Drawing.Size(682, 63);
            this.lblTema.TabIndex = 0;
            this.lblTema.Text = "Programa: Que aprenderás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblSemana.ForeColor = System.Drawing.Color.White;
            this.lblSemana.Location = new System.Drawing.Point(189, 180);
            this.lblSemana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(173, 46);
            this.lblSemana.TabIndex = 2;
            this.lblSemana.Text = "Nombre:";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.rtxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxtDescripcion.ForeColor = System.Drawing.Color.White;
            this.rtxtDescripcion.Location = new System.Drawing.Point(396, 240);
            this.rtxtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(933, 128);
            this.rtxtDescripcion.TabIndex = 5;
            this.rtxtDescripcion.Text = "Texto de Prueba";
            // 
            // rtxtTema
            // 
            this.rtxtTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.rtxtTema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rtxtTema.ForeColor = System.Drawing.Color.White;
            this.rtxtTema.Location = new System.Drawing.Point(396, 180);
            this.rtxtTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxtTema.Name = "rtxtTema";
            this.rtxtTema.Size = new System.Drawing.Size(704, 52);
            this.rtxtTema.TabIndex = 6;
            this.rtxtTema.Text = "Introduccion";
            // 
            // dgvReuniones
            // 
            this.dgvReuniones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvReuniones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReuniones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReuniones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvReuniones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReuniones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.HoraInicio,
            this.HoraFin,
            this.UnirseReunion});
            this.dgvReuniones.EnableHeadersVisualStyles = false;
            this.dgvReuniones.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvReuniones.Location = new System.Drawing.Point(144, 490);
            this.dgvReuniones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvReuniones.Name = "dgvReuniones";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReuniones.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvReuniones.RowHeadersWidth = 62;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            this.dgvReuniones.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dgvReuniones.RowTemplate.Height = 28;
            this.dgvReuniones.Size = new System.Drawing.Size(1364, 382);
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
            this.label4.Location = new System.Drawing.Point(333, 515);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(151, 424);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 46);
            this.label5.TabIndex = 12;
            this.label5.Text = "Reuniones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(120, 235);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 46);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descripcion:";
            // 
            // btnEditarDescrip
            // 
            this.btnEditarDescrip.AutoSize = true;
            this.btnEditarDescrip.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarDescrip.Depth = 0;
            this.btnEditarDescrip.Location = new System.Drawing.Point(1395, 245);
            this.btnEditarDescrip.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarDescrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarDescrip.Name = "btnEditarDescrip";
            this.btnEditarDescrip.Primary = false;
            this.btnEditarDescrip.Size = new System.Drawing.Size(110, 36);
            this.btnEditarDescrip.TabIndex = 23;
            this.btnEditarDescrip.Text = "Editar";
            this.btnEditarDescrip.UseVisualStyleBackColor = true;
            this.btnEditarDescrip.Click += new System.EventHandler(this.btnEditarDescrip_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(1395, 297);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = false;
            this.btnGuardar.Size = new System.Drawing.Size(142, 36);
            this.btnGuardar.TabIndex = 24;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminarReunion
            // 
            this.btnEliminarReunion.AutoSize = true;
            this.btnEliminarReunion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarReunion.Depth = 0;
            this.btnEliminarReunion.Location = new System.Drawing.Point(1542, 538);
            this.btnEliminarReunion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarReunion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarReunion.Name = "btnEliminarReunion";
            this.btnEliminarReunion.Primary = false;
            this.btnEliminarReunion.Size = new System.Drawing.Size(25, 36);
            this.btnEliminarReunion.TabIndex = 25;
            this.btnEliminarReunion.Text = "-";
            this.btnEliminarReunion.UseVisualStyleBackColor = true;
            this.btnEliminarReunion.Click += new System.EventHandler(this.btnEliminarReunion_Click);
            // 
            // btnAgregarReunion
            // 
            this.btnAgregarReunion.AutoSize = true;
            this.btnAgregarReunion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarReunion.Depth = 0;
            this.btnAgregarReunion.Location = new System.Drawing.Point(1542, 490);
            this.btnAgregarReunion.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarReunion.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarReunion.Name = "btnAgregarReunion";
            this.btnAgregarReunion.Primary = false;
            this.btnAgregarReunion.Size = new System.Drawing.Size(32, 36);
            this.btnAgregarReunion.TabIndex = 26;
            this.btnAgregarReunion.Text = "+";
            this.btnAgregarReunion.UseVisualStyleBackColor = true;
            this.btnAgregarReunion.Click += new System.EventHandler(this.btnAgregarReunion_Click);
            // 
            // btnAsitencia
            // 
            this.btnAsitencia.AutoSize = true;
            this.btnAsitencia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAsitencia.Depth = 0;
            this.btnAsitencia.Location = new System.Drawing.Point(144, 952);
            this.btnAsitencia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAsitencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsitencia.Name = "btnAsitencia";
            this.btnAsitencia.Primary = false;
            this.btnAsitencia.Size = new System.Drawing.Size(171, 36);
            this.btnAsitencia.TabIndex = 27;
            this.btnAsitencia.Text = "Asistencia";
            this.btnAsitencia.UseVisualStyleBackColor = true;
            this.btnAsitencia.Click += new System.EventHandler(this.btnAsitencia_Click);
            // 
            // bntConfigurarTiempo
            // 
            this.bntConfigurarTiempo.AutoSize = true;
            this.bntConfigurarTiempo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bntConfigurarTiempo.Depth = 0;
            this.bntConfigurarTiempo.Location = new System.Drawing.Point(1172, 930);
            this.bntConfigurarTiempo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.bntConfigurarTiempo.MouseState = MaterialSkin.MouseState.HOVER;
            this.bntConfigurarTiempo.Name = "bntConfigurarTiempo";
            this.bntConfigurarTiempo.Primary = false;
            this.bntConfigurarTiempo.Size = new System.Drawing.Size(110, 36);
            this.bntConfigurarTiempo.TabIndex = 28;
            this.bntConfigurarTiempo.Text = "Editar";
            this.bntConfigurarTiempo.UseVisualStyleBackColor = true;
            this.bntConfigurarTiempo.Click += new System.EventHandler(this.bntConfigurarTiempo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = true;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Location = new System.Drawing.Point(1172, 1023);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = false;
            this.btnRegresar.Size = new System.Drawing.Size(152, 36);
            this.btnRegresar.TabIndex = 29;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // frmModificarPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1744, 1125);
            this.ControlBox = false;
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.bntConfigurarTiempo);
            this.Controls.Add(this.btnAsitencia);
            this.Controls.Add(this.btnAgregarReunion);
            this.Controls.Add(this.btnEliminarReunion);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEditarDescrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvReuniones);
            this.Controls.Add(this.rtxtTema);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTema);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmModificarPrograma";
            this.Sizable = false;
            this.Text = "frmModificarPrograma";
            this.Load += new System.EventHandler(this.frmModificarPrograma_Load);
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
        private System.Windows.Forms.DataGridView dgvReuniones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DataGridViewLinkColumn UnirseReunion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialFlatButton btnEditarDescrip;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminarReunion;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarReunion;
        private MaterialSkin.Controls.MaterialFlatButton btnAsitencia;
        private MaterialSkin.Controls.MaterialFlatButton bntConfigurarTiempo;
        private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
    }
}