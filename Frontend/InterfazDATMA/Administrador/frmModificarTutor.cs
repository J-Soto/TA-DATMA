using MaterialSkin.Controls;
using InterfazDATMA.plantilla;
using InterfazDATMA.validacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA.util;
using MaterialSkin;

namespace InterfazDATMA.Administrador
{
    public partial class frmModificarTutor : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        public frmOperacionesPersona formOperacionPersona;

        private TutorWS.TutorWSClient daoTutor;

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;

        private TutorWS.tutor tutor;
        private string rutaFoto = "";

        public bool usuarioAsignado = false;

        public frmModificarTutor(frmOperacionesPersona formOperacionPersona, frmPlantillaGestion formPlantilla, TutorWS.tutor tutor)
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.tutor = tutor;
            
            this.formPlantilla = formPlantilla;
            this.formOperacionPersona = formOperacionPersona;


            txtDistrito.ReadOnly = true;
            daoTutor = new TutorWS.TutorWSClient();
            inicializarComponentes();
            completarDatosTutores();
        }

        private void inicializarComponentes()
        {
            txtNombre.Text = "";
            txtApellidoPat.Text = "";
            txtApellidoMat.Text = "";
            txtCorreo.Text = "";
            txtDni.Text = "";
            txtTelf.Text = "";
            txtCelular.Text = "";
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = false;
            if (tutor.user != null || tutor.user!="0") btnAsignarUsuario.Enabled = false;
        }

        private void completarDatosTutores()
        {
            txtNombre.Text = tutor.nombre;
            txtApellidoPat.Text = tutor.apellidoPaterno;
            txtApellidoMat.Text = tutor.apellidoMaterno;
            txtCorreo.Text = tutor.correo;
            /* La contraseña no se muestra*/
            //txtPass.Text = tutor.password;
            //txtConfirmarPass.Text = tutor.password;
            /*----------------------------*/
            txtDni.Text = tutor.DNI;
            txtTelf.Text = tutor.telefono;
            txtCelular.Text = tutor.celular;
            if (tutor.genero == 'M')
            {
                rbtnHombre.Checked = true;
            }
            else
            {
                rbtnMujer.Checked = true;
            }
            // Si se tiene la foto de perfil guardada en BD, esta se carga en PictureBox

            if (tutor.fotoPerfil != null)
            {
                MemoryStream ms = new MemoryStream(tutor.fotoPerfil);
                pbFoto.Image = new Bitmap(ms);
            }
            // Distrito
            if (tutor.distrito != null)
                txtDistrito.Text = tutor.distrito.nombre;
        }

        private void rbtnMujer_Click(object sender, EventArgs e)
        {
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = true;
        }

        private void rbtnHombre_Click(object sender, EventArgs e)
        {
            rbtnMujer.Checked = false;
            rbtnHombre.Checked = true;
        }

        private void txtTelf_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void btnSubirFoto_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ofdSubirFoto.ShowDialog() == DialogResult.OK)
                {
                    // Se obtiene la ruta de la foto
                    rutaFoto = ofdSubirFoto.FileName;
                    //MessageBox.Show(rutaFoto);
                    // Se guarda en el PictureBox
                    pbFoto.Image = Image.FromFile(rutaFoto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seleccionar una imagen valida. Error: " + ex, "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnNuevoDistrito_Click_1(object sender, EventArgs e)
        {
            frmInsertarDistrito frmDistrito = new frmInsertarDistrito();
            if (frmDistrito.ShowDialog() == DialogResult.OK)
            {
                if (frmDistrito.distrito != null)
                {
                    tutor.distrito.idDistrito = frmDistrito.distrito.idDistrito;
                    tutor.distrito.nombre = frmDistrito.distrito.nombre;
                    txtDistrito.Text = tutor.distrito.nombre;
                }
            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            formPlantilla.abrirFormulario(formOperacionPersona);

        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            // TextBox
            tutor.nombre = txtNombre.Text;
            tutor.apellidoPaterno = txtApellidoPat.Text;
            tutor.apellidoMaterno = txtApellidoMat.Text;
            tutor.correo = txtCorreo.Text;
            tutor.DNI = txtDni.Text;
            tutor.telefono = txtTelf.Text;
            tutor.celular = txtCelular.Text;
            tutor.fechaNacimiento = dtpFechaNacimiento.Value;
            tutor.fechaNacimientoSpecified = true;
            // RadioButton
            if (rbtnHombre.Checked == true)
            {
                tutor.genero = 'M';
            }
            else
            {
                tutor.genero = 'F';
            }
            //Foto es opcional
            if (rutaFoto.Equals("") != true)
            {
                FileStream fs = new FileStream(rutaFoto, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                tutor.fotoPerfil = br.ReadBytes((int)fs.Length);
            }

            //Validaciones:
            bool validacionCorrecta = true;

            // txtDni
            if (tutor.DNI.Length != 8 || tutor.DNI[0] == '0')  // El DNI debe tener 8 dígitos
            {
                this.errorProvider.SetError(txtDni, "El DNI debe tener 8 dígitos.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtDni, "");
            }

            // txtTelf
            if (tutor.telefono.Length != 7 || tutor.telefono[0] == '0')  // El telefono debe tener 7 dígitos
            {
                this.errorProvider.SetError(txtTelf, "El telefono debe tener 7 dígitos.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtTelf, "");
            }

            // txtCelular
            if (tutor.celular.Length != 9 || tutor.celular[0] != '9')  // El telefono debe tener 7 dígitos
            {
                this.errorProvider.SetError(txtCelular, "El número de celular debe tener 9 dígitos y empezar con 9.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtCelular, "");
            }

            // txtNombre
            if (tutor.nombre == "")
            {
                this.errorProvider.SetError(txtNombre, "Es requerido ingresar el nombre.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtNombre, "");
            }

            // txtApellidoPat
            if (tutor.apellidoPaterno == "")
            {
                this.errorProvider.SetError(txtApellidoPat, "Es requerido ingresar el apellido paterno.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtApellidoPat, "");
            }


            // dtpFechaNacimiento
            if (tutor.fechaNacimiento.Year > 2003)
            {
                this.errorProvider.SetError(dtpFechaNacimiento, "Es requerido ingresar una fecha de nacimiento válida.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(dtpFechaNacimiento, "");
            }

            // txtDistrito
            if (tutor.distrito == null)
            {
                this.errorProvider.SetError(txtDistrito, "Es requerido ingresar un distrito.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(txtDistrito, "");
            }

            // rbtnMujer
            if (tutor.genero == 2)
            {
                this.errorProvider.SetError(rbtnMujer, "Es requerido seleccionar un género.");
                validacionCorrecta = false;
            }
            else
            {
                this.errorProvider.SetError(rbtnMujer, "");
            }

            // txtCorreo
            if (tutor.correo != "")
            {
                if (!Char.IsLetter(tutor.correo[0]) || tutor.correo.Contains("@") != true || !(tutor.correo.IndexOf(".", tutor.correo.IndexOf("@")) > tutor.correo.IndexOf("@")))
                {
                    this.errorProvider.SetError(txtCorreo, "Ingrese un correo válido.");
                    validacionCorrecta = false;
                }
                else
                {
                    this.errorProvider.SetError(txtCorreo, "");
                }
            }
            else
            {
                this.errorProvider.SetError(txtCorreo, "Es requerido ingresar un correo.");
                validacionCorrecta = false;
            }


            if (validacionCorrecta)
            {
                int verificado = daoTutor.verificarDNI(tutor.DNI, tutor.nombre, tutor.apellidoPaterno, tutor.apellidoMaterno);
                if (verificado == -1)
                {
                    var resultado = MessageBox.Show("No se ha podido verificar el DNI. ¿Quiere continuar?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                    formPlantilla.abrirFormulario(new frmModificarPreferencias(this, formPlantilla, tutor));
                    }
                }
                else if (verificado == 0)
                    MessageBox.Show("El DNI no concuerda con los nombres.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    // AVANZA
                    formPlantilla.abrirFormulario(new frmModificarPreferencias(this, formPlantilla, tutor));
            }
            else
            {
                MessageBox.Show("Faltan datos o están incorrectos. Revisar nuevamente.", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDni_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtDni.Text.Length != 8 || txtDni.Text[0] == '0')  // El DNI debe tener 8 dígitos
            {
                this.errorProvider.SetError(txtDni, "El DNI debe tener 8 dígitos.");
            }
            else
            {
                this.errorProvider.SetError(txtDni, "");
            }
        }

        private void txtTelf_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtTelf.Text.Length != 7 || txtTelf.Text[0] == '0')  // El telefono debe tener 7 dígitos
            {
                this.errorProvider.SetError(txtTelf, "El telefono debe tener 7 dígitos.");
            }
            else
            {
                this.errorProvider.SetError(txtTelf, "");
            }
        }

        private void txtCelular_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCelular.Text.Length != 9 || txtCelular.Text[0] != '9')  // El telefono debe tener 7 dígitos
            {
                this.errorProvider.SetError(txtCelular, "El número de celular debe tener 9 dígitos y empezar con 9.");
            }
            else
            {
                this.errorProvider.SetError(txtCelular, "");
            }
        }

        private void txtNombre_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtNombre.Text == "")
            {
                this.errorProvider.SetError(txtNombre, "Es requerido ingresar el nombre.");
            }
            else
            {
                this.errorProvider.SetError(txtNombre, "");
            }
        }

        private void txtApellidoPat_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtApellidoPat.Text == "")
            {
                this.errorProvider.SetError(txtApellidoPat, "Es requerido ingresar el apellido paterno.");
            }
            else
            {
                this.errorProvider.SetError(txtApellidoPat, "");
            }
        }

        private void txtCorreo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCorreo.Text != "")
            {
                if (!Char.IsLetter(txtCorreo.Text[0]) || txtCorreo.Text.Contains("@") != true || !(txtCorreo.Text.IndexOf(".", txtCorreo.Text.IndexOf("@")) > txtCorreo.Text.IndexOf("@")))
                {
                    this.errorProvider.SetError(txtCorreo, "Ingrese un correo válido.");
                }
                else
                {
                    this.errorProvider.SetError(txtCorreo, "");
                }
            }
            else
            {
                this.errorProvider.SetError(txtCorreo, "Es requerido ingresar un correo.");
            }
        }

        private void dtpFechaNacimiento_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dtpFechaNacimiento.Value.Year > 2003)
            {
                this.errorProvider.SetError(dtpFechaNacimiento, "Es requerido ingresar una fecha de nacimiento válida.");
            }
            else
            {
                this.errorProvider.SetError(dtpFechaNacimiento, "");
            }
        }

        private void txtDistrito_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtDistrito.Text == null)
            {
                this.errorProvider.SetError(txtDistrito, "Es requerido ingresar un distrito.");
            }
            else
            {
                this.errorProvider.SetError(txtDistrito, "");
            }
        }

        private void rbtnMujer_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (rbtnMujer.Checked == false && rbtnHombre.Checked == false)
            {
                this.errorProvider.SetError(rbtnMujer, "Es requerido seleccionar un género.");
            }
            else
            {
                this.errorProvider.SetError(rbtnMujer, "");
            }
        }

        private (string, string) generarUsuario()
        {
            string user = Guid.NewGuid().ToString("N");
            if (user.Length > 75)
                user = user.Substring(0, 75);
            string password = Guid.NewGuid().ToString("N");
            if (password.Length > 15)
                password = password.Substring(0, 15);
            return (user, password);
        }
        private void btnAsignarUsuario_Click(object sender, EventArgs e)
        {
            var credenciales = generarUsuario();
            tutor.user = credenciales.Item1;
            tutor.password = credenciales.Item2;
            usuarioAsignado = true;
            btnAsignarUsuario.Enabled = false;
        }
    }
}
