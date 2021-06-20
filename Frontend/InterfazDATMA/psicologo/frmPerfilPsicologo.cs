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

namespace InterfazDATMA.psicologo
{
    public partial class frmPerfilPsicologo : Form
    {
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private frmPlantillaGestion plantillaGestion;
        public frmPerfilPsicologo(frmPlantillaGestion Plantilla)
        { 
            InitializeComponent();
            plantillaGestion = Plantilla;
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            // obtener psicolog a partir del usuario
            var psicologos = daoPsicologo.listarTodosPsicologos();
            foreach (var psico in psicologos)
            {
                if (psico.idUsuario == frmPlantillaGestion.user.idUsuario)
                {
                    frmPlantillaGestion.psico = psico;
                    break;
                }
            }
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
        }

        private void Cursos_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmGestionarModulosPsicologo(plantillaGestion));
        }
    }
}
