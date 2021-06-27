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
namespace InterfazDATMA
{
    public partial class frmInscripcionHecha : MaterialSkin.Controls.MaterialForm 
    {
        public frmCursosDisponibles formAnterior;
        private frmPlantillaGestion plantillaGestion; 
        public frmInscripcionHecha(frmCursosDisponibles formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            this.formAnterior = formAnterior;
            this.plantillaGestion = plantillaGestion;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIrCurso_Click_1(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmDetalleCurso(this, plantillaGestion));
        }

        private void btnIrLista_Click_1(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(formAnterior);
        }
    }
}
