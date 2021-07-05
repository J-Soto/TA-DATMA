using MaterialSkin.Controls;
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
using InterfazDATMA.util;
using MaterialSkin;

namespace InterfazDATMA.psicologo
{
    public partial class frmPerfilPsicologo : MaterialSkin.Controls.MaterialForm
    {
        
        private UsuarioWS.UsuarioWSClient daoUsuario;
        private frmPlantillaGestion plantillaGestion;

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public frmPerfilPsicologo(frmPlantillaGestion Plantilla)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            HabilitarCampos();
            plantillaGestion = Plantilla;
            daoUsuario = new UsuarioWS.UsuarioWSClient();
            txtUser.Enabled = true;
            txtPass.Enabled = true;
            

            txtUser.Text = frmPlantillaGestion.psico.user;
            txtPass.Text = frmPlantillaGestion.psico.password;
            txtCel.Text = frmPlantillaGestion.psico.celular;
            txtGen.Text = frmPlantillaGestion.psico.correo;
            txtDni.Text = frmPlantillaGestion.psico.DNI;
            txtEdad.Text = frmPlantillaGestion.psico.edad.ToString(); 
            txtFechaNac.Text = frmPlantillaGestion.psico.fechaNacimiento.ToString();
            txtGen.Text = Convert.ToChar(frmPlantillaGestion.psico.genero).ToString();
            txtNom.Text = frmPlantillaGestion.psico.nombre + " " + frmPlantillaGestion.psico.apellidoPaterno + " " + frmPlantillaGestion.psico.apellidoMaterno;
            txtTelf.Text = frmPlantillaGestion.psico.telefono;
           
            if (frmPlantillaGestion.psico.fotoPerfil is object)
            {
                picPerfil.Image = (Bitmap)((new ImageConverter()).ConvertFrom(frmPlantillaGestion.psico.fotoPerfil));
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmGestionarModulosPsicologo(plantillaGestion));
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtUser.Text = frmPlantillaGestion.user.user;
            txtPass.Text = frmPlantillaGestion.user.password;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("Seguro que quiere modificar los datos?\nNuevo Usuario: " + txtUser.Text + "\nNueva Contraseña: " + txtPass.Text,
                "Mensaje de Confirmación",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == DialogResult.Yes)
            {
                UsuarioWS.usuario tempUser = new UsuarioWS.usuario();
                tempUser.idUsuario = frmPlantillaGestion.user.idUsuario;
                tempUser.user = txtUser.Text;
                tempUser.password = txtPass.Text;
                int resultado = daoUsuario.modificarUsuario(tempUser);
                if (resultado == 1)
                {
                    daoUsuario.enviarDatosUsuario(txtCorreo.Text, tempUser.user, tempUser.password, txtNom.Text, "", 1);
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
        private void DeshabilitarCampos()
        {
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
            txtNom.Enabled = true;
            txtNom.ReadOnly = false;
            txtPass.Enabled = true;
            txtPass.ReadOnly = false;
            txtTelf.Enabled = true;
            txtTelf.ReadOnly = false;
            txtUser.Enabled = true;
            txtUser.ReadOnly = false;
        }

        private void frmPerfilPsicologo_Load(object sender, EventArgs e)
        {

        }
    }
}
