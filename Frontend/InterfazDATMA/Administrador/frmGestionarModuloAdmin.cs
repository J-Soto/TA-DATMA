using MaterialSkin.Controls;
using InterfazDATMA.plantilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterfazDATMA.util;

namespace InterfazDATMA.Administrador
{
    public partial class frmGestionarModuloAdmin : MaterialSkin.Controls.MaterialForm
    {
        private frmPlantillaGestion plantillaGestion;
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private TutorWS.TutorWSClient daoTutor;

        public frmGestionarModuloAdmin(frmPlantillaGestion plantilla)
        {
            this.DoubleBuffered = true;
            InitializeComponent();

            Design.Ini(this);
            plantillaGestion = plantilla;
        }


        private void dgvPsicologos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGestionarModuloAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dgvPsicologos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dgvPsicologos_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarTutor_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmOperacionesCursos(this, plantillaGestion));
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmOperacionesPersona(this, plantillaGestion));
        }
    }
}
