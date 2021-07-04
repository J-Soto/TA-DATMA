
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.txtNombrePsico = new System.Windows.Forms.TextBox();
            this.dgvPsicologos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarPsico = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnBuscarPsico = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReportePsi = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(226, 122);
            this.lblTutoresUser.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(289, 37);
            this.lblTutoresUser.TabIndex = 16;
            this.lblTutoresUser.Text = "Nombre Psicologo:";
            // 
            // txtNombrePsico
            // 
            this.txtNombrePsico.Location = new System.Drawing.Point(629, 127);
            this.txtNombrePsico.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtNombrePsico.Name = "txtNombrePsico";
            this.txtNombrePsico.Size = new System.Drawing.Size(802, 38);
            this.txtNombrePsico.TabIndex = 17;
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
            this.Nombre,
            this.Apellidos,
            this.Correo,
            this.Celular});
            this.dgvPsicologos.EnableHeadersVisualStyles = false;
            this.dgvPsicologos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPsicologos.Location = new System.Drawing.Point(235, 226);
            this.dgvPsicologos.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
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
            this.dgvPsicologos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPsicologos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPsicologos.RowTemplate.Height = 28;
            this.dgvPsicologos.Size = new System.Drawing.Size(1596, 560);
            this.dgvPsicologos.TabIndex = 26;
            this.dgvPsicologos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPsicologos_CellFormatting);
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
            // btnAgregarPsico
            // 
            this.btnAgregarPsico.AutoSize = false;
            this.btnAgregarPsico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarPsico.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregarPsico.Depth = 0;
            this.btnAgregarPsico.HighEmphasis = true;
            this.btnAgregarPsico.Icon = null;
            this.btnAgregarPsico.Location = new System.Drawing.Point(235, 840);
            this.btnAgregarPsico.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnAgregarPsico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarPsico.Name = "btnAgregarPsico";
            this.btnAgregarPsico.Size = new System.Drawing.Size(297, 68);
            this.btnAgregarPsico.TabIndex = 27;
            this.btnAgregarPsico.Text = "Seleccionar";
            this.btnAgregarPsico.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregarPsico.UseAccentColor = false;
            this.btnAgregarPsico.UseVisualStyleBackColor = true;
            this.btnAgregarPsico.Click += new System.EventHandler(this.btnAgregarPsico_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = false;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(595, 840);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(297, 68);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscarPsico
            // 
            this.btnBuscarPsico.AutoSize = false;
            this.btnBuscarPsico.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarPsico.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarPsico.Depth = 0;
            this.btnBuscarPsico.HighEmphasis = true;
            this.btnBuscarPsico.Icon = null;
            this.btnBuscarPsico.Location = new System.Drawing.Point(1470, 116);
            this.btnBuscarPsico.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnBuscarPsico.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarPsico.Name = "btnBuscarPsico";
            this.btnBuscarPsico.Size = new System.Drawing.Size(217, 65);
            this.btnBuscarPsico.TabIndex = 29;
            this.btnBuscarPsico.Text = "Buscar";
            this.btnBuscarPsico.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarPsico.UseAccentColor = false;
            this.btnBuscarPsico.UseVisualStyleBackColor = true;
            this.btnBuscarPsico.Click += new System.EventHandler(this.btnBuscarPsico_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(788, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 63);
            this.label1.TabIndex = 30;
            this.label1.Text = "Buscar Psicologos:";
            // 
            // btnReportePsi
            // 
            this.btnReportePsi.AutoSize = false;
            this.btnReportePsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReportePsi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReportePsi.Depth = 0;
            this.btnReportePsi.HighEmphasis = true;
            this.btnReportePsi.Icon = null;
            this.btnReportePsi.Location = new System.Drawing.Point(1474, 840);
            this.btnReportePsi.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.btnReportePsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReportePsi.Name = "btnReportePsi";
            this.btnReportePsi.Size = new System.Drawing.Size(357, 68);
            this.btnReportePsi.TabIndex = 31;
            this.btnReportePsi.Text = "Reporte Psicologos";
            this.btnReportePsi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReportePsi.UseAccentColor = false;
            this.btnReportePsi.UseVisualStyleBackColor = true;
            this.btnReportePsi.Click += new System.EventHandler(this.btnReportePsi_Click);
            // 
            // frmBuscarPsicologoGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(2052, 938);
            this.ControlBox = false;
            this.Controls.Add(this.btnReportePsi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscarPsico);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarPsico);
            this.Controls.Add(this.dgvPsicologos);
            this.Controls.Add(this.txtNombrePsico);
            this.Controls.Add(this.lblTutoresUser);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmBuscarPsicologoGrupo";
            this.Padding = new System.Windows.Forms.Padding(5, 99, 5, 5);
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
        private MaterialSkin.Controls.MaterialButton btnAgregarPsico;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnBuscarPsico;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnReportePsi;
    }
}