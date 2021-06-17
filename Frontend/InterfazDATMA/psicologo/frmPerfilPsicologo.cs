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

namespace InterfazDATMA.psicologo
{
    public partial class frmPerfilPsicologo : Form
    {
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private frmPlantillaGestion plantillaGestion;
        public frmPerfilPsicologo()
        {
            InitializeComponent();
        }

        private void Cursos_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmGestionarModulosPsicologo(plantillaGestion));
        }
    }
}
