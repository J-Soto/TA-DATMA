
namespace InterfazDATMA.Administrador
{
    partial class frmModificarTutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarTutor));
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelf = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtApellidoMat = new System.Windows.Forms.TextBox();
            this.txtApellidoPat = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.rbtnHombre = new System.Windows.Forms.RadioButton();
            this.rbtnMujer = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApMat = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblApPat = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.ofdSubirFoto = new System.Windows.Forms.OpenFileDialog();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.AgregarDistrio = new MaterialSkin.Controls.MaterialButton();
            this.btnAsignarUsuario = new MaterialSkin.Controls.MaterialButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialButton();
            this.btnSiguiente = new MaterialSkin.Controls.MaterialButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Header = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // lblGenero
            // 
            resources.ApplyResources(this.lblGenero, "lblGenero");
            this.lblGenero.ForeColor = System.Drawing.Color.White;
            this.lblGenero.Name = "lblGenero";
            // 
            // txtCelular
            // 
            resources.ApplyResources(this.txtCelular, "txtCelular");
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Validating += new System.ComponentModel.CancelEventHandler(this.txtCelular_Validating);
            // 
            // txtTelf
            // 
            resources.ApplyResources(this.txtTelf, "txtTelf");
            this.txtTelf.Name = "txtTelf";
            this.txtTelf.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelf_Validating);
            // 
            // txtDni
            // 
            resources.ApplyResources(this.txtDni, "txtDni");
            this.txtDni.Name = "txtDni";
            this.txtDni.Validating += new System.ComponentModel.CancelEventHandler(this.txtDni_Validating);
            // 
            // txtCorreo
            // 
            resources.ApplyResources(this.txtCorreo, "txtCorreo");
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.txtCorreo_Validating);
            // 
            // txtApellidoMat
            // 
            resources.ApplyResources(this.txtApellidoMat, "txtApellidoMat");
            this.txtApellidoMat.Name = "txtApellidoMat";
            // 
            // txtApellidoPat
            // 
            resources.ApplyResources(this.txtApellidoPat, "txtApellidoPat");
            this.txtApellidoPat.Name = "txtApellidoPat";
            this.txtApellidoPat.Validating += new System.ComponentModel.CancelEventHandler(this.txtApellidoPat_Validating);
            // 
            // dtpFechaNacimiento
            // 
            resources.ApplyResources(this.dtpFechaNacimiento, "dtpFechaNacimiento");
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Validating += new System.ComponentModel.CancelEventHandler(this.dtpFechaNacimiento_Validating);
            // 
            // rbtnHombre
            // 
            resources.ApplyResources(this.rbtnHombre, "rbtnHombre");
            this.rbtnHombre.ForeColor = System.Drawing.Color.White;
            this.rbtnHombre.Name = "rbtnHombre";
            this.rbtnHombre.TabStop = true;
            this.rbtnHombre.UseVisualStyleBackColor = true;
            // 
            // rbtnMujer
            // 
            resources.ApplyResources(this.rbtnMujer, "rbtnMujer");
            this.rbtnMujer.ForeColor = System.Drawing.Color.White;
            this.rbtnMujer.Name = "rbtnMujer";
            this.rbtnMujer.TabStop = true;
            this.rbtnMujer.UseVisualStyleBackColor = true;
            this.rbtnMujer.Validating += new System.ComponentModel.CancelEventHandler(this.rbtnMujer_Validating);
            // 
            // txtNombre
            // 
            resources.ApplyResources(this.txtNombre, "txtNombre");
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // lblApMat
            // 
            resources.ApplyResources(this.lblApMat, "lblApMat");
            this.lblApMat.ForeColor = System.Drawing.Color.White;
            this.lblApMat.Name = "lblApMat";
            // 
            // lblCorreo
            // 
            resources.ApplyResources(this.lblCorreo, "lblCorreo");
            this.lblCorreo.ForeColor = System.Drawing.Color.White;
            this.lblCorreo.Name = "lblCorreo";
            // 
            // lblDni
            // 
            resources.ApplyResources(this.lblDni, "lblDni");
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Name = "lblDni";
            // 
            // lblDistrito
            // 
            resources.ApplyResources(this.lblDistrito, "lblDistrito");
            this.lblDistrito.ForeColor = System.Drawing.Color.White;
            this.lblDistrito.Name = "lblDistrito";
            // 
            // lblCelular
            // 
            resources.ApplyResources(this.lblCelular, "lblCelular");
            this.lblCelular.ForeColor = System.Drawing.Color.White;
            this.lblCelular.Name = "lblCelular";
            // 
            // lblApPat
            // 
            resources.ApplyResources(this.lblApPat, "lblApPat");
            this.lblApPat.ForeColor = System.Drawing.Color.White;
            this.lblApPat.Name = "lblApPat";
            // 
            // lblFechaNacimiento
            // 
            resources.ApplyResources(this.lblFechaNacimiento, "lblFechaNacimiento");
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            // 
            // lblTelefono
            // 
            resources.ApplyResources(this.lblTelefono, "lblTelefono");
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Name = "lblTelefono";
            // 
            // lblNombre
            // 
            resources.ApplyResources(this.lblNombre, "lblNombre");
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Name = "lblNombre";
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Image = global::InterfazDATMA.Properties.Resources.postulante;
            resources.ApplyResources(this.pbFoto, "pbFoto");
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.TabStop = false;
            // 
            // txtDistrito
            // 
            resources.ApplyResources(this.txtDistrito, "txtDistrito");
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Validating += new System.ComponentModel.CancelEventHandler(this.txtDistrito_Validating);
            // 
            // btnSubirFoto
            // 
            resources.ApplyResources(this.btnSubirFoto, "btnSubirFoto");
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click_1);
            // 
            // AgregarDistrio
            // 
            resources.ApplyResources(this.AgregarDistrio, "AgregarDistrio");
            this.AgregarDistrio.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AgregarDistrio.Depth = 0;
            this.AgregarDistrio.HighEmphasis = true;
            this.AgregarDistrio.Icon = null;
            this.AgregarDistrio.MouseState = MaterialSkin.MouseState.HOVER;
            this.AgregarDistrio.Name = "AgregarDistrio";
            this.AgregarDistrio.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AgregarDistrio.UseAccentColor = false;
            this.AgregarDistrio.UseVisualStyleBackColor = true;
            this.AgregarDistrio.Click += new System.EventHandler(this.btnNuevoDistrito_Click_1);
            // 
            // btnAsignarUsuario
            // 
            resources.ApplyResources(this.btnAsignarUsuario, "btnAsignarUsuario");
            this.btnAsignarUsuario.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAsignarUsuario.Depth = 0;
            this.btnAsignarUsuario.HighEmphasis = true;
            this.btnAsignarUsuario.Icon = null;
            this.btnAsignarUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAsignarUsuario.Name = "btnAsignarUsuario";
            this.btnAsignarUsuario.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAsignarUsuario.UseAccentColor = false;
            this.btnAsignarUsuario.UseVisualStyleBackColor = true;
            this.btnAsignarUsuario.Click += new System.EventHandler(this.btnAsignarUsuario_Click);
            // 
            // btnCancelar
            // 
            resources.ApplyResources(this.btnCancelar, "btnCancelar");
            this.btnCancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.HighEmphasis = true;
            this.btnCancelar.Icon = null;
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancelar.UseAccentColor = false;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnSiguiente
            // 
            resources.ApplyResources(this.btnSiguiente, "btnSiguiente");
            this.btnSiguiente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSiguiente.Depth = 0;
            this.btnSiguiente.HighEmphasis = true;
            this.btnSiguiente.Icon = null;
            this.btnSiguiente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSiguiente.UseAccentColor = false;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // Header
            // 
            resources.ApplyResources(this.Header, "Header");
            this.Header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.Name = "Header";
            // 
            // frmModificarTutor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(107)))), ((int)(((byte)(130)))));
            this.ControlBox = false;
            this.Controls.Add(this.Header);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAsignarUsuario);
            this.Controls.Add(this.AgregarDistrio);
            this.Controls.Add(this.btnSubirFoto);
            this.Controls.Add(this.txtDistrito);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelf);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtApellidoMat);
            this.Controls.Add(this.txtApellidoPat);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.rbtnHombre);
            this.Controls.Add(this.rbtnMujer);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApMat);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblDistrito);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblApPat);
            this.Controls.Add(this.lblFechaNacimiento);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmModificarTutor";
            this.Sizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelf;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidoMat;
        private System.Windows.Forms.TextBox txtApellidoPat;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.RadioButton rbtnHombre;
        private System.Windows.Forms.RadioButton rbtnMujer;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApMat;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblApPat;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.OpenFileDialog ofdSubirFoto;
        private System.Windows.Forms.Button btnSubirFoto;
        private MaterialSkin.Controls.MaterialButton AgregarDistrio;
        private MaterialSkin.Controls.MaterialButton btnAsignarUsuario;
        private MaterialSkin.Controls.MaterialButton btnCancelar;
        private MaterialSkin.Controls.MaterialButton btnSiguiente;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label Header;
        //private MaterialSkin.Controls.MaterialFlatButton btnAsignarUsuario;
    }
}