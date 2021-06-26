
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTutores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.btnRegresar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregarGrupo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnQuitarGrupo = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupos
            // 
            this.dgvGrupos.AllowUserToAddRows = false;
            this.dgvGrupos.AllowUserToDeleteRows = false;
            this.dgvGrupos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.MaxTutores});
            this.dgvGrupos.EnableHeadersVisualStyles = false;
            this.dgvGrupos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvGrupos.Location = new System.Drawing.Point(81, 230);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvGrupos.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGrupos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvGrupos.RowTemplate.Height = 28;
            this.dgvGrupos.Size = new System.Drawing.Size(840, 510);
            this.dgvGrupos.TabIndex = 19;
            this.dgvGrupos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCursos_CellFormatting);
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
            this.MaxTutores.HeaderText = "Cantidad Max. de Tutores";
            this.MaxTutores.MinimumWidth = 8;
            this.MaxTutores.Name = "MaxTutores";
            this.MaxTutores.ReadOnly = true;
            this.MaxTutores.Width = 150;
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(74, 148);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(244, 37);
            this.lblTutoresUser.TabIndex = 20;
            this.lblTutoresUser.Text = "Grupos Activos:";
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = true;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Location = new System.Drawing.Point(974, 733);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = false;
            this.btnRegresar.Size = new System.Drawing.Size(116, 36);
            this.btnRegresar.TabIndex = 25;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Depth = 0;
            this.btnModificar.Location = new System.Drawing.Point(798, 177);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Primary = false;
            this.btnModificar.Size = new System.Drawing.Size(123, 36);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // btnAgregarGrupo
            // 
            this.btnAgregarGrupo.AutoSize = true;
            this.btnAgregarGrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarGrupo.Depth = 0;
            this.btnAgregarGrupo.Location = new System.Drawing.Point(947, 230);
            this.btnAgregarGrupo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAgregarGrupo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarGrupo.Name = "btnAgregarGrupo";
            this.btnAgregarGrupo.Primary = false;
            this.btnAgregarGrupo.Size = new System.Drawing.Size(26, 36);
            this.btnAgregarGrupo.TabIndex = 27;
            this.btnAgregarGrupo.Text = "+";
            this.btnAgregarGrupo.UseVisualStyleBackColor = true;
            this.btnAgregarGrupo.Click += new System.EventHandler(this.btnAgregarGrupo_Click_1);
            // 
            // btnQuitarGrupo
            // 
            this.btnQuitarGrupo.AutoSize = true;
            this.btnQuitarGrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnQuitarGrupo.Depth = 0;
            this.btnQuitarGrupo.Location = new System.Drawing.Point(947, 289);
            this.btnQuitarGrupo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnQuitarGrupo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnQuitarGrupo.Name = "btnQuitarGrupo";
            this.btnQuitarGrupo.Primary = false;
            this.btnQuitarGrupo.Size = new System.Drawing.Size(21, 36);
            this.btnQuitarGrupo.TabIndex = 28;
            this.btnQuitarGrupo.Text = "-";
            this.btnQuitarGrupo.UseVisualStyleBackColor = true;
            this.btnQuitarGrupo.Click += new System.EventHandler(this.btnQuitarGrupo_Click);
            // 
            // frmVerGruposCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitarGrupo);
            this.Controls.Add(this.btnAgregarGrupo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTutoresUser);
            this.Controls.Add(this.dgvGrupos);
            this.Name = "frmVerGruposCurso";
            this.Sizable = false;
            this.Text = "Grupos de Curso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupos;
        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTutores;
        private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
        private MaterialSkin.Controls.MaterialFlatButton btnModificar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarGrupo;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarGrupo;
    }
}