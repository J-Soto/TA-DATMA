
namespace InterfazDATMA.Administrador
{
    partial class frmModificarPreferencias
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.chblRedes = new System.Windows.Forms.CheckedListBox();
            this.chbGestante = new System.Windows.Forms.CheckBox();
            this.chblDias = new System.Windows.Forms.CheckedListBox();
            this.chblTurno = new System.Windows.Forms.CheckedListBox();
            this.chblInternet = new System.Windows.Forms.CheckedListBox();
            this.chbRecursos = new System.Windows.Forms.CheckBox();
            this.chblDispositivos = new System.Windows.Forms.CheckedListBox();
            this.lblRedes = new System.Windows.Forms.Label();
            this.lblInternet = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblDispElec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(1186, 658);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(358, 56);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(578, 658);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(358, 56);
            this.btnRegresar.TabIndex = 52;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
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
            this.chblRedes.Location = new System.Drawing.Point(578, 421);
            this.chblRedes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chblRedes.Name = "chblRedes";
            this.chblRedes.Size = new System.Drawing.Size(454, 144);
            this.chblRedes.TabIndex = 51;
            // 
            // chbGestante
            // 
            this.chbGestante.AutoSize = true;
            this.chbGestante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbGestante.ForeColor = System.Drawing.Color.White;
            this.chbGestante.Location = new System.Drawing.Point(1164, 502);
            this.chbGestante.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chbGestante.Name = "chbGestante";
            this.chbGestante.Size = new System.Drawing.Size(157, 35);
            this.chbGestante.TabIndex = 50;
            this.chbGestante.Text = "Gestante";
            this.chbGestante.UseVisualStyleBackColor = true;
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
            this.chblDias.Location = new System.Drawing.Point(64, 421);
            this.chblDias.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chblDias.Name = "chblDias";
            this.chblDias.Size = new System.Drawing.Size(454, 200);
            this.chblDias.TabIndex = 49;
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
            this.chblTurno.Location = new System.Drawing.Point(1086, 192);
            this.chblTurno.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chblTurno.Name = "chblTurno";
            this.chblTurno.Size = new System.Drawing.Size(454, 88);
            this.chblTurno.TabIndex = 48;
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
            this.chblInternet.Location = new System.Drawing.Point(578, 192);
            this.chblInternet.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chblInternet.Name = "chblInternet";
            this.chblInternet.Size = new System.Drawing.Size(454, 116);
            this.chblInternet.TabIndex = 47;
            // 
            // chbRecursos
            // 
            this.chbRecursos.AutoSize = true;
            this.chbRecursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbRecursos.ForeColor = System.Drawing.Color.White;
            this.chbRecursos.Location = new System.Drawing.Point(1164, 450);
            this.chbRecursos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chbRecursos.Name = "chbRecursos";
            this.chbRecursos.Size = new System.Drawing.Size(237, 35);
            this.chbRecursos.TabIndex = 46;
            this.chbRecursos.Text = "Bajos Recursos";
            this.chbRecursos.UseVisualStyleBackColor = true;
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
            this.chblDispositivos.Location = new System.Drawing.Point(64, 192);
            this.chblDispositivos.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chblDispositivos.Name = "chblDispositivos";
            this.chblDispositivos.Size = new System.Drawing.Size(454, 116);
            this.chblDispositivos.TabIndex = 45;
            // 
            // lblRedes
            // 
            this.lblRedes.AutoSize = true;
            this.lblRedes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRedes.ForeColor = System.Drawing.Color.White;
            this.lblRedes.Location = new System.Drawing.Point(572, 383);
            this.lblRedes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRedes.Name = "lblRedes";
            this.lblRedes.Size = new System.Drawing.Size(203, 31);
            this.lblRedes.TabIndex = 44;
            this.lblRedes.Text = "Redes Sociales";
            // 
            // lblInternet
            // 
            this.lblInternet.AutoSize = true;
            this.lblInternet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblInternet.ForeColor = System.Drawing.Color.White;
            this.lblInternet.Location = new System.Drawing.Point(572, 154);
            this.lblInternet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInternet.Name = "lblInternet";
            this.lblInternet.Size = new System.Drawing.Size(167, 31);
            this.lblInternet.TabIndex = 43;
            this.lblInternet.Text = "Tipo Internet";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblTurno.ForeColor = System.Drawing.Color.White;
            this.lblTurno.Location = new System.Drawing.Point(1080, 154);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(231, 31);
            this.lblTurno.TabIndex = 42;
            this.lblTurno.Text = "Preferencia Turno";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDias.ForeColor = System.Drawing.Color.White;
            this.lblDias.Location = new System.Drawing.Point(58, 383);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(215, 31);
            this.lblDias.TabIndex = 41;
            this.lblDias.Text = "Preferencia Días";
            // 
            // lblDispElec
            // 
            this.lblDispElec.AutoSize = true;
            this.lblDispElec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDispElec.ForeColor = System.Drawing.Color.White;
            this.lblDispElec.Location = new System.Drawing.Point(58, 154);
            this.lblDispElec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDispElec.Name = "lblDispElec";
            this.lblDispElec.Size = new System.Drawing.Size(317, 31);
            this.lblDispElec.TabIndex = 40;
            this.lblDispElec.Text = "Dispositivos Electrónicos";
            // 
            // frmModificarPreferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.ControlBox = false;
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnRegresar);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmModificarPreferencias";
            this.Sizable = false;
            this.Text = "frmModificarPreferencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.CheckedListBox chblRedes;
        private System.Windows.Forms.CheckBox chbGestante;
        private System.Windows.Forms.CheckedListBox chblDias;
        private System.Windows.Forms.CheckedListBox chblTurno;
        private System.Windows.Forms.CheckedListBox chblInternet;
        private System.Windows.Forms.CheckBox chbRecursos;
        private System.Windows.Forms.CheckedListBox chblDispositivos;
        private System.Windows.Forms.Label lblRedes;
        private System.Windows.Forms.Label lblInternet;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblDispElec;
    }
}