
namespace InterfazDATMA
{
    partial class frmInscripcionHecha
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
            this.lblFelicitacion = new System.Windows.Forms.Label();
            this.btnIrCurso = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnIrLista = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // lblFelicitacion
            // 
            this.lblFelicitacion.AutoSize = true;
            this.lblFelicitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFelicitacion.ForeColor = System.Drawing.Color.White;
            this.lblFelicitacion.Location = new System.Drawing.Point(194, 171);
            this.lblFelicitacion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFelicitacion.Name = "lblFelicitacion";
            this.lblFelicitacion.Size = new System.Drawing.Size(604, 37);
            this.lblFelicitacion.TabIndex = 0;
            this.lblFelicitacion.Text = "Tu inscripción ha sido realizada con éxito";
            this.lblFelicitacion.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnIrCurso
            // 
            this.btnIrCurso.AutoSize = true;
            this.btnIrCurso.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIrCurso.Depth = 0;
            this.btnIrCurso.Location = new System.Drawing.Point(390, 366);
            this.btnIrCurso.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIrCurso.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIrCurso.Name = "btnIrCurso";
            this.btnIrCurso.Primary = false;
            this.btnIrCurso.Size = new System.Drawing.Size(177, 36);
            this.btnIrCurso.TabIndex = 58;
            this.btnIrCurso.Text = "Ir al Curso";
            this.btnIrCurso.UseVisualStyleBackColor = true;
            this.btnIrCurso.Click += new System.EventHandler(this.btnIrCurso_Click_1);
            // 
            // btnIrLista
            // 
            this.btnIrLista.AutoSize = true;
            this.btnIrLista.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIrLista.Depth = 0;
            this.btnIrLista.Location = new System.Drawing.Point(390, 515);
            this.btnIrLista.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnIrLista.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnIrLista.Name = "btnIrLista";
            this.btnIrLista.Primary = false;
            this.btnIrLista.Size = new System.Drawing.Size(138, 36);
            this.btnIrLista.TabIndex = 59;
            this.btnIrLista.Text = "Aceptar";
            this.btnIrLista.UseVisualStyleBackColor = true;
            this.btnIrLista.Click += new System.EventHandler(this.btnIrLista_Click_1);
            // 
            // frmInscripcionHecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(958, 646);
            this.ControlBox = false;
            this.Controls.Add(this.btnIrLista);
            this.Controls.Add(this.btnIrCurso);
            this.Controls.Add(this.lblFelicitacion);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmInscripcionHecha";
            this.Text = "frmInscripcionHecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFelicitacion;
        private MaterialSkin.Controls.MaterialFlatButton btnIrCurso;
        private MaterialSkin.Controls.MaterialFlatButton btnIrLista;
    }
}