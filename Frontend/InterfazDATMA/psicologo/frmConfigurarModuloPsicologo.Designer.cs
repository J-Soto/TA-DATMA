
namespace InterfazDATMA
{
    partial class frmConfigurarModuloPsicologo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNombreModulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPrograma = new System.Windows.Forms.DataGridView();
            this.Semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListaCuidadores = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInsertarSemana = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificarSemana = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnListaCursos = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograma)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreModulo
            // 
            this.lblNombreModulo.AutoSize = true;
            this.lblNombreModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNombreModulo.ForeColor = System.Drawing.Color.White;
            this.lblNombreModulo.Location = new System.Drawing.Point(84, 130);
            this.lblNombreModulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreModulo.Name = "lblNombreModulo";
            this.lblNombreModulo.Size = new System.Drawing.Size(249, 63);
            this.lblNombreModulo.TabIndex = 0;
            this.lblNombreModulo.Text = "Modulo 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(181, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "Programa:";
            // 
            // dgvPrograma
            // 
            this.dgvPrograma.AllowUserToAddRows = false;
            this.dgvPrograma.AllowUserToDeleteRows = false;
            this.dgvPrograma.AllowUserToResizeColumns = false;
            this.dgvPrograma.AllowUserToResizeRows = false;
            this.dgvPrograma.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPrograma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrograma.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrograma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPrograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrograma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semana,
            this.Tema,
            this.FechaInicio});
            this.dgvPrograma.EnableHeadersVisualStyles = false;
            this.dgvPrograma.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPrograma.Location = new System.Drawing.Point(191, 289);
            this.dgvPrograma.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrograma.Name = "dgvPrograma";
            this.dgvPrograma.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrograma.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvPrograma.RowHeadersWidth = 62;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPrograma.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPrograma.RowTemplate.Height = 28;
            this.dgvPrograma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrograma.Size = new System.Drawing.Size(1395, 606);
            this.dgvPrograma.TabIndex = 9;
            // 
            // Semana
            // 
            this.Semana.DataPropertyName = "NombreSemana";
            this.Semana.HeaderText = "Semana";
            this.Semana.MinimumWidth = 8;
            this.Semana.Name = "Semana";
            this.Semana.ReadOnly = true;
            this.Semana.Width = 193;
            // 
            // Tema
            // 
            this.Tema.DataPropertyName = "NombreTema";
            this.Tema.HeaderText = "Tema";
            this.Tema.MinimumWidth = 8;
            this.Tema.Name = "Tema";
            this.Tema.ReadOnly = true;
            this.Tema.Width = 290;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "dd/MM/yyyy";
            dataGridViewCellStyle14.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle14;
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.MinimumWidth = 8;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            this.FechaInicio.Width = 150;
            // 
            // btnListaCuidadores
            // 
            this.btnListaCuidadores.AutoSize = true;
            this.btnListaCuidadores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListaCuidadores.Depth = 0;
            this.btnListaCuidadores.Location = new System.Drawing.Point(1250, 230);
            this.btnListaCuidadores.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListaCuidadores.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListaCuidadores.Name = "btnListaCuidadores";
            this.btnListaCuidadores.Primary = false;
            this.btnListaCuidadores.Size = new System.Drawing.Size(304, 36);
            this.btnListaCuidadores.TabIndex = 11;
            this.btnListaCuidadores.Text = "Lista de Cuidadores";
            this.btnListaCuidadores.UseVisualStyleBackColor = true;
            this.btnListaCuidadores.Click += new System.EventHandler(this.btnListaCuidadores_Click);
            // 
            // btnInsertarSemana
            // 
            this.btnInsertarSemana.AutoSize = true;
            this.btnInsertarSemana.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertarSemana.Depth = 0;
            this.btnInsertarSemana.Location = new System.Drawing.Point(191, 971);
            this.btnInsertarSemana.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInsertarSemana.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertarSemana.Name = "btnInsertarSemana";
            this.btnInsertarSemana.Primary = false;
            this.btnInsertarSemana.Size = new System.Drawing.Size(264, 36);
            this.btnInsertarSemana.TabIndex = 12;
            this.btnInsertarSemana.Text = "Insertar Semana";
            this.btnInsertarSemana.UseVisualStyleBackColor = true;
            this.btnInsertarSemana.Click += new System.EventHandler(this.btnInsertarSemana_Click);
            // 
            // btnModificarSemana
            // 
            this.btnModificarSemana.AutoSize = true;
            this.btnModificarSemana.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarSemana.Depth = 0;
            this.btnModificarSemana.Location = new System.Drawing.Point(680, 971);
            this.btnModificarSemana.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificarSemana.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarSemana.Name = "btnModificarSemana";
            this.btnModificarSemana.Primary = false;
            this.btnModificarSemana.Size = new System.Drawing.Size(280, 36);
            this.btnModificarSemana.TabIndex = 13;
            this.btnModificarSemana.Text = "Modificar Semana";
            this.btnModificarSemana.UseVisualStyleBackColor = true;
            this.btnModificarSemana.Click += new System.EventHandler(this.btnModificarSemana_Click);
            // 
            // btnListaCursos
            // 
            this.btnListaCursos.AutoSize = true;
            this.btnListaCursos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListaCursos.Depth = 0;
            this.btnListaCursos.Location = new System.Drawing.Point(1250, 1051);
            this.btnListaCursos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListaCursos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListaCursos.Name = "btnListaCursos";
            this.btnListaCursos.Primary = false;
            this.btnListaCursos.Size = new System.Drawing.Size(417, 36);
            this.btnListaCursos.TabIndex = 14;
            this.btnListaCursos.Text = "Volver a la lista de cursos";
            this.btnListaCursos.UseVisualStyleBackColor = true;
            this.btnListaCursos.Click += new System.EventHandler(this.btnListaCursos_Click);
            // 
            // frmConfigurarModuloPsicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1744, 1125);
            this.ControlBox = false;
            this.Controls.Add(this.btnListaCursos);
            this.Controls.Add(this.btnModificarSemana);
            this.Controls.Add(this.btnInsertarSemana);
            this.Controls.Add(this.btnListaCuidadores);
            this.Controls.Add(this.dgvPrograma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombreModulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConfigurarModuloPsicologo";
            this.Sizable = false;
            this.Text = "frmConfigurarModuloPsicologo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreModulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPrograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tema;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private MaterialSkin.Controls.MaterialFlatButton btnListaCuidadores;
        private MaterialSkin.Controls.MaterialFlatButton btnInsertarSemana;
        private MaterialSkin.Controls.MaterialFlatButton btnModificarSemana;
        private MaterialSkin.Controls.MaterialFlatButton btnListaCursos;
    }
}