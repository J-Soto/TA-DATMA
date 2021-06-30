
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvGrupos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTutores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.btnRegresar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregarGrupo = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnQuitarGrupo = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblNombreCurso = new System.Windows.Forms.Label();
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
            this.dgvGrupos.Location = new System.Drawing.Point(125, 290);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrupos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrupos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvGrupos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGrupos.RowTemplate.Height = 28;
            this.dgvGrupos.Size = new System.Drawing.Size(923, 533);
            this.dgvGrupos.TabIndex = 19;
            this.dgvGrupos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCursos_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
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
            this.lblTutoresUser.Location = new System.Drawing.Point(118, 220);
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
            this.btnRegresar.Location = new System.Drawing.Point(1132, 787);
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
            this.btnModificar.Location = new System.Drawing.Point(925, 225);
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
            this.btnAgregarGrupo.Location = new System.Drawing.Point(1063, 300);
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
            this.btnQuitarGrupo.Location = new System.Drawing.Point(1063, 346);
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
            // lblNombreCurso
            // 
            this.lblNombreCurso.AutoSize = true;
            this.lblNombreCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblNombreCurso.ForeColor = System.Drawing.Color.White;
            this.lblNombreCurso.Location = new System.Drawing.Point(81, 124);
            this.lblNombreCurso.Name = "lblNombreCurso";
            this.lblNombreCurso.Size = new System.Drawing.Size(108, 39);
            this.lblNombreCurso.TabIndex = 30;
            this.lblNombreCurso.Text = "Curso";
            // 
            // frmVerGruposCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1320, 911);
            this.ControlBox = false;
            this.Controls.Add(this.lblNombreCurso);
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
        private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
        private MaterialSkin.Controls.MaterialFlatButton btnModificar;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarGrupo;
        private MaterialSkin.Controls.MaterialFlatButton btnQuitarGrupo;
        private System.Windows.Forms.Label lblNombreCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTutores;
    }
}