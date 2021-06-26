
namespace InterfazDATMA.Administrador
{
    partial class frmBuscarCursosRequerimiento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCursosReq = new System.Windows.Forms.DataGridView();
            this.NombreCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSeleccionarCur = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosReq)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCursosReq
            // 
            this.dgvCursosReq.AllowUserToAddRows = false;
            this.dgvCursosReq.AllowUserToDeleteRows = false;
            this.dgvCursosReq.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvCursosReq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursosReq.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursosReq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCursosReq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursosReq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCurso,
            this.FechaInicial,
            this.FechaFinal});
            this.dgvCursosReq.EnableHeadersVisualStyles = false;
            this.dgvCursosReq.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvCursosReq.Location = new System.Drawing.Point(68, 105);
            this.dgvCursosReq.Name = "dgvCursosReq";
            this.dgvCursosReq.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursosReq.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCursosReq.RowHeadersWidth = 62;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCursosReq.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCursosReq.RowTemplate.Height = 28;
            this.dgvCursosReq.Size = new System.Drawing.Size(898, 361);
            this.dgvCursosReq.TabIndex = 29;
            this.dgvCursosReq.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCursosReq_CellFormatting);
            // 
            // NombreCurso
            // 
            this.NombreCurso.HeaderText = "Nombre";
            this.NombreCurso.MinimumWidth = 8;
            this.NombreCurso.Name = "NombreCurso";
            this.NombreCurso.ReadOnly = true;
            this.NombreCurso.Width = 180;
            // 
            // FechaInicial
            // 
            dataGridViewCellStyle7.Format = "dd/MM/yyyy";
            dataGridViewCellStyle7.NullValue = null;
            this.FechaInicial.DefaultCellStyle = dataGridViewCellStyle7;
            this.FechaInicial.HeaderText = "Fecha Inicio";
            this.FechaInicial.MinimumWidth = 8;
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.ReadOnly = true;
            this.FechaInicial.Width = 150;
            // 
            // FechaFinal
            // 
            dataGridViewCellStyle8.Format = "dd/MM/yyyy";
            dataGridViewCellStyle8.NullValue = null;
            this.FechaFinal.DefaultCellStyle = dataGridViewCellStyle8;
            this.FechaFinal.HeaderText = "Fecha Fin";
            this.FechaFinal.MinimumWidth = 8;
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.ReadOnly = true;
            this.FechaFinal.Width = 150;
            // 
            // btnSeleccionarCur
            // 
            this.btnSeleccionarCur.AutoSize = true;
            this.btnSeleccionarCur.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSeleccionarCur.Depth = 0;
            this.btnSeleccionarCur.Location = new System.Drawing.Point(288, 474);
            this.btnSeleccionarCur.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSeleccionarCur.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSeleccionarCur.Name = "btnSeleccionarCur";
            this.btnSeleccionarCur.Primary = false;
            this.btnSeleccionarCur.Size = new System.Drawing.Size(149, 36);
            this.btnSeleccionarCur.TabIndex = 32;
            this.btnSeleccionarCur.Text = "Seleccionar";
            this.btnSeleccionarCur.UseVisualStyleBackColor = true;
            this.btnSeleccionarCur.Click += new System.EventHandler(this.btnSeleccionarCur_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(620, 474);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(119, 36);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // frmBuscarCursosRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1108, 539);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleccionarCur);
            this.Controls.Add(this.dgvCursosReq);
            this.Name = "frmBuscarCursosRequerimiento";
            this.Sizable = false;
            this.Text = "Buscar Curso Requisito";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursosReq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCursosReq;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFinal;
        private MaterialSkin.Controls.MaterialFlatButton btnSeleccionarCur;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
    }
}