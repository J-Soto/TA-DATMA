
namespace InterfazDATMA.Administrador
{
    partial class frmBuscarPsicologoGrupo
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
            this.txtNombrePsico = new System.Windows.Forms.TextBox();
            this.dgvPsicologos = new System.Windows.Forms.DataGridView();
            //this.btnBuscarPsico = new MaterialSkin.Controls.MaterialFlatButton();
            //this.btnAgregarPsico = new MaterialSkin.Controls.MaterialFlatButton();
            //this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
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
            this.lblTutoresUser.Location = new System.Drawing.Point(141, 132);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(221, 29);
            this.lblTutoresUser.TabIndex = 16;
            this.lblTutoresUser.Text = "Nombre Psicologo:";
            // 
            // txtNombrePsico
            // 
            this.txtNombrePsico.Location = new System.Drawing.Point(368, 135);
            this.txtNombrePsico.Name = "txtNombrePsico";
            this.txtNombrePsico.Size = new System.Drawing.Size(453, 26);
            this.txtNombrePsico.TabIndex = 17;
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
            this.dgvPsicologos.Location = new System.Drawing.Point(146, 199);
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
            this.dgvPsicologos.Size = new System.Drawing.Size(898, 361);
            this.dgvPsicologos.TabIndex = 26;
            this.dgvPsicologos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPsicologos_CellFormatting);
            // 
            // btnBuscarPsico
            // 
            //this.btnBuscarPsico.AutoSize = true;
            //this.btnBuscarPsico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.btnBuscarPsico.Depth = 0;
            //this.btnBuscarPsico.Location = new System.Drawing.Point(850, 130);
            //this.btnBuscarPsico.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            //this.btnBuscarPsico.MouseState = MaterialSkin.MouseState.HOVER;
            //this.btnBuscarPsico.Name = "btnBuscarPsico";
            //this.btnBuscarPsico.Primary = false;
            //this.btnBuscarPsico.Size = new System.Drawing.Size(93, 36);
            //this.btnBuscarPsico.TabIndex = 29;
            //this.btnBuscarPsico.Text = "Buscar";
            //this.btnBuscarPsico.UseVisualStyleBackColor = true;
            //this.btnBuscarPsico.Click += new System.EventHandler(this.btnBuscarPsico_Click);
            //// 
            //// btnAgregarPsico
            //// 
            //this.btnAgregarPsico.AutoSize = true;
            //this.btnAgregarPsico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.btnAgregarPsico.Depth = 0;
            //this.btnAgregarPsico.Location = new System.Drawing.Point(399, 588);
            //this.btnAgregarPsico.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            //this.btnAgregarPsico.MouseState = MaterialSkin.MouseState.HOVER;
            //this.btnAgregarPsico.Name = "btnAgregarPsico";
            //this.btnAgregarPsico.Primary = false;
            //this.btnAgregarPsico.Size = new System.Drawing.Size(149, 36);
            //this.btnAgregarPsico.TabIndex = 30;
            //this.btnAgregarPsico.Text = "Seleccionar";
            //this.btnAgregarPsico.UseVisualStyleBackColor = true;
            //this.btnAgregarPsico.Click += new System.EventHandler(this.btnAgregarPsico_Click);
            //// 
            //// btnCancelar
            //// 
            //this.btnCancelar.AutoSize = true;
            //this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.btnCancelar.Depth = 0;
            //this.btnCancelar.Location = new System.Drawing.Point(655, 588);
            //this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            //this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            //this.btnCancelar.Name = "btnCancelar";
            //this.btnCancelar.Primary = false;
            //this.btnCancelar.Size = new System.Drawing.Size(119, 36);
            //this.btnCancelar.TabIndex = 31;
            //this.btnCancelar.Text = "Cancelar";
            //this.btnCancelar.UseVisualStyleBackColor = true;
            //this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 180;
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
            // frmBuscarPsicologoGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1218, 674);
            this.ControlBox = false;
            //this.Controls.Add(this.btnCancelar);
            //this.Controls.Add(this.btnAgregarPsico);
            //this.Controls.Add(this.btnBuscarPsico);
            this.Controls.Add(this.dgvPsicologos);
            this.Controls.Add(this.txtNombrePsico);
            this.Controls.Add(this.lblTutoresUser);
            this.Name = "frmBuscarPsicologoGrupo";
            this.Sizable = false;
            this.Text = "Buscar Psicologos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.TextBox txtNombrePsico;
        private System.Windows.Forms.DataGridView dgvPsicologos;
        //private MaterialSkin.Controls.MaterialFlatButton btnBuscarPsico;
        //private MaterialSkin.Controls.MaterialFlatButton btnAgregarPsico;
        //private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
    }
}