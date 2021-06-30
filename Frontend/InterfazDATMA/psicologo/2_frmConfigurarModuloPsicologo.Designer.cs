
namespace InterfazDATMA
{
    partial class frmConfigurarModuloPsicologo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.dgvPrograma = new System.Windows.Forms.DataGridView();
            this.Semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.VolverCursos = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumeroModulo = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.VolverCuidadores = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurso = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel25 = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ModificarSemana = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel15.SuspendLayout();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograma)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel24.SuspendLayout();
            this.tableLayoutPanel25.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.238465F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.73641F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.980025F));
            this.tableLayoutPanel15.Controls.Add(this.materialCard1, 1, 1);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 335);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 3;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(1398, 553);
            this.tableLayoutPanel15.TabIndex = 33;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvPrograma);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(45, 69);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1269, 414);
            this.materialCard1.TabIndex = 47;
            // 
            // dgvPrograma
            // 
            this.dgvPrograma.AllowUserToAddRows = false;
            this.dgvPrograma.AllowUserToDeleteRows = false;
            this.dgvPrograma.AllowUserToResizeColumns = false;
            this.dgvPrograma.AllowUserToResizeRows = false;
            this.dgvPrograma.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvPrograma.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPrograma.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrograma.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrograma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrograma.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semana,
            this.Tema,
            this.FechaInicio});
            this.dgvPrograma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrograma.EnableHeadersVisualStyles = false;
            this.dgvPrograma.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPrograma.Location = new System.Drawing.Point(14, 14);
            this.dgvPrograma.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPrograma.Name = "dgvPrograma";
            this.dgvPrograma.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrograma.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrograma.RowHeadersWidth = 62;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPrograma.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrograma.RowTemplate.Height = 28;
            this.dgvPrograma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrograma.Size = new System.Drawing.Size(1241, 386);
            this.dgvPrograma.TabIndex = 10;
            // 
            // Semana
            // 
            this.Semana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Semana.DataPropertyName = "NombreSemana";
            this.Semana.HeaderText = "Semana";
            this.Semana.MinimumWidth = 8;
            this.Semana.Name = "Semana";
            this.Semana.ReadOnly = true;
            // 
            // Tema
            // 
            this.Tema.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tema.DataPropertyName = "NombreTema";
            this.Tema.HeaderText = "Tema";
            this.Tema.MinimumWidth = 8;
            this.Tema.Name = "Tema";
            this.Tema.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaInicio.DataPropertyName = "FechaInicio";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            dataGridViewCellStyle2.NullValue = null;
            this.FechaInicio.DefaultCellStyle = dataGridViewCellStyle2;
            this.FechaInicio.HeaderText = "Fecha Inicio";
            this.FechaInicio.MinimumWidth = 8;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel18, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel15, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel17, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel24, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel11, 0, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 80);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1404, 1115);
            this.tableLayoutPanel3.TabIndex = 55;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel18.ColumnCount = 3;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.71474F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.42028F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.888077F));
            this.tableLayoutPanel18.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 1003);
            this.tableLayoutPanel18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(1398, 110);
            this.tableLayoutPanel18.TabIndex = 60;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.VolverCursos);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(1047, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 106);
            this.panel6.TabIndex = 32;
            // 
            // VolverCursos
            // 
            this.VolverCursos.AutoSize = false;
            this.VolverCursos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VolverCursos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.VolverCursos.Depth = 0;
            this.VolverCursos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VolverCursos.HighEmphasis = true;
            this.VolverCursos.Icon = null;
            this.VolverCursos.Location = new System.Drawing.Point(0, 0);
            this.VolverCursos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VolverCursos.MouseState = MaterialSkin.MouseState.HOVER;
            this.VolverCursos.Name = "VolverCursos";
            this.VolverCursos.Size = new System.Drawing.Size(279, 106);
            this.VolverCursos.TabIndex = 60;
            this.VolverCursos.Text = "Volver a la lista de cursos";
            this.VolverCursos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VolverCursos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.VolverCursos.UseAccentColor = false;
            this.VolverCursos.UseVisualStyleBackColor = true;
            this.VolverCursos.Click += new System.EventHandler(this.VolverCursos_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel26, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel27, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1398, 107);
            this.tableLayoutPanel9.TabIndex = 60;
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel26.ColumnCount = 3;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.330883F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.06618F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.52243F));
            this.tableLayoutPanel26.Controls.Add(this.lblNumeroModulo, 1, 1);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel26.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 3;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(693, 103);
            this.tableLayoutPanel26.TabIndex = 28;
            // 
            // lblNumeroModulo
            // 
            this.lblNumeroModulo.BackColor = System.Drawing.Color.Maroon;
            this.lblNumeroModulo.Depth = 0;
            this.lblNumeroModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumeroModulo.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNumeroModulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNumeroModulo.Location = new System.Drawing.Point(39, 20);
            this.lblNumeroModulo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumeroModulo.Name = "lblNumeroModulo";
            this.lblNumeroModulo.Size = new System.Drawing.Size(382, 61);
            this.lblNumeroModulo.TabIndex = 58;
            this.lblNumeroModulo.Text = "Modulo 1";
            this.lblNumeroModulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel27.ColumnCount = 3;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.40404F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.733701F));
            this.tableLayoutPanel27.Controls.Add(this.VolverCuidadores, 1, 1);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(702, 2);
            this.tableLayoutPanel27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 3;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(693, 103);
            this.tableLayoutPanel27.TabIndex = 27;
            // 
            // VolverCuidadores
            // 
            this.VolverCuidadores.AutoSize = false;
            this.VolverCuidadores.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.VolverCuidadores.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.VolverCuidadores.Depth = 0;
            this.VolverCuidadores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VolverCuidadores.HighEmphasis = true;
            this.VolverCuidadores.Icon = null;
            this.VolverCuidadores.Location = new System.Drawing.Point(350, 26);
            this.VolverCuidadores.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.VolverCuidadores.MouseState = MaterialSkin.MouseState.HOVER;
            this.VolverCuidadores.Name = "VolverCuidadores";
            this.VolverCuidadores.Size = new System.Drawing.Size(271, 49);
            this.VolverCuidadores.TabIndex = 61;
            this.VolverCuidadores.Text = "Lista de Cuidadores";
            this.VolverCuidadores.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.VolverCuidadores.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.VolverCuidadores.UseAccentColor = false;
            this.VolverCuidadores.UseVisualStyleBackColor = true;
            this.VolverCuidadores.Click += new System.EventHandler(this.VolverCuidadores_Click);
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel17.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel17.ColumnCount = 3;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.414579F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.4738F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.15717F));
            this.tableLayoutPanel17.Controls.Add(this.tableLayoutPanel20, 1, 1);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(0, 111);
            this.tableLayoutPanel17.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 3;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(1404, 111);
            this.tableLayoutPanel17.TabIndex = 60;
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel20.ColumnCount = 3;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.171303F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.70425F));
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel20.Controls.Add(this.lblCurso, 1, 1);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(36, 24);
            this.tableLayoutPanel20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 3;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(393, 62);
            this.tableLayoutPanel20.TabIndex = 61;
            // 
            // lblCurso
            // 
            this.lblCurso.BackColor = System.Drawing.Color.Transparent;
            this.lblCurso.Depth = 0;
            this.lblCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurso.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblCurso.Location = new System.Drawing.Point(7, 3);
            this.lblCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(362, 55);
            this.lblCurso.TabIndex = 57;
            this.lblCurso.Text = "Programa:";
            this.lblCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel24.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel24.ColumnCount = 3;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.36902F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.79043F));
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.8861F));
            this.tableLayoutPanel24.Controls.Add(this.tableLayoutPanel25, 1, 1);
            this.tableLayoutPanel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel24.Location = new System.Drawing.Point(0, 222);
            this.tableLayoutPanel24.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 3;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(1404, 111);
            this.tableLayoutPanel24.TabIndex = 60;
            // 
            // tableLayoutPanel25
            // 
            this.tableLayoutPanel25.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel25.ColumnCount = 3;
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.171875F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.46354F));
            this.tableLayoutPanel25.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.29484F));
            this.tableLayoutPanel25.Controls.Add(this.materialLabel3, 1, 1);
            this.tableLayoutPanel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel25.Location = new System.Drawing.Point(36, 24);
            this.tableLayoutPanel25.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel25.Name = "tableLayoutPanel25";
            this.tableLayoutPanel25.RowCount = 3;
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel25.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel25.Size = new System.Drawing.Size(664, 62);
            this.tableLayoutPanel25.TabIndex = 61;
            // 
            // materialLabel3
            // 
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(10, 3);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(382, 55);
            this.materialLabel3.TabIndex = 59;
            this.materialLabel3.Text = "Modulo nro1-3.52";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel11.ColumnCount = 5;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.055733F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.30882F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.63408F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.29603F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.842394F));
            this.tableLayoutPanel11.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 892);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1398, 107);
            this.tableLayoutPanel11.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ModificarSemana);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(31, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 103);
            this.panel3.TabIndex = 32;
            // 
            // ModificarSemana
            // 
            this.ModificarSemana.AutoSize = false;
            this.ModificarSemana.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ModificarSemana.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ModificarSemana.Depth = 0;
            this.ModificarSemana.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModificarSemana.HighEmphasis = true;
            this.ModificarSemana.Icon = null;
            this.ModificarSemana.Location = new System.Drawing.Point(0, 0);
            this.ModificarSemana.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ModificarSemana.MouseState = MaterialSkin.MouseState.HOVER;
            this.ModificarSemana.Name = "ModificarSemana";
            this.ModificarSemana.Size = new System.Drawing.Size(221, 103);
            this.ModificarSemana.TabIndex = 0;
            this.ModificarSemana.Text = "Modificar Semana";
            this.ModificarSemana.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ModificarSemana.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ModificarSemana.UseAccentColor = false;
            this.ModificarSemana.UseVisualStyleBackColor = true;
            this.ModificarSemana.Click += new System.EventHandler(this.ModificarSemana_Click);
            // 
            // frmConfigurarModuloPsicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1412, 1199);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmConfigurarModuloPsicologo";
            this.Padding = new System.Windows.Forms.Padding(4, 80, 4, 4);
            this.Sizable = false;
            this.Text = "frmConfigurarModuloPsicologo";
            this.Load += new System.EventHandler(this.frmConfigurarModuloPsicologo_Load);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrograma)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel24.ResumeLayout(false);
            this.tableLayoutPanel25.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel lblCurso;
        private MaterialSkin.Controls.MaterialLabel lblNumeroModulo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialButton VolverCursos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton ModificarSemana;
        private MaterialSkin.Controls.MaterialButton VolverCuidadores;
        private System.Windows.Forms.DataGridView dgvPrograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tema;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
    }
}