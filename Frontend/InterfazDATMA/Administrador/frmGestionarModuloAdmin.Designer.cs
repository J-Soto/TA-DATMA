
namespace InterfazDATMA.Administrador
{
    partial class frmGestionarModuloAdmin
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
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.lblPsicologosUser = new System.Windows.Forms.Label();
            this.dgvPsicologos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvTutores = new System.Windows.Forms.DataGridView();
            this.btnOpPersona = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnOpCurso = new MaterialSkin.Controls.MaterialFlatButton();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(29, 137);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(198, 29);
            this.lblTutoresUser.TabIndex = 12;
            this.lblTutoresUser.Text = "Usuarios/Tutores";
            // 
            // lblPsicologosUser
            // 
            this.lblPsicologosUser.AutoSize = true;
            this.lblPsicologosUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPsicologosUser.ForeColor = System.Drawing.Color.White;
            this.lblPsicologosUser.Location = new System.Drawing.Point(663, 137);
            this.lblPsicologosUser.Name = "lblPsicologosUser";
            this.lblPsicologosUser.Size = new System.Drawing.Size(235, 29);
            this.lblPsicologosUser.TabIndex = 13;
            this.lblPsicologosUser.Text = "Usuarios/Psicólogos";
            this.lblPsicologosUser.Click += new System.EventHandler(this.lblPsicologosUser_Click);
            // 
            // dgvPsicologos
            // 
            this.dgvPsicologos.AllowUserToAddRows = false;
            this.dgvPsicologos.AllowUserToDeleteRows = false;
            this.dgvPsicologos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPsicologos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPsicologos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPsicologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPsicologos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.foto2});
            this.dgvPsicologos.EnableHeadersVisualStyles = false;
            this.dgvPsicologos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPsicologos.Location = new System.Drawing.Point(668, 182);
            this.dgvPsicologos.Name = "dgvPsicologos";
            this.dgvPsicologos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPsicologos.RowHeadersVisible = false;
            this.dgvPsicologos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPsicologos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPsicologos.RowTemplate.Height = 28;
            this.dgvPsicologos.Size = new System.Drawing.Size(600, 732);
            this.dgvPsicologos.TabIndex = 11;
            this.dgvPsicologos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPsicologos_CellContentClick);
            this.dgvPsicologos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPsicologos_CellFormatting);
            this.dgvPsicologos.SelectionChanged += new System.EventHandler(this.dgvPsicologos_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre Completo";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 240;
            // 
            // foto2
            // 
            this.foto2.HeaderText = "Foto";
            this.foto2.Image = global::InterfazDATMA.Properties.Resources.avatarPsicologa;
            this.foto2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.foto2.MinimumWidth = 8;
            this.foto2.Name = "foto2";
            this.foto2.ReadOnly = true;
            this.foto2.Width = 70;
            // 
            // dgvTutores
            // 
            this.dgvTutores.AllowUserToAddRows = false;
            this.dgvTutores.AllowUserToDeleteRows = false;
            this.dgvTutores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvTutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompleto,
            this.foto});
            this.dgvTutores.EnableHeadersVisualStyles = false;
            this.dgvTutores.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTutores.Location = new System.Drawing.Point(34, 182);
            this.dgvTutores.Name = "dgvTutores";
            this.dgvTutores.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTutores.RowHeadersVisible = false;
            this.dgvTutores.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTutores.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTutores.RowTemplate.Height = 28;
            this.dgvTutores.Size = new System.Drawing.Size(600, 732);
            this.dgvTutores.TabIndex = 11;
            this.dgvTutores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTutores_CellContentClick);
            this.dgvTutores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTutores_CellFormatting);
            this.dgvTutores.SelectionChanged += new System.EventHandler(this.dgvTutores_SelectionChanged);
            // 
            // btnOpPersona
            // 
            this.btnOpPersona.AutoSize = true;
            this.btnOpPersona.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpPersona.Depth = 0;
            this.btnOpPersona.Location = new System.Drawing.Point(462, 72);
            this.btnOpPersona.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOpPersona.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpPersona.Name = "btnOpPersona";
            this.btnOpPersona.Primary = false;
            this.btnOpPersona.Size = new System.Drawing.Size(250, 36);
            this.btnOpPersona.TabIndex = 14;
            this.btnOpPersona.Text = "Operaciones Persona";
            this.btnOpPersona.UseVisualStyleBackColor = true;
            this.btnOpPersona.Click += new System.EventHandler(this.btnOpPersona_Click);
            // 
            // btnOpCurso
            // 
            this.btnOpCurso.AutoSize = true;
            this.btnOpCurso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpCurso.Depth = 0;
            this.btnOpCurso.Location = new System.Drawing.Point(462, 939);
            this.btnOpCurso.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnOpCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOpCurso.Name = "btnOpCurso";
            this.btnOpCurso.Primary = false;
            this.btnOpCurso.Size = new System.Drawing.Size(223, 36);
            this.btnOpCurso.TabIndex = 15;
            this.btnOpCurso.Text = "Operaciones Curso";
            this.btnOpCurso.UseVisualStyleBackColor = true;
            this.btnOpCurso.Click += new System.EventHandler(this.btnOpCurso_Click);
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 8;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 310;
            // 
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.Image = global::InterfazDATMA.Properties.Resources.avatarPsicologa;
            this.foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.foto.MinimumWidth = 8;
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            this.foto.Width = 70;
            // 
            // frmGestionarModuloAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1280, 885);
            this.ControlBox = false;
            this.Controls.Add(this.btnOpCurso);
            this.Controls.Add(this.btnOpPersona);
            this.Controls.Add(this.lblPsicologosUser);
            this.Controls.Add(this.lblTutoresUser);
            this.Controls.Add(this.dgvPsicologos);
            this.Controls.Add(this.dgvTutores);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmGestionarModuloAdmin";
            this.Sizable = false;
            this.Text = "Módulo Admin";
            this.Load += new System.EventHandler(this.frmGestionarModuloAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTutores;
        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.Label lblPsicologosUser;
        private System.Windows.Forms.DataGridView dgvPsicologos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn foto2;
        private MaterialSkin.Controls.MaterialFlatButton btnOpPersona;
        private MaterialSkin.Controls.MaterialFlatButton btnOpCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewImageColumn foto;
    }
}