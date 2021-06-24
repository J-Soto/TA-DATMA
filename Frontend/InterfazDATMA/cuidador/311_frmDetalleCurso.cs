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

namespace InterfazDATMA
{
    public partial class frmDetalleCurso : MaterialSkin.Controls.MaterialForm 
    {
        public frmInscripcionHecha formAnterior1=null;
        public frmInformacionCurso formAnterior2=null;
        private frmPlantillaGestion plantillaGestion;
        public frmDetalleCurso(frmInscripcionHecha formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            this.formAnterior1 = formAnterior;
            this.plantillaGestion = plantillaGestion;
        }public frmDetalleCurso(frmInformacionCurso formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            this.formAnterior2 = formAnterior;
            this.plantillaGestion = plantillaGestion;
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            if (formAnterior1 != null)
                plantillaGestion.abrirFormulario(formAnterior1.formAnterior);
            else plantillaGestion.abrirFormulario(formAnterior2.formAnterior);
        }

        private void btnAnt_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void lblInfoSemana_Click(object sender, EventArgs e)
        {

        }
    }
}
