using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA;
using InterfazDATMA.plantilla;

namespace InterfazDATMA
{
    public partial class frmGestionarModulosPsicologo : Form
    {
        private frmPlantillaGestion plantillaGestion;
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private CursoWS.CursoWSClient daoCurso;

        public frmGestionarModulosPsicologo(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            plantillaGestion = plantilla;
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            daoCurso = new CursoWS.CursoWSClient();
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
            // obtener cursos del psicologo
            var cursos = daoCurso.listarCursos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmConfigurarModuloPsicologo(this,plantillaGestion));
        }

       
    }
}
