
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxTutores = new System.Windows.Forms.TextBox();
            this.dgvPsicologos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarPsico = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBack = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnReportePsi = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(31, 118);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(220, 29);
            this.lblTutoresUser.TabIndex = 15;
            this.lblTutoresUser.Text = "Nombre del Grupo:";
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(272, 126);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(340, 26);
            this.txtNombreGrupo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(805, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Max. Tutores:";
            // 
            // txtMaxTutores
            // 
            this.txtMaxTutores.Location = new System.Drawing.Point(989, 121);
            this.txtMaxTutores.Name = "txtMaxTutores";
            this.txtMaxTutores.Size = new System.Drawing.Size(97, 26);
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPsicologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPsicologos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellidos,
            this.DNI,
            this.Correo,
            this.User,
            this.Celular});
            this.dgvPsicologos.EnableHeadersVisualStyles = false;
            this.dgvPsicologos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPsicologos.Location = new System.Drawing.Point(156, 210);
            this.dgvPsicologos.Name = "dgvPsicologos";
            this.dgvPsicologos.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPsicologos.RowHeadersWidth = 62;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPsicologos.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPsicologos.RowTemplate.Height = 28;
            this.dgvPsicologos.Size = new System.Drawing.Size(788, 411);
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
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 8;
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 150;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 8;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            this.Correo.Width = 150;
            // 
            // User
            // 
            this.User.HeaderText = "User";
            this.User.MinimumWidth = 8;
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Width = 150;
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
            this.label2.Location = new System.Drawing.Point(42, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Psicologos:";
            // 
            // btnAgregarPsico
            // 
            this.btnAgregarPsico.AutoSize = true;
            this.btnAgregarPsico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPsico.Depth = 0;
            this.btnAgregarPsico.Location = new System.Drawing.Point(972, 210);
            this.btnAgregarPsico.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAgregarPsico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarPsico.Name = "btnAgregarPsico";
            this.btnAgregarPsico.Primary = false;
            this.btnAgregarPsico.Size = new System.Drawing.Size(26, 36);
            this.btnAgregarPsico.TabIndex = 30;
            this.btnAgregarPsico.Text = "+";
            this.btnAgregarPsico.UseVisualStyleBackColor = true;
            this.btnAgregarPsico.Click += new System.EventHandler(this.btnAgregarPsico_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = true;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.Location = new System.Drawing.Point(972, 256);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Primary = false;
            this.btnEliminar.Size = new System.Drawing.Size(21, 36);
            this.btnEliminar.TabIndex = 31;
            this.btnEliminar.Text = "-";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(1038, 622);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = false;
            this.btnGuardar.Size = new System.Drawing.Size(108, 36);
            this.btnGuardar.TabIndex = 32;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Depth = 0;
            this.btnBack.Location = new System.Drawing.Point(1038, 691);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Primary = false;
            this.btnBack.Size = new System.Drawing.Size(119, 36);
            this.btnBack.TabIndex = 33;
            this.btnBack.Text = "Cancelar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnReportePsi
            // 
            this.btnReportePsi.AutoSize = true;
            this.btnReportePsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReportePsi.Depth = 0;
            this.btnReportePsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnReportePsi.Location = new System.Drawing.Point(711, 643);
            this.btnReportePsi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReportePsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReportePsi.Name = "btnReportePsi";
            this.btnReportePsi.Primary = false;
            this.btnReportePsi.Size = new System.Drawing.Size(233, 36);
            this.btnReportePsi.TabIndex = 34;
            this.btnReportePsi.Text = "Reporte Psicologos";
            this.btnReportePsi.UseVisualStyleBackColor = true;
            this.btnReportePsi.Click += new System.EventHandler(this.btnReportePsi_Click);
            // 
            // frmCrearGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1206, 735);
            this.ControlBox = false;
            this.Controls.Add(this.btnReportePsi);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregarPsico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPsicologos);
            this.Controls.Add(this.txtMaxTutores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreGrupo);
            this.Controls.Add(this.lblTutoresUser);
            this.Name = "frmCrearGrupo";
            this.Sizable = false;
            this.Text = "Crear Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarPsico;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        private MaterialSkin.Controls.MaterialFlatButton btnBack;
        private MaterialSkin.Controls.MaterialFlatButton btnReportePsi;
    }
}