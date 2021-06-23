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

namespace InterfazDATMA.Administrador
{
    public partial class frmModificarTutor : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        public frmOperacionesPersona formOperacionPersona;

        private TutorWS.TutorWSClient daoTutor;

        private TutorWS.tutor tutor;
        private string rutaFoto = "";

        public frmModificarTutor(frmOperacionesPersona formOperacionPersona, frmPlantillaGestion formPlantilla, TutorWS.tutor tutor)
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            this.tutor = tutor;
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500,MaterialSkin.Primary.BlueGrey700,MaterialSkin.Primary.BlueGrey100,MaterialSkin.Accent.Teal700,MaterialSkin.TextShade.WHITE);
            
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
            txtApPat.Text = "";
            txtApMat.Text = "";
            txtCorreo.Text = "";
            txtDni.Text = "";
            txtTelf.Text = "";
            txtCel.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = false;
        }

        private void completarDatosTutores()
        {
            txtNombre.Text = tutor.nombre;
            txtApPat.Text = tutor.apellidoPaterno;
            txtApMat.Text = tutor.apellidoMaterno;
            txtCorreo.Text = tutor.correo;
            txtUser.Text = tutor.user;
            /* La contraseña no se muestra*/
            //txtPass.Text = tutor.password;
            //txtConfirmarPass.Text = tutor.password;
            /*----------------------------*/
            txtDni.Text = tutor.DNI;
            txtTelf.Text = tutor.telefono;
            txtCel.Text = tutor.celular;
            txtDistrito.Text = tutor.distrito.nombre;
            if (tutor.genero == 'M')
            {
                rbtnHombre.Checked = true;
            }
            else
            {
                rbtnMujer.Checked = true;
            }

            if (tutor.fotoPerfil != null)
            {
                MemoryStream ms = new MemoryStream(tutor.fotoPerfil);
                pbFoto.Image = new Bitmap(ms);
            }
        }

        private void btnSubirFoto_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ofdSubirFoto.ShowDialog() == DialogResult.OK)
                {
                    rutaFoto = ofdSubirFoto.FileName;
                    //MessageBox.Show(rutaFoto);
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
            tutor.apellidoPaterno = txtApPat.Text;
            tutor.apellidoMaterno = txtApMat.Text;
            tutor.correo = txtCorreo.Text;
            tutor.DNI = txtDni.Text;
            tutor.telefono = txtTelf.Text;
            tutor.celular = txtCel.Text;
            tutor.fechaNacimiento = dtpFechaNacimiento.Value;
            tutor.fechaNacimientoSpecified = true;
            tutor.user = txtUser.Text;
            tutor.password = txtPass.Text;
            // RadioButton
            if (rbtnHombre.Checked == true)
            {
                tutor.genero = 'M';
            }
            else
            {
                tutor.genero = 'F';
            }
            //Foto es opcional:
            if (rutaFoto.Equals("") != true)
            {
                FileStream fs = new FileStream(rutaFoto, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                tutor.fotoPerfil = br.ReadBytes((int)fs.Length);
            }
            else
            {
                tutor.fotoPerfil = null;
            }

            //Validaciones:
            if (tutor.DNI.Length != 8)  // FALTA No debe iniciar con 0
            {
                MessageBox.Show("El DNI debe tener 8 digitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.celular.Length != 9) // FALTA Debe iniciar con 9
            {
                MessageBox.Show("El celular debe tener 9 digitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.user.Length < 4)
            {
                MessageBox.Show("El usuario debe tener al menos 4 caracteres", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.telefono.Length != 7)    // FALTA No puede iniciar con 0
            {
                MessageBox.Show("El telefono debe tener 7 digitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.password != txtConfirmarPass.Text)   // FALTA Minimo 6 caracteres - al menos 1 numero - 1 mayuscula
            {
                MessageBox.Show("Las contraseñas deben coincidir", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.correo.Contains("@") != true)       // FALTA Restringir a .com, .pe, etc
            {
                MessageBox.Show("Correo invalido", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
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
        }
    }
}
