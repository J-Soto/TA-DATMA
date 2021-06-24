
namespace InterfazDATMA
{
    partial class frmInsertarSemana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsertarSemana));
            this.txtSemanaNombre = new System.Windows.Forms.TextBox();
            this.txtSemanaDescrip = new System.Windows.Forms.TextBox();
            this.dateSemanaFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvTemas = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.dateCursoFechaFin = new Nevron.Nov.WinFormControls.NDateTimeBoxControl();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dateCursoFechaInicio = new Nevron.Nov.WinFormControls.NDateTimeBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).BeginInit();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSemanaNombre
            // 
            this.txtSemanaNombre.Location = new System.Drawing.Point(194, 202);
            this.txtSemanaNombre.Margin = new System.Windows.Forms.Padding(6);
            this.txtSemanaNombre.Name = "txtSemanaNombre";
            this.txtSemanaNombre.Size = new System.Drawing.Size(396, 31);
            this.txtSemanaNombre.TabIndex = 0;
            // 
            // txtSemanaDescrip
            // 
            this.txtSemanaDescrip.Location = new System.Drawing.Point(194, 271);
            this.txtSemanaDescrip.Margin = new System.Windows.Forms.Padding(6);
            this.txtSemanaDescrip.Name = "txtSemanaDescrip";
            this.txtSemanaDescrip.Size = new System.Drawing.Size(552, 31);
            this.txtSemanaDescrip.TabIndex = 1;
            // 
            // dateSemanaFechaInicio
            // 
            this.dateSemanaFechaInicio.Location = new System.Drawing.Point(194, 338);
            this.dateSemanaFechaInicio.Margin = new System.Windows.Forms.Padding(6);
            this.dateSemanaFechaInicio.Name = "dateSemanaFechaInicio";
            this.dateSemanaFechaInicio.Size = new System.Drawing.Size(396, 31);
            this.dateSemanaFechaInicio.TabIndex = 2;
            this.dateSemanaFechaInicio.ValueChanged += new System.EventHandler(this.dateSemanaFechaInicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Semana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 350);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha Inicio";
            // 
            // dgvTemas
            // 
            this.dgvTemas.AllowUserToAddRows = false;
            this.dgvTemas.AllowUserToDeleteRows = false;
            this.dgvTemas.AllowUserToResizeColumns = false;
            this.dgvTemas.AllowUserToResizeRows = false;
            this.dgvTemas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Descripcion});
            this.dgvTemas.Location = new System.Drawing.Point(846, 202);
            this.dgvTemas.Margin = new System.Windows.Forms.Padding(6);
            this.dgvTemas.Name = "dgvTemas";
            this.dgvTemas.ReadOnly = true;
            this.dgvTemas.RowHeadersWidth = 82;
            this.dgvTemas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTemas.Size = new System.Drawing.Size(714, 481);
            this.dgvTemas.TabIndex = 7;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 10;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 10;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(838, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tema";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 440);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 37);
            this.label6.TabIndex = 9;
            this.label6.Text = "Curso";
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(395, 194);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha Inicio";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(395, 194);
            this.label8.TabIndex = 13;
            this.label8.Text = "Fecha Fin";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(47, 697);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = false;
            this.btnGuardar.Size = new System.Drawing.Size(142, 36);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Location = new System.Drawing.Point(441, 697);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(156, 36);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(72)))));
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.4712F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.69633F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.701571F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel11, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(102, 836);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1506, 516);
            this.tableLayoutPanel9.TabIndex = 28;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 3;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.57229F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.85542F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.72289F));
            this.tableLayoutPanel11.Controls.Add(this.dateCursoFechaFin, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(160, 260);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(1316, 200);
            this.tableLayoutPanel11.TabIndex = 15;
            // 
            // dateCursoFechaFin
            // 
            this.dateCursoFechaFin.AutoSize = false;
            this.dateCursoFechaFin.DesignTimeState = resources.GetString("dateCursoFechaFin.DesignTimeState");
            this.dateCursoFechaFin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateCursoFechaFin.Location = new System.Drawing.Point(586, 3);
            this.dateCursoFechaFin.Name = "dateCursoFechaFin";
            this.dateCursoFechaFin.Size = new System.Drawing.Size(727, 194);
            this.dateCursoFechaFin.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.panel7.Controls.Add(this.label8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(395, 194);
            this.panel7.TabIndex = 13;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.57229F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.55422F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.0241F));
            this.tableLayoutPanel3.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateCursoFechaInicio, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(160, 54);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1316, 200);
            this.tableLayoutPanel3.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.panel6.Controls.Add(this.label7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(395, 194);
            this.panel6.TabIndex = 14;
            // 
            // dateCursoFechaInicio
            // 
            this.dateCursoFechaInicio.AutoSize = false;
            this.dateCursoFechaInicio.DesignTimeState = resources.GetString("dateCursoFechaInicio.DesignTimeState");
            this.dateCursoFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateCursoFechaInicio.Location = new System.Drawing.Point(582, 3);
            this.dateCursoFechaInicio.Name = "dateCursoFechaInicio";
            this.dateCursoFechaInicio.Size = new System.Drawing.Size(731, 194);
            this.dateCursoFechaInicio.TabIndex = 15;
            // 
            // frmInsertarSemana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2570, 1610);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvTemas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateSemanaFechaInicio);
            this.Controls.Add(this.txtSemanaDescrip);
            this.Controls.Add(this.txtSemanaNombre);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmInsertarSemana";
            this.Sizable = false;
            this.Text = "frmInsertarSemana";
            this.VisibleChanged += new System.EventHandler(this.frmInsertarSemana_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemas)).EndInit();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSemanaNombre;
        private System.Windows.Forms.TextBox txtSemanaDescrip;
        private System.Windows.Forms.DateTimePicker dateSemanaFechaInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvTemas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private Nevron.Nov.WinFormControls.NDateTimeBoxControl dateCursoFechaFin;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel6;
        private Nevron.Nov.WinFormControls.NDateTimeBoxControl dateCursoFechaInicio;
    }
}