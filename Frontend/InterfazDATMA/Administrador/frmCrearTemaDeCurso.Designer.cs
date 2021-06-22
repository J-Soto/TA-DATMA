
namespace InterfazDATMA.Administrador
{
    partial class frmCrearTemaDeCurso
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTema = new System.Windows.Forms.TextBox();
            this.txtDescripcionTema = new System.Windows.Forms.RichTextBox();
            this.btnGuardarTema = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(69, 88);
            this.lblTutoresUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTutoresUser.Name = "lblTutoresUser";
            this.lblTutoresUser.Size = new System.Drawing.Size(283, 37);
            this.lblTutoresUser.TabIndex = 14;
            this.lblTutoresUser.Text = "Nombre del Tema:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descripcion:";
            // 
            // txtNombreTema
            // 
            this.txtNombreTema.Location = new System.Drawing.Point(383, 92);
            this.txtNombreTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreTema.Name = "txtNombreTema";
            this.txtNombreTema.Size = new System.Drawing.Size(483, 31);
            this.txtNombreTema.TabIndex = 16;
            // 
            // txtDescripcionTema
            // 
            this.txtDescripcionTema.Location = new System.Drawing.Point(385, 169);
            this.txtDescripcionTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionTema.Name = "txtDescripcionTema";
            this.txtDescripcionTema.Size = new System.Drawing.Size(479, 153);
            this.txtDescripcionTema.TabIndex = 17;
            this.txtDescripcionTema.Text = "";
            // 
            // btnGuardarTema
            // 
            this.btnGuardarTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnGuardarTema.FlatAppearance.BorderSize = 0;
            this.btnGuardarTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardarTema.ForeColor = System.Drawing.Color.White;
            this.btnGuardarTema.Location = new System.Drawing.Point(317, 396);
            this.btnGuardarTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarTema.Name = "btnGuardarTema";
            this.btnGuardarTema.Size = new System.Drawing.Size(215, 58);
            this.btnGuardarTema.TabIndex = 22;
            this.btnGuardarTema.Text = "Guardar";
            this.btnGuardarTema.UseVisualStyleBackColor = false;
            this.btnGuardarTema.Click += new System.EventHandler(this.btnGuardarTema_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(621, 396);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(215, 58);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCrearTemaDeCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1141, 528);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardarTema);
            this.Controls.Add(this.txtDescripcionTema);
            this.Controls.Add(this.txtNombreTema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTutoresUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCrearTemaDeCurso";
            this.Sizable = false;
            this.Text = "frmCrearTemaDeCurso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreTema;
        private System.Windows.Forms.RichTextBox txtDescripcionTema;
        private System.Windows.Forms.Button btnGuardarTema;
        private System.Windows.Forms.Button btnCancelar;
    }
}