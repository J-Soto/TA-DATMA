
namespace InterfazDATMA
{
    partial class frmListaCursoInscritos
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
            this.btnCursosDisponibles = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModulo2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModulo3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnModulo1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCursosDisponibles
            // 
            this.btnCursosDisponibles.AutoSize = true;
            this.btnCursosDisponibles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCursosDisponibles.Depth = 0;
            this.btnCursosDisponibles.Location = new System.Drawing.Point(1246, 1035);
            this.btnCursosDisponibles.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCursosDisponibles.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCursosDisponibles.Name = "btnCursosDisponibles";
            this.btnCursosDisponibles.Primary = false;
            this.btnCursosDisponibles.Size = new System.Drawing.Size(451, 36);
            this.btnCursosDisponibles.TabIndex = 53;
            this.btnCursosDisponibles.Text = "Acceder a Cursos Disponibles";
            this.btnCursosDisponibles.UseVisualStyleBackColor = true;
            // 
            // btnModulo2
            // 
            this.btnModulo2.AutoSize = true;
            this.btnModulo2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModulo2.Depth = 0;
            this.btnModulo2.Location = new System.Drawing.Point(396, 267);
            this.btnModulo2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModulo2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModulo2.Name = "btnModulo2";
            this.btnModulo2.Primary = false;
            this.btnModulo2.Size = new System.Drawing.Size(121, 36);
            this.btnModulo2.TabIndex = 52;
            this.btnModulo2.Text = "Entrar";
            this.btnModulo2.UseVisualStyleBackColor = true;
            // 
            // btnModulo3
            // 
            this.btnModulo3.AutoSize = true;
            this.btnModulo3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModulo3.Depth = 0;
            this.btnModulo3.Location = new System.Drawing.Point(396, 367);
            this.btnModulo3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModulo3.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModulo3.Name = "btnModulo3";
            this.btnModulo3.Primary = false;
            this.btnModulo3.Size = new System.Drawing.Size(121, 36);
            this.btnModulo3.TabIndex = 51;
            this.btnModulo3.Text = "Entrar";
            this.btnModulo3.UseVisualStyleBackColor = true;
            // 
            // btnModulo1
            // 
            this.btnModulo1.AutoSize = true;
            this.btnModulo1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnModulo1.Depth = 0;
            this.btnModulo1.Location = new System.Drawing.Point(396, 169);
            this.btnModulo1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnModulo1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnModulo1.Name = "btnModulo1";
            this.btnModulo1.Primary = false;
            this.btnModulo1.Size = new System.Drawing.Size(121, 36);
            this.btnModulo1.TabIndex = 50;
            this.btnModulo1.Text = "Entrar";
            this.btnModulo1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Fecha});
            this.dataGridView1.Location = new System.Drawing.Point(811, 93);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(918, 829);
            this.dataGridView1.TabIndex = 49;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MinimumWidth = 10;
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 200;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 10;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 200;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(112, 610);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(76, 402);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 25);
            this.label6.TabIndex = 47;
            this.label6.Text = "Avance: 0% completado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(72, 364);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(253, 37);
            this.label7.TabIndex = 46;
            this.label7.Text = "Curso: Modulo 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(72, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Avance: 0% completado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(68, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 37);
            this.label5.TabIndex = 44;
            this.label5.Text = "Curso: Modulo 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(72, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "Avance: 0% completado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 37);
            this.label2.TabIndex = 42;
            this.label2.Text = "Curso: Modulo 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 44);
            this.label1.TabIndex = 41;
            this.label1.Text = "Lista de Cursos Inscritos";
            // 
            // frmListaCursoInscritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(135)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1744, 1125);
            this.ControlBox = false;
            this.Controls.Add(this.btnCursosDisponibles);
            this.Controls.Add(this.btnModulo2);
            this.Controls.Add(this.btnModulo3);
            this.Controls.Add(this.btnModulo1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmListaCursoInscritos";
            this.Text = "DATMA";
            this.Load += new System.EventHandler(this.frmListaCursoInscritos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton btnCursosDisponibles;
        private MaterialSkin.Controls.MaterialFlatButton btnModulo2;
        private MaterialSkin.Controls.MaterialFlatButton btnModulo3;
        private MaterialSkin.Controls.MaterialFlatButton btnModulo1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}