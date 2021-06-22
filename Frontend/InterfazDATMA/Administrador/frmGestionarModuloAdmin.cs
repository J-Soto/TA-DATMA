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

namespace InterfazDATMA.Administrador
{
    public partial class frmGestionarModuloAdmin : MaterialSkin.Controls.MaterialForm 
    {
        private frmPlantillaGestion plantillaGestion;
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private TutorWS.TutorWSClient daoTutor;

        public frmGestionarModuloAdmin(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey500, MaterialSkin.Primary.BlueGrey700, MaterialSkin.Primary.BlueGrey100, MaterialSkin.Accent.Teal700, MaterialSkin.TextShade.WHITE);


            plantillaGestion = plantilla;

            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            daoTutor = new TutorWS.TutorWSClient();

            // Tutores
            typeof(DataGridView).InvokeMember(
            "DoubleBuffered",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
            null,
            dgvTutores,
            new object[] { true });
            dgvTutores.AutoGenerateColumns = false;
            dgvTutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTutores.DataSource = daoTutor.listarTodosTutores();

            // Psicologos
            typeof(DataGridView).InvokeMember(
            "DoubleBuffered",
            BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
            null,
            dgvPsicologos,
            new object[] { true });
            dgvPsicologos.AutoGenerateColumns = false;
            dgvPsicologos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPsicologos.DataSource = daoPsicologo.listarTodosPsicologos();
        }

        public byte[] ResizeImage(byte[] data, int width)
        {
            using (var stream = new MemoryStream(data))
            {
                var image = Image.FromStream(stream);

                var height = (width * image.Height) / image.Width;
                var thumbnail = image.GetThumbnailImage(width, height, null, IntPtr.Zero);

                using (var thumbnailStream = new MemoryStream())
                {
                    thumbnail.Save(thumbnailStream, ImageFormat.Jpeg);
                    return thumbnailStream.ToArray();
                }
            }
        }


        private void dgvTutores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TutorWS.tutor tutor = (TutorWS.tutor)dgvTutores.Rows[e.RowIndex].DataBoundItem;
            dgvTutores.Rows[e.RowIndex].Cells[0].Value = tutor.nombre + " " + tutor.apellidoPaterno + " " + tutor.apellidoMaterno;
            try
            {
                if (tutor.fotoPerfil != null)
                {
                    dgvTutores.Rows[e.RowIndex].Cells[1].Value = tutor.fotoPerfil;
                }

            }
            catch (Exception ex){
                System.Console.WriteLine(ex.Message);
            }
            dgvTutores.RowTemplate.Height = 100;
        }

        private void dgvPsicologos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PsicologoWS.psicologo psi = (PsicologoWS.psicologo)dgvPsicologos.Rows[e.RowIndex].DataBoundItem;
            dgvPsicologos.Rows[e.RowIndex].Cells[0].Value = psi.nombre + " " + psi.apellidoPaterno + " " + psi.apellidoMaterno;
            try
            {
                if (psi.fotoPerfil != null)
                {
                    dgvPsicologos.Rows[e.RowIndex].Cells[1].Value = psi.fotoPerfil;
                }

            }
            catch (Exception ex){
                System.Console.WriteLine(ex.Message);
            }
            dgvPsicologos.RowTemplate.Height = 100;
        }

        private void dgvTutores_SelectionChanged(object sender, EventArgs e)
        {
            dgvTutores.ClearSelection();
        }

        private void dgvPsicologos_SelectionChanged(object sender, EventArgs e)
        {
            dgvPsicologos.ClearSelection();
        }

        private void dgvTutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPsicologos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmGestionarModuloAdmin_Load(object sender, EventArgs e)
        {

        }

        private void lblPsicologosUser_Click(object sender, EventArgs e)
        {

        }

        private void btnOpPersona_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmOperacionesPersona(this, plantillaGestion));


        }

        private void btnOpCurso_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmOperacionesCursos(this, plantillaGestion));

        }
    }
}
