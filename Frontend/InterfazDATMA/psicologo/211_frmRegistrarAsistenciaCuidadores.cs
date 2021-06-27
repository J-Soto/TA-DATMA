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
    public partial class frmRegistrarAsistenciaCuidadores : MaterialSkin.Controls.MaterialForm 
    {
        private frmModificarPrograma formModificarPrograma;
        private frmPlantillaGestion formPlantillaGestion;

        public frmRegistrarAsistenciaCuidadores(frmModificarPrograma formModificarPrograma, frmPlantillaGestion formPlantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            this.formModificarPrograma = formModificarPrograma;
            this.formPlantillaGestion = formPlantillaGestion;
        }

        private void frmRegistrarAsistenciaCuidadores_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarAsistencia_Click(object sender, EventArgs e)
        {

        }

        private void brnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formModificarPrograma);
        }
    }
}
