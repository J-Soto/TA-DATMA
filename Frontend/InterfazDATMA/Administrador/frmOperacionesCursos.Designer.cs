
namespace InterfazDATMA.Administrador
{
    partial class frmOperacionesCursos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantSemanas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.btnInsertarCurso = new MaterialSkin.Controls.MaterialButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarCurso = new MaterialSkin.Controls.MaterialButton();
            this.btnReporte = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.FechaInicial,
            this.FechaFinal,
            this.FechaInscripcion,
            this.CantSemanas});
            this.dgvCursos.EnableHeadersVisualStyles = false;
            this.dgvCursos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCursos.Location = new System.Drawing.Point(132, 73);
            this.dgvCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCursos.RowHeadersWidth = 62;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCursos.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCursos.RowTemplate.Height = 28;
            this.dgvCursos.Size = new System.Drawing.Size(648, 330);
            this.dgvCursos.TabIndex = 19;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 280;
            // 
            // FechaInicial
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaInicial.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaInicial.HeaderText = "FechaInicial";
            this.FechaInicial.MinimumWidth = 8;
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.ReadOnly = true;
            this.FechaInicial.Width = 150;
            // 
            // FechaFinal
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.FechaFinal.DefaultCellStyle = dataGridViewCellStyle3;
            this.FechaFinal.HeaderText = "Fecha Final";
            this.FechaFinal.MinimumWidth = 8;
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.ReadOnly = true;
            this.FechaFinal.Width = 150;
            // 
            // FechaInscripcion
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.FechaInscripcion.DefaultCellStyle = dataGridViewCellStyle4;
            this.FechaInscripcion.HeaderText = "Fecha Inscripcion";
            this.FechaInscripcion.MinimumWidth = 8;
            this.FechaInscripcion.Name = "FechaInscripcion";
            this.FechaInscripcion.ReadOnly = true;
            this.FechaInscripcion.Width = 150;
            // 
            // CantSemanas
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CantSemanas.DefaultCellStyle = dataGridViewCellStyle5;
            this.CantSemanas.HeaderText = "Cant. Semanas";
            this.CantSemanas.MinimumWidth = 8;
            this.CantSemanas.Name = "CantSemanas";
            this.CantSemanas.ReadOnly = true;
            this.CantSemanas.Width = 70;
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(126, 30);
            this.lblTutoresUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(257, 31);
            this.lblTutoresUser.TabIndex = 20;
            this.lblTutoresUser.Text = "Cursos Disponibles:";
            // 
            // btnInsertarCurso
            // 
            this.btnInsertarCurso.AutoSize = false;
            this.btnInsertarCurso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertarCurso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsertarCurso.Depth = 0;
            this.btnInsertarCurso.HighEmphasis = true;
            this.btnInsertarCurso.Icon = null;
            this.btnInsertarCurso.Location = new System.Drawing.Point(814, 73);
            this.btnInsertarCurso.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnInsertarCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertarCurso.Name = "btnInsertarCurso";
            this.btnInsertarCurso.Size = new System.Drawing.Size(106, 29);
            this.btnInsertarCurso.TabIndex = 21;
            this.btnInsertarCurso.Text = "Insertar Curso";
            this.btnInsertarCurso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInsertarCurso.UseAccentColor = false;
            this.btnInsertarCurso.UseVisualStyleBackColor = true;
            this.btnInsertarCurso.Click += new System.EventHandler(this.btnInsertarCurso_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = false;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.HighEmphasis = true;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(814, 374);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(106, 29);
            this.btnRegresar.TabIndex = 22;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegresar.UseAccentColor = false;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnEliminarCurso
            // 
            this.btnEliminarCurso.AutoSize = false;
            this.btnEliminarCurso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarCurso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarCurso.Depth = 0;
            this.btnEliminarCurso.HighEmphasis = true;
            this.btnEliminarCurso.Icon = null;
            this.btnEliminarCurso.Location = new System.Drawing.Point(814, 108);
            this.btnEliminarCurso.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEliminarCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarCurso.Name = "btnEliminarCurso";
            this.btnEliminarCurso.Size = new System.Drawing.Size(106, 29);
            this.btnEliminarCurso.TabIndex = 22;
            this.btnEliminarCurso.Text = "Eliminar Curso";
            this.btnEliminarCurso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarCurso.UseAccentColor = false;
            this.btnEliminarCurso.UseVisualStyleBackColor = true;
            this.btnEliminarCurso.Click += new System.EventHandler(this.btnEliminarCurso_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.AutoSize = false;
            this.btnReporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReporte.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReporte.Depth = 0;
            this.btnReporte.HighEmphasis = true;
            this.btnReporte.Icon = null;
            this.btnReporte.Location = new System.Drawing.Point(814, 326);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReporte.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(106, 29);
            this.btnReporte.TabIndex = 23;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReporte.UseAccentColor = false;
            this.btnReporte.UseVisualStyleBackColor = true;
            // 
            // frmOperacionesCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(977, 505);
            this.ControlBox = false;
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnEliminarCurso);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnInsertarCurso);
            this.Controls.Add(this.lblTutoresUser);
            this.Controls.Add(this.dgvCursos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmOperacionesCursos";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.Sizable = false;
            this.Text = "Operaciones Cursos";
            this.Load += new System.EventHandler(this.frmOperacionesCursos_Load);
            this.VisibleChanged += new System.EventHandler(this.frmOperacionesCursos_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label lblTutoresUser;
        private MaterialSkin.Controls.MaterialButton btnInsertarCurso;
        private MaterialSkin.Controls.MaterialButton btnRegresar;
        private MaterialSkin.Controls.MaterialButton btnEliminarCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantSemanas;
        private MaterialSkin.Controls.MaterialButton btnReporte;
    }
}