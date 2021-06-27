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
        private frmWalkthrough formAnterior;
        private frmPerfilCuidador formAnterior2;
        private frmPlantillaGestion plantillaGestion;
        private List<CursoWS.curso> cursos = null;
        private CursoWS.CursoWSClient daoCuros = new CursoWS.CursoWSClient();

        public frmListaCursoInscritos(frmWalkthrough formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            var temp = daoCuros.listarCursosDeTutor(frmPlantillaGestion.tutor.idPersona);
            if (temp is object)
            {
                cursos = new List<CursoWS.curso>(temp);
            }

            this.plantillaGestion = plantillaGestion;
            this.formAnterior = formAnterior;
        }
        public frmListaCursoInscritos(frmPerfilCuidador formAnterior2, frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            this.plantillaGestion = plantillaGestion;
            this.formAnterior2 = formAnterior2;
        }

        private void frmListaCursoInscritos_Load(object sender, EventArgs e)
        {
            
        }

        private bool verificarCursosDisponibles()
        {
            Random rd = new Random();
            if (rd.Next(2) == 1) return true;
            else return false;
        }
        private void btnCursosDisponibles_Click(object sender, EventArgs e)
        {
            /*
            bool hayCursos = verificarCursosDisponibles();
            if (hayCursos) plantillaGestion.abrirFormulario(new frmCursosDisponibles(this, plantillaGestion));
            else plantillaGestion.abrirFormulario(new frmSinCursosDisponibles(this, plantillaGestion));*/
            plantillaGestion.abrirFormulario(new frmCursosDisponibles(this, plantillaGestion));

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

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
