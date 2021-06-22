
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblAgradecimiento = new System.Windows.Forms.Label();
            this.lblNotificacionActiva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(121, 289);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(296, 46);
            this.btnAceptar.TabIndex = 25;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblAgradecimiento
            // 
            this.lblAgradecimiento.AutoSize = true;
            this.lblAgradecimiento.ForeColor = System.Drawing.Color.White;
            this.lblAgradecimiento.Location = new System.Drawing.Point(84, 203);
            this.lblAgradecimiento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAgradecimiento.Name = "lblAgradecimiento";
            this.lblAgradecimiento.Size = new System.Drawing.Size(373, 25);
            this.lblAgradecimiento.TabIndex = 24;
            this.lblAgradecimiento.Text = "Gracias por utilizar nuestra aplicacion";
            // 
            // lblNotificacionActiva
            // 
            this.lblNotificacionActiva.AutoSize = true;
            this.lblNotificacionActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacionActiva.ForeColor = System.Drawing.Color.White;
            this.lblNotificacionActiva.Location = new System.Drawing.Point(89, 98);
            this.lblNotificacionActiva.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotificacionActiva.Name = "lblNotificacionActiva";
            this.lblNotificacionActiva.Size = new System.Drawing.Size(368, 37);
            this.lblNotificacionActiva.TabIndex = 23;
            this.lblNotificacionActiva.Text = "Sesion cerrada con exito";
            // 
            // frmLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(572, 435);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblAgradecimiento);
            this.Controls.Add(this.lblNotificacionActiva);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogout";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogout";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblAgradecimiento;
        private System.Windows.Forms.Label lblNotificacionActiva;
    }
}