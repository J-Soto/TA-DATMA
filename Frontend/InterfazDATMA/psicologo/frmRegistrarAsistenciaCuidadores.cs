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
    public partial class frmRegistrarAsistenciaCuidadores : MaterialSkin.Controls.MaterialForm 
    {
        private frmModificarPrograma formModificarPrograma;
        private frmPlantillaGestion formPlantillaGestion;

        public frmRegistrarAsistenciaCuidadores(frmModificarPrograma formModificarPrograma, frmPlantillaGestion formPlantillaGestion)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

            this.formModificarPrograma = formModificarPrograma;
            this.formPlantillaGestion = formPlantillaGestion;
        }

        private void frmRegistrarAsistenciaCuidadores_Load(object sender, EventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
           
        }

        private void brnRegresar_Click(object sender, EventArgs e)
        {
            formPlantillaGestion.abrirFormulario(formModificarPrograma);
        }
    }
}
