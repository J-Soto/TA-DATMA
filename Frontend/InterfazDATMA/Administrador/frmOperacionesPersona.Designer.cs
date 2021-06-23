
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTutores = new System.Windows.Forms.Label();
            this.lblPsicologo = new System.Windows.Forms.Label();
            this.dgvTutores = new System.Windows.Forms.DataGridView();
            this.NombreCompletoTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajoRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FotoTutor = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvPsicologos = new System.Windows.Forms.DataGridView();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantCursos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBusqTutor = new System.Windows.Forms.TextBox();
            this.txtBusqPsi = new System.Windows.Forms.TextBox();
            this.btnBuscarTutor = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInsertarTutor = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificarTutor = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModificarPsi = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnInsertarPsi = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBuscarPsi = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnDeshabilitar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnListarPsi = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnListarTut = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnMostrarFoto = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTutores
            // 
            this.lblTutores.AutoSize = true;
            this.lblTutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTutores.ForeColor = System.Drawing.Color.White;
            this.lblTutores.Location = new System.Drawing.Point(40, 58);
            this.lblTutores.Name = "lblTutores";
            this.lblTutores.Size = new System.Drawing.Size(79, 25);
            this.lblTutores.TabIndex = 14;
            this.lblTutores.Text = "Tutores";
            // 
            // lblPsicologo
            // 
            this.lblPsicologo.AutoSize = true;
            this.lblPsicologo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPsicologo.ForeColor = System.Drawing.Color.White;
            this.lblPsicologo.Location = new System.Drawing.Point(40, 355);
            this.lblPsicologo.Name = "lblPsicologo";
            this.lblPsicologo.Size = new System.Drawing.Size(107, 25);
            this.lblPsicologo.TabIndex = 18;
            this.lblPsicologo.Text = "Psicólogos";
            // 
            // dgvTutores
            // 
            this.dgvTutores.AllowUserToAddRows = false;
            this.dgvTutores.AllowUserToDeleteRows = false;
            this.dgvTutores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvTutores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTutores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompletoTutor,
            this.celularTutor,
            this.bajoRE,
            this.FotoTutor});
            this.dgvTutores.EnableHeadersVisualStyles = false;
            this.dgvTutores.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTutores.Location = new System.Drawing.Point(44, 106);
            this.dgvTutores.Name = "dgvTutores";
            this.dgvTutores.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTutores.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTutores.RowHeadersWidth = 62;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTutores.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTutores.RowTemplate.Height = 28;
            this.dgvTutores.Size = new System.Drawing.Size(934, 212);
            this.dgvTutores.TabIndex = 19;
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
            // celularTutor
            // 
            this.celularTutor.HeaderText = "Celular";
            this.celularTutor.MinimumWidth = 8;
            this.celularTutor.Name = "celularTutor";
            this.celularTutor.ReadOnly = true;
            this.celularTutor.Width = 150;
            // 
            // bajoRE
            // 
            this.bajoRE.HeaderText = "Bajo Recursos Económicos";
            this.bajoRE.MinimumWidth = 8;
            this.bajoRE.Name = "bajoRE";
            this.bajoRE.ReadOnly = true;
            this.bajoRE.Width = 150;
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
            this.dgvPsicologos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPsicologos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPsicologos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPsicologos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPsicologos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreCompleto,
            this.celular,
            this.cantCursos,
            this.foto});
            this.dgvPsicologos.EnableHeadersVisualStyles = false;
            this.dgvPsicologos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPsicologos.Location = new System.Drawing.Point(44, 400);
            this.dgvPsicologos.Name = "dgvPsicologos";
            this.dgvPsicologos.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPsicologos.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPsicologos.RowHeadersWidth = 62;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPsicologos.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPsicologos.RowTemplate.Height = 28;
            this.dgvPsicologos.Size = new System.Drawing.Size(934, 212);
            this.dgvPsicologos.TabIndex = 20;
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
            // celular
            // 
            this.celular.HeaderText = "Celular";
            this.celular.MinimumWidth = 8;
            this.celular.Name = "celular";
            this.celular.ReadOnly = true;
            this.celular.Width = 150;
            // 
            // cantCursos
            // 
            this.cantCursos.HeaderText = "Cursos Dictando";
            this.cantCursos.MinimumWidth = 8;
            this.cantCursos.Name = "cantCursos";
            this.cantCursos.ReadOnly = true;
            this.cantCursos.Width = 150;
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
            this.txtBusqTutor.Location = new System.Drawing.Point(544, 56);
            this.txtBusqTutor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqTutor.Name = "txtBusqTutor";
            this.txtBusqTutor.Size = new System.Drawing.Size(432, 26);
            this.txtBusqTutor.TabIndex = 21;
            this.txtBusqTutor.Text = "Nombres y Apellidos";
            this.txtBusqTutor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBusqTutor_MouseClick);
            // 
            // txtBusqPsi
            // 
            this.txtBusqPsi.Location = new System.Drawing.Point(544, 354);
            this.txtBusqPsi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBusqPsi.Name = "txtBusqPsi";
            this.txtBusqPsi.Size = new System.Drawing.Size(432, 26);
            this.txtBusqPsi.TabIndex = 22;
            this.txtBusqPsi.Text = "Nombres y Apellidos";
            this.txtBusqPsi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBusqPsi_MouseClick);
            // 
            // btnBuscarTutor
            // 
            this.btnBuscarTutor.AutoSize = true;
            this.btnBuscarTutor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarTutor.Depth = 0;
            this.btnBuscarTutor.Location = new System.Drawing.Point(996, 106);
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
            this.btnInsertarTutor.Location = new System.Drawing.Point(996, 166);
            this.btnInsertarTutor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnInsertarTutor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnInsertarTutor.Name = "btnInsertarTutor";
            this.btnInsertarTutor.Primary = false;
            this.btnInsertarTutor.Size = new System.Drawing.Size(176, 36);
            this.btnInsertarTutor.TabIndex = 28;
            this.btnInsertarTutor.Text = "InsertarTutor";
            this.btnInsertarTutor.UseVisualStyleBackColor = true;
            this.btnInsertarTutor.Click += new System.EventHandler(this.btnInsertarTutor_Click_1);
            // 
            // btnModificarTutor
            // 
            this.btnModificarTutor.AutoSize = true;
            this.btnModificarTutor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarTutor.Depth = 0;
            this.btnModificarTutor.Location = new System.Drawing.Point(996, 222);
            this.btnModificarTutor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModificarTutor.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarTutor.Name = "btnModificarTutor";
            this.btnModificarTutor.Primary = false;
            this.btnModificarTutor.Size = new System.Drawing.Size(188, 36);
            this.btnModificarTutor.TabIndex = 29;
            this.btnModificarTutor.Text = "ModificarTutor";
            this.btnModificarTutor.UseVisualStyleBackColor = true;
            this.btnModificarTutor.Click += new System.EventHandler(this.btnModificarTutor_Click_1);
            // 
            // btnModificarPsi
            // 
            this.btnModificarPsi.AutoSize = true;
            this.btnModificarPsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificarPsi.Depth = 0;
            this.btnModificarPsi.Location = new System.Drawing.Point(983, 528);
            this.btnModificarPsi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModificarPsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificarPsi.Name = "btnModificarPsi";
            this.btnModificarPsi.Primary = false;
            this.btnModificarPsi.Size = new System.Drawing.Size(241, 36);
            this.btnModificarPsi.TabIndex = 32;
            this.btnModificarPsi.Text = "Modificar Psicólogo";
            this.btnModificarPsi.UseVisualStyleBackColor = true;
            this.btnModificarPsi.Click += new System.EventHandler(this.btnModificarPsi_Click_1);
            // 
            // btnInsertarPsi
            // 
            this.btnInsertarPsi.AutoSize = true;
            this.btnInsertarPsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInsertarPsi.Depth = 0;
            this.btnInsertarPsi.Location = new System.Drawing.Point(983, 462);
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
            // btnBuscarPsi
            // 
            this.btnBuscarPsi.AutoSize = true;
            this.btnBuscarPsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarPsi.Depth = 0;
            this.btnBuscarPsi.Location = new System.Drawing.Point(983, 400);
            this.btnBuscarPsi.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscarPsi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarPsi.Name = "btnBuscarPsi";
            this.btnBuscarPsi.Primary = false;
            this.btnBuscarPsi.Size = new System.Drawing.Size(93, 36);
            this.btnBuscarPsi.TabIndex = 30;
            this.btnBuscarPsi.Text = "Buscar";
            this.btnBuscarPsi.UseVisualStyleBackColor = true;
            this.btnBuscarPsi.Click += new System.EventHandler(this.btnBuscarPsi_Click_1);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.AutoSize = true;
            this.btnDeshabilitar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDeshabilitar.Depth = 0;
            this.btnDeshabilitar.Location = new System.Drawing.Point(837, 636);
            this.btnDeshabilitar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDeshabilitar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Primary = false;
            this.btnDeshabilitar.Size = new System.Drawing.Size(253, 36);
            this.btnDeshabilitar.TabIndex = 35;
            this.btnDeshabilitar.Text = "Deshabilitar Persona";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click_1);
            // 
            // btnListarPsi
            // 
            this.btnListarPsi.AutoSize = true;
            this.btnListarPsi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListarPsi.Depth = 0;
            this.btnListarPsi.Location = new System.Drawing.Point(421, 636);
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
            this.btnListarTut.Location = new System.Drawing.Point(52, 636);
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
            this.btnMostrarFoto.Location = new System.Drawing.Point(996, 282);
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
            // frmOperacionesPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1258, 677);
            this.ControlBox = false;
            this.Controls.Add(this.btnMostrarFoto);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnListarPsi);
            this.Controls.Add(this.btnListarTut);
            this.Controls.Add(this.btnModificarPsi);
            this.Controls.Add(this.btnInsertarPsi);
            this.Controls.Add(this.btnBuscarPsi);
            this.Controls.Add(this.btnModificarTutor);
            this.Controls.Add(this.btnInsertarTutor);
            this.Controls.Add(this.btnBuscarTutor);
            this.Controls.Add(this.txtBusqPsi);
            this.Controls.Add(this.txtBusqTutor);
            this.Controls.Add(this.dgvPsicologos);
            this.Controls.Add(this.dgvTutores);
            this.Controls.Add(this.lblPsicologo);
            this.Controls.Add(this.lblTutores);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOperacionesPersona";
            this.Sizable = false;
            this.Text = "Operaciones Persona";
            this.Load += new System.EventHandler(this.frmOperacionesPersona_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsicologos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTutores;
        private System.Windows.Forms.Label lblPsicologo;
        private System.Windows.Forms.DataGridView dgvTutores;
        private System.Windows.Forms.DataGridView dgvPsicologos;
        private System.Windows.Forms.TextBox txtBusqTutor;
        private System.Windows.Forms.TextBox txtBusqPsi;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarTutor;
        private MaterialSkin.Controls.MaterialFlatButton btnInsertarTutor;
        private MaterialSkin.Controls.MaterialFlatButton btnModificarTutor;
        private MaterialSkin.Controls.MaterialFlatButton btnModificarPsi;
        private MaterialSkin.Controls.MaterialFlatButton btnInsertarPsi;
        private MaterialSkin.Controls.MaterialFlatButton btnBuscarPsi;
        private MaterialSkin.Controls.MaterialFlatButton btnDeshabilitar;
        private MaterialSkin.Controls.MaterialFlatButton btnListarPsi;
        private MaterialSkin.Controls.MaterialFlatButton btnListarTut;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantCursos;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompletoTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn bajoRE;
        private System.Windows.Forms.DataGridViewImageColumn FotoTutor;
        private MaterialSkin.Controls.MaterialFlatButton btnMostrarFoto;
    }
}