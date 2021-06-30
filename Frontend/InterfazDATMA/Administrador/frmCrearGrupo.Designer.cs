
namespace InterfazDATMA.Administrador
{
    partial class frmCrearGrupo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxTutores = new System.Windows.Forms.TextBox();
            this.dgvPsicologos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarPsico = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.btnReportePsi = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(22, 26);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(220, 29);
            this.lblTutoresUser.TabIndex = 15;
            this.lblTutoresUser.Text = "Nombre del Grupo:";
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(248, 30);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(340, 26);
            this.txtNombreGrupo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(745, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Max. Tutores:";
            // 
            // txtMaxTutores
            // 
            this.txtMaxTutores.Location = new System.Drawing.Point(909, 30);
            this.txtMaxTutores.Name = "txtMaxTutores";
            this.txtMaxTutores.Size = new System.Drawing.Size(62, 26);
            this.txtMaxTutores.TabIndex = 18;
            this.txtMaxTutores.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaxTutores_KeyPress);
            // 
            // dgvPsicologos
            // 
            this.dgvPsicologos.AllowUserToAddRows = false;
            this.dgvPsicologos.AllowUserToDeleteRows = false;
            this.dgvPsicologos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPsicologos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPsicologos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvPsicologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPsicologos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellidos,
            this.Correo,
            this.Celular});
            this.dgvPsicologos.EnableHeadersVisualStyles = false;
            this.dgvPsicologos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPsicologos.Location = new System.Drawing.Point(238, 159);
            this.dgvPsicologos.Name = "dgvPsicologos";
            this.dgvPsicologos.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvPsicologos.RowHeadersWidth = 62;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPsicologos.RowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvPsicologos.RowTemplate.Height = 28;
            this.dgvPsicologos.Size = new System.Drawing.Size(863, 450);
            this.dgvPsicologos.TabIndex = 20;
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
            this.label2.Location = new System.Drawing.Point(149, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Psicologos Inscritos:";
            // 
            // btnAgregarPsico
            // 
            this.btnAgregarPsico.AutoSize = false;
            this.btnAgregarPsico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPsico.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarPsico.Depth = 0;
            this.btnAgregarPsico.HighEmphasis = true;
            this.btnAgregarPsico.Icon = null;
            this.btnAgregarPsico.Location = new System.Drawing.Point(1119, 159);
            this.btnAgregarPsico.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAgregarPsico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarPsico.Name = "btnAgregarPsico";
            this.btnAgregarPsico.Size = new System.Drawing.Size(42, 44);
            this.btnAgregarPsico.TabIndex = 23;
            this.btnAgregarPsico.Text = "+";
            this.btnAgregarPsico.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarPsico.UseAccentColor = false;
            this.btnAgregarPsico.UseVisualStyleBackColor = true;
            this.btnAgregarPsico.Click += new System.EventHandler(this.btnAgregarPsico_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(1119, 227);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(42, 44);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "-";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(1128, 504);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(126, 46);
            this.btnGuardar.TabIndex = 25;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = false;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBack.Depth = 0;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(1128, 563);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(126, 46);
            this.btnBack.TabIndex = 26;
            this.btnBack.Text = "Cancelar";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReportePsi
            // 
            this.btnReportePsi.AutoSize = false;
            this.btnReportePsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReportePsi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReportePsi.Depth = 0;
            this.btnReportePsi.HighEmphasis = true;
            this.btnReportePsi.Icon = null;
            this.btnReportePsi.Location = new System.Drawing.Point(238, 627);
            this.btnReportePsi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReportePsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReportePsi.Name = "btnReportePsi";
            this.btnReportePsi.Size = new System.Drawing.Size(201, 44);
            this.btnReportePsi.TabIndex = 27;
            this.btnReportePsi.Text = "Reporte Psicologos";
            this.btnReportePsi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReportePsi.UseAccentColor = false;
            this.btnReportePsi.UseVisualStyleBackColor = true;
            this.btnReportePsi.Click += new System.EventHandler(this.btnReportePsi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaxTutores);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreGrupo);
            this.groupBox1.Controls.Add(this.lblTutoresUser);
            this.groupBox1.Location = new System.Drawing.Point(151, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 67);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion Grupo:";
            // 
            // frmCrearGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1301, 751);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReportePsi);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarPsico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPsicologos);
            this.Name = "frmCrearGrupo";
            this.Sizable = false;
            this.Text = "Crear Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.TextBox txtNombreGrupo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxTutores;
        private System.Windows.Forms.DataGridView dgvPsicologos;
        private System.Windows.Forms.Label label2;
        //private MaterialSkin.Controls.MaterialFlatButton btnAgregarPsico;
        //private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        //private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        //private MaterialSkin.Controls.MaterialFlatButton btnBack;
        //private MaterialSkin.Controls.MaterialFlatButton btnReportePsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private MaterialSkin.Controls.MaterialButton btnAgregarPsico;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private MaterialSkin.Controls.MaterialButton btnBack;
        private MaterialSkin.Controls.MaterialButton btnReportePsi;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}