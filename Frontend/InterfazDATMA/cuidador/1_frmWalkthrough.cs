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
    public partial class frmWalkthrough : MaterialSkin.Controls.MaterialForm 
    {
        private int estado = 1;
        public frmPlantillaGestion plantillaGestion; 
        public frmWalkthrough(frmPlantillaGestion plantillaGestion)
        {
            this.plantillaGestion = plantillaGestion;
            InitializeComponent();
            Design.Ini(this);
            cambiarEstado(estado);
        }

        private void cambiarEstado(int estado)
        {
            if (estado == 1)
            {
                btnAnt.Enabled = false;
                pictureboxWalk.Image = global::InterfazDATMA.Properties.Resources.canon1 ;
            }
                
            else if (estado == 2)
            {
                btnAnt.Enabled = true;
                btnNext.Enabled = true;
                pictureboxWalk.Image = global::InterfazDATMA.Properties.Resources.canon2;
            }
            else
            {
                btnNext.Enabled = false;
                pictureboxWalk.Image = global::InterfazDATMA.Properties.Resources.canon3;
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            estado += 1;
            cambiarEstado(estado);

        }

        private void btnAnt_Click_1(object sender, EventArgs e)
        {
            estado -= 1;
            cambiarEstado(estado);

        }

        private void btnFinalizar_Click_1(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmListaCursoInscritos(this, plantillaGestion));


        }
    }
}
