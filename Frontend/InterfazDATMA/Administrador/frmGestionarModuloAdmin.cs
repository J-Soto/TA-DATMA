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

namespace InterfazDATMA.Administrador
{
    public partial class frmGestionarModuloAdmin : Form
    {
        private frmPlantillaGestion plantillaGestion;
        private PsicologoWS.PsicologoWSClient daoPsicologo;
        private TutorWS.TutorWSClient daoTutor;
        public frmGestionarModuloAdmin(frmPlantillaGestion plantilla)
        {
            InitializeComponent();
            plantillaGestion = plantilla;
            daoPsicologo = new PsicologoWS.PsicologoWSClient();
            daoTutor = new TutorWS.TutorWSClient();

            dgvTutores.AutoGenerateColumns = false;
            dgvTutores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTutores.DataSource = daoTutor.listarTodosTutores();
            dgvPsicologos.AutoGenerateColumns = false;
            dgvPsicologos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPsicologos.DataSource = daoPsicologo.listarTodosPsicologos();
        }

        private void btnOpPersona_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmOperacionesPersona(this, plantillaGestion));
        }

        private void btnOpCurso_Click(object sender, EventArgs e)
        {
            plantillaGestion.abrirFormulario(new frmOperacionesCursos(this, plantillaGestion));
        }

        private void dgvTutores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            TutorWS.tutor tutor = (TutorWS.tutor)dgvTutores.Rows[e.RowIndex].DataBoundItem;
            dgvTutores.Rows[e.RowIndex].Cells[0].Value = tutor.nombre + " " + tutor.apellidoPaterno + " " + tutor.apellidoMaterno;
        }

        private void dgvPsicologos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            PsicologoWS.psicologo psi = (PsicologoWS.psicologo)dgvPsicologos.Rows[e.RowIndex].DataBoundItem;
            dgvPsicologos.Rows[e.RowIndex].Cells[0].Value = psi.nombre + " " + psi.apellidoPaterno + " " + psi.apellidoMaterno;
        }

        private void dgvTutores_SelectionChanged(object sender, EventArgs e)
        {
            dgvTutores.ClearSelection();
        }

        private void dgvPsicologos_SelectionChanged(object sender, EventArgs e)
        {
            dgvPsicologos.ClearSelection();
        }
    }
}
