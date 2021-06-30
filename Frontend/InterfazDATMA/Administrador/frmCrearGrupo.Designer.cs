
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.txtNombreGrupo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxTutores = new System.Windows.Forms.TextBox();
            this.dgvPsicologos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            //this.btnAgregarPsico = new MaterialSkin.Controls.MaterialFlatButton();
            //this.btnEliminar = new MaterialSkin.Controls.MaterialFlatButton();
            //this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            //this.btnBack = new MaterialSkin.Controls.MaterialFlatButton();
            //this.btnReportePsi = new MaterialSkin.Controls.MaterialFlatButton();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(45, 118);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(220, 29);
            this.lblTutoresUser.TabIndex = 15;
            this.lblTutoresUser.Text = "Nombre del Grupo:";
            // 
            // txtNombreGrupo
            // 
            this.txtNombreGrupo.Location = new System.Drawing.Point(281, 118);
            this.txtNombreGrupo.Name = "txtNombreGrupo";
            this.txtNombreGrupo.Size = new System.Drawing.Size(340, 26);
            this.txtNombreGrupo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(704, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Max. Tutores:";
            // 
            // txtMaxTutores
            // 
            this.txtMaxTutores.Location = new System.Drawing.Point(879, 118);
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
            this.dgvPsicologos.Location = new System.Drawing.Point(156, 241);
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
            this.dgvPsicologos.Size = new System.Drawing.Size(863, 450);
            this.dgvPsicologos.TabIndex = 20;
            this.dgvPsicologos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPsicologos_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(45, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Psicologos Inscritos:";
            // 
            // btnAgregarPsico
            // 
            //this.btnAgregarPsico.AutoSize = true;
            //this.btnAgregarPsico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.btnAgregarPsico.Depth = 0;
            //this.btnAgregarPsico.Location = new System.Drawing.Point(1038, 241);
            //this.btnAgregarPsico.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            //this.btnAgregarPsico.MouseState = MaterialSkin.MouseState.HOVER;
            //this.btnAgregarPsico.Name = "btnAgregarPsico";
            //this.btnAgregarPsico.Primary = false;
            //this.btnAgregarPsico.Size = new System.Drawing.Size(26, 36);
            //this.btnAgregarPsico.TabIndex = 30;
            //this.btnAgregarPsico.Text = "+";
            //this.btnAgregarPsico.UseVisualStyleBackColor = true;
            //this.btnAgregarPsico.Click += new System.EventHandler(this.btnAgregarPsico_Click);
            //// 
            //// btnEliminar
            //// 
            //this.btnEliminar.AutoSize = true;
            //this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.btnEliminar.Depth = 0;
            //this.btnEliminar.Location = new System.Drawing.Point(1038, 290);
            //this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            //this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            //this.btnEliminar.Name = "btnEliminar";
            //this.btnEliminar.Primary = false;
            //this.btnEliminar.Size = new System.Drawing.Size(21, 36);
            //this.btnEliminar.TabIndex = 31;
            //this.btnEliminar.Text = "-";
            //this.btnEliminar.UseVisualStyleBackColor = true;
            //this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //// 
            //// btnGuardar
            //// 
            //this.btnGuardar.AutoSize = true;
            //this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.btnGuardar.Depth = 0;
            //this.btnGuardar.Location = new System.Drawing.Point(1107, 700);
            //this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            //this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            //this.btnGuardar.Name = "btnGuardar";
            //this.btnGuardar.Primary = false;
            //this.btnGuardar.Size = new System.Drawing.Size(108, 36);
            //this.btnGuardar.TabIndex = 32;
            //this.btnGuardar.Text = "Guardar";
            //this.btnGuardar.UseVisualStyleBackColor = true;
            //this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //// 
            //// btnBack
            //// 
            //this.btnBack.AutoSize = true;
            //this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.btnBack.Depth = 0;
            //this.btnBack.Location = new System.Drawing.Point(1107, 755);
            //this.btnBack.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            //this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            //this.btnBack.Name = "btnBack";
            //this.btnBack.Primary = false;
            //this.btnBack.Size = new System.Drawing.Size(119, 36);
            //this.btnBack.TabIndex = 33;
            //this.btnBack.Text = "Cancelar";
            //this.btnBack.UseVisualStyleBackColor = true;
            //this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            //// 
            //// btnReportePsi
            //// 
            //this.btnReportePsi.AutoSize = true;
            //this.btnReportePsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.btnReportePsi.Depth = 0;
            //this.btnReportePsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            //this.btnReportePsi.Location = new System.Drawing.Point(786, 711);
            //this.btnReportePsi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            //this.btnReportePsi.MouseState = MaterialSkin.MouseState.HOVER;
            //this.btnReportePsi.Name = "btnReportePsi";
            //this.btnReportePsi.Primary = false;
            //this.btnReportePsi.Size = new System.Drawing.Size(233, 36);
            //this.btnReportePsi.TabIndex = 34;
            //this.btnReportePsi.Text = "Reporte Psicologos";
            //this.btnReportePsi.UseVisualStyleBackColor = true;
            //this.btnReportePsi.Click += new System.EventHandler(this.btnReportePsi_Click);
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
            // frmCrearGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1306, 829);
            this.ControlBox = false;
            //this.Controls.Add(this.btnReportePsi);
            //this.Controls.Add(this.btnBack);
            //this.Controls.Add(this.btnGuardar);
            //this.Controls.Add(this.btnEliminar);
            //this.Controls.Add(this.btnAgregarPsico);
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
        //private MaterialSkin.Controls.MaterialFlatButton btnAgregarPsico;
        //private MaterialSkin.Controls.MaterialFlatButton btnEliminar;
        //private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        //private MaterialSkin.Controls.MaterialFlatButton btnBack;
        //private MaterialSkin.Controls.MaterialFlatButton btnReportePsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
    }
}