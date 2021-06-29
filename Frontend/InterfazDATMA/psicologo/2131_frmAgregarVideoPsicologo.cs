using InterfazDATMA.MaterialWS;
using MaterialSkin.Controls;
using InterfazDATMA.util;

using System.Windows.Forms;

namespace InterfazDATMA
{
    public partial class frmAgregarMaterialPsicologo : MaterialSkin.Controls.MaterialForm 
    {

        private MaterialWS.video video = null;

        public video Video { get => video; set => video = value; }


        public frmAgregarMaterialPsicologo()
        {
            InitializeComponent();
            Design.Ini(this);
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

        private void frmAgregarMaterialPsicologo_Load_1(object sender, System.EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, System.EventArgs e)
        {
            video = new MaterialWS.video();

            if(txtLinkVideo.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos","Mensaje de advertencia",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                video.descripcion = txtDescripcion.Text;
                video.linkVideo = txtLinkVideo.Text;

                this.DialogResult = DialogResult.OK;
            }

        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
