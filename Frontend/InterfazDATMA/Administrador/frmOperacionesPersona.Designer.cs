
namespace InterfazDATMA.Administrador
{
    partial class frmOperacionesPersona
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTutores = new System.Windows.Forms.DataGridView();
            this.NombreCompletoTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FotoTutor = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvPsicologos = new System.Windows.Forms.DataGridView();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBusqUser = new System.Windows.Forms.TextBox();
            this.checkSoloTutores = new System.Windows.Forms.CheckBox();
            this.checkSoloPsicologos = new System.Windows.Forms.CheckBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.nombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoUsuario = new System.Windows.Forms.DataGridViewImageColumn();
            this.checkSoloActivos = new System.Windows.Forms.CheckBox();
            this.btnListarTut = new MaterialSkin.Controls.MaterialButton();
            this.btnListarPsi = new MaterialSkin.Controls.MaterialButton();
            this.btnMostrarFoto = new MaterialSkin.Controls.MaterialButton();
            this.btnDeshabilitar = new MaterialSkin.Controls.MaterialButton();
            this.btnInsertarPsi = new MaterialSkin.Controls.MaterialButton();
            this.btnInsertarTutor = new MaterialSkin.Controls.MaterialButton();
            this.btnModificarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnBuscarUser = new MaterialSkin.Controls.MaterialButton();
            this.Header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTutores
            // 
            this.dgvTutores.AllowUserToAddRows = false;
            this.dgvTutores.AllowUserToDeleteRows = false;
            this.dgvTutores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvTutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompletoTutor,
            this.FotoTutor});
            this.dgvTutores.EnableHeadersVisualStyles = false;
            this.dgvTutores.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTutores.Location = new System.Drawing.Point(1578, 29);
            this.dgvTutores.Name = "dgvTutores";
            this.dgvTutores.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTutores.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTutores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTutores.RowTemplate.Height = 28;
            this.dgvTutores.Size = new System.Drawing.Size(10, 10);
            this.dgvTutores.TabIndex = 19;
            this.dgvTutores.Visible = false;
            this.dgvTutores.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTutores_CellFormatting);
            this.dgvTutores.SelectionChanged += new System.EventHandler(this.dgvTutores_SelectionChanged);
            // 
            // NombreCompletoTutor
            // 
            this.NombreCompletoTutor.HeaderText = "Nombre Completo";
            this.NombreCompletoTutor.MinimumWidth = 8;
            this.NombreCompletoTutor.Name = "NombreCompletoTutor";
            this.NombreCompletoTutor.ReadOnly = true;
            this.NombreCompletoTutor.Width = 150;
            // 
            // FotoTutor
            // 
            this.FotoTutor.HeaderText = "Foto";
            this.FotoTutor.Image = global::InterfazDATMA.Properties.Resources.avatarPsicologa;
            this.FotoTutor.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.FotoTutor.MinimumWidth = 8;
            this.FotoTutor.Name = "FotoTutor";
            this.FotoTutor.ReadOnly = true;
            this.FotoTutor.Width = 70;
            // 
            // dgvPsicologos
            // 
            this.dgvPsicologos.AllowUserToAddRows = false;
            this.dgvPsicologos.AllowUserToDeleteRows = false;
            this.dgvPsicologos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
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
            this.NombreCompleto,
            this.foto});
            this.dgvPsicologos.EnableHeadersVisualStyles = false;
            this.dgvPsicologos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPsicologos.Location = new System.Drawing.Point(1578, 56);
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
            this.dgvPsicologos.Size = new System.Drawing.Size(10, 10);
            this.dgvPsicologos.TabIndex = 20;
            this.dgvPsicologos.Visible = false;
            this.dgvPsicologos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPsicologos_CellFormatting);
            this.dgvPsicologos.SelectionChanged += new System.EventHandler(this.dgvPsicologos_SelectionChanged);
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.MinimumWidth = 8;
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 150;
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
            // txtBusqUser
            // 
            this.txtBusqUser.Location = new System.Drawing.Point(824, 85);
            this.txtBusqUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqUser.Name = "txtBusqUser";
            this.txtBusqUser.Size = new System.Drawing.Size(432, 26);
            this.txtBusqUser.TabIndex = 21;
            this.txtBusqUser.Text = "Nombres y Apellidos";
            this.txtBusqUser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBusqTutor_MouseClick);
            // 
            // checkSoloTutores
            // 
            this.checkSoloTutores.AutoSize = true;
            this.checkSoloTutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkSoloTutores.ForeColor = System.Drawing.Color.White;
            this.checkSoloTutores.Location = new System.Drawing.Point(57, 83);
            this.checkSoloTutores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkSoloTutores.Name = "checkSoloTutores";
            this.checkSoloTutores.Size = new System.Drawing.Size(150, 29);
            this.checkSoloTutores.TabIndex = 47;
            this.checkSoloTutores.Text = "Solo Tutores";
            this.checkSoloTutores.UseVisualStyleBackColor = true;
            this.checkSoloTutores.CheckedChanged += new System.EventHandler(this.checkSoloTutores_CheckedChanged);
            // 
            // checkSoloPsicologos
            // 
            this.checkSoloPsicologos.AutoSize = true;
            this.checkSoloPsicologos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkSoloPsicologos.ForeColor = System.Drawing.Color.White;
            this.checkSoloPsicologos.Location = new System.Drawing.Point(251, 83);
            this.checkSoloPsicologos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkSoloPsicologos.Name = "checkSoloPsicologos";
            this.checkSoloPsicologos.Size = new System.Drawing.Size(178, 29);
            this.checkSoloPsicologos.TabIndex = 48;
            this.checkSoloPsicologos.Text = "Solo Psicólogos";
            this.checkSoloPsicologos.UseVisualStyleBackColor = true;
            this.checkSoloPsicologos.CheckedChanged += new System.EventHandler(this.checkSoloPsicologos_CheckedChanged);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreUsuario,
            this.celularUsuario,
            this.correoUsuario,
            this.tipoUsuario,
            this.activoUsuario,
            this.fotoUsuario});
            this.dgvUsuario.EnableHeadersVisualStyles = false;
            this.dgvUsuario.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvUsuario.Location = new System.Drawing.Point(57, 134);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUsuario.RowHeadersVisible = false;
            this.dgvUsuario.RowHeadersWidth = 62;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuario.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUsuario.RowTemplate.Height = 28;
            this.dgvUsuario.Size = new System.Drawing.Size(1080, 445);
            this.dgvUsuario.TabIndex = 49;
            // 
            // nombreUsuario
            // 
            this.nombreUsuario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombreUsuario.HeaderText = "Nombre Completo";
            this.nombreUsuario.MinimumWidth = 8;
            this.nombreUsuario.Name = "nombreUsuario";
            this.nombreUsuario.ReadOnly = true;
            // 
            // celularUsuario
            // 
            this.celularUsuario.HeaderText = "Celular";
            this.celularUsuario.MinimumWidth = 8;
            this.celularUsuario.Name = "celularUsuario";
            this.celularUsuario.ReadOnly = true;
            this.celularUsuario.Width = 90;
            // 
            // correoUsuario
            // 
            this.correoUsuario.HeaderText = "Correo Electrónico";
            this.correoUsuario.MinimumWidth = 8;
            this.correoUsuario.Name = "correoUsuario";
            this.correoUsuario.ReadOnly = true;
            this.correoUsuario.Width = 170;
            // 
            // tipoUsuario
            // 
            this.tipoUsuario.HeaderText = "Usuario";
            this.tipoUsuario.MinimumWidth = 8;
            this.tipoUsuario.Name = "tipoUsuario";
            this.tipoUsuario.ReadOnly = true;
            this.tipoUsuario.Width = 150;
            // 
            // activoUsuario
            // 
            this.activoUsuario.HeaderText = "Activo";
            this.activoUsuario.MinimumWidth = 8;
            this.activoUsuario.Name = "activoUsuario";
            this.activoUsuario.ReadOnly = true;
            this.activoUsuario.Width = 80;
            // 
            // fotoUsuario
            // 
            this.fotoUsuario.HeaderText = "Foto";
            this.fotoUsuario.Image = global::InterfazDATMA.Properties.Resources.postulante;
            this.fotoUsuario.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.fotoUsuario.MinimumWidth = 8;
            this.fotoUsuario.Name = "fotoUsuario";
            this.fotoUsuario.ReadOnly = true;
            this.fotoUsuario.Visible = false;
            this.fotoUsuario.Width = 78;
            // 
            // checkSoloActivos
            // 
            this.checkSoloActivos.AutoSize = true;
            this.checkSoloActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkSoloActivos.ForeColor = System.Drawing.Color.White;
            this.checkSoloActivos.Location = new System.Drawing.Point(467, 83);
            this.checkSoloActivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkSoloActivos.Name = "checkSoloActivos";
            this.checkSoloActivos.Size = new System.Drawing.Size(147, 29);
            this.checkSoloActivos.TabIndex = 50;
            this.checkSoloActivos.Text = "Solo Activos";
            this.checkSoloActivos.UseVisualStyleBackColor = true;
            this.checkSoloActivos.CheckedChanged += new System.EventHandler(this.checkSoloActivos_CheckedChanged);
            // 
            // btnListarTut
            // 
            this.btnListarTut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListarTut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListarTut.Depth = 0;
            this.btnListarTut.HighEmphasis = true;
            this.btnListarTut.Icon = null;
            this.btnListarTut.Location = new System.Drawing.Point(57, 603);
            this.btnListarTut.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnListarTut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListarTut.Name = "btnListarTut";
            this.btnListarTut.Size = new System.Drawing.Size(138, 36);
            this.btnListarTut.TabIndex = 51;
            this.btnListarTut.Text = "Listar Tutores";
            this.btnListarTut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListarTut.UseAccentColor = false;
            this.btnListarTut.UseVisualStyleBackColor = true;
            this.btnListarTut.Click += new System.EventHandler(this.btnListarTut_Click_1);
            // 
            // btnListarPsi
            // 
            this.btnListarPsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListarPsi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListarPsi.Depth = 0;
            this.btnListarPsi.HighEmphasis = true;
            this.btnListarPsi.Icon = null;
            this.btnListarPsi.Location = new System.Drawing.Point(220, 603);
            this.btnListarPsi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnListarPsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListarPsi.Name = "btnListarPsi";
            this.btnListarPsi.Size = new System.Drawing.Size(163, 36);
            this.btnListarPsi.TabIndex = 52;
            this.btnListarPsi.Text = "Listar Psicologos";
            this.btnListarPsi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListarPsi.UseAccentColor = false;
            this.btnListarPsi.UseVisualStyleBackColor = true;
            this.btnListarPsi.Click += new System.EventHandler(this.btnListarPsi_Click_1);
            // 
            // btnMostrarFoto
            // 
            this.btnMostrarFoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMostrarFoto.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMostrarFoto.Depth = 0;
            this.btnMostrarFoto.HighEmphasis = true;
            this.btnMostrarFoto.Icon = null;
            this.btnMostrarFoto.Location = new System.Drawing.Point(667, 80);
            this.btnMostrarFoto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMostrarFoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMostrarFoto.Name = "btnMostrarFoto";
            this.btnMostrarFoto.Size = new System.Drawing.Size(131, 36);
            this.btnMostrarFoto.TabIndex = 53;
            this.btnMostrarFoto.Text = "Mostrar Foto";
            this.btnMostrarFoto.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMostrarFoto.UseAccentColor = false;
            this.btnMostrarFoto.UseVisualStyleBackColor = true;
            this.btnMostrarFoto.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeshabilitar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDeshabilitar.Depth = 0;
            this.btnDeshabilitar.HighEmphasis = true;
            this.btnDeshabilitar.Icon = null;
            this.btnDeshabilitar.Location = new System.Drawing.Point(950, 603);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDeshabilitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(193, 36);
            this.btnDeshabilitar.TabIndex = 54;
            this.btnDeshabilitar.Text = "Des/Habilitar Usuario";
            this.btnDeshabilitar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDeshabilitar.UseAccentColor = false;
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click_1);
            // 
            // btnInsertarPsi
            // 
            this.btnInsertarPsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertarPsi.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsertarPsi.Depth = 0;
            this.btnInsertarPsi.HighEmphasis = true;
            this.btnInsertarPsi.Icon = null;
            this.btnInsertarPsi.Location = new System.Drawing.Point(1176, 134);
            this.btnInsertarPsi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInsertarPsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertarPsi.Name = "btnInsertarPsi";
            this.btnInsertarPsi.Size = new System.Drawing.Size(175, 36);
            this.btnInsertarPsi.TabIndex = 55;
            this.btnInsertarPsi.Text = "Insertar Psicólogo";
            this.btnInsertarPsi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInsertarPsi.UseAccentColor = false;
            this.btnInsertarPsi.UseVisualStyleBackColor = true;
            this.btnInsertarPsi.Click += new System.EventHandler(this.btnInsertarPsi_Click_1);
            // 
            // btnInsertarTutor
            // 
            this.btnInsertarTutor.AutoSize = false;
            this.btnInsertarTutor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertarTutor.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnInsertarTutor.Depth = 0;
            this.btnInsertarTutor.HighEmphasis = true;
            this.btnInsertarTutor.Icon = null;
            this.btnInsertarTutor.Location = new System.Drawing.Point(1176, 198);
            this.btnInsertarTutor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInsertarTutor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertarTutor.Name = "btnInsertarTutor";
            this.btnInsertarTutor.Size = new System.Drawing.Size(159, 44);
            this.btnInsertarTutor.TabIndex = 56;
            this.btnInsertarTutor.Text = "Insertar Tutor";
            this.btnInsertarTutor.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnInsertarTutor.UseAccentColor = false;
            this.btnInsertarTutor.UseVisualStyleBackColor = true;
            this.btnInsertarTutor.Click += new System.EventHandler(this.btnInsertarTutor_Click_1);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificarUsuario.Depth = 0;
            this.btnModificarUsuario.HighEmphasis = true;
            this.btnModificarUsuario.Icon = null;
            this.btnModificarUsuario.Location = new System.Drawing.Point(1176, 265);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModificarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(164, 36);
            this.btnModificarUsuario.TabIndex = 57;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificarUsuario.UseAccentColor = false;
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarPsi_Click_1);
            // 
            // btnBuscarUser
            // 
            this.btnBuscarUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarUser.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarUser.Depth = 0;
            this.btnBuscarUser.HighEmphasis = true;
            this.btnBuscarUser.Icon = null;
            this.btnBuscarUser.Location = new System.Drawing.Point(1304, 80);
            this.btnBuscarUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscarUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarUser.Name = "btnBuscarUser";
            this.btnBuscarUser.Size = new System.Drawing.Size(77, 36);
            this.btnBuscarUser.TabIndex = 58;
            this.btnBuscarUser.Text = "Buscar";
            this.btnBuscarUser.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarUser.UseAccentColor = false;
            this.btnBuscarUser.UseVisualStyleBackColor = true;
            this.btnBuscarUser.Click += new System.EventHandler(this.btnBuscarTutor_Click_1);
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(240, 2);
            this.Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(416, 61);
            this.Header.TabIndex = 59;
            this.Header.Text = "Lista de Usuarios";
            // 
            // frmOperacionesPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1430, 771);
            this.ControlBox = false;
            this.Controls.Add(this.Header);
            this.Controls.Add(this.btnBuscarUser);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnInsertarTutor);
            this.Controls.Add(this.btnInsertarPsi);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnMostrarFoto);
            this.Controls.Add(this.btnListarPsi);
            this.Controls.Add(this.btnListarTut);
            this.Controls.Add(this.checkSoloActivos);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.checkSoloPsicologos);
            this.Controls.Add(this.checkSoloTutores);
            this.Controls.Add(this.txtBusqUser);
            this.Controls.Add(this.dgvPsicologos);
            this.Controls.Add(this.dgvTutores);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOperacionesPersona";
            this.Sizable = false;
            this.Text = "Lista de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvTutores;
        private System.Windows.Forms.DataGridView dgvPsicologos;
        private System.Windows.Forms.TextBox txtBusqUser;
        //private MaterialSkin.Controls.MaterialFlatButton btnBuscarUser;
        //private MaterialSkin.Controls.MaterialFlatButton btnInsertarTutor;
        //private MaterialSkin.Controls.MaterialFlatButton btnModificarUsuario;
        //private MaterialSkin.Controls.MaterialFlatButton btnInsertarPsi;
        //private MaterialSkin.Controls.MaterialFlatButton btnDeshabilitar;
        //private MaterialSkin.Controls.MaterialFlatButton btnListarPsi;
        //private MaterialSkin.Controls.MaterialFlatButton btnListarTut;
        //private MaterialSkin.Controls.MaterialFlatButton btnMostrarFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompletoTutor;
        private System.Windows.Forms.DataGridViewImageColumn FotoTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.CheckBox checkSoloTutores;
        private System.Windows.Forms.CheckBox checkSoloPsicologos;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.CheckBox checkSoloActivos;
        private MaterialSkin.Controls.MaterialButton btnListarTut;
        private MaterialSkin.Controls.MaterialButton btnListarPsi;
        private MaterialSkin.Controls.MaterialButton btnMostrarFoto;
        private MaterialSkin.Controls.MaterialButton btnDeshabilitar;
        private MaterialSkin.Controls.MaterialButton btnInsertarPsi;
        private MaterialSkin.Controls.MaterialButton btnInsertarTutor;
        private MaterialSkin.Controls.MaterialButton btnModificarUsuario;
        private MaterialSkin.Controls.MaterialButton btnBuscarUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoUsuario;
        private System.Windows.Forms.DataGridViewImageColumn fotoUsuario;
        private System.Windows.Forms.Label Header;
    }
}