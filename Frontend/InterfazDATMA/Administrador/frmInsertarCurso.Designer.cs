
namespace InterfazDATMA.Administrador
{
    partial class frmInsertarCurso
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
            this.lblTutoresUser = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCurso = new System.Windows.Forms.TextBox();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInscrip = new System.Windows.Forms.DateTimePicker();
            this.txtCantSemana = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelaccionarTemas = new MaterialSkin.Controls.MaterialButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVerGrupos = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnModificar = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardarCurso = new MaterialSkin.Controls.MaterialButton();
            this.btnRegresar = new MaterialSkin.Controls.MaterialButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(119, 41);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(177, 29);
            this.lblTutoresUser.TabIndex = 17;
            this.lblTutoresUser.Text = "Nombre Curso:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(89, 215);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(208, 29);
            this.lbl.TabIndex = 18;
            this.lbl.Text = "Fecha Inscripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(170, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(115, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 29);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cant. Semanas:";
            // 
            // txtNombreCurso
            // 
            this.txtNombreCurso.Location = new System.Drawing.Point(303, 44);
            this.txtNombreCurso.Name = "txtNombreCurso";
            this.txtNombreCurso.Size = new System.Drawing.Size(434, 26);
            this.txtNombreCurso.TabIndex = 22;
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInicial.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicial.Location = new System.Drawing.Point(303, 88);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(333, 26);
            this.dtpFechaInicial.TabIndex = 23;
            this.dtpFechaInicial.ValueChanged += new System.EventHandler(this.dtpFechaInicial_ValueChanged);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaFin.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(302, 131);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(333, 26);
            this.dtpFechaFin.TabIndex = 24;
            // 
            // dtpFechaInscrip
            // 
            this.dtpFechaInscrip.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaInscrip.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaInscrip.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInscrip.Location = new System.Drawing.Point(302, 218);
            this.dtpFechaInscrip.Name = "dtpFechaInscrip";
            this.dtpFechaInscrip.Size = new System.Drawing.Size(334, 26);
            this.dtpFechaInscrip.TabIndex = 25;
            // 
            // txtCantSemana
            // 
            this.txtCantSemana.Location = new System.Drawing.Point(302, 176);
            this.txtCantSemana.Name = "txtCantSemana";
            this.txtCantSemana.Size = new System.Drawing.Size(134, 26);
            this.txtCantSemana.TabIndex = 26;
            this.txtCantSemana.TextChanged += new System.EventHandler(this.textCantSemana_TextChanged);
            this.txtCantSemana.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCantSemana_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "Pre-Requisitos:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelaccionarTemas);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(210, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 127);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "2. Temas:";
            // 
            // btnSelaccionarTemas
            // 
            this.btnSelaccionarTemas.AutoSize = false;
            this.btnSelaccionarTemas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelaccionarTemas.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSelaccionarTemas.Depth = 0;
            this.btnSelaccionarTemas.HighEmphasis = true;
            this.btnSelaccionarTemas.Icon = null;
            this.btnSelaccionarTemas.Location = new System.Drawing.Point(102, 49);
            this.btnSelaccionarTemas.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSelaccionarTemas.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelaccionarTemas.Name = "btnSelaccionarTemas";
            this.btnSelaccionarTemas.Size = new System.Drawing.Size(221, 44);
            this.btnSelaccionarTemas.TabIndex = 36;
            this.btnSelaccionarTemas.Text = "Seleccionar Temas";
            this.btnSelaccionarTemas.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSelaccionarTemas.UseAccentColor = false;
            this.btnSelaccionarTemas.UseVisualStyleBackColor = true;
            this.btnSelaccionarTemas.Click += new System.EventHandler(this.btnSelaccionarTemas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVerGrupos);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(210, 537);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 130);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "3. Grupos:";
            // 
            // btnVerGrupos
            // 
            this.btnVerGrupos.AutoSize = false;
            this.btnVerGrupos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerGrupos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnVerGrupos.Depth = 0;
            this.btnVerGrupos.HighEmphasis = true;
            this.btnVerGrupos.Icon = null;
            this.btnVerGrupos.Location = new System.Drawing.Point(102, 54);
            this.btnVerGrupos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnVerGrupos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerGrupos.Name = "btnVerGrupos";
            this.btnVerGrupos.Size = new System.Drawing.Size(221, 44);
            this.btnVerGrupos.TabIndex = 37;
            this.btnVerGrupos.Text = "Ver Grupos";
            this.btnVerGrupos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnVerGrupos.UseAccentColor = false;
            this.btnVerGrupos.UseVisualStyleBackColor = true;
            this.btnVerGrupos.Click += new System.EventHandler(this.btnVerGrupos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCantSemana);
            this.groupBox3.Controls.Add(this.dtpFechaInscrip);
            this.groupBox3.Controls.Add(this.dtpFechaFin);
            this.groupBox3.Controls.Add(this.dtpFechaInicial);
            this.groupBox3.Controls.Add(this.txtNombreCurso);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.lbl);
            this.groupBox3.Controls.Add(this.lblTutoresUser);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(210, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(925, 277);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "1. Informacion Curso:";
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModificar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnModificar.Depth = 0;
            this.btnModificar.HighEmphasis = true;
            this.btnModificar.Icon = null;
            this.btnModificar.Location = new System.Drawing.Point(1252, 456);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnModificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 36);
            this.btnModificar.TabIndex = 38;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnModificar.UseAccentColor = false;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = false;
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.HighEmphasis = true;
            this.btnLimpiar.Icon = null;
            this.btnLimpiar.Location = new System.Drawing.Point(943, 385);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(192, 44);
            this.btnLimpiar.TabIndex = 46;
            this.btnLimpiar.Text = "Borrar Todo";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardarCurso
            // 
            this.btnGuardarCurso.AutoSize = false;
            this.btnGuardarCurso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarCurso.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarCurso.Depth = 0;
            this.btnGuardarCurso.HighEmphasis = true;
            this.btnGuardarCurso.Icon = null;
            this.btnGuardarCurso.Location = new System.Drawing.Point(943, 561);
            this.btnGuardarCurso.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnGuardarCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarCurso.Name = "btnGuardarCurso";
            this.btnGuardarCurso.Size = new System.Drawing.Size(192, 44);
            this.btnGuardarCurso.TabIndex = 47;
            this.btnGuardarCurso.Text = "Guardar";
            this.btnGuardarCurso.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarCurso.UseAccentColor = false;
            this.btnGuardarCurso.UseVisualStyleBackColor = true;
            this.btnGuardarCurso.Click += new System.EventHandler(this.btnGuardarCurso_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.AutoSize = false;
            this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegresar.Depth = 0;
            this.btnRegresar.HighEmphasis = true;
            this.btnRegresar.Icon = null;
            this.btnRegresar.Location = new System.Drawing.Point(943, 615);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(192, 44);
            this.btnRegresar.TabIndex = 48;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegresar.UseAccentColor = false;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(202, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 46);
            this.label5.TabIndex = 49;
            this.label5.Text = "Nuevo Curso:";
            // 
            // frmInsertarCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1532, 827);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnGuardarCurso);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmInsertarCurso";
            this.Sizable = false;
            this.Text = "Insertar Curso";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCurso;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInscrip;
        private System.Windows.Forms.TextBox txtCantSemana;
        private System.Windows.Forms.Label label4;
        //private MaterialSkin.Controls.MaterialFlatButton btnSelaccionarTemas;
        //private MaterialSkin.Controls.MaterialFlatButton btnVerGrupos;
        //private MaterialSkin.Controls.MaterialFlatButton btnAgregarReq;
        //private MaterialSkin.Controls.MaterialFlatButton btnEliminarReq;
        //private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
        //private MaterialSkin.Controls.MaterialFlatButton btnGuardarCurso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private MaterialSkin.Controls.MaterialButton btnSelaccionarTemas;
        private MaterialSkin.Controls.MaterialButton btnVerGrupos;
        private MaterialSkin.Controls.MaterialButton btnModificar;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnGuardarCurso;
        private MaterialSkin.Controls.MaterialButton btnRegresar;
        private System.Windows.Forms.Label label5;
        //private MaterialSkin.Controls.MaterialFlatButton btnLimpiar;
        //private MaterialSkin.Controls.MaterialFlatButton btnModificar;
    }
}