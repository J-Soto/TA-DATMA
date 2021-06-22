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
    public partial class frmSinCursosDisponibles : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion plantillaGestion;
        private frmListaCursoInscritos formAnterior;
        public frmSinCursosDisponibles(frmListaCursoInscritos formAnterior,frmPlantillaGestion plantillaGestion)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            this.plantillaGestion = plantillaGestion;
            this.formAnterior = formAnterior;
        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            frmNotificacionActiva formNotificacion = new frmNotificacionActiva();
            if (formNotificacion.ShowDialog() == DialogResult.OK)
            {
                plantillaGestion.abrirFormulario(formAnterior);
            }
        }

    }
}
