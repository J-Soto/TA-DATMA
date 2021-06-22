using MaterialSkin.Controls;

using System.Windows.Forms;

namespace InterfazDATMA
{
    public partial class frmAgregarMaterialPsicologo : MaterialSkin.Controls.MaterialForm 
    {
        public frmAgregarMaterialPsicologo()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);

        }



        private void frmAgregarMaterialPsicologo_Load(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void btnGuardarArchivo_Click(object sender, System.EventArgs e)
        {

        }
    }
}
