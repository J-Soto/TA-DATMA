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

namespace InterfazDATMA.psicologo
{
    public partial class frmModificarActividad : MaterialSkin.Controls.MaterialForm
    {

        private frmModificarPrograma formModificarPrograma;
        private frmPlantillaGestion formPlantillaGestion;

        public frmModificarActividad(frmModificarPrograma formModificarPrograma, frmPlantillaGestion formPlantillaGestion)
        {
            InitializeComponent();
            Design.Ini(this);
            this.formModificarPrograma = formModificarPrograma;
            this.formPlantillaGestion = formPlantillaGestion;

            dtpHInicio.CustomFormat = "hh:mm tt";
            dtpHInicio.Format = DateTimePickerFormat.Custom;
            dtpHInicio.ShowUpDown = true;

            dtpHFin.CustomFormat = "hh:mm tt";
            dtpHFin.Format = DateTimePickerFormat.Custom;
            dtpHFin.ShowUpDown = true;

            dtpFechaReunion.CustomFormat = "dd/MM/yyyy";
            dtpFechaReunion.Format = DateTimePickerFormat.Custom;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formModificarPrograma);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
