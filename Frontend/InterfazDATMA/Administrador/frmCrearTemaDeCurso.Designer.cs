
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
            this.btnGuardarTema = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lblTutoresUser
            // 
            this.lblTutoresUser.AutoSize = true;
            this.lblTutoresUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTutoresUser.ForeColor = System.Drawing.Color.White;
            this.lblTutoresUser.Location = new System.Drawing.Point(69, 142);
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
            this.label1.Location = new System.Drawing.Point(161, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "Descripcion:";
            // 
            // txtNombreTema
            // 
            this.txtNombreTema.Location = new System.Drawing.Point(383, 148);
            this.txtNombreTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreTema.Name = "txtNombreTema";
            this.txtNombreTema.Size = new System.Drawing.Size(483, 31);
            this.txtNombreTema.TabIndex = 16;
            // 
            // txtDescripcionTema
            // 
            this.txtDescripcionTema.Location = new System.Drawing.Point(387, 214);
            this.txtDescripcionTema.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionTema.Name = "txtDescripcionTema";
            this.txtDescripcionTema.Size = new System.Drawing.Size(479, 153);
            this.txtDescripcionTema.TabIndex = 17;
            this.txtDescripcionTema.Text = "";
            // 
            // btnGuardarTema
            // 
            this.btnGuardarTema.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardarTema.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardarTema.Depth = 0;
            this.btnGuardarTema.HighEmphasis = true;
            this.btnGuardarTema.Icon = null;
            this.btnGuardarTema.Location = new System.Drawing.Point(193, 421);
            this.btnGuardarTema.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardarTema.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardarTema.Name = "btnGuardarTema";
            this.btnGuardarTema.Size = new System.Drawing.Size(158, 36);
            this.btnGuardarTema.TabIndex = 18;
            this.btnGuardarTema.Text = "Guardar";
            this.btnGuardarTema.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardarTema.UseAccentColor = false;
            this.btnGuardarTema.UseVisualStyleBackColor = true;
            this.btnGuardarTema.Click += new System.EventHandler(this.btnGuardarTema_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(611, 421);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 36);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            this.Padding = new System.Windows.Forms.Padding(4, 80, 4, 4);
            this.Sizable = false;
            this.Text = "Crear Tema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutoresUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreTema;
        private System.Windows.Forms.RichTextBox txtDescripcionTema;
        private MaterialSkin.Controls.MaterialButton btnGuardarTema;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        //private MaterialSkin.Controls.MaterialFlatButton btnGuardarTema;
        //private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
    }
}