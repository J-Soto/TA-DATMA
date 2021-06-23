
namespace InterfazDATMA.Administrador
{
    partial class frmReportePsicologos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportePsicologos));
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btnDescargar = new MaterialSkin.Controls.MaterialFlatButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(240, 12);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(307, 426);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // btnDescargar
            // 
            this.btnDescargar.AutoSize = true;
            this.btnDescargar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDescargar.Depth = 0;
            this.btnDescargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDescargar.Location = new System.Drawing.Point(644, 402);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnDescargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Primary = false;
            this.btnDescargar.Size = new System.Drawing.Size(91, 36);
            this.btnDescargar.TabIndex = 35;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnReportePsi_Click);
            // 
            // frmReportePsicologos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.axAcroPDF1);
            this.Name = "frmReportePsicologos";
            this.Text = "frmReportePsicologos";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private MaterialSkin.Controls.MaterialFlatButton btnDescargar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}