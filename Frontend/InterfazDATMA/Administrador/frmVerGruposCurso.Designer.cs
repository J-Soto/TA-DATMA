
namespace InterfazDATMA.Administrador
{
    partial class frmVerGruposCurso
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModificar = new MaterialSkin.Controls.MaterialButton();
            this.btnAgregarGrupo = new MaterialSkin.Controls.MaterialButton();
            this.btnQuitarGrupo = new MaterialSkin.Controls.MaterialButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialButton();
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.lblNombreCurso = new System.Windows.Forms.Label();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTutores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = false;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificar.Depth = 0;
            this.btnModificar.HighEmphasis = true;
            this.btnModificar.Icon = null;
            this.btnModificar.Location = new System.Drawing.Point(978, 47);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(130, 43);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificar.UseAccentColor = false;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.AutoSize = false;
            this.btnAgregarGrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarGrupo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarGrupo.Depth = 0;
            this.btnAgregarGrupo.HighEmphasis = true;
            this.btnAgregarGrupo.Icon = null;
            this.btnAgregarGrupo.Location = new System.Drawing.Point(1130, 110);
            this.btnAgregarGrupo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregarGrupo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Size = new System.Drawing.Size(45, 46);
            this.btnAgregarGrupo.TabIndex = 32;
            this.btnAgregarGrupo.Text = "+";
            this.btnAgregarGrupo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarGrupo.UseAccentColor = false;
            this.btnAgregarGrupo.UseVisualStyleBackColor = true;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click_1);
            // 
            // btnQuitarGrupo
            // 
            this.btnQuitarGrupo.AutoSize = false;
            this.btnQuitarGrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarGrupo.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnQuitarGrupo.Depth = 0;
            this.btnQuitarGrupo.HighEmphasis = true;
            this.btnQuitarGrupo.Icon = null;
            this.btnQuitarGrupo.Location = new System.Drawing.Point(1130, 183);
            this.btnQuitarGrupo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuitarGrupo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarGrupo.Name = "btnQuitarGrupo";
            this.btnQuitarGrupo.Size = new System.Drawing.Size(45, 44);
            this.btnQuitarGrupo.TabIndex = 33;
            this.btnQuitarGrupo.Text = "-";
            this.btnQuitarGrupo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnQuitarGrupo.UseAccentColor = false;
            this.btnQuitarGrupo.UseVisualStyleBackColor = true;
            this.btnQuitarGrupo.Click += new System.EventHandler(this.btnQuitarGrupo_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = false;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.HighEmphasis = true;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(1130, 569);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(130, 43);
            this.btnRegresar.TabIndex = 34;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegresar.UseAccentColor = false;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(297, 53);
            this.lblTutoresUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(244, 37);
            this.lblTutoresUser.TabIndex = 20;
            this.lblTutoresUser.Text = "Grupos Activos:";
            // 
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblNombreCurso.ForeColor = System.Drawing.Color.White;
            this.lblNombreCurso.Location = new System.Drawing.Point(297, -1);
            this.lblNombreCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(108, 39);
            this.lblNombreCurso.TabIndex = 30;
            this.lblNombreCurso.Text = "Curso";
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AllowUserToAddRows = false;
            this.dgvGrupos.AllowUserToDeleteRows = false;
            this.dgvGrupos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.MaxTutores});
            this.dgvGrupos.EnableHeadersVisualStyles = false;
            this.dgvGrupos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvGrupos.Location = new System.Drawing.Point(349, 110);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGrupos.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGrupos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGrupos.RowTemplate.Height = 28;
            this.dgvGrupos.Size = new System.Drawing.Size(740, 502);
            this.dgvGrupos.TabIndex = 35;
            this.dgvGrupos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvGrupos_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // MaxTutores
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MaxTutores.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaxTutores.HeaderText = "Cantidad Max. de Tutores";
            this.MaxTutores.MinimumWidth = 8;
            this.MaxTutores.Name = "MaxTutores";
            this.MaxTutores.ReadOnly = true;
            this.MaxTutores.Width = 125;
            // 
            // frmVerGruposCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1362, 746);
            this.ControlBox = false;
            this.Controls.Add(this.dgvGrupos);
            this.Controls.Add(this.lblNombreCurso);
            this.Controls.Add(this.btnQuitarGrupo);
            this.Controls.Add(this.btnAgregarGrupo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTutoresUser);
            this.Name = "frmVerGruposCurso";
            this.Sizable = false;
            this.Text = "Grupos de Curso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialButton btnAgregarGrupo;
        private MaterialSkin.Controls.MaterialButton btnQuitarGrupo;
        private MaterialSkin.Controls.MaterialButton btnRegresar;
        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTutores;
    }
}