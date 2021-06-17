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
    public partial class frmPerfilCuidador : Form
    {
        private TutorWS.TutorWSClient daoTutor;
        private frmPlantillaGestion plantillaGestion;
        public frmPerfilCuidador(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            plantillaGestion = plantilla;
            daoTutor = new TutorWS.TutorWSClient();
            //daoTutor.modificarTutor(new TutorWS.tutor());
            var tutores = daoTutor.listarTodosTutores();
            foreach (var tutor in tutores)
            {
                if (tutor.idUsuario== frmPlantillaGestion.user.idUsuario)
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
            txtNombre.Text = frmPlantillaGestion.tutor.nombre;
            txtTelef.Text = frmPlantillaGestion.tutor.telefono;
            txtBajoRec.Text = frmPlantillaGestion.tutor.bajoRecursos.ToString();
            txtGestante.Text = frmPlantillaGestion.tutor.gestante.ToString();
        }

        private void Cursos_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmListaCursoInscritos(this,plantillaGestion));
        }
    }
}
