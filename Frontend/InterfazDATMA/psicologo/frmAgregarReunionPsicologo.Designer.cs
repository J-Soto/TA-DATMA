﻿
namespace InterfazDATMA
{
    partial class frmAgregarReunionPsicologo
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
            this.btnGuardarReunion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaReunion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.RichTextBox();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnGuardarReunion
            // 
            this.btnGuardarReunion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(100)))));
            this.btnGuardarReunion.FlatAppearance.BorderSize = 0;
            this.btnGuardarReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGuardarReunion.ForeColor = System.Drawing.Color.White;
            this.btnGuardarReunion.Location = new System.Drawing.Point(301, 409);
            this.btnGuardarReunion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardarReunion.Name = "btnGuardarReunion";
            this.btnGuardarReunion.Size = new System.Drawing.Size(357, 55);
            this.btnGuardarReunion.TabIndex = 6;
            this.btnGuardarReunion.Text = "GUARDAR";
            this.btnGuardarReunion.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(231, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hora de Inicio:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(140, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Hora de Fin:";
            // 
            // dtpFechaReunion
            // 
            this.dtpFechaReunion.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight;
            this.dtpFechaReunion.CustomFormat = "\"dd/MM/yyyy\"";
            this.dtpFechaReunion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaReunion.Location = new System.Drawing.Point(387, 91);
            this.dtpFechaReunion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaReunion.Name = "dtpFechaReunion";
            this.dtpFechaReunion.Size = new System.Drawing.Size(271, 31);
            this.dtpFechaReunion.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(260, 304);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 37);
            this.label4.TabIndex = 13;
            this.label4.Text = "Link:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtLink
            // 
            this.txtLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.txtLink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtLink.ForeColor = System.Drawing.Color.White;
            this.txtLink.Location = new System.Drawing.Point(387, 304);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(452, 36);
            this.txtLink.TabIndex = 14;
            this.txtLink.Text = "";
            this.txtLink.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(387, 164);
            this.dtpInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(215, 31);
            this.dtpInicio.TabIndex = 15;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(387, 238);
            this.dtpFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(215, 31);
            this.dtpFin.TabIndex = 16;
            // 
            // frmAgregarReunionPsicologo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(960, 541);
            this.ControlBox = false;
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpFechaReunion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardarReunion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAgregarReunionPsicologo";
            this.Sizable = false;
            this.Text = "frmAgregarReunionPsicologo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardarReunion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaReunion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtLink;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
    }
}