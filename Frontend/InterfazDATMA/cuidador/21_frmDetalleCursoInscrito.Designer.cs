
namespace InterfazDATMA
{
    partial class frmDetalleCursoInscrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleCursoInscrito));
            this.btnRegresar = new MaterialSkin.Controls.MaterialButton();
            this.dgvSemanas = new System.Windows.Forms.DataGridView();
            this.Semana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSemanaDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReuniones = new MaterialSkin.Controls.MaterialButton();
            this.btnMaterial = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.nLabelControl1 = new Nevron.Nov.WinFormControls.NLabelControl();
            this.tableLayoutPanel27 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombreCurso = new Nevron.Nov.WinFormControls.NLabelControl();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.nLabelControl3 = new Nevron.Nov.WinFormControls.NLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel27.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = false;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegresar.HighEmphasis = true;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(254, 16);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(215, 20);
            this.btnRegresar.TabIndex = 0;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegresar.UseAccentColor = false;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // dgvSemanas
            // 
            this.dgvSemanas.AllowUserToAddRows = false;
            this.dgvSemanas.AllowUserToDeleteRows = false;
            this.dgvSemanas.AllowUserToResizeColumns = false;
            this.dgvSemanas.AllowUserToResizeRows = false;
            this.dgvSemanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemanas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Semana});
            this.dgvSemanas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSemanas.Location = new System.Drawing.Point(6, 7);
            this.dgvSemanas.MultiSelect = false;
            this.dgvSemanas.Name = "dgvSemanas";
            this.dgvSemanas.ReadOnly = true;
            this.dgvSemanas.RowHeadersVisible = false;
            this.dgvSemanas.RowHeadersWidth = 82;
            this.dgvSemanas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSemanas.Size = new System.Drawing.Size(728, 128);
            this.dgvSemanas.TabIndex = 1;
            this.dgvSemanas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSemanas_CellClick);
            // 
            // Semana
            // 
            this.Semana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Semana.DataPropertyName = "nombre";
            this.Semana.HeaderText = "Nombre";
            this.Semana.MinimumWidth = 10;
            this.Semana.Name = "Semana";
            this.Semana.ReadOnly = true;
            // 
            // txtSemanaDescripcion
            // 
            this.txtSemanaDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtSemanaDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSemanaDescripcion.Depth = 0;
            this.txtSemanaDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSemanaDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSemanaDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSemanaDescripcion.Location = new System.Drawing.Point(20, 16);
            this.txtSemanaDescripcion.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSemanaDescripcion.Name = "txtSemanaDescripcion";
            this.txtSemanaDescripcion.ReadOnly = true;
            this.txtSemanaDescripcion.Size = new System.Drawing.Size(132, 109);
            this.txtSemanaDescripcion.TabIndex = 3;
            this.txtSemanaDescripcion.Text = "";
            // 
            // dgvActividades
            // 
            this.dgvActividades.AllowUserToAddRows = false;
            this.dgvActividades.AllowUserToDeleteRows = false;
            this.dgvActividades.AllowUserToResizeColumns = false;
            this.dgvActividades.AllowUserToResizeRows = false;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.FechaInicio,
            this.HoraInicio,
            this.HoraFin});
            this.dgvActividades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActividades.Location = new System.Drawing.Point(6, 7);
            this.dgvActividades.MultiSelect = false;
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.RowHeadersVisible = false;
            this.dgvActividades.RowHeadersWidth = 82;
            this.dgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActividades.Size = new System.Drawing.Size(765, 181);
            this.dgvActividades.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FechaInicio.DataPropertyName = "fecha";
            this.FechaInicio.HeaderText = "Fecha Inicial";
            this.FechaInicio.MinimumWidth = 10;
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // HoraInicio
            // 
            this.HoraInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoraInicio.DataPropertyName = "horaInicioStr";
            this.HoraInicio.HeaderText = "Hora Inicial";
            this.HoraInicio.MinimumWidth = 10;
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // HoraFin
            // 
            this.HoraFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HoraFin.DataPropertyName = "horaFinStr";
            this.HoraFin.HeaderText = "Hora Final";
            this.HoraFin.MinimumWidth = 10;
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            // 
            // btnReuniones
            // 
            this.btnReuniones.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReuniones.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnReuniones.Depth = 0;
            this.btnReuniones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReuniones.HighEmphasis = true;
            this.btnReuniones.Icon = null;
            this.btnReuniones.Location = new System.Drawing.Point(0, 0);
            this.btnReuniones.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnReuniones.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnReuniones.Name = "btnReuniones";
            this.btnReuniones.Size = new System.Drawing.Size(136, 37);
            this.btnReuniones.TabIndex = 7;
            this.btnReuniones.Text = "Ir a Reunion";
            this.btnReuniones.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnReuniones.UseAccentColor = false;
            this.btnReuniones.UseVisualStyleBackColor = true;
            this.btnReuniones.Click += new System.EventHandler(this.btnReuniones_Click);
            // 
            // btnMaterial
            // 
            this.btnMaterial.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMaterial.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMaterial.Depth = 0;
            this.btnMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMaterial.HighEmphasis = true;
            this.btnMaterial.Icon = null;
            this.btnMaterial.Location = new System.Drawing.Point(0, 0);
            this.btnMaterial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMaterial.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(136, 37);
            this.btnMaterial.TabIndex = 8;
            this.btnMaterial.Text = "Ver Material";
            this.btnMaterial.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMaterial.UseAccentColor = false;
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.btnMaterial_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.626459F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.34436F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.Controls.Add(this.materialCard1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 348);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(958, 233);
            this.tableLayoutPanel4.TabIndex = 30;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dgvActividades);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(31, 18);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.materialCard1.Size = new System.Drawing.Size(777, 195);
            this.materialCard1.TabIndex = 47;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(816, 13);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(140, 205);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.btnMaterial);
            this.panel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(2, 125);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(136, 37);
            this.panel7.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.btnReuniones);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(2, 43);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(136, 37);
            this.panel6.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.012404F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.98759F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.Controls.Add(this.materialCard2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialCard3, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 116);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 174);
            this.tableLayoutPanel1.TabIndex = 53;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.dgvSemanas);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(29, 15);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.materialCard2.Size = new System.Drawing.Size(740, 142);
            this.materialCard2.TabIndex = 54;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.tableLayoutPanel3);
            this.materialCard3.Depth = 0;
            this.materialCard3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(782, 15);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.materialCard3.Size = new System.Drawing.Size(169, 142);
            this.materialCard3.TabIndex = 55;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.Controls.Add(this.txtSemanaDescripcion, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.809264F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.6485F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(155, 128);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.832031F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.83203F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.28711F));
            this.tableLayoutPanel6.Controls.Add(this.nLabelControl1, 1, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 60);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(954, 54);
            this.tableLayoutPanel6.TabIndex = 54;
            // 
            // nLabelControl1
            // 
            this.nLabelControl1.AutoSize = false;
            this.nLabelControl1.DesignTimeState = resources.GetString("nLabelControl1.DesignTimeState");
            this.nLabelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nLabelControl1.Location = new System.Drawing.Point(29, 7);
            this.nLabelControl1.Name = "nLabelControl1";
            this.nLabelControl1.Size = new System.Drawing.Size(261, 39);
            this.nLabelControl1.TabIndex = 95;
            // 
            // tableLayoutPanel27
            // 
            this.tableLayoutPanel27.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel27.ColumnCount = 2;
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel27.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.45535F));
            this.tableLayoutPanel27.Controls.Add(this.btnRegresar, 1, 1);
            this.tableLayoutPanel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel27.Location = new System.Drawing.Point(479, 1);
            this.tableLayoutPanel27.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel27.Name = "tableLayoutPanel27";
            this.tableLayoutPanel27.RowCount = 3;
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel27.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel27.Size = new System.Drawing.Size(473, 54);
            this.tableLayoutPanel27.TabIndex = 27;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel26, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel27, 1, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(954, 56);
            this.tableLayoutPanel9.TabIndex = 61;
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel26.ColumnCount = 3;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.330883F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.06618F));
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.52243F));
            this.tableLayoutPanel26.Controls.Add(this.txtNombreCurso, 1, 1);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel26.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 3;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(473, 54);
            this.tableLayoutPanel26.TabIndex = 28;
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.AutoSize = false;
            this.txtNombreCurso.DesignTimeState = resources.GetString("txtNombreCurso.DesignTimeState");
            this.txtNombreCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreCurso.Location = new System.Drawing.Point(27, 12);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(261, 28);
            this.txtNombreCurso.TabIndex = 94;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel1, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 33);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(958, 581);
            this.tableLayoutPanel7.TabIndex = 62;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.076172F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.23828F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.636719F));
            this.tableLayoutPanel5.Controls.Add(this.nLabelControl3, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 292);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(954, 54);
            this.tableLayoutPanel5.TabIndex = 50;
            // 
            // nLabelControl3
            // 
            this.nLabelControl3.AutoSize = false;
            this.nLabelControl3.DesignTimeState = resources.GetString("nLabelControl3.DesignTimeState");
            this.nLabelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nLabelControl3.Location = new System.Drawing.Point(31, 7);
            this.nLabelControl3.Name = "nLabelControl3";
            this.nLabelControl3.Size = new System.Drawing.Size(895, 39);
            this.nLabelControl3.TabIndex = 97;
            // 
            // frmDetalleCursoInscrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(962, 616);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel7);
            this.Name = "frmDetalleCursoInscrito";
            this.Padding = new System.Windows.Forms.Padding(2, 33, 2, 2);
            this.Text = "DATMA";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel27.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnRegresar;
        private System.Windows.Forms.DataGridView dgvSemanas;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtSemanaDescripcion;
        private System.Windows.Forms.DataGridView dgvActividades;
        private MaterialSkin.Controls.MaterialButton btnReuniones;
        private MaterialSkin.Controls.MaterialButton btnMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Semana;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel27;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private Nevron.Nov.WinFormControls.NLabelControl nLabelControl1;
        private Nevron.Nov.WinFormControls.NLabelControl txtNombreCurso;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Nevron.Nov.WinFormControls.NLabelControl nLabelControl3;
    }
}