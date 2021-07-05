
namespace InterfazDATMA.Administrador
{
    partial class frmInsertarTutor
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
            this.lblTutores = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblApPat = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblApMat = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtApPat = new System.Windows.Forms.TextBox();
            this.txtApMat = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtTelf = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.nuevoDistrito = new MaterialSkin.Controls.MaterialButton();
            this.btnSiguiente = new MaterialSkin.Controls.MaterialButton();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTutores
            // 
            this.lblTutores.AutoSize = true;
            this.lblTutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTutores.ForeColor = System.Drawing.Color.White;
            this.lblTutores.Location = new System.Drawing.Point(65, 97);
            this.lblTutores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTutores.Name = "lblTutores";
            this.lblTutores.Size = new System.Drawing.Size(65, 17);
            this.lblTutores.TabIndex = 15;
            this.lblTutores.Text = "Nombres";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(553, 133);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 17);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(64, 203);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(141, 17);
            this.lblFechaNacimiento.TabIndex = 17;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblApPat
            // 
            this.lblApPat.AutoSize = true;
            this.lblApPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblApPat.ForeColor = System.Drawing.Color.White;
            this.lblApPat.Location = new System.Drawing.Point(65, 133);
            this.lblApPat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApPat.Name = "lblApPat";
            this.lblApPat.Size = new System.Drawing.Size(112, 17);
            this.lblApPat.TabIndex = 18;
            this.lblApPat.Text = "Apellido Paterno";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCelular.ForeColor = System.Drawing.Color.White;
            this.lblCelular.Location = new System.Drawing.Point(553, 167);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(52, 17);
            this.lblCelular.TabIndex = 19;
            this.lblCelular.Text = "Celular";
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDistrito.ForeColor = System.Drawing.Color.White;
            this.lblDistrito.Location = new System.Drawing.Point(64, 239);
            this.lblDistrito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(52, 17);
            this.lblDistrito.TabIndex = 20;
            this.lblDistrito.Text = "Distrito";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(553, 96);
            this.lblDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 17);
            this.lblDni.TabIndex = 21;
            this.lblDni.Text = "Dni";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(64, 274);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(51, 17);
            this.lblCorreo.TabIndex = 22;
            this.lblCorreo.Text = "Correo";
            // 
            // lblApMat
            // 
            this.lblApMat.AutoSize = true;
            this.lblApMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblApMat.ForeColor = System.Drawing.Color.White;
            this.lblApMat.Location = new System.Drawing.Point(65, 168);
            this.lblApMat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApMat.Name = "lblApMat";
            this.lblApMat.Size = new System.Drawing.Size(114, 17);
            this.lblApMat.TabIndex = 23;
            this.lblApMat.Text = "Apellido Materno";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(212, 96);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(278, 20);
            this.txtNombre.TabIndex = 24;
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.ForeColor = System.Drawing.Color.White;
            this.rbtnMujer.Location = new System.Drawing.Point(712, 202);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(71, 17);
            this.rbtnMujer.TabIndex = 25;
            this.rbtnMujer.TabStop = true;
            this.rbtnMujer.Text = "Femenino";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            this.rbtnMujer.Click += new System.EventHandler(this.rbtnMujer_Click);
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.ForeColor = System.Drawing.Color.White;
            this.rbtnHombre.Location = new System.Drawing.Point(620, 202);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(73, 17);
            this.rbtnHombre.TabIndex = 26;
            this.rbtnHombre.TabStop = true;
            this.rbtnHombre.Text = "Masculino";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            this.rbtnHombre.Click += new System.EventHandler(this.rbtnHombre_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(212, 202);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(278, 20);
            this.dtpFechaNacimiento.TabIndex = 27;
            // 
            // txtApPat
            // 
            this.txtApPat.Location = new System.Drawing.Point(212, 132);
            this.txtApPat.Name = "txtApPat";
            this.txtApPat.Size = new System.Drawing.Size(278, 20);
            this.txtApPat.TabIndex = 28;
            // 
            // txtApMat
            // 
            this.txtApMat.Location = new System.Drawing.Point(212, 168);
            this.txtApMat.Name = "txtApMat";
            this.txtApMat.Size = new System.Drawing.Size(278, 20);
            this.txtApMat.TabIndex = 29;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(212, 273);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(278, 20);
            this.txtCorreo.TabIndex = 31;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(620, 96);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(167, 20);
            this.txtDni.TabIndex = 32;
            // 
            // txtTelf
            // 
            this.txtTelf.Location = new System.Drawing.Point(620, 132);
            this.txtTelf.Name = "txtTelf";
            this.txtTelf.Size = new System.Drawing.Size(167, 20);
            this.txtTelf.TabIndex = 33;
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(620, 166);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(167, 20);
            this.txtCel.TabIndex = 34;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(553, 203);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(56, 17);
            this.lblGenero.TabIndex = 35;
            this.lblGenero.Text = "Genero";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(212, 390);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 108;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nuevoDistrito
            // 
            this.nuevoDistrito.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nuevoDistrito.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nuevoDistrito.Depth = 0;
            this.nuevoDistrito.HighEmphasis = true;
            this.nuevoDistrito.Icon = null;
            this.nuevoDistrito.Location = new System.Drawing.Point(557, 239);
            this.nuevoDistrito.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nuevoDistrito.MouseState = MaterialSkin.MouseState.HOVER;
            this.nuevoDistrito.Name = "nuevoDistrito";
            this.nuevoDistrito.Size = new System.Drawing.Size(155, 36);
            this.nuevoDistrito.TabIndex = 109;
            this.nuevoDistrito.Text = "Agregar Distrito";
            this.nuevoDistrito.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nuevoDistrito.UseAccentColor = false;
            this.nuevoDistrito.UseVisualStyleBackColor = true;
            this.nuevoDistrito.Click += new System.EventHandler(this.nuevoDistrito_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSiguiente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSiguiente.Depth = 0;
            this.btnSiguiente.HighEmphasis = true;
            this.btnSiguiente.Icon = null;
            this.btnSiguiente.Location = new System.Drawing.Point(425, 390);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSiguiente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(95, 36);
            this.btnSiguiente.TabIndex = 110;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSiguiente.UseAccentColor = false;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // cboDistrito
            // 
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(212, 238);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(278, 21);
            this.cboDistrito.TabIndex = 111;
            this.cboDistrito.SelectedIndexChanged += new System.EventHandler(this.cboDistrito_SelectedIndexChanged);
            // 
            // frmInsertarTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(952, 560);
            this.ControlBox = false;
            this.Controls.Add(this.cboDistrito);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.nuevoDistrito);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtTelf);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApMat);
            this.Controls.Add(this.txtApPat);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.rbtnHombre);
            this.Controls.Add(this.rbtnMujer);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApMat);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblDistrito);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblApPat);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblTutores);
            this.Name = "frmInsertarTutor";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.Sizable = false;
            this.Text = "Insertar Tutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutores;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblApPat;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblApMat;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private System.Windows.Forms.RadioButton rbtnHombre;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtApPat;
        private System.Windows.Forms.TextBox txtApMat;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtTelf;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label lblGenero;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton nuevoDistrito;
        private MaterialSkin.Controls.MaterialButton btnSiguiente;
        private System.Windows.Forms.ComboBox cboDistrito;
        //private MaterialSkin.Controls.MaterialFlatButton nuevoDistrito;
        //private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        //private MaterialSkin.Controls.MaterialFlatButton btnSiguiente;
    }
}