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
    public partial class frmDetalleCursoInscrito : MaterialSkin.Controls.MaterialForm 
    {
        public frmListaCursoInscritos formAnterior;
        private frmPlantillaGestion plantillaGestion;

        public frmDetalleCursoInscrito(frmListaCursoInscritos formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
        }


        private void btnVideos_Click_1(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscritoMaterial(this, plantillaGestion));

        }

        private void btnReuniones_Click_1(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCursoInscritoReunion(this, plantillaGestion));

        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(formAnterior);

        }
    }
}
