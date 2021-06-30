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

namespace InterfazDATMA.Administrador
{
    public partial class frmModificarTutor : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion formPlantilla;
        public frmOperacionesPersona formOperacionPersona;

        private TutorWS.TutorWSClient daoTutor;

        private TutorWS.tutor tutor;
        private string rutaFoto = "";

        public bool usuarioAsignado = false;

        public frmModificarTutor(frmOperacionesPersona formOperacionPersona, frmPlantillaGestion formPlantilla, TutorWS.tutor tutor)
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
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
            txtApPat.Text = "";
            txtApMat.Text = "";
            txtCorreo.Text = "";
            txtDni.Text = "";
            txtTelf.Text = "";
            txtCel.Text = "";
            rbtnHombre.Checked = false;
            rbtnMujer.Checked = false;
            if (tutor.user != null || tutor.user!="0") btnAsignarUsuario.Enabled = false;
        }

        private void completarDatosTutores()
        {
            txtNombre.Text = tutor.nombre;
            txtApPat.Text = tutor.apellidoPaterno;
            txtApMat.Text = tutor.apellidoMaterno;
            txtCorreo.Text = tutor.correo;
            /* La contraseña no se muestra*/
            //txtPass.Text = tutor.password;
            //txtConfirmarPass.Text = tutor.password;
            /*----------------------------*/
            txtDni.Text = tutor.DNI;
            txtTelf.Text = tutor.telefono;
            txtCel.Text = tutor.celular;
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
            tutor.apellidoPaterno = txtApPat.Text;
            tutor.apellidoMaterno = txtApMat.Text;
            tutor.correo = txtCorreo.Text;
            tutor.DNI = txtDni.Text;
            tutor.telefono = txtTelf.Text;
            tutor.celular = txtCel.Text;
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
            if (tutor.DNI.Length != 8)  // Si el DNI es una cadena diferente de longitud 8
            {
                MessageBox.Show("El DNI debe tener 8 digitos.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.DNI[0] == '0')    // Si el DNI inicia con cero 
            {
                MessageBox.Show("El DNI no puede empezar con cero.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.celular.Length != 9) // Si el celular es una cadena diferente de longitud 9
            {
                MessageBox.Show("El número de celular debe tener 9 digitos.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.celular[0] != '9')   // Si el numero de celular no empieza con 9
            {
                MessageBox.Show("El número de celular debe empezar con nueve.", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.user.Length < 4)     // Si el usuario tiene menos de 4 caracteres
            {
                MessageBox.Show("El usuario debe tener al menos 4 caracteres", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.telefono.Length != 7)    // Si el número de telefono inicia con 7
            {
                MessageBox.Show("El telefono debe tener 7 digitos", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(tutor.telefono[0] == '0')       // Si el numero de telefono inicia con cero
            {
                MessageBox.Show("El número de teléfono no puede empezar con cero", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (tutor.password.Length == 5) // Si la contraseña tiene 5 caracteres
            {
                MessageBox.Show("La contraseña debe tener al menos 5 caracteres", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!Char.IsLetter(tutor.correo[0]) || tutor.correo.Contains("@") != true || (tutor.correo.Contains(".com") || tutor.correo.Contains(".pe")) != true)       // El correo debe tener el @, iniciar con .com o .pe y además debe comenzar con una letra
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
