﻿
namespace InterfazDATMA.Administrador
{
    partial class frmInsertarPreferencias
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
            this.lblDispElec = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblInternet = new System.Windows.Forms.Label();
            this.lblRedes = new System.Windows.Forms.Label();
            this.chblDispositivos = new System.Windows.Forms.CheckedListBox();
            this.chbRecursos = new System.Windows.Forms.CheckBox();
            this.chblInternet = new System.Windows.Forms.CheckedListBox();
            this.chblTurno = new System.Windows.Forms.CheckedListBox();
            this.chblDias = new System.Windows.Forms.CheckedListBox();
            this.chbGestante = new System.Windows.Forms.CheckBox();
            this.chblRedes = new System.Windows.Forms.CheckedListBox();
            //this.btnRegresar = new MaterialSkin.Controls.MaterialFlatButton();
            //this.btnGuardar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lblDispElec
            // 
            this.lblDispElec.AutoSize = true;
            this.lblDispElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDispElec.ForeColor = System.Drawing.Color.White;
            this.lblDispElec.Location = new System.Drawing.Point(130, 185);
            this.lblDispElec.Name = "lblDispElec";
            this.lblDispElec.Size = new System.Drawing.Size(227, 25);
            this.lblDispElec.TabIndex = 16;
            this.lblDispElec.Text = "Dispositivos Electrónicos";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDias.ForeColor = System.Drawing.Color.White;
            this.lblDias.Location = new System.Drawing.Point(130, 445);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(155, 25);
            this.lblDias.TabIndex = 18;
            this.lblDias.Text = "Preferencia Días";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTurno.ForeColor = System.Drawing.Color.White;
            this.lblTurno.Location = new System.Drawing.Point(950, 183);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(168, 25);
            this.lblTurno.TabIndex = 19;
            this.lblTurno.Text = "Preferencia Turno";
            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInternet.ForeColor = System.Drawing.Color.White;
            this.lblInternet.Location = new System.Drawing.Point(525, 185);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(121, 25);
            this.lblInternet.TabIndex = 21;
            this.lblInternet.Text = "Tipo Internet";
            // 
            // lblRedes
            // 
            this.lblRedes.AutoSize = true;
            this.lblRedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRedes.ForeColor = System.Drawing.Color.White;
            this.lblRedes.Location = new System.Drawing.Point(525, 445);
            this.lblRedes.Name = "lblRedes";
            this.lblRedes.Size = new System.Drawing.Size(148, 25);
            this.lblRedes.TabIndex = 22;
            this.lblRedes.Text = "Redes Sociales";
            // 
            // chblDispositivos
            // 
            this.chblDispositivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.chblDispositivos.ForeColor = System.Drawing.Color.White;
            this.chblDispositivos.FormattingEnabled = true;
            this.chblDispositivos.Items.AddRange(new object[] {
            "Computadora",
            "Laptop",
            "Celular",
            "Tablet"});
            this.chblDispositivos.Location = new System.Drawing.Point(130, 240);
            this.chblDispositivos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chblDispositivos.Name = "chblDispositivos";
            this.chblDispositivos.Size = new System.Drawing.Size(328, 96);
            this.chblDispositivos.TabIndex = 24;
            // 
            // chbRecursos
            // 
            this.chbRecursos.AutoSize = true;
            this.chbRecursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbRecursos.ForeColor = System.Drawing.Color.White;
            this.chbRecursos.Location = new System.Drawing.Point(950, 445);
            this.chbRecursos.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chbRecursos.Name = "chbRecursos";
            this.chbRecursos.Size = new System.Drawing.Size(174, 29);
            this.chbRecursos.TabIndex = 25;
            this.chbRecursos.Text = "Bajos Recursos";
            this.chbRecursos.UseVisualStyleBackColor = true;
            // 
            // chblInternet
            // 
            this.chblInternet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.chblInternet.ForeColor = System.Drawing.Color.White;
            this.chblInternet.FormattingEnabled = true;
            this.chblInternet.Items.AddRange(new object[] {
            "Internet Fijo",
            "Plan de Datos",
            "Recarga Diaria",
            "No Cuenta"});
            this.chblInternet.Location = new System.Drawing.Point(530, 240);
            this.chblInternet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chblInternet.Name = "chblInternet";
            this.chblInternet.Size = new System.Drawing.Size(343, 96);
            this.chblInternet.TabIndex = 26;
            // 
            // chblTurno
            // 
            this.chblTurno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.chblTurno.ForeColor = System.Drawing.Color.White;
            this.chblTurno.FormattingEnabled = true;
            this.chblTurno.Items.AddRange(new object[] {
            "Mañana",
            "Tarde ",
            "Noche"});
            this.chblTurno.Location = new System.Drawing.Point(950, 240);
            this.chblTurno.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chblTurno.Name = "chblTurno";
            this.chblTurno.Size = new System.Drawing.Size(342, 73);
            this.chblTurno.TabIndex = 27;
            // 
            // chblDias
            // 
            this.chblDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.chblDias.ForeColor = System.Drawing.Color.White;
            this.chblDias.FormattingEnabled = true;
            this.chblDias.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.chblDias.Location = new System.Drawing.Point(130, 500);
            this.chblDias.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chblDias.Name = "chblDias";
            this.chblDias.Size = new System.Drawing.Size(328, 165);
            this.chblDias.TabIndex = 28;
            // 
            // chbGestante
            // 
            this.chbGestante.AutoSize = true;
            this.chbGestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbGestante.ForeColor = System.Drawing.Color.White;
            this.chbGestante.Location = new System.Drawing.Point(950, 525);
            this.chbGestante.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chbGestante.Name = "chbGestante";
            this.chbGestante.Size = new System.Drawing.Size(117, 29);
            this.chbGestante.TabIndex = 29;
            this.chbGestante.Text = "Gestante";
            this.chbGestante.UseVisualStyleBackColor = true;
            // 
            // chblRedes
            // 
            this.chblRedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.chblRedes.ForeColor = System.Drawing.Color.White;
            this.chblRedes.FormattingEnabled = true;
            this.chblRedes.Items.AddRange(new object[] {
            "Whatsapp",
            "Facebook",
            "Instagram",
            "Telegram",
            "Twitter"});
            this.chblRedes.Location = new System.Drawing.Point(541, 500);
            this.chblRedes.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.chblRedes.Name = "chblRedes";
            this.chblRedes.Size = new System.Drawing.Size(343, 119);
            this.chblRedes.TabIndex = 30;
            // 
            // btnRegresar
            // 
            //this.btnRegresar.AutoSize = true;
            //this.btnRegresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.btnRegresar.Depth = 0;
            //this.btnRegresar.Location = new System.Drawing.Point(84, 717);
            //this.btnRegresar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            //this.btnRegresar.MouseState = MaterialSkin.MouseState.HOVER;
            //this.btnRegresar.Name = "btnRegresar";
            //this.btnRegresar.Primary = false;
            //this.btnRegresar.Size = new System.Drawing.Size(116, 36);
            //this.btnRegresar.TabIndex = 40;
            //this.btnRegresar.Text = "Regresar";
            //this.btnRegresar.UseVisualStyleBackColor = true;
            //this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            //// 
            //// btnGuardar
            //// 
            //this.btnGuardar.AutoSize = true;
            //this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.btnGuardar.Depth = 0;
            //this.btnGuardar.Location = new System.Drawing.Point(903, 717);
            //this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            //this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            //this.btnGuardar.Name = "btnGuardar";
            //this.btnGuardar.Primary = false;
            //this.btnGuardar.Size = new System.Drawing.Size(108, 36);
            //this.btnGuardar.TabIndex = 41;
            //this.btnGuardar.Text = "Guardar";
            //this.btnGuardar.UseVisualStyleBackColor = true;
            //this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            //// 
            // frmInsertarPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1428, 862);
            this.ControlBox = false;
            //this.Controls.Add(this.btnGuardar);
            //this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.chblRedes);
            this.Controls.Add(this.chbGestante);
            this.Controls.Add(this.chblDias);
            this.Controls.Add(this.chblTurno);
            this.Controls.Add(this.chblInternet);
            this.Controls.Add(this.chbRecursos);
            this.Controls.Add(this.chblDispositivos);
            this.Controls.Add(this.lblRedes);
            this.Controls.Add(this.lblInternet);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblDispElec);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmInsertarPreferencias";
            this.Sizable = false;
            this.Text = "Insertar Preferencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDispElec;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblInternet;
        private System.Windows.Forms.Label lblRedes;
        private System.Windows.Forms.CheckedListBox chblDispositivos;
        private System.Windows.Forms.CheckBox chbRecursos;
        private System.Windows.Forms.CheckedListBox chblInternet;
        private System.Windows.Forms.CheckedListBox chblTurno;
        private System.Windows.Forms.CheckedListBox chblDias;
        private System.Windows.Forms.CheckBox chbGestante;
        private System.Windows.Forms.CheckedListBox chblRedes;
        //private MaterialSkin.Controls.MaterialFlatButton btnRegresar;
        //private MaterialSkin.Controls.MaterialFlatButton btnGuardar;
    }
}