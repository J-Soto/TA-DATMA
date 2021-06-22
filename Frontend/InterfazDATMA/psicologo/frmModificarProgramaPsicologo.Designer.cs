
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
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
            this.dgvMateriales = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descargar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAsitencia = new System.Windows.Forms.Button();
            this.bntConfigurarTiempo = new System.Windows.Forms.Button();
            this.btnAgregarReunion = new System.Windows.Forms.Button();
            this.btnEliminarReunion = new System.Windows.Forms.Button();
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.btnEliminarMaterial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReuniones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programa: Que aprenderás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(754, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            // 
            // lblSemana
            // 
            this.lblSemana.AutoSize = true;
            this.lblSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblSemana.ForeColor = System.Drawing.Color.White;
            this.lblSemana.Location = new System.Drawing.Point(218, 156);
            this.lblSemana.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSemana.Name = "lblSemana";
            this.lblSemana.Size = new System.Drawing.Size(234, 53);
            this.lblSemana.TabIndex = 2;
            this.lblSemana.Text = "Semana 1";
            // 
            // rtxtDescripcion
            // 
            this.rtxtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.rtxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtxtDescripcion.ForeColor = System.Drawing.Color.White;
            this.rtxtDescripcion.Location = new System.Drawing.Point(226, 244);
            this.rtxtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtDescripcion.Name = "rtxtDescripcion";
            this.rtxtDescripcion.Size = new System.Drawing.Size(972, 127);
            this.rtxtDescripcion.TabIndex = 5;
            this.rtxtDescripcion.Text = "Texto de Prueba";
            // 
            // rtxtTema
            // 
            this.rtxtTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.rtxtTema.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.rtxtTema.ForeColor = System.Drawing.Color.White;
            this.rtxtTema.Location = new System.Drawing.Point(594, 160);
            this.rtxtTema.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtTema.Name = "rtxtTema";
            this.rtxtTema.Size = new System.Drawing.Size(606, 60);
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
            this.btnEditarDescrip.Location = new System.Drawing.Point(1222, 279);
            this.btnEditarDescrip.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarDescrip.Name = "btnEditarDescrip";
            this.btnEditarDescrip.Size = new System.Drawing.Size(224, 42);
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
            this.dgvReuniones.Location = new System.Drawing.Point(226, 490);
            this.dgvReuniones.Margin = new System.Windows.Forms.Padding(4);
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
            this.dgvReuniones.Size = new System.Drawing.Size(1224, 244);
            this.dgvReuniones.TabIndex = 8;
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
            // dgvMateriales
            // 
            this.dgvMateriales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvMateriales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMateriales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Descargar});
            this.dgvMateriales.EnableHeadersVisualStyles = false;
            this.dgvMateriales.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvMateriales.Location = new System.Drawing.Point(226, 879);
            this.dgvMateriales.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMateriales.Name = "dgvMateriales";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMateriales.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMateriales.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvMateriales.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMateriales.RowTemplate.Height = 28;
            this.dgvMateriales.Size = new System.Drawing.Size(972, 212);
            this.dgvMateriales.TabIndex = 9;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 250;
            // 
            // Descargar
            // 
            this.Descargar.HeaderText = "Descargar";
            this.Descargar.MinimumWidth = 8;
            this.Descargar.Name = "Descargar";
            this.Descargar.Width = 170;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(222, 823);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 53);
            this.label3.TabIndex = 10;
            this.label3.Text = "Materiales:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 515);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(222, 435);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 53);
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
            this.btnGuardar.Location = new System.Drawing.Point(1222, 329);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(224, 42);
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
            this.btnAsitencia.Location = new System.Drawing.Point(984, 740);
            this.btnAsitencia.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsitencia.Name = "btnAsitencia";
            this.btnAsitencia.Size = new System.Drawing.Size(230, 50);
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
            this.bntConfigurarTiempo.Location = new System.Drawing.Point(1222, 740);
            this.bntConfigurarTiempo.Margin = new System.Windows.Forms.Padding(4);
            this.bntConfigurarTiempo.Name = "bntConfigurarTiempo";
            this.bntConfigurarTiempo.Size = new System.Drawing.Size(230, 50);
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
            this.btnAgregarReunion.Location = new System.Drawing.Point(1458, 490);
            this.btnAgregarReunion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarReunion.Name = "btnAgregarReunion";
            this.btnAgregarReunion.Size = new System.Drawing.Size(54, 50);
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
            this.btnEliminarReunion.Location = new System.Drawing.Point(1458, 548);
            this.btnEliminarReunion.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarReunion.Name = "btnEliminarReunion";
            this.btnEliminarReunion.Size = new System.Drawing.Size(54, 50);
            this.btnEliminarReunion.TabIndex = 17;
            this.btnEliminarReunion.Text = "-";
            this.btnEliminarReunion.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAgregarMaterial.FlatAppearance.BorderSize = 0;
            this.btnAgregarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAgregarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMaterial.Location = new System.Drawing.Point(1206, 879);
            this.btnAgregarMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(54, 50);
            this.btnAgregarMaterial.TabIndex = 18;
            this.btnAgregarMaterial.Text = "+";
            this.btnAgregarMaterial.UseVisualStyleBackColor = false;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // btnEliminarMaterial
            // 
            this.btnEliminarMaterial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnEliminarMaterial.FlatAppearance.BorderSize = 0;
            this.btnEliminarMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEliminarMaterial.ForeColor = System.Drawing.Color.White;
            this.btnEliminarMaterial.Location = new System.Drawing.Point(1206, 937);
            this.btnEliminarMaterial.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarMaterial.Name = "btnEliminarMaterial";
            this.btnEliminarMaterial.Size = new System.Drawing.Size(54, 50);
            this.btnEliminarMaterial.TabIndex = 19;
            this.btnEliminarMaterial.Text = "-";
            this.btnEliminarMaterial.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1288, 1077);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmModificarPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1744, 1125);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEliminarMaterial);
            this.Controls.Add(this.btnAgregarMaterial);
            this.Controls.Add(this.btnEliminarReunion);
            this.Controls.Add(this.btnAgregarReunion);
            this.Controls.Add(this.bntConfigurarTiempo);
            this.Controls.Add(this.btnAsitencia);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMateriales);
            this.Controls.Add(this.dgvReuniones);
            this.Controls.Add(this.btnEditarDescrip);
            this.Controls.Add(this.rtxtTema);
            this.Controls.Add(this.rtxtDescripcion);
            this.Controls.Add(this.lblSemana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmModificarPrograma";
            this.Sizable = false;
            this.Text = "frmModificarPrograma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReuniones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.DataGridView dgvMateriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewButtonColumn Descargar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAsitencia;
        private System.Windows.Forms.Button bntConfigurarTiempo;
        private System.Windows.Forms.Button btnAgregarReunion;
        private System.Windows.Forms.Button btnEliminarReunion;
        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.Button btnEliminarMaterial;
        private System.Windows.Forms.Button button1;
    }
}