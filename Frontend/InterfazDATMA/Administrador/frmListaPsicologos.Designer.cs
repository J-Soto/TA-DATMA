
namespace InterfazDATMA.Administrador
{
    partial class Header
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Header));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvPsico = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApPat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApMat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsico)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // txtBuscar
            // 
            resources.ApplyResources(this.txtBuscar, "txtBuscar");
            this.txtBuscar.Name = "txtBuscar";
            // 
            // dgvPsico
            // 
            this.dgvPsico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPsico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colApPat,
            this.colApMat,
            this.colDNI,
            this.colFechaNac,
            this.colEdad,
            this.colTelf,
            this.colCel,
            this.colEmail});
            resources.ApplyResources(this.dgvPsico, "dgvPsico");
            this.dgvPsico.Name = "dgvPsico";
            this.dgvPsico.RowHeadersVisible = false;
            this.dgvPsico.RowTemplate.Height = 33;
            // 
            // colNombre
            // 
            this.colNombre.DataPropertyName = "nombre";
            resources.ApplyResources(this.colNombre, "colNombre");
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colApPat
            // 
            this.colApPat.DataPropertyName = "apellidoPaterno";
            resources.ApplyResources(this.colApPat, "colApPat");
            this.colApPat.Name = "colApPat";
            this.colApPat.ReadOnly = true;
            // 
            // colApMat
            // 
            this.colApMat.DataPropertyName = "apellidoMaterno";
            resources.ApplyResources(this.colApMat, "colApMat");
            this.colApMat.Name = "colApMat";
            this.colApMat.ReadOnly = true;
            // 
            // colDNI
            // 
            this.colDNI.DataPropertyName = "DNI";
            resources.ApplyResources(this.colDNI, "colDNI");
            this.colDNI.Name = "colDNI";
            this.colDNI.ReadOnly = true;
            // 
            // colFechaNac
            // 
            this.colFechaNac.DataPropertyName = "fechaNacimiento";
            resources.ApplyResources(this.colFechaNac, "colFechaNac");
            this.colFechaNac.Name = "colFechaNac";
            this.colFechaNac.ReadOnly = true;
            // 
            // colEdad
            // 
            this.colEdad.DataPropertyName = "edad";
            resources.ApplyResources(this.colEdad, "colEdad");
            this.colEdad.Name = "colEdad";
            this.colEdad.ReadOnly = true;
            // 
            // colTelf
            // 
            this.colTelf.DataPropertyName = "telefono";
            resources.ApplyResources(this.colTelf, "colTelf");
            this.colTelf.Name = "colTelf";
            this.colTelf.ReadOnly = true;
            // 
            // colCel
            // 
            this.colCel.DataPropertyName = "celular";
            resources.ApplyResources(this.colCel, "colCel");
            this.colCel.Name = "colCel";
            this.colCel.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "correo";
            resources.ApplyResources(this.colEmail, "colEmail");
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            // 
            // btnBuscar
            // 
            resources.ApplyResources(this.btnBuscar, "btnBuscar");
            this.btnBuscar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscar.Depth = 0;
            this.btnBuscar.HighEmphasis = true;
            this.btnBuscar.Icon = null;
            this.btnBuscar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscar.UseAccentColor = false;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // Header
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ControlBox = false;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvPsico);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Header";
            this.Sizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.dgvPsico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvPsico;
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