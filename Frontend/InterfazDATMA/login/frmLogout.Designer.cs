
namespace InterfazDATMA.login
{
    partial class frmLogout
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
            this.btnAceptar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblNotificacionActiva = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblAgradecimiento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Location = new System.Drawing.Point(233, 442);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = false;
            this.btnAceptar.Size = new System.Drawing.Size(138, 36);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // lblNotificacionActiva
            // 
            this.lblNotificacionActiva.Depth = 0;
            this.lblNotificacionActiva.Hint = "";
            this.lblNotificacionActiva.Location = new System.Drawing.Point(130, 188);
            this.lblNotificacionActiva.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNotificacionActiva.Name = "lblNotificacionActiva";
            this.lblNotificacionActiva.PasswordChar = '\0';
            this.lblNotificacionActiva.SelectedText = "";
            this.lblNotificacionActiva.SelectionLength = 0;
            this.lblNotificacionActiva.SelectionStart = 0;
            this.lblNotificacionActiva.Size = new System.Drawing.Size(399, 41);
            this.lblNotificacionActiva.TabIndex = 34;
            this.lblNotificacionActiva.Text = "Sesion cerrada con exito";
            this.lblNotificacionActiva.UseSystemPasswordChar = false;
            // 
            // lblAgradecimiento
            // 
            this.lblAgradecimiento.Depth = 0;
            this.lblAgradecimiento.Hint = "";
            this.lblAgradecimiento.Location = new System.Drawing.Point(69, 306);
            this.lblAgradecimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAgradecimiento.Name = "lblAgradecimiento";
            this.lblAgradecimiento.PasswordChar = '\0';
            this.lblAgradecimiento.SelectedText = "";
            this.lblAgradecimiento.SelectionLength = 0;
            this.lblAgradecimiento.SelectionStart = 0;
            this.lblAgradecimiento.Size = new System.Drawing.Size(505, 41);
            this.lblAgradecimiento.TabIndex = 35;
            this.lblAgradecimiento.Text = "Gracias por utilizar nuestra aplicacion";
            this.lblAgradecimiento.UseSystemPasswordChar = false;
            // 
            // frmLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 546);
            this.ControlBox = false;
            this.Controls.Add(this.lblAgradecimiento);
            this.Controls.Add(this.lblNotificacionActiva);
            this.Controls.Add(this.btnAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogout";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogout";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmLogout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton btnAceptar;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblNotificacionActiva;
        private MaterialSkin.Controls.MaterialSingleLineTextField lblAgradecimiento;
    }
}