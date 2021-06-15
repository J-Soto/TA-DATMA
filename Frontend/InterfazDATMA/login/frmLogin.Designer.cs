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
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnOlvido = new System.Windows.Forms.Button();
            this.checkBoxRecordarme = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(148, 260);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(225, 27);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clickUsuario);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Montserrat", 11F);
            this.txtContraseña.Location = new System.Drawing.Point(148, 312);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(225, 27);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickContraseña);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(185, 419);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(136, 37);
            this.btnIngresar.TabIndex = 21;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // btnOlvido
            // 
            this.btnOlvido.BackColor = System.Drawing.Color.Transparent;
            this.btnOlvido.FlatAppearance.BorderSize = 0;
            this.btnOlvido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOlvido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.btnOlvido.ForeColor = System.Drawing.Color.Blue;
            this.btnOlvido.Location = new System.Drawing.Point(148, 461);
            this.btnOlvido.Name = "btnOlvido";
            this.btnOlvido.Size = new System.Drawing.Size(225, 37);
            this.btnOlvido.TabIndex = 22;
            this.btnOlvido.Text = "Olvidó su contraseña?";
            this.btnOlvido.UseVisualStyleBackColor = false;
            // 
            // checkBoxRecordarme
            // 
            this.checkBoxRecordarme.AutoSize = true;
            this.checkBoxRecordarme.ForeColor = System.Drawing.Color.White;
            this.checkBoxRecordarme.Location = new System.Drawing.Point(148, 368);
            this.checkBoxRecordarme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxRecordarme.Name = "checkBoxRecordarme";
            this.checkBoxRecordarme.Size = new System.Drawing.Size(123, 24);
            this.checkBoxRecordarme.TabIndex = 23;
            this.checkBoxRecordarme.Text = "Recordarme";
            this.checkBoxRecordarme.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InterfazDATMA.Properties.Resources.DATMA_logo;
            this.pictureBox1.Location = new System.Drawing.Point(198, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(41)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(530, 510);
            this.Controls.Add(this.checkBoxRecordarme);
            this.Controls.Add(this.btnOlvido);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnOlvido;
        private System.Windows.Forms.CheckBox checkBoxRecordarme;
    }
}