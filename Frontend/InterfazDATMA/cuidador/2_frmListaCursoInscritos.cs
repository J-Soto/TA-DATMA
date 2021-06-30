using InterfazDATMA.cuidador;
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
namespace InterfazDATMA
{
    public partial class frmListaCursoInscritos : MaterialSkin.Controls.MaterialForm
    {
        private frmPerfilCuidador formAnterior2;
        private frmPlantillaGestion plantillaGestion;
        private List<CursoWS.curso> cursos = null;
        private CursoWS.CursoWSClient daoCurso = new CursoWS.CursoWSClient();

        public frmListaCursoInscritos(frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            var temp = daoCurso.listarCursosDeTutor(frmPlantillaGestion.tutor.idPersona);
            if (temp is object)
            {
                cursos = new List<CursoWS.curso>(temp);
            }

            this.plantillaGestion = plantillaGestion;
        }
        public frmListaCursoInscritos(frmPerfilCuidador formAnterior2, frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            this.plantillaGestion = plantillaGestion;
            this.formAnterior2 = formAnterior2;
        }
      
        private void btnCursosDisponibles_Click(object sender, EventArgs e)
        {
            var temp = daoCurso.listarCursosDisponibles(frmPlantillaGestion.tutor.idPersona);
            if (temp is object)
            {
                // hay cursos disponibles
                plantillaGestion.abrirFormulario(new frmCursosDisponibles(this, plantillaGestion, new List<CursoWS.curso>(temp)));
            }
            else
            {
                // no hay
                plantillaGestion.abrirFormulario(new frmSinCursosDisponibles(this, plantillaGestion));
            }
        }

        private void btnModulo1_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscrito(this, plantillaGestion));
        }

        private void btnModulo2_Click_1(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscrito(this, plantillaGestion));
        }

        private void btnModulo3_Click_1(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscrito(this, plantillaGestion));
        }
    }
}
