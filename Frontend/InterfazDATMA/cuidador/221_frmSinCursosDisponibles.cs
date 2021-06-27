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
    public partial class frmSinCursosDisponibles : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion plantillaGestion;
        private frmListaCursoInscritos formAnterior; 
        public frmSinCursosDisponibles(frmListaCursoInscritos formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            this.plantillaGestion = plantillaGestion;
            this.formAnterior = formAnterior;
        }


        private void btnNotificar_Click_1(object sender, EventArgs e)
        {
            frmNotificacionActiva formNotificacion = new frmNotificacionActiva();
            if (formNotificacion.ShowDialog() == DialogResult.OK)
            {
                plantillaGestion.abrirFormulario(formAnterior);
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
