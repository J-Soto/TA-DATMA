﻿
namespace InterfazDATMA.Administrador
{
    partial class frmInsertarPsicologo
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelf = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidoMat = new System.Windows.Forms.TextBox();
            this.txtApellidoPat = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApMat = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblApPat = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtConfirmarPass = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblConfirmarPass = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.ofdSubirFoto = new System.Windows.Forms.OpenFileDialog();
            this.nuevoDistrito = new System.Windows.Forms.Button();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(48, 742);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(358, 56);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1180, 742);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(358, 56);
            this.btnGuardar.TabIndex = 61;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Location = new System.Drawing.Point(1038, 288);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(104, 31);
            this.lblGenero.TabIndex = 59;
            this.lblGenero.Text = "Genero";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(1204, 221);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(330, 31);
            this.txtCelular.TabIndex = 58;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtTelf
            // 
            this.txtTelf.Location = new System.Drawing.Point(1204, 154);
            this.txtTelf.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTelf.Name = "txtTelf";
            this.txtTelf.Size = new System.Drawing.Size(330, 31);
            this.txtTelf.TabIndex = 57;
            this.txtTelf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelf_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(1204, 94);
            this.txtDni.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(330, 31);
            this.txtDni.TabIndex = 56;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(376, 423);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(554, 31);
            this.txtCorreo.TabIndex = 55;
            // 
            // txtApellidoMat
            // 
            this.txtApellidoMat.Location = new System.Drawing.Point(376, 223);
            this.txtApellidoMat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtApellidoMat.Name = "txtApellidoMat";
            this.txtApellidoMat.Size = new System.Drawing.Size(330, 31);
            this.txtApellidoMat.TabIndex = 53;
            // 
            // txtApellidoPat
            // 
            this.txtApellidoPat.Location = new System.Drawing.Point(376, 156);
            this.txtApellidoPat.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtApellidoPat.Name = "txtApellidoPat";
            this.txtApellidoPat.Size = new System.Drawing.Size(330, 31);
            this.txtApellidoPat.TabIndex = 52;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(376, 288);
            this.dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(554, 32);
            this.dtpFechaNacimiento.TabIndex = 51;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.dtpFechaNacimiento_ValueChanged);
            // 
            // rbtnHombre
            // 
            this.rbtnHombre.AutoSize = true;
            this.rbtnHombre.ForeColor = System.Drawing.Color.White;
            this.rbtnHombre.Location = new System.Drawing.Point(1204, 288);
            this.rbtnHombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.Size = new System.Drawing.Size(141, 29);
            this.rbtnHombre.TabIndex = 50;
            this.rbtnHombre.TabStop = true;
            this.rbtnHombre.Text = "Masculino";
            this.rbtnHombre.UseVisualStyleBackColor = true;
            this.rbtnHombre.Click += new System.EventHandler(this.rbtnHombre_Click);
            // 
            // rbtnMujer
            // 
            this.rbtnMujer.AutoSize = true;
            this.rbtnMujer.ForeColor = System.Drawing.Color.White;
            this.rbtnMujer.Location = new System.Drawing.Point(1396, 288);
            this.rbtnMujer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.Size = new System.Drawing.Size(138, 29);
            this.rbtnMujer.TabIndex = 49;
            this.rbtnMujer.TabStop = true;
            this.rbtnMujer.Text = "Femenino";
            this.rbtnMujer.UseVisualStyleBackColor = true;
            this.rbtnMujer.Click += new System.EventHandler(this.rbtnMujer_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(376, 92);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(554, 31);
            this.txtNombre.TabIndex = 48;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblApMat
            // 
            this.lblApMat.AutoSize = true;
            this.lblApMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblApMat.ForeColor = System.Drawing.Color.White;
            this.lblApMat.Location = new System.Drawing.Point(42, 223);
            this.lblApMat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApMat.Name = "lblApMat";
            this.lblApMat.Size = new System.Drawing.Size(216, 31);
            this.lblApMat.TabIndex = 47;
            this.lblApMat.Text = "Apellido Materno";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Location = new System.Drawing.Point(42, 423);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(97, 31);
            this.lblCorreo.TabIndex = 46;
            this.lblCorreo.Text = "Correo";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(1038, 96);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(55, 31);
            this.lblDni.TabIndex = 45;
            this.lblDni.Text = "Dni";
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDistrito.ForeColor = System.Drawing.Color.White;
            this.lblDistrito.Location = new System.Drawing.Point(42, 354);
            this.lblDistrito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(100, 31);
            this.lblDistrito.TabIndex = 44;
            this.lblDistrito.Text = "Distrito";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCelular.ForeColor = System.Drawing.Color.White;
            this.lblCelular.Location = new System.Drawing.Point(1038, 223);
            this.lblCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(100, 31);
            this.lblCelular.TabIndex = 43;
            this.lblCelular.Text = "Celular";
            // 
            // lblApPat
            // 
            this.lblApPat.AutoSize = true;
            this.lblApPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblApPat.ForeColor = System.Drawing.Color.White;
            this.lblApPat.Location = new System.Drawing.Point(42, 156);
            this.lblApPat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApPat.Name = "lblApPat";
            this.lblApPat.Size = new System.Drawing.Size(212, 31);
            this.lblApPat.TabIndex = 42;
            this.lblApPat.Text = "Apellido Paterno";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(42, 288);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(270, 31);
            this.lblFechaNacimiento.TabIndex = 41;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(1038, 156);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(120, 31);
            this.lblTelefono.TabIndex = 40;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(42, 92);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(124, 31);
            this.lblNombre.TabIndex = 39;
            this.lblNombre.Text = "Nombres";
            // 
            // txtConfirmarPass
            // 
            this.txtConfirmarPass.Location = new System.Drawing.Point(376, 621);
            this.txtConfirmarPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtConfirmarPass.Name = "txtConfirmarPass";
            this.txtConfirmarPass.Size = new System.Drawing.Size(330, 31);
            this.txtConfirmarPass.TabIndex = 68;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(376, 554);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(330, 31);
            this.txtPass.TabIndex = 67;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(376, 490);
            this.txtUser.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(554, 31);
            this.txtUser.TabIndex = 66;
            // 
            // lblConfirmarPass
            // 
            this.lblConfirmarPass.AutoSize = true;
            this.lblConfirmarPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblConfirmarPass.ForeColor = System.Drawing.Color.White;
            this.lblConfirmarPass.Location = new System.Drawing.Point(42, 621);
            this.lblConfirmarPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfirmarPass.Name = "lblConfirmarPass";
            this.lblConfirmarPass.Size = new System.Drawing.Size(281, 31);
            this.lblConfirmarPass.TabIndex = 65;
            this.lblConfirmarPass.Text = "Confirmar Contraseña";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(42, 554);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(155, 31);
            this.lblPassword.TabIndex = 64;
            this.lblPassword.Text = "Contraseña";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(42, 490);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(108, 31);
            this.lblUser.TabIndex = 63;
            this.lblUser.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1038, 354);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 31);
            this.label1.TabIndex = 69;
            this.label1.Text = "Foto";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.Location = new System.Drawing.Point(1438, 354);
            this.btnSubirFoto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(60, 44);
            this.btnSubirFoto.TabIndex = 71;
            this.btnSubirFoto.Text = "...";
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Image = global::InterfazDATMA.Properties.Resources.avatarPsicologa;
            this.pbFoto.Location = new System.Drawing.Point(1204, 354);
            this.pbFoto.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(220, 240);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 70;
            this.pbFoto.TabStop = false;
            // 
            // nuevoDistrito
            // 
            this.nuevoDistrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.nuevoDistrito.FlatAppearance.BorderSize = 0;
            this.nuevoDistrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuevoDistrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.nuevoDistrito.ForeColor = System.Drawing.Color.White;
            this.nuevoDistrito.Location = new System.Drawing.Point(716, 350);
            this.nuevoDistrito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nuevoDistrito.Name = "nuevoDistrito";
            this.nuevoDistrito.Size = new System.Drawing.Size(214, 42);
            this.nuevoDistrito.TabIndex = 72;
            this.nuevoDistrito.Text = "Agregar Distrito";
            this.nuevoDistrito.UseVisualStyleBackColor = false;
            this.nuevoDistrito.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(372, 352);
            this.txtDistrito.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(330, 31);
            this.txtDistrito.TabIndex = 73;
            // 
            // frmInsertarPsicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.ControlBox = false;
            this.Controls.Add(this.txtDistrito);
            this.Controls.Add(this.nuevoDistrito);
            this.Controls.Add(this.btnSubirFoto);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfirmarPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblConfirmarPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelf);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellidoMat);
            this.Controls.Add(this.txtApellidoPat);
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
            this.Controls.Add(this.lblNombre);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmInsertarPsicologo";
            this.Sizable = false;
            this.Text = "Insertar Psicólogo";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelf;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidoMat;
        private System.Windows.Forms.TextBox txtApellidoPat;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.RadioButton rbtnHombre;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApMat;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblApPat;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtConfirmarPass;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblConfirmarPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.OpenFileDialog ofdSubirFoto;
        private System.Windows.Forms.Button nuevoDistrito;
        private System.Windows.Forms.TextBox txtDistrito;
    }
}