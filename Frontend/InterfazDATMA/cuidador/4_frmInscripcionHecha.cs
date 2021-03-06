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

namespace InterfazDATMA
{
    public partial class frmInscripcionHecha : MaterialSkin.Controls.MaterialForm 
    {
        public frmCursosDisponibles formAnterior;
        private frmPlantillaGestion plantillaGestion;
        private frmListaCursoInscritos formAnterior2;
        private CursoTutor ct;

        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public frmInscripcionHecha(frmCursosDisponibles formAnterior, frmPlantillaGestion plantillaGestion, CursoTutor ct, frmListaCursoInscritos formAnterior2)
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
            this.formAnterior2 = formAnterior2;
            this.ct = ct;
        }

        private void btnIrCurso_Click_1(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscrito(formAnterior2, plantillaGestion, ct.Curso));
        }

        private void btnIrLista_Click_1(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(formAnterior);
        }
    }
}
