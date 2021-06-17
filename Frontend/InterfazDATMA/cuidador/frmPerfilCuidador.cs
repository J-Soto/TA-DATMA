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
        private UsuarioWS.UsuarioWSClient daoUsuario;
        private TutorWS.TutorWSClient daoTutor;
        private frmPlantillaGestion plantillaGestion;
        public frmPerfilCuidador()
        {
            InitializeComponent();
            daoTutor.modificarTutor(new TutorWS.tutor());
        }

        private void Cursos_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmListaCursoInscritos(this,plantillaGestion));
        }
    }
}
