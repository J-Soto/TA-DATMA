namespace InterfazDATMA
{
    partial class frmLogin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtContraseña = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.checkBoxRecordarme = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnIngresar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfazDATMA.Properties.Resources.DATMA_logo;
            this.pictureBox1.Location = new System.Drawing.Point(559, 129);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(526, 553);
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(358, 41);
            this.txtUsuario.TabIndex = 24;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtContraseña.Depth = 0;
            this.txtContraseña.Hint = "";
            this.txtContraseña.Location = new System.Drawing.Point(526, 635);
            this.txtContraseña.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '\0';
            this.txtContraseña.SelectedText = "";
            this.txtContraseña.SelectionLength = 0;
            this.txtContraseña.SelectionStart = 0;
            this.txtContraseña.Size = new System.Drawing.Size(358, 41);
            this.txtContraseña.TabIndex = 25;
            this.txtContraseña.TabStop = false;
            this.txtContraseña.Text = "Password";
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // checkBoxRecordarme
            // 
            this.checkBoxRecordarme.AutoSize = true;
            this.checkBoxRecordarme.Depth = 0;
            this.checkBoxRecordarme.Font = new System.Drawing.Font("Roboto", 10F);
            this.checkBoxRecordarme.Location = new System.Drawing.Point(526, 721);
            this.checkBoxRecordarme.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxRecordarme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxRecordarme.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxRecordarme.Name = "checkBoxRecordarme";
            this.checkBoxRecordarme.Ripple = true;
            this.checkBoxRecordarme.Size = new System.Drawing.Size(185, 30);
            this.checkBoxRecordarme.TabIndex = 26;
            this.checkBoxRecordarme.Text = "Recordarme";
            this.checkBoxRecordarme.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.AutoSize = true;
            this.btnIngresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIngresar.Depth = 0;
            this.btnIngresar.Location = new System.Drawing.Point(539, 817);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIngresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Primary = false;
            this.btnIngresar.Size = new System.Drawing.Size(147, 36);
            this.btnIngresar.TabIndex = 27;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.ForeColor = System.Drawing.Color.Blue;
            this.materialFlatButton2.Location = new System.Drawing.Point(539, 911);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(353, 36);
            this.materialFlatButton2.TabIndex = 28;
            this.materialFlatButton2.Text = "Olivdo su contrasena?";
            this.materialFlatButton2.UseVisualStyleBackColor = false;
            // 
            // frmLogin
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 1050);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.checkBoxRecordarme);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmLogin";
            this.Padding = new System.Windows.Forms.Padding(6, 123, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtContraseña;
        private MaterialSkin.Controls.MaterialCheckBox checkBoxRecordarme;
        private MaterialSkin.Controls.MaterialFlatButton btnIngresar;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    }
}