
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTutores = new System.Windows.Forms.Label();
            this.lblPsicologo = new System.Windows.Forms.Label();
            this.dgvTutores = new System.Windows.Forms.DataGridView();
            this.NombreCompletoTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FotoTutor = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvPsicologos = new System.Windows.Forms.DataGridView();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBusqTutor = new System.Windows.Forms.TextBox();
            this.btnBuscarTutor = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInsertarTutor = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificarUsuario = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInsertarPsi = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDeshabilitar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnListarPsi = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnListarTut = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMostrarFoto = new MaterialSkin.Controls.MaterialFlatButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTutores
            // 
            this.lblTutores.AutoSize = true;
            this.lblTutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTutores.ForeColor = System.Drawing.Color.White;
            this.lblTutores.Location = new System.Drawing.Point(1110, 77);
            this.lblTutores.Name = "lblTutores";
            this.lblTutores.Size = new System.Drawing.Size(79, 25);
            this.lblTutores.TabIndex = 14;
            this.lblTutores.Text = "Tutores";
            this.lblTutores.Visible = false;
            // 
            // lblPsicologo
            // 
            this.lblPsicologo.AutoSize = true;
            this.lblPsicologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPsicologo.ForeColor = System.Drawing.Color.White;
            this.lblPsicologo.Location = new System.Drawing.Point(1211, 77);
            this.lblPsicologo.Name = "lblPsicologo";
            this.lblPsicologo.Size = new System.Drawing.Size(107, 25);
            this.lblPsicologo.TabIndex = 18;
            this.lblPsicologo.Text = "Psicólogos";
            this.lblPsicologo.Visible = false;
            // 
            // dgvTutores
            // 
            this.dgvTutores.AllowUserToAddRows = false;
            this.dgvTutores.AllowUserToDeleteRows = false;
            this.dgvTutores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvTutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompletoTutor,
            this.FotoTutor});
            this.dgvTutores.EnableHeadersVisualStyles = false;
            this.dgvTutores.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTutores.Location = new System.Drawing.Point(1578, 29);
            this.dgvTutores.Name = "dgvTutores";
            this.dgvTutores.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTutores.RowHeadersWidth = 62;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTutores.RowsDefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvPsicologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPsicologos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompleto,
            this.foto});
            this.dgvPsicologos.EnableHeadersVisualStyles = false;
            this.dgvPsicologos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPsicologos.Location = new System.Drawing.Point(1578, 45);
            this.dgvPsicologos.Name = "dgvPsicologos";
            this.dgvPsicologos.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvPsicologos.RowHeadersWidth = 62;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPsicologos.RowsDefaultCellStyle = dataGridViewCellStyle15;
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
            // txtBusqTutor
            // 
            this.txtBusqTutor.Location = new System.Drawing.Point(824, 147);
            this.txtBusqTutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqTutor.Name = "txtBusqTutor";
            this.txtBusqTutor.Size = new System.Drawing.Size(432, 26);
            this.txtBusqTutor.TabIndex = 21;
            this.txtBusqTutor.Text = "Nombres y Apellidos";
            this.txtBusqTutor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBusqTutor_MouseClick);
            this.txtBusqTutor.TextChanged += new System.EventHandler(this.txtBusqTutor_TextChanged);
            // 
            // btnBuscarTutor
            // 
            this.btnBuscarTutor.AutoSize = true;
            this.btnBuscarTutor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarTutor.Depth = 0;
            this.btnBuscarTutor.Location = new System.Drawing.Point(1277, 147);
            this.btnBuscarTutor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscarTutor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarTutor.Name = "btnBuscarTutor";
            this.btnBuscarTutor.Primary = false;
            this.btnBuscarTutor.Size = new System.Drawing.Size(93, 36);
            this.btnBuscarTutor.TabIndex = 27;
            this.btnBuscarTutor.Text = "Buscar";
            this.btnBuscarTutor.UseVisualStyleBackColor = true;
            this.btnBuscarTutor.Click += new System.EventHandler(this.btnBuscarTutor_Click_1);
            // 
            // btnInsertarTutor
            // 
            this.btnInsertarTutor.AutoSize = true;
            this.btnInsertarTutor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertarTutor.Depth = 0;
            this.btnInsertarTutor.Location = new System.Drawing.Point(1277, 355);
            this.btnInsertarTutor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInsertarTutor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertarTutor.Name = "btnInsertarTutor";
            this.btnInsertarTutor.Primary = false;
            this.btnInsertarTutor.Size = new System.Drawing.Size(181, 36);
            this.btnInsertarTutor.TabIndex = 28;
            this.btnInsertarTutor.Text = "Insertar Tutor";
            this.btnInsertarTutor.UseVisualStyleBackColor = true;
            this.btnInsertarTutor.Click += new System.EventHandler(this.btnInsertarTutor_Click_1);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.AutoSize = true;
            this.btnModificarUsuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarUsuario.Depth = 0;
            this.btnModificarUsuario.Location = new System.Drawing.Point(1277, 441);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModificarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Primary = false;
            this.btnModificarUsuario.Size = new System.Drawing.Size(214, 36);
            this.btnModificarUsuario.TabIndex = 32;
            this.btnModificarUsuario.Text = "Modificar Usuario";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarPsi_Click_1);
            // 
            // btnInsertarPsi
            // 
            this.btnInsertarPsi.AutoSize = true;
            this.btnInsertarPsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertarPsi.Depth = 0;
            this.btnInsertarPsi.Location = new System.Drawing.Point(1277, 264);
            this.btnInsertarPsi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInsertarPsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertarPsi.Name = "btnInsertarPsi";
            this.btnInsertarPsi.Primary = false;
            this.btnInsertarPsi.Size = new System.Drawing.Size(228, 36);
            this.btnInsertarPsi.TabIndex = 31;
            this.btnInsertarPsi.Text = "Insertar Psicólogo";
            this.btnInsertarPsi.UseVisualStyleBackColor = true;
            this.btnInsertarPsi.Click += new System.EventHandler(this.btnInsertarPsi_Click_1);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.AutoSize = true;
            this.btnDeshabilitar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeshabilitar.Depth = 0;
            this.btnDeshabilitar.Location = new System.Drawing.Point(1025, 1000);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDeshabilitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Primary = false;
            this.btnDeshabilitar.Size = new System.Drawing.Size(246, 36);
            this.btnDeshabilitar.TabIndex = 35;
            this.btnDeshabilitar.Text = "Deshabilitar Usuario";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click_1);
            // 
            // btnListarPsi
            // 
            this.btnListarPsi.AutoSize = true;
            this.btnListarPsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListarPsi.Depth = 0;
            this.btnListarPsi.Location = new System.Drawing.Point(554, 1000);
            this.btnListarPsi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnListarPsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListarPsi.Name = "btnListarPsi";
            this.btnListarPsi.Primary = false;
            this.btnListarPsi.Size = new System.Drawing.Size(213, 36);
            this.btnListarPsi.TabIndex = 34;
            this.btnListarPsi.Text = "Listar Psicologos";
            this.btnListarPsi.UseVisualStyleBackColor = true;
            this.btnListarPsi.Click += new System.EventHandler(this.btnListarPsi_Click_1);
            // 
            // btnListarTut
            // 
            this.btnListarTut.AutoSize = true;
            this.btnListarTut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListarTut.Depth = 0;
            this.btnListarTut.Location = new System.Drawing.Point(41, 1000);
            this.btnListarTut.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnListarTut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListarTut.Name = "btnListarTut";
            this.btnListarTut.Primary = false;
            this.btnListarTut.Size = new System.Drawing.Size(177, 36);
            this.btnListarTut.TabIndex = 33;
            this.btnListarTut.Text = "Listar Tutores";
            this.btnListarTut.UseVisualStyleBackColor = true;
            this.btnListarTut.Click += new System.EventHandler(this.btnListarTut_Click_1);
            // 
            // btnMostrarFoto
            // 
            this.btnMostrarFoto.AutoSize = true;
            this.btnMostrarFoto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMostrarFoto.Depth = 0;
            this.btnMostrarFoto.Location = new System.Drawing.Point(642, 142);
            this.btnMostrarFoto.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnMostrarFoto.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMostrarFoto.Name = "btnMostrarFoto";
            this.btnMostrarFoto.Primary = false;
            this.btnMostrarFoto.Size = new System.Drawing.Size(163, 36);
            this.btnMostrarFoto.TabIndex = 36;
            this.btnMostrarFoto.Text = "Ocultar Foto";
            this.btnMostrarFoto.UseVisualStyleBackColor = true;
            this.btnMostrarFoto.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // checkSoloTutores
            // 
            this.checkSoloTutores.AutoSize = true;
            this.checkSoloTutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkSoloTutores.ForeColor = System.Drawing.Color.White;
            this.checkSoloTutores.Location = new System.Drawing.Point(41, 145);
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
            this.checkSoloPsicologos.Location = new System.Drawing.Point(245, 147);
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
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
            this.dgvUsuario.Location = new System.Drawing.Point(41, 201);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvUsuario.RowHeadersVisible = false;
            this.dgvUsuario.RowHeadersWidth = 62;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuario.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvUsuario.RowTemplate.Height = 28;
            this.dgvUsuario.Size = new System.Drawing.Size(1230, 778);
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
            this.fotoUsuario.Image = global::InterfazDATMA.Properties.Resources.avatarPsicologa;
            this.fotoUsuario.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.fotoUsuario.MinimumWidth = 8;
            this.fotoUsuario.Name = "fotoUsuario";
            this.fotoUsuario.ReadOnly = true;
            this.fotoUsuario.Width = 70;
            // 
            // checkSoloActivos
            // 
            this.checkSoloActivos.AutoSize = true;
            this.checkSoloActivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkSoloActivos.ForeColor = System.Drawing.Color.White;
            this.checkSoloActivos.Location = new System.Drawing.Point(467, 142);
            this.checkSoloActivos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkSoloActivos.Name = "checkSoloActivos";
            this.checkSoloActivos.Size = new System.Drawing.Size(147, 29);
            this.checkSoloActivos.TabIndex = 50;
            this.checkSoloActivos.Text = "Solo Activos";
            this.checkSoloActivos.UseVisualStyleBackColor = true;
            this.checkSoloActivos.CheckedChanged += new System.EventHandler(this.checkSoloActivos_CheckedChanged);
            // 
            // frmOperacionesPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1600, 1050);
            this.ControlBox = false;
            this.Controls.Add(this.checkSoloActivos);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.checkSoloPsicologos);
            this.Controls.Add(this.checkSoloTutores);
            this.Controls.Add(this.btnMostrarFoto);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnListarPsi);
            this.Controls.Add(this.btnListarTut);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(this.btnInsertarPsi);
            this.Controls.Add(this.btnInsertarTutor);
            this.Controls.Add(this.btnBuscarTutor);
            this.Controls.Add(this.txtBusqTutor);
            this.Controls.Add(this.dgvPsicologos);
            this.Controls.Add(this.dgvTutores);
            this.Controls.Add(this.lblPsicologo);
            this.Controls.Add(this.lblTutores);
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
        private System.Windows.Forms.Label lblTutores;
        private System.Windows.Forms.Label lblPsicologo;
        private System.Windows.Forms.DataGridView dgvTutores;
        private System.Windows.Forms.DataGridView dgvPsicologos;
        private System.Windows.Forms.TextBox txtBusqTutor;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarTutor;
        private MaterialSkin.Controls.MaterialFlatButton btnInsertarTutor;
        private MaterialSkin.Controls.MaterialFlatButton btnModificarUsuario;
        private MaterialSkin.Controls.MaterialFlatButton btnInsertarPsi;
        private MaterialSkin.Controls.MaterialFlatButton btnDeshabilitar;
        private MaterialSkin.Controls.MaterialFlatButton btnListarPsi;
        private MaterialSkin.Controls.MaterialFlatButton btnListarTut;
        private MaterialSkin.Controls.MaterialFlatButton btnMostrarFoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompletoTutor;
        private System.Windows.Forms.DataGridViewImageColumn FotoTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.CheckBox checkSoloTutores;
        private System.Windows.Forms.CheckBox checkSoloPsicologos;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.CheckBox checkSoloActivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn activoUsuario;
        private System.Windows.Forms.DataGridViewImageColumn fotoUsuario;
    }
}