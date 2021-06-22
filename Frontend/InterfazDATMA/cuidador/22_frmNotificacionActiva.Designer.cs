
namespace InterfazDATMA
{
    partial class frmNotificacionActiva
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
            this.lblNotificacionActiva = new System.Windows.Forms.Label();
            this.lblAgradecimiento = new System.Windows.Forms.Label();
            this.btnAceptar = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lblNotificacionActiva
            // 
            this.lblNotificacionActiva.AutoSize = true;
            this.lblNotificacionActiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotificacionActiva.ForeColor = System.Drawing.Color.White;
            this.lblNotificacionActiva.Location = new System.Drawing.Point(148, 96);
            this.lblNotificacionActiva.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotificacionActiva.Name = "lblNotificacionActiva";
            this.lblNotificacionActiva.Size = new System.Drawing.Size(280, 37);
            this.lblNotificacionActiva.TabIndex = 0;
            this.lblNotificacionActiva.Text = "Notificacion Activa";
            // 
            // lblAgradecimiento
            // 
            this.lblAgradecimiento.AutoSize = true;
            this.lblAgradecimiento.ForeColor = System.Drawing.Color.White;
            this.lblAgradecimiento.Location = new System.Drawing.Point(150, 198);
            this.lblAgradecimiento.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAgradecimiento.Name = "lblAgradecimiento";
            this.lblAgradecimiento.Size = new System.Drawing.Size(286, 25);
            this.lblAgradecimiento.TabIndex = 1;
            this.lblAgradecimiento.Text = "Tu notificacion esta activada";
            // 
            // btnAceptar
            // 
            this.btnAceptar.AutoSize = true;
            this.btnAceptar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAceptar.Depth = 0;
            this.btnAceptar.Location = new System.Drawing.Point(140, 361);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAceptar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Primary = false;
            this.btnAceptar.Size = new System.Drawing.Size(138, 36);
            this.btnAceptar.TabIndex = 23;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // frmNotificacionActiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(572, 435);
            this.ControlBox = false;
            this.Controls.Add(this.lblAgradecimiento);
            this.Controls.Add(this.lblNotificacionActiva);
            this.Controls.Add(this.btnAceptar);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmNotificacionActiva";
            this.Text = "Notificacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotificacionActiva;
        private System.Windows.Forms.Label lblAgradecimiento;
        private MaterialSkin.Controls.MaterialFlatButton btnAceptar;
    }
}