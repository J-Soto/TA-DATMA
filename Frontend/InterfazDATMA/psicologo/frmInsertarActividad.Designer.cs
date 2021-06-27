
namespace InterfazDATMA.psicologo
{
    partial class frmInsertarActividad
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
            this.txtNombreAct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaReunion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHInicio = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHFin = new System.Windows.Forms.DateTimePicker();
            this.txtLinkZoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDocumentos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvVideos = new System.Windows.Forms.DataGridView();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnAgregarDoc = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminarDoc = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnAgregarVid = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnEliminarVid = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombreAct
            // 
            this.txtNombreAct.Location = new System.Drawing.Point(264, 168);
            this.txtNombreAct.Name = "txtNombreAct";
            this.txtNombreAct.Size = new System.Drawing.Size(452, 26);
            this.txtNombreAct.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(156, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre:";
            // 
            // dtpFechaReunion
            // 
            this.dtpFechaReunion.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaReunion.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaReunion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReunion.Location = new System.Drawing.Point(264, 211);
            this.dtpFechaReunion.Name = "dtpFechaReunion";
            this.dtpFechaReunion.Size = new System.Drawing.Size(209, 26);
            this.dtpFechaReunion.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(74, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hora de Inicio:";
            // 
            // dtpHInicio
            // 
            this.dtpHInicio.Location = new System.Drawing.Point(264, 253);
            this.dtpHInicio.Name = "dtpHInicio";
            this.dtpHInicio.Size = new System.Drawing.Size(162, 26);
            this.dtpHInicio.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(97, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hora de Fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(179, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Link:";
            // 
            // dtpHFin
            // 
            this.dtpHFin.Location = new System.Drawing.Point(264, 298);
            this.dtpHFin.Name = "dtpHFin";
            this.dtpHFin.Size = new System.Drawing.Size(162, 26);
            this.dtpHFin.TabIndex = 19;
            // 
            // txtLinkZoom
            // 
            this.txtLinkZoom.Location = new System.Drawing.Point(264, 340);
            this.txtLinkZoom.Name = "txtLinkZoom";
            this.txtLinkZoom.Size = new System.Drawing.Size(452, 26);
            this.txtLinkZoom.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(59, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 36);
            this.label6.TabIndex = 21;
            this.label6.Text = "Informacion de la Actividad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(59, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 36);
            this.label7.TabIndex = 22;
            this.label7.Text = "Materiales:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(88, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 29);
            this.label8.TabIndex = 23;
            this.label8.Text = "Documentos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(642, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 29);
            this.label9.TabIndex = 24;
            this.label9.Text = "Videos:";
            // 
            // dgvDocumentos
            // 
            this.dgvDocumentos.AllowUserToAddRows = false;
            this.dgvDocumentos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvDocumentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDocumentos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumentos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDocumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocumentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewButtonColumn1});
            this.dgvDocumentos.EnableHeadersVisualStyles = false;
            this.dgvDocumentos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvDocumentos.Location = new System.Drawing.Point(93, 507);
            this.dgvDocumentos.Name = "dgvDocumentos";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocumentos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDocumentos.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDocumentos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDocumentos.RowTemplate.Height = 28;
            this.dgvDocumentos.Size = new System.Drawing.Size(422, 270);
            this.dgvDocumentos.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Documento";
            this.dataGridViewButtonColumn1.MinimumWidth = 8;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Width = 150;
            // 
            // dgvVideos
            // 
            this.dgvVideos.AllowUserToAddRows = false;
            this.dgvVideos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvVideos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVideos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVideos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVideos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Link});
            this.dgvVideos.EnableHeadersVisualStyles = false;
            this.dgvVideos.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvVideos.Location = new System.Drawing.Point(647, 507);
            this.dgvVideos.Name = "dgvVideos";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVideos.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVideos.RowHeadersWidth = 62;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvVideos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVideos.RowTemplate.Height = 28;
            this.dgvVideos.Size = new System.Drawing.Size(521, 270);
            this.dgvVideos.TabIndex = 27;
            this.dgvVideos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVideos_CellContentClick);
            this.dgvVideos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVideos_CellFormatting);
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 8;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 150;
            // 
            // Link
            // 
            this.Link.HeaderText = "Link";
            this.Link.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Link.LinkColor = System.Drawing.Color.White;
            this.Link.MinimumWidth = 8;
            this.Link.Name = "Link";
            this.Link.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Link.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Link.VisitedLinkColor = System.Drawing.Color.White;
            this.Link.Width = 150;
            // 
            // btnAgregarDoc
            // 
            this.btnAgregarDoc.AutoSize = true;
            this.btnAgregarDoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarDoc.Depth = 0;
            this.btnAgregarDoc.Location = new System.Drawing.Point(544, 507);
            this.btnAgregarDoc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAgregarDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarDoc.Name = "btnAgregarDoc";
            this.btnAgregarDoc.Primary = false;
            this.btnAgregarDoc.Size = new System.Drawing.Size(26, 36);
            this.btnAgregarDoc.TabIndex = 28;
            this.btnAgregarDoc.Text = "+";
            this.btnAgregarDoc.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDoc
            // 
            this.btnEliminarDoc.AutoSize = true;
            this.btnEliminarDoc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarDoc.Depth = 0;
            this.btnEliminarDoc.Location = new System.Drawing.Point(544, 562);
            this.btnEliminarDoc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEliminarDoc.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarDoc.Name = "btnEliminarDoc";
            this.btnEliminarDoc.Primary = false;
            this.btnEliminarDoc.Size = new System.Drawing.Size(21, 36);
            this.btnEliminarDoc.TabIndex = 29;
            this.btnEliminarDoc.Text = "-";
            this.btnEliminarDoc.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVid
            // 
            this.btnAgregarVid.AutoSize = true;
            this.btnAgregarVid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregarVid.Depth = 0;
            this.btnAgregarVid.Location = new System.Drawing.Point(1189, 507);
            this.btnAgregarVid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAgregarVid.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregarVid.Name = "btnAgregarVid";
            this.btnAgregarVid.Primary = false;
            this.btnAgregarVid.Size = new System.Drawing.Size(26, 36);
            this.btnAgregarVid.TabIndex = 30;
            this.btnAgregarVid.Text = "+";
            this.btnAgregarVid.UseVisualStyleBackColor = true;
            this.btnAgregarVid.Click += new System.EventHandler(this.btnAgregarVid_Click);
            // 
            // btnEliminarVid
            // 
            this.btnEliminarVid.AutoSize = true;
            this.btnEliminarVid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarVid.Depth = 0;
            this.btnEliminarVid.Location = new System.Drawing.Point(1189, 562);
            this.btnEliminarVid.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEliminarVid.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarVid.Name = "btnEliminarVid";
            this.btnEliminarVid.Primary = false;
            this.btnEliminarVid.Size = new System.Drawing.Size(21, 36);
            this.btnEliminarVid.TabIndex = 31;
            this.btnEliminarVid.Text = "-";
            this.btnEliminarVid.UseVisualStyleBackColor = true;
            this.btnEliminarVid.Click += new System.EventHandler(this.btnEliminarVid_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = true;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.Location = new System.Drawing.Point(1189, 854);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Primary = false;
            this.btnRegresar.Size = new System.Drawing.Size(116, 36);
            this.btnRegresar.TabIndex = 45;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = true;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.Location = new System.Drawing.Point(1189, 795);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Primary = false;
            this.btnGuardar.Size = new System.Drawing.Size(108, 36);
            this.btnGuardar.TabIndex = 44;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmInsertarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(1355, 897);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminarVid);
            this.Controls.Add(this.btnAgregarVid);
            this.Controls.Add(this.btnEliminarDoc);
            this.Controls.Add(this.btnAgregarDoc);
            this.Controls.Add(this.dgvVideos);
            this.Controls.Add(this.dgvDocumentos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLinkZoom);
            this.Controls.Add(this.dtpHFin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpFechaReunion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreAct);
            this.Name = "frmInsertarActividad";
            this.Text = "InsertarActividad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocumentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNombreAct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaReunion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHInicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHFin;
        private System.Windows.Forms.TextBox txtLinkZoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDocumentos;
        private System.Windows.Forms.DataGridView dgvVideos;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarDoc;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminarDoc;
        private MaterialSkin.Controls.MaterialFlatButton btnAgregarVid;
        private MaterialSkin.Controls.MaterialFlatButton btnEliminarVid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
        private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewLinkColumn Link;
    }
}