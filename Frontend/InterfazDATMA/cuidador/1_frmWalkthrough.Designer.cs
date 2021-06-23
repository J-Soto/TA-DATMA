
namespace InterfazDATMA
{
    partial class frmWalkthrough
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAnt = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnFinalizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureboxWalk = new System.Windows.Forms.PictureBox();
            this.btnNext = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxWalk)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnAnt
            // 
            this.btnAnt.AutoSize = true;
            this.btnAnt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnt.Depth = 0;
            this.btnAnt.Location = new System.Drawing.Point(513, 786);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnt.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Primary = false;
            this.btnAnt.Size = new System.Drawing.Size(147, 36);
            this.btnAnt.TabIndex = 7;
            this.btnAnt.Text = "Anterior";
            this.btnAnt.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AutoSize = true;
            this.btnFinalizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinalizar.Depth = 0;
            this.btnFinalizar.Location = new System.Drawing.Point(787, 894);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinalizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Primary = false;
            this.btnFinalizar.Size = new System.Drawing.Size(152, 36);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            // 
            // pictureboxWalk
            // 
            this.pictureboxWalk.Image = global::InterfazDATMA.Properties.Resources.canon1;
            this.pictureboxWalk.Location = new System.Drawing.Point(427, 195);
            this.pictureboxWalk.Margin = new System.Windows.Forms.Padding(6);
            this.pictureboxWalk.Name = "pictureboxWalk";
            this.pictureboxWalk.Size = new System.Drawing.Size(890, 510);
            this.pictureboxWalk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxWalk.TabIndex = 6;
            this.pictureboxWalk.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Depth = 0;
            this.btnNext.Location = new System.Drawing.Point(1101, 786);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.Primary = false;
            this.btnNext.Size = new System.Drawing.Size(152, 36);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // frmWalkthrough
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1744, 1125);
            this.ControlBox = false;
            this.Controls.Add(this.btnAnt);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.pictureboxWalk);
            this.Controls.Add(this.btnNext);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmWalkthrough";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Tutorial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxWalk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialFlatButton btnAnt;
        private MaterialSkin.Controls.MaterialFlatButton btnFinalizar;
        private System.Windows.Forms.PictureBox pictureboxWalk;
        private MaterialSkin.Controls.MaterialFlatButton btnNext;
    }
}