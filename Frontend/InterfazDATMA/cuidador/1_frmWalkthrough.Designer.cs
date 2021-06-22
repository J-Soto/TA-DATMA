
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
            this.pictureboxWalk = new System.Windows.Forms.PictureBox();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.btnAnt = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnFinalizar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNext = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxWalk)).BeginInit();
            this.pnlContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureboxWalk
            // 
            this.pictureboxWalk.Image = global::InterfazDATMA.Properties.Resources.canon1;
            this.pictureboxWalk.Location = new System.Drawing.Point(349, 50);
            this.pictureboxWalk.Margin = new System.Windows.Forms.Padding(6);
            this.pictureboxWalk.Name = "pictureboxWalk";
            this.pictureboxWalk.Size = new System.Drawing.Size(890, 510);
            this.pictureboxWalk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxWalk.TabIndex = 2;
            this.pictureboxWalk.TabStop = false;
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.pnlContenido.Controls.Add(this.btnAnt);
            this.pnlContenido.Controls.Add(this.btnFinalizar);
            this.pnlContenido.Controls.Add(this.pictureboxWalk);
            this.pnlContenido.Controls.Add(this.btnNext);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 0);
            this.pnlContenido.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(1744, 1125);
            this.pnlContenido.TabIndex = 24;
            // 
            // btnAnt
            // 
            this.btnAnt.AutoSize = true;
            this.btnAnt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnt.Depth = 0;
            this.btnAnt.Location = new System.Drawing.Point(435, 641);
            this.btnAnt.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnt.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnt.Name = "btnAnt";
            this.btnAnt.Primary = false;
            this.btnAnt.Size = new System.Drawing.Size(147, 36);
            this.btnAnt.TabIndex = 3;
            this.btnAnt.Text = "Anterior";
            this.btnAnt.UseVisualStyleBackColor = true;
            this.btnAnt.Click += new System.EventHandler(this.btnAnt_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.AutoSize = true;
            this.btnFinalizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinalizar.Depth = 0;
            this.btnFinalizar.Location = new System.Drawing.Point(709, 749);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinalizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Primary = false;
            this.btnFinalizar.Size = new System.Drawing.Size(152, 36);
            this.btnFinalizar.TabIndex = 2;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Depth = 0;
            this.btnNext.Location = new System.Drawing.Point(1023, 641);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.Primary = false;
            this.btnNext.Size = new System.Drawing.Size(152, 36);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Siguiente";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // frmWalkthrough
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1744, 1125);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContenido);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmWalkthrough";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Tutorial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxWalk)).EndInit();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureboxWalk;
        private System.Windows.Forms.Panel pnlContenido;
        private MaterialSkin.Controls.MaterialFlatButton btnAnt;
        private MaterialSkin.Controls.MaterialFlatButton btnFinalizar;
        private MaterialSkin.Controls.MaterialFlatButton btnNext;
    }
}