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
            txtPass.Text = tutor.password;
            txtConfirmarPass.Text = tutor.password;
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

        private void btnSubirFoto_Click(object sender, EventArgs e)
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
                MessageBox.Show("Seleccionar una imagen valida", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbFoto_Click(object sender, EventArgs e)
        {

        }

        private void frmModificarTutor_Load(object sender, EventArgs e)
        {

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
                MessageBox.Show("Seleccionar una imagen valida", "Mensaje de Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            tutor.nombre = txtNombre.Text;
            tutor.apellidoPaterno = txtApPat.Text;
            tutor.apellidoMaterno = txtApMat.Text;
            tutor.correo = txtCorreo.Text;
            tutor.DNI = txtDni.Text;
            tutor.telefono = txtTelf.Text;
            tutor.celular = txtCel.Text;
            tutor.fechaNacimiento = dtpFechaNacimiento.Value;
            tutor.fechaNacimientoSpecified = true;

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

            // Se inserta también el tutor para la siguiente pantalla
            int verificado = daoTutor.verificarDNI(tutor.DNI, tutor.nombre, tutor.apellidoPaterno, tutor.apellidoMaterno);
            if (verificado == -1)
            {
                var resultado = MessageBox.Show("No se ha podido verificar el DNI. Quiere continuar?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    formPlantilla.abrirFormulario(new frmModificarPreferencias(this, formPlantilla, tutor));
                }
            }
            else if (verificado == 0)
                MessageBox.Show("El DNI no concuerda con los nombres", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                formPlantilla.abrirFormulario(new frmModificarPreferencias(this, formPlantilla, tutor));


        }
    }
}
