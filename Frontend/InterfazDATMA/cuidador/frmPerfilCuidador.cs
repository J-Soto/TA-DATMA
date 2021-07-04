
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
using MaterialSkin;

namespace InterfazDATMA.cuidador
{
    public partial class frmPerfilCuidador : MaterialSkin.Controls.MaterialForm 
    {

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        private UsuarioWS.UsuarioWSClient daoUsuario = new UsuarioWS.UsuarioWSClient();
        private frmPlantillaGestion plantillaGestion;
        public frmPerfilCuidador(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            HabilitarCampos();
            plantillaGestion = plantilla;
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
            catch (Exception)
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
                HabilitarCampos();
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

        private void  DeshabilitarCampos()
        {
            txtBajoRec.Enabled = false;
            txtBajoRec.ReadOnly = true;
            txtCel.Enabled = false;
            txtCel.ReadOnly = true;
            txtCorreo.Enabled = false;
            txtCorreo.ReadOnly = true;
            txtDni.Enabled = false;
            txtDni.ReadOnly = true;
            txtEdad.Enabled = false;
            txtEdad.ReadOnly = true;
            txtFechaNac.Enabled = false;
            txtFechaNac.ReadOnly = true;
            txtGen.Enabled = false;
            txtGen.ReadOnly = true;
            txtGest.Enabled = false;
            txtGest.ReadOnly = true;
            txtNom.Enabled = false;
            txtNom.ReadOnly = true;
            txtPass.Enabled = false;
            txtPass.ReadOnly = true;
            txtTelf.Enabled = false;
            txtTelf.ReadOnly = true;
            txtUser.Enabled = false;
            txtUser.ReadOnly = true;
        }


        private void HabilitarCampos()
        {
            txtBajoRec.Enabled = true;
            txtBajoRec.ReadOnly= false;
            txtCel.Enabled = true;
            txtCel.ReadOnly = false;
            txtCorreo.Enabled = true;
            txtCorreo.ReadOnly = false;
            txtDni.Enabled = true;
            txtDni.ReadOnly = false;
            txtEdad.Enabled = true;
            txtEdad.ReadOnly = false;
            txtFechaNac.Enabled = true;
            txtFechaNac.ReadOnly = false;
            txtGen.Enabled = true;
            txtGen.ReadOnly = false;
            txtGest.Enabled = true;
            txtGest.ReadOnly = false;
            txtNom.Enabled = true;
            txtNom.ReadOnly = false;
            txtPass.Enabled = true;
            txtPass.ReadOnly = false;
            txtTelf.Enabled = true;
            txtTelf.ReadOnly = false;
            txtUser.Enabled = true;
            txtUser.ReadOnly = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUser.Text = frmPlantillaGestion.user.user;
            txtPass.Text = frmPlantillaGestion.user.password;
        }

       
    }
}
