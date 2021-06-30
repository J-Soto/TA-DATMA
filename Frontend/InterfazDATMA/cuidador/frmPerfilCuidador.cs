
using InterfazDATMA.plantilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using InterfazDATMA.util;

namespace InterfazDATMA.cuidador
{
    public partial class frmPerfilCuidador : MaterialSkin.Controls.MaterialForm 
    {
        private TutorWS.TutorWSClient daoTutor;
        private UsuarioWS.UsuarioWSClient daoUsuario;
        private frmPlantillaGestion plantillaGestion;
        public frmPerfilCuidador(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            Design.Ini(this);
            plantillaGestion = plantilla;
            daoTutor = new TutorWS.TutorWSClient();
            daoUsuario = new UsuarioWS.UsuarioWSClient();
            //daoTutor.modificarTutor(new TutorWS.tutor());
            var tutores = daoTutor.listarTodosTutores();
            foreach (var tutor in tutores)
            {
                if (tutor.idUsuario == frmPlantillaGestion.user.idUsuario)
                {
                    frmPlantillaGestion.tutor = tutor;
                    break;
                }
            }
            txtUser.Text = frmPlantillaGestion.tutor.user;
            txtPass.Text = frmPlantillaGestion.tutor.password;
            txtCel.Text = frmPlantillaGestion.tutor.celular;
            txtCorreo.Text = frmPlantillaGestion.tutor.correo;
            txtDni.Text = frmPlantillaGestion.tutor.DNI;
            txtEdad.Text = frmPlantillaGestion.tutor.edad.ToString();
            txtFechaNac.Text = frmPlantillaGestion.tutor.fechaNacimiento.ToString();
            txtGen.Text = Convert.ToChar(frmPlantillaGestion.tutor.genero).ToString();
            txtNom.Text = frmPlantillaGestion.tutor.nombre + " " + frmPlantillaGestion.tutor.apellidoPaterno + " " + frmPlantillaGestion.tutor.apellidoMaterno;
            txtTelf.Text = frmPlantillaGestion.tutor.telefono;
            if (frmPlantillaGestion.tutor.bajoRecursos == 1) txtBajoRec.Text = "No";
            else txtBajoRec.Text = "Si";
            if (frmPlantillaGestion.tutor.gestante == 1) txtGest.Text = "No";
            else txtGest.Text = "Si";
            try
            {
                pictureBox1.Image = (Bitmap)((new ImageConverter()).ConvertFrom(frmPlantillaGestion.tutor.fotoPerfil));
            }
            catch (Exception ex)
            {

            }
        }


        private void Cursos_Click_1(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmListaCursoInscritos(this, plantillaGestion));
        }

        private void frmPerfilCuidador_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel21_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Correo_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmListaCursoInscritos(this, plantillaGestion));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Seguro que quiere modificar los datos?", "Mensaje de Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                UsuarioWS.usuario tempUser = new UsuarioWS.usuario();
                tempUser.idUsuario = frmPlantillaGestion.user.idUsuario;
                tempUser.user = txtUser.Text;
                tempUser.password = txtPass.Text;
                int resultado = daoUsuario.modificarUsuario(tempUser);
                if (resultado == 1)
                {
                    daoUsuario.enviarDatosUsuario(txtCorreo.Text, tempUser.user, tempUser.password);
                    MessageBox.Show("Datos cambiados con éxito.", "Mensaje de Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmPlantillaGestion.user.user = txtUser.Text;
                    frmPlantillaGestion.user.password = txtPass.Text;
                }
                else
                    MessageBox.Show("Error al cambiar los datos. Intentelo más tarde", "Mensaje de Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                txtUser.Text = frmPlantillaGestion.user.user;
                txtPass.Text = frmPlantillaGestion.user.password;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUser.Text = frmPlantillaGestion.user.user;
            txtPass.Text = frmPlantillaGestion.user.password;
        }
    }
}
