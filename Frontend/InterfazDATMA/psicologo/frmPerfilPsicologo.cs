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

namespace InterfazDATMA.psicologo
{
    public partial class frmPerfilPsicologo : MaterialSkin.Controls.MaterialForm
    {
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private UsuarioWS.UsuarioWSClient daoUsuario;
        private frmPlantillaGestion plantillaGestion;
        private PsicologoWS.psicologo psico;

        public frmPerfilPsicologo(frmPlantillaGestion Plantilla)
        {
            InitializeComponent();
            Design.Ini(this);
            plantillaGestion = Plantilla;
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            daoUsuario = new UsuarioWS.UsuarioWSClient();
            // obtener psicolog a partir del usuario
            //var psicologos = daoPsicologo.listarTodosPsicologos();
            //foreach (var psico in psicologos)
            //{
            //    if (psico.idUsuario == frmPlantillaGestion.user.idUsuario)
            //    {
            //        frmPlantillaGestion.psico = psico;
            //        break;
            //    }
            //}
            txtUser.Enabled = true;
            txtPass.Enabled = true;

            psico = daoPsicologo.buscarPsicologoPorIdUsuario(frmPlantillaGestion.user.idUsuario);
            frmPlantillaGestion.psico = psico;

            txtUser.Text = frmPlantillaGestion.psico.user;
            txtPass.Text = frmPlantillaGestion.psico.password;
            txtCel.Text = frmPlantillaGestion.psico.celular;
            txtGen.Text = frmPlantillaGestion.psico.correo;
            txtDNI.Text = frmPlantillaGestion.psico.DNI;
            txtEdad.Text = frmPlantillaGestion.psico.edad.ToString(); 
            txtFecha.Text = frmPlantillaGestion.psico.fechaNacimiento.ToString();
            txtGen.Text = Convert.ToChar(frmPlantillaGestion.psico.genero).ToString();
            txtNombre.Text = frmPlantillaGestion.psico.nombre + " " + frmPlantillaGestion.psico.apellidoPaterno + " " + frmPlantillaGestion.psico.apellidoMaterno;
            txtTelef.Text = frmPlantillaGestion.psico.telefono;
            //picPerfil.Image = (Bitmap)((new ImageConverter()).ConvertFrom(frmPlantillaGestion.psico.fotoPerfil));
            

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
    }
}
