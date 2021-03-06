
namespace InterfazDATMA.Administrador
{
    partial class ReporteTutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteTutor));
            this.btnDescargar = new MaterialSkin.Controls.MaterialButton();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDescargar
            // 
            this.btnDescargar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDescargar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDescargar.Depth = 0;
            this.btnDescargar.HighEmphasis = true;
            this.btnDescargar.Icon = null;
            this.btnDescargar.Location = new System.Drawing.Point(1137, 479);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnDescargar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(106, 36);
            this.btnDescargar.TabIndex = 2;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDescargar.UseAccentColor = false;
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(248, 87);
            this.axAcroPDF1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(791, 428);
            this.axAcroPDF1.TabIndex = 3;
            // 
            // ReporteTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 654);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.btnDescargar);
            this.Name = "ReporteTutor";
            this.Padding = new System.Windows.Forms.Padding(3, 51, 3, 3);
            this.Text = "ReporteTutor";
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnDescargar;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}