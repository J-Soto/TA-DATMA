
namespace InterfazDATMA.psicologo
{
    partial class frmInsertarDocumento
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtRutaArchivo = new System.Windows.Forms.TextBox();
            this.btnSubirArchivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.ofdBuscarDoc = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Archivo:";
            // 
            // txtRutaArchivo
            // 
            this.txtRutaArchivo.Location = new System.Drawing.Point(228, 127);
            this.txtRutaArchivo.Name = "txtRutaArchivo";
            this.txtRutaArchivo.Size = new System.Drawing.Size(492, 26);
            this.txtRutaArchivo.TabIndex = 11;
            // 
            // btnSubirArchivo
            // 
            this.btnSubirArchivo.Location = new System.Drawing.Point(752, 127);
            this.btnSubirArchivo.Name = "btnSubirArchivo";
            this.btnSubirArchivo.Size = new System.Drawing.Size(98, 35);
            this.btnSubirArchivo.TabIndex = 12;
            this.btnSubirArchivo.Text = "...";
            this.btnSubirArchivo.UseVisualStyleBackColor = true;
            this.btnSubirArchivo.Click += new System.EventHandler(this.btnSubirArchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(231, 199);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(488, 158);
            this.txtDescripcion.TabIndex = 14;
            this.txtDescripcion.Text = "";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(341, 453);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 40);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(557, 456);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(147, 35);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ofdBuscarDoc
            // 
            this.ofdBuscarDoc.FileName = "openFileDialog1";
            // 
            // frmInsertarDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(992, 508);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubirArchivo);
            this.Controls.Add(this.txtRutaArchivo);
            this.Controls.Add(this.label2);
            this.Name = "frmInsertarDocumento";
            this.Text = "Insertar Documento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRutaArchivo;
        private System.Windows.Forms.Button btnSubirArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.OpenFileDialog ofdBuscarDoc;
    }
}