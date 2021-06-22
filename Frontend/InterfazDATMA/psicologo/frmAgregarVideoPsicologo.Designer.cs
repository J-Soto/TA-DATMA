
namespace InterfazDATMA
{
    partial class frmAgregarMaterialPsicologo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarMaterialPsicologo));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtlinkArchivo = new System.Windows.Forms.TextBox();
            this.btnLinkArchivo = new System.Windows.Forms.Button();
            this.btnGuardarArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // txtDescripcion
            // 
            resources.ApplyResources(this.txtDescripcion, "txtDescripcion");
            this.txtDescripcion.Name = "txtDescripcion";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtlinkArchivo
            // 
            resources.ApplyResources(this.txtlinkArchivo, "txtlinkArchivo");
            this.txtlinkArchivo.Name = "txtlinkArchivo";
            // 
            // btnLinkArchivo
            // 
            this.btnLinkArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnLinkArchivo.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnLinkArchivo, "btnLinkArchivo");
            this.btnLinkArchivo.ForeColor = System.Drawing.Color.White;
            this.btnLinkArchivo.Name = "btnLinkArchivo";
            this.btnLinkArchivo.UseVisualStyleBackColor = false;
            // 
            // btnGuardarArchivo
            // 
            this.btnGuardarArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnGuardarArchivo.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnGuardarArchivo, "btnGuardarArchivo");
            this.btnGuardarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarArchivo.Name = "btnGuardarArchivo";
            this.btnGuardarArchivo.UseVisualStyleBackColor = false;
            // 
            // frmAgregarMaterialPsicologo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ControlBox = false;
            this.Controls.Add(this.btnGuardarArchivo);
            this.Controls.Add(this.btnLinkArchivo);
            this.Controls.Add(this.txtlinkArchivo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmAgregarMaterialPsicologo";
            this.Sizable = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtlinkArchivo;
        private System.Windows.Forms.Button btnGuardarArchivo;
        internal System.Windows.Forms.Button btnLinkArchivo;
    }
}