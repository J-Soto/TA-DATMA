﻿
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
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtTelf = new System.Windows.Forms.TextBox();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTutores
            // 
            this.lblTutores.AutoSize = true;
            this.lblTutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTutores.ForeColor = System.Drawing.Color.White;
            this.lblTutores.Location = new System.Drawing.Point(122, 80);
            this.lblTutores.Name = "lblTutores";
            this.lblTutores.Size = new System.Drawing.Size(91, 25);
            this.lblTutores.TabIndex = 15;
            this.lblTutores.Text = "Nombres";
            this.lblTutores.Click += new System.EventHandler(this.lblTutores_Click);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(122, 458);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(89, 25);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(122, 237);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(196, 25);
            this.lblFechaNacimiento.TabIndex = 17;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            this.lblFechaNacimiento.Click += new System.EventHandler(this.lblFechaNacimiento_Click);
            // 
            // lblApPat
            // 
            this.lblApPat.AutoSize = true;
            this.lblApPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblApPat.ForeColor = System.Drawing.Color.White;
            this.lblApPat.Location = new System.Drawing.Point(122, 131);
            this.lblApPat.Name = "lblApPat";
            this.lblApPat.Size = new System.Drawing.Size(155, 25);
            this.lblApPat.TabIndex = 18;
            this.lblApPat.Text = "Apellido Paterno";
            this.lblApPat.Click += new System.EventHandler(this.lblApPat_Click);
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCelular.ForeColor = System.Drawing.Color.White;
            this.lblCelular.Location = new System.Drawing.Point(122, 518);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(74, 25);
            this.lblCelular.TabIndex = 19;
            this.lblCelular.Text = "Celular";
            this.lblCelular.Click += new System.EventHandler(this.lblCelular_Click);
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDistrito.ForeColor = System.Drawing.Color.White;
            this.lblDistrito.Location = new System.Drawing.Point(122, 289);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(71, 25);
            this.lblDistrito.TabIndex = 20;
            this.lblDistrito.Text = "Distrito";
            this.lblDistrito.Click += new System.EventHandler(this.lblDistrito_Click);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(122, 402);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(41, 25);
            this.lblDni.TabIndex = 21;
            this.lblDni.Text = "Dni";
            this.lblDni.Click += new System.EventHandler(this.lblDni_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(122, 345);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(72, 25);
            this.lblCorreo.TabIndex = 22;
            this.lblCorreo.Text = "Correo";
            this.lblCorreo.Click += new System.EventHandler(this.lblCorreo_Click);
            // 
            // lblApMat
            // 
            this.lblApMat.AutoSize = true;
            this.lblApMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblApMat.ForeColor = System.Drawing.Color.White;
            this.lblApMat.Location = new System.Drawing.Point(122, 185);
            this.lblApMat.Name = "lblApMat";
            this.lblApMat.Size = new System.Drawing.Size(159, 25);
            this.lblApMat.TabIndex = 23;
            this.lblApMat.Text = "Apellido Materno";
            this.lblApMat.Click += new System.EventHandler(this.lblApMat_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(384, 78);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(416, 26);
            this.txtNombre.TabIndex = 24;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.ForeColor = System.Drawing.Color.White;
            this.rbtnMujer.Location = new System.Drawing.Point(528, 575);
            this.rbtnMujer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(105, 24);
            this.rbtnMujer.TabIndex = 25;
            this.rbtnMujer.TabStop = true;
            this.rbtnMujer.Text = "Femenino";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            this.rbtnMujer.CheckedChanged += new System.EventHandler(this.rbtnMujer_CheckedChanged);
            this.rbtnMujer.Click += new System.EventHandler(this.rbtnMujer_Click);
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.ForeColor = System.Drawing.Color.White;
            this.rbtnHombre.Location = new System.Drawing.Point(384, 575);
            this.rbtnHombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(105, 24);
            this.rbtnHombre.TabIndex = 26;
            this.rbtnHombre.TabStop = true;
            this.rbtnHombre.Text = "Masculino";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            this.rbtnHombre.CheckedChanged += new System.EventHandler(this.rbtnHombre_CheckedChanged);
            this.rbtnHombre.Click += new System.EventHandler(this.rbtnHombre_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Enabled = false;
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(384, 235);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(416, 26);
            this.dtpFechaNacimiento.TabIndex = 27;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // txtApPat
            // 
            this.txtApPat.Location = new System.Drawing.Point(384, 129);
            this.txtApPat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApPat.Name = "txtApPat";
            this.txtApPat.Size = new System.Drawing.Size(248, 26);
            this.txtApPat.TabIndex = 28;
            this.txtApPat.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtApMat
            // 
            this.txtApMat.Location = new System.Drawing.Point(384, 183);
            this.txtApMat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApMat.Name = "txtApMat";
            this.txtApMat.Size = new System.Drawing.Size(248, 26);
            this.txtApMat.TabIndex = 29;
            this.txtApMat.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // cboDistrito
            // 
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(384, 288);
            this.cboDistrito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(248, 28);
            this.cboDistrito.TabIndex = 30;
            this.cboDistrito.SelectedIndexChanged += new System.EventHandler(this.cboDistrito_SelectedIndexChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(384, 343);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(416, 26);
            this.txtCorreo.TabIndex = 31;
            this.txtCorreo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(384, 400);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(248, 26);
            this.txtDni.TabIndex = 32;
            this.txtDni.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtTelf
            // 
            this.txtTelf.Location = new System.Drawing.Point(384, 458);
            this.txtTelf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelf.Name = "txtTelf";
            this.txtTelf.Size = new System.Drawing.Size(248, 26);
            this.txtTelf.TabIndex = 33;
            this.txtTelf.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(384, 517);
            this.txtCel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(248, 26);
            this.txtCel.TabIndex = 34;
            this.txtCel.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(122, 575);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(77, 25);
            this.lblGenero.TabIndex = 35;
            this.lblGenero.Text = "Genero";
            this.lblGenero.Click += new System.EventHandler(this.lblGenero_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSiguiente.ForeColor = System.Drawing.Color.White;
            this.btnSiguiente.Location = new System.Drawing.Point(843, 500);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(268, 45);
            this.btnSiguiente.TabIndex = 37;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(843, 566);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(268, 45);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmInsertarTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.txtTelf);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.cboDistrito);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInsertarTutor";
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
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtTelf;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnCancelar;
    }
}