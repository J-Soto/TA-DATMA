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
        private frmPlantillaGestion plantillaGestion;
        private PsicologoWS.psicologo psico;

        public frmPerfilPsicologo(frmPlantillaGestion Plantilla)
        { 
            InitializeComponent();
            Design.Ini(this);
            plantillaGestion = Plantilla;
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
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

            
            psico = daoPsicologo.buscarPsicologoPorIdUsuario(frmPlantillaGestion.user.idUsuario);
            frmPlantillaGestion.psico = psico;

            txtUser.Text = frmPlantillaGestion.psico.user;
            txtPass.Text = frmPlantillaGestion.psico.password;
            txtCel.Text = frmPlantillaGestion.psico.celular;
            txtCorreo.Text = frmPlantillaGestion.psico.correo;
            txtDNI.Text = frmPlantillaGestion.psico.DNI;
            txtEdad.Text = frmPlantillaGestion.psico.edad.ToString(); 
            txtFecha.Text = frmPlantillaGestion.psico.fechaNacimiento.ToString();
            txtGen.Text = Convert.ToChar(frmPlantillaGestion.psico.genero).ToString();
            txtNombre.Text = frmPlantillaGestion.psico.nombre + " " + frmPlantillaGestion.psico.apellidoPaterno + " " + frmPlantillaGestion.psico.apellidoMaterno;
            txtTelef.Text = frmPlantillaGestion.psico.telefono;
            //picPerfil.Image = (Bitmap)((new ImageConverter()).ConvertFrom(frmPlantillaGestion.psico.fotoPerfil));
            txtCel.Enabled = false;
            txtCorreo.Enabled = false;
            txtDNI.Enabled = false;
            txtEdad.Enabled = false;
            txtFecha.Enabled = false;
            txtGen.Enabled = false;
            txtNombre.Enabled = false;
            txtTelef.Enabled = false;
            txtUser.Enabled = false;
            txtPass.Enabled = false;
        }

        private void Cursos_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmGestionarModulosPsicologo(plantillaGestion));
        }

        private void Cursos_Click_1(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            txtBajoRec.Enabled = true;
            txtCel.Enabled = true;
            txtCorreo.Enabled = true;
            txtDNI.Enabled = true;
            txtEdad.Enabled = true;
            txtFecha.Enabled = true;
            txtGen.Enabled = true;
            txtGestante.Enabled = true;
            txtNombre.Enabled = true;
            txtTelef.Enabled = true;
            txtUser.Enabled = true;
            txtPass.Enabled = true;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            txtCel.Enabled = false;
            txtCorreo.Enabled = false;
            txtDNI.Enabled = false;
            txtEdad.Enabled = false;
            txtFecha.Enabled = false;
            txtGen.Enabled = false;
            txtNombre.Enabled = false;
            txtTelef.Enabled = false;
            txtUser.Enabled = false;
            txtPass.Enabled = false;
        }
    }
}
