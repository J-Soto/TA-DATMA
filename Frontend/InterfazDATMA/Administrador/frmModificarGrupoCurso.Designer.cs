
namespace InterfazDATMA.Administrador
{
    partial class frmModificarGrupoCurso
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
            this.dgvPsicologos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxTutores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.btnAgregarPsico = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarPsico = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPsicologos
            // 
            this.dgvPsicologos.AllowUserToAddRows = false;
            this.dgvPsicologos.AllowUserToDeleteRows = false;
            this.dgvPsicologos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPsicologos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPsicologos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPsicologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPsicologos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellidos,
            this.Correo,
            this.Celular});
            this.dgvPsicologos.EnableHeadersVisualStyles = false;
            this.dgvPsicologos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPsicologos.Location = new System.Drawing.Point(299, 191);
            this.dgvPsicologos.Name = "dgvPsicologos";
            this.dgvPsicologos.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPsicologos.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPsicologos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPsicologos.RowTemplate.Height = 28;
            this.dgvPsicologos.Size = new System.Drawing.Size(856, 481);
            this.dgvPsicologos.TabIndex = 21;
            this.dgvPsicologos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPsicologos_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 170;
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.MinimumWidth = 8;
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            this.Apellidos.Width = 150;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.MinimumWidth = 8;
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(229, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Psicologos Inscritos:";
            // 
            // txtMaxTutores
            // 
            this.txtMaxTutores.Location = new System.Drawing.Point(947, 30);
            this.txtMaxTutores.Name = "txtMaxTutores";
            this.txtMaxTutores.Size = new System.Drawing.Size(67, 26);
            this.txtMaxTutores.TabIndex = 33;
            this.txtMaxTutores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxTutores_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(783, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 32;
            this.label1.Text = "Max. Tutores:";
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(244, 29);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(341, 26);
            this.txtNombreGrupo.TabIndex = 31;
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(18, 25);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(220, 29);
            this.lblTutoresUser.TabIndex = 30;
            this.lblTutoresUser.Text = "Nombre del Grupo:";
            // 
            // btnAgregarPsico
            // 
            this.btnAgregarPsico.AutoSize = false;
            this.btnAgregarPsico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPsico.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarPsico.Depth = 0;
            this.btnAgregarPsico.HighEmphasis = true;
            this.btnAgregarPsico.Icon = null;
            this.btnAgregarPsico.Location = new System.Drawing.Point(1197, 191);
            this.btnAgregarPsico.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAgregarPsico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarPsico.Name = "btnAgregarPsico";
            this.btnAgregarPsico.Size = new System.Drawing.Size(42, 44);
            this.btnAgregarPsico.TabIndex = 34;
            this.btnAgregarPsico.Text = "+";
            this.btnAgregarPsico.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarPsico.UseAccentColor = false;
            this.btnAgregarPsico.UseVisualStyleBackColor = true;
            this.btnAgregarPsico.Click += new System.EventHandler(this.btnAgregarPsico_Click_1);
            // 
            // btnEliminarPsico
            // 
            this.btnEliminarPsico.AutoSize = false;
            this.btnEliminarPsico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarPsico.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarPsico.Depth = 0;
            this.btnEliminarPsico.HighEmphasis = true;
            this.btnEliminarPsico.Icon = null;
            this.btnEliminarPsico.Location = new System.Drawing.Point(1197, 245);
            this.btnEliminarPsico.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEliminarPsico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarPsico.Name = "btnEliminarPsico";
            this.btnEliminarPsico.Size = new System.Drawing.Size(42, 44);
            this.btnEliminarPsico.TabIndex = 35;
            this.btnEliminarPsico.Text = "-";
            this.btnEliminarPsico.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarPsico.UseAccentColor = false;
            this.btnEliminarPsico.UseVisualStyleBackColor = true;
            this.btnEliminarPsico.Click += new System.EventHandler(this.btnEliminarPsico_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(1199, 561);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 50);
            this.btnGuardar.TabIndex = 36;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = false;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(1199, 622);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(138, 50);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Cancelar";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaxTutores);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreGrupo);
            this.groupBox1.Controls.Add(this.lblTutoresUser);
            this.groupBox1.Location = new System.Drawing.Point(234, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 75);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Grupo:";
            // 
            // frmModificarGrupoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1421, 832);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminarPsico);
            this.Controls.Add(this.btnAgregarPsico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPsicologos);
            this.Name = "frmModificarGrupoCurso";
            this.Sizable = false;
            this.Text = "Modificar Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPsicologos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxTutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.Label lblTutoresUser;
        //private MaterialSkin.Controls.MaterialFlatButton btnAgregarPsico;
        //private MaterialSkin.Controls.MaterialFlatButton btnEliminarPsico;
        //private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        //private MaterialSkin.Controls.MaterialFlatButton btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private MaterialSkin.Controls.MaterialButton btnAgregarPsico;
        private MaterialSkin.Controls.MaterialButton btnEliminarPsico;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}