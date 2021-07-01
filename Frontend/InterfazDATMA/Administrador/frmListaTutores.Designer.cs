﻿
namespace InterfazDATMA.Administrador
{
    partial class frmListaTutores
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
            this.Header = new System.Windows.Forms.Label();
            this.dgvTutor = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApPat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutor)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.Font = new System.Drawing.Font("Century Gothic", 25F);
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Location = new System.Drawing.Point(113, 51);
            this.Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(406, 61);
            this.Header.TabIndex = 2;
            this.Header.Text = "Lista de Tutores ";
            // 
            // dgvTutor
            // 
            this.dgvTutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colApPat,
            this.colApMat,
            this.colDNI,
            this.colFechaNac,
            this.colEdad,
            this.colTelf,
            this.colCel,
            this.colEmail});
            this.dgvTutor.Location = new System.Drawing.Point(124, 260);
            this.dgvTutor.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvTutor.Name = "dgvTutor";
            this.dgvTutor.RowHeadersVisible = false;
            this.dgvTutor.RowHeadersWidth = 82;
            this.dgvTutor.RowTemplate.Height = 33;
            this.dgvTutor.Size = new System.Drawing.Size(1174, 393);
            this.dgvTutor.TabIndex = 11;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(734, 206);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(461, 26);
            this.txtBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.Location = new System.Drawing.Point(1221, 201);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(77, 36);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.MinimumWidth = 10;
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 200;
            // 
            // colApPat
            // 
            this.colApPat.DataPropertyName = "apellidoPaterno";
            this.colApPat.HeaderText = "Apellido Paterno";
            this.colApPat.MinimumWidth = 10;
            this.colApPat.Name = "colApPat";
            this.colApPat.ReadOnly = true;
            this.colApPat.Width = 200;
            // 
            // colApMat
            // 
            this.colApMat.DataPropertyName = "apellidoMaterno";
            this.colApMat.HeaderText = "Apellido Materno";
            this.colApMat.MinimumWidth = 10;
            this.colApMat.Name = "colApMat";
            this.colApMat.ReadOnly = true;
            this.colApMat.Width = 200;
            // 
            // colDNI
            // 
            this.colDNI.DataPropertyName = "DNI";
            this.colDNI.HeaderText = "DNI";
            this.colDNI.MinimumWidth = 10;
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            this.colDNI.Width = 200;
            // 
            // colFechaNac
            // 
            this.colFechaNac.DataPropertyName = "fechaNacimiento";
            this.colFechaNac.HeaderText = "Fecha de Nacimiento";
            this.colFechaNac.MinimumWidth = 10;
            this.colFechaNac.Name = "colFechaNac";
            this.colFechaNac.ReadOnly = true;
            this.colFechaNac.Width = 200;
            // 
            // colEdad
            // 
            this.colEdad.DataPropertyName = "edad";
            this.colEdad.HeaderText = "Edad";
            this.colEdad.MinimumWidth = 10;
            this.colEdad.Name = "colEdad";
            this.colEdad.ReadOnly = true;
            this.colEdad.Width = 200;
            // 
            // colTelf
            // 
            this.colTelf.DataPropertyName = "telefono";
            this.colTelf.HeaderText = "Telefono";
            this.colTelf.MinimumWidth = 10;
            this.colTelf.Name = "colTelf";
            this.colTelf.ReadOnly = true;
            this.colTelf.Width = 200;
            // 
            // colCel
            // 
            this.colCel.DataPropertyName = "celular";
            this.colCel.HeaderText = "Celular";
            this.colCel.MinimumWidth = 10;
            this.colCel.Name = "colCel";
            this.colCel.ReadOnly = true;
            this.colCel.Width = 200;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "correo";
            this.colEmail.HeaderText = "Correo";
            this.colEmail.MinimumWidth = 10;
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 200;
            // 
            // frmListaTutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1450, 714);
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvTutor);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.Header);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmListaTutores";
            this.Padding = new System.Windows.Forms.Padding(2, 51, 2, 2);
            this.Sizable = false;
            this.Text = "frmListaTutores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.DataGridView dgvTutor;
        private System.Windows.Forms.TextBox txtBuscar;
        private MaterialSkin.Controls.MaterialButton btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApPat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        //private MaterialSkin.Controls.MaterialFlatButton btnBuscar;
    }
}