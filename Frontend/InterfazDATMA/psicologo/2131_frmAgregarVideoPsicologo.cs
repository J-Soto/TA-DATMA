using InterfazDATMA.MaterialWS;
using MaterialSkin.Controls;
using InterfazDATMA.util;

using System.Windows.Forms;
using MaterialSkin;

namespace InterfazDATMA
{
    public partial class frmAgregarMaterialPsicologo : MaterialSkin.Controls.MaterialForm 
    {

        private MaterialWS.video video = null;

        public video Video { get => video; set => video = value; }


        public MaterialSkinManager ThemeManager = MaterialSkinManager.Instance;
        public frmAgregarMaterialPsicologo()
        {
            InitializeComponent();
            Design.Ini(this);
            if (Design.tema == 'd') ThemeManager.Theme = MaterialSkinManager.Themes.DARK;
            else ThemeManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void materialButton1_Click(object sender, System.EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, System.EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {

        }

        private void materialButton2_Click_1(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void materialButton1_Click_1(object sender, System.EventArgs e)
        {
            video = new MaterialWS.video();

            if (txtLinkVideo.Text.Trim() == "" || txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debe llenar todos los campos", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                video.descripcion = txtDescripcion.Text;
                video.linkVideo = txtLinkVideo.Text;

                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
