
namespace InterfazDATMA
{
    partial class frmDetalleCursoInscrito
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
            this.btnRegresar = new MaterialSkin.Controls.MaterialButton();
            this.dgvSemanas = new System.Windows.Forms.DataGridView();
            this.txtNombreCurso = new MaterialSkin.Controls.MaterialLabel();
            this.txtSemanaDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtSemana = new MaterialSkin.Controls.MaterialLabel();
            this.Semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.HighEmphasis = true;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(765, 25);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(94, 36);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegresar.UseAccentColor = false;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgvSemanas
            // 
            this.dgvSemanas.AllowUserToAddRows = false;
            this.dgvSemanas.AllowUserToDeleteRows = false;
            this.dgvSemanas.AllowUserToResizeColumns = false;
            this.dgvSemanas.AllowUserToResizeRows = false;
            this.dgvSemanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemanas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semana});
            this.dgvSemanas.Location = new System.Drawing.Point(31, 128);
            this.dgvSemanas.MultiSelect = false;
            this.dgvSemanas.Name = "dgvSemanas";
            this.dgvSemanas.ReadOnly = true;
            this.dgvSemanas.RowHeadersVisible = false;
            this.dgvSemanas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSemanas.Size = new System.Drawing.Size(230, 230);
            this.dgvSemanas.TabIndex = 1;
            this.dgvSemanas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSemanas_CellClick);
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.AutoSize = true;
            this.txtNombreCurso.BackColor = System.Drawing.Color.White;
            this.txtNombreCurso.Depth = 0;
            this.txtNombreCurso.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCurso.Location = new System.Drawing.Point(28, 25);
            this.txtNombreCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(50, 19);
            this.txtNombreCurso.TabIndex = 2;
            this.txtNombreCurso.Text = "Curso: ";
            // 
            // txtSemanaDescripcion
            // 
            this.txtSemanaDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSemanaDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSemanaDescripcion.Depth = 0;
            this.txtSemanaDescripcion.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSemanaDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSemanaDescripcion.Location = new System.Drawing.Point(335, 128);
            this.txtSemanaDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSemanaDescripcion.Name = "txtSemanaDescripcion";
            this.txtSemanaDescripcion.ReadOnly = true;
            this.txtSemanaDescripcion.Size = new System.Drawing.Size(609, 297);
            this.txtSemanaDescripcion.TabIndex = 3;
            this.txtSemanaDescripcion.Text = "";
            // 
            // txtSemana
            // 
            this.txtSemana.AutoSize = true;
            this.txtSemana.BackColor = System.Drawing.Color.White;
            this.txtSemana.Depth = 0;
            this.txtSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSemana.Location = new System.Drawing.Point(26, 87);
            this.txtSemana.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(60, 19);
            this.txtSemana.TabIndex = 4;
            this.txtSemana.Text = "Semana";
            // 
            // Semana
            // 
            this.Semana.DataPropertyName = "nombre";
            this.Semana.HeaderText = "Nombre";
            this.Semana.Name = "Semana";
            this.Semana.ReadOnly = true;
            this.Semana.Width = 227;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(31, 452);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(230, 230);
            this.dataGridView1.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 227;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(31, 405);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(67, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Actividad";
            // 
            // frmDetalleCursoInscrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1031, 708);
            this.ControlBox = false;
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSemana);
            this.Controls.Add(this.txtSemanaDescripcion);
            this.Controls.Add(this.txtNombreCurso);
            this.Controls.Add(this.dgvSemanas);
            this.Controls.Add(this.btnRegresar);
            this.Name = "frmDetalleCursoInscrito";
            this.Padding = new System.Windows.Forms.Padding(2, 33, 2, 2);
            this.Text = "DATMA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnRegresar;
        private System.Windows.Forms.DataGridView dgvSemanas;
        private MaterialSkin.Controls.MaterialLabel txtNombreCurso;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtSemanaDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semana;
        private MaterialSkin.Controls.MaterialLabel txtSemana;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}