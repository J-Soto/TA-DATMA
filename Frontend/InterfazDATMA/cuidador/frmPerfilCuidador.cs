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

namespace InterfazDATMA.cuidador
{
    public partial class frmPerfilCuidador : MaterialSkin.Controls.MaterialForm 
    {
        private TutorWS.TutorWSClient daoTutor;
        private frmPlantillaGestion plantillaGestion;
        public frmPerfilCuidador(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            plantillaGestion = plantilla;
            daoTutor = new TutorWS.TutorWSClient();
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
            txtDNI.Text = frmPlantillaGestion.tutor.DNI;
            txtEdad.Text = frmPlantillaGestion.tutor.edad.ToString();
            txtFecha.Text = frmPlantillaGestion.tutor.fechaNacimiento.ToString();
            txtGen.Text = Convert.ToChar(frmPlantillaGestion.tutor.genero).ToString();
            txtNombre.Text = frmPlantillaGestion.tutor.nombre + " " + frmPlantillaGestion.tutor.apellidoPaterno + " " + frmPlantillaGestion.tutor.apellidoMaterno;
            txtTelef.Text = frmPlantillaGestion.tutor.telefono;
            if (frmPlantillaGestion.tutor.bajoRecursos==1) txtBajoRec.Text = "No";
            else txtBajoRec.Text = "Si";
            if (frmPlantillaGestion.tutor.gestante == 1) txtGestante.Text = "No";
            else txtGestante.Text = "Si";
            picPerfil.Image = (Bitmap)((new ImageConverter()).ConvertFrom(frmPlantillaGestion.tutor.fotoPerfil));
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
    }
}
