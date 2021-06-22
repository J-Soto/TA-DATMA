
namespace InterfazDATMA
{
    partial class frmSinCursosDisponibles
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
            this.lblCursosDisponibles = new System.Windows.Forms.Label();
            this.grpBoxJustificacion = new System.Windows.Forms.GroupBox();
            this.lblJustificacion = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNotificacion = new System.Windows.Forms.Label();
            this.btnNotificar = new MaterialSkin.Controls.MaterialFlatButton();
            this.grpBoxJustificacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCursosDisponibles
            // 
            this.lblCursosDisponibles.AutoSize = true;
            this.lblCursosDisponibles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCursosDisponibles.ForeColor = System.Drawing.Color.White;
            this.lblCursosDisponibles.Location = new System.Drawing.Point(454, 87);
            this.lblCursosDisponibles.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCursosDisponibles.Name = "lblCursosDisponibles";
            this.lblCursosDisponibles.Size = new System.Drawing.Size(414, 37);
            this.lblCursosDisponibles.TabIndex = 0;
            this.lblCursosDisponibles.Text = "Lista de Cursos Disponibles";
            // 
            // grpBoxJustificacion
            // 
            this.grpBoxJustificacion.Controls.Add(this.lblJustificacion);
            this.grpBoxJustificacion.Location = new System.Drawing.Point(410, 181);
            this.grpBoxJustificacion.Margin = new System.Windows.Forms.Padding(6);
            this.grpBoxJustificacion.Name = "grpBoxJustificacion";
            this.grpBoxJustificacion.Padding = new System.Windows.Forms.Padding(6);
            this.grpBoxJustificacion.Size = new System.Drawing.Size(582, 265);
            this.grpBoxJustificacion.TabIndex = 1;
            this.grpBoxJustificacion.TabStop = false;
            // 
            // lblJustificacion
            // 
            this.lblJustificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblJustificacion.ForeColor = System.Drawing.Color.White;
            this.lblJustificacion.Location = new System.Drawing.Point(100, 85);
            this.lblJustificacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblJustificacion.Name = "lblJustificacion";
            this.lblJustificacion.Size = new System.Drawing.Size(386, 98);
            this.lblJustificacion.TabIndex = 2;
            this.lblJustificacion.Text = "Disculpe, pero actualmente no hay cursos disponibles";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNotificar);
            this.groupBox1.Controls.Add(this.lblNotificacion);
            this.groupBox1.Location = new System.Drawing.Point(410, 498);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(582, 265);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblNotificacion
            // 
            this.lblNotificacion.ForeColor = System.Drawing.Color.White;
            this.lblNotificacion.Location = new System.Drawing.Point(100, 46);
            this.lblNotificacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNotificacion.Name = "lblNotificacion";
            this.lblNotificacion.Size = new System.Drawing.Size(386, 98);
            this.lblNotificacion.TabIndex = 2;
            this.lblNotificacion.Text = "Te notificaremos cuando haya nuevos cursos";
            // 
            // btnNotificar
            // 
            this.btnNotificar.AutoSize = true;
            this.btnNotificar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNotificar.Depth = 0;
            this.btnNotificar.Location = new System.Drawing.Point(193, 150);
            this.btnNotificar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNotificar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNotificar.Name = "btnNotificar";
            this.btnNotificar.Primary = false;
            this.btnNotificar.Size = new System.Drawing.Size(195, 36);
            this.btnNotificar.TabIndex = 5;
            this.btnNotificar.Text = "Notificarme";
            this.btnNotificar.UseVisualStyleBackColor = true;
            this.btnNotificar.Click += new System.EventHandler(this.btnNotificar_Click_1);
            // 
            // frmSinCursosDisponibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1744, 1125);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpBoxJustificacion);
            this.Controls.Add(this.lblCursosDisponibles);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmSinCursosDisponibles";
            this.Text = "Cursos Disponibles";
            this.grpBoxJustificacion.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCursosDisponibles;
        private System.Windows.Forms.GroupBox grpBoxJustificacion;
        private System.Windows.Forms.Label lblJustificacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNotificacion;
        private MaterialSkin.Controls.MaterialFlatButton btnNotificar;
    }
}